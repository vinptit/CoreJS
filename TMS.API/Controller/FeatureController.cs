﻿using Core.Enums;
using Core.Extensions;
using Core.SMSModels;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Linq.Dynamic.Core;
using TMS.API.Models;

namespace TMS.API.Controllers
{
    public class FeatureController : TMSController<Feature>
    {
        public IConfiguration _IConfiguration;
        public FeatureController(TMSContext context, EntityService entityService, IHttpContextAccessor httpContextAccessor, IConfiguration iConfiguration) : base(context, entityService, httpContextAccessor)
        {
            _IConfiguration = iConfiguration;
        }

        [AllowAnonymous]
        public override Task<OdataResult<Feature>> Get(ODataQueryOptions<Feature> options)
        {
            var query =
                from feature in db.Feature
                join policyLeft in db.FeaturePolicy on feature.Id equals policyLeft.FeatureId into policyLeftJoin
                from policy in policyLeftJoin.DefaultIfEmpty()
                where UserId == 1 || feature.IsPublic || RoleIds.Contains(feature.RoleId) || feature.InsertedBy == UserId || policy.RoleId != null
                    && policy.CanRead && (RoleIds.Contains(policy.RoleId.Value) || feature.IsPermissionInherited && AllRoleIds.Contains(policy.RoleId.Value))
                select feature;

            return ApplyQuery(options, query.Distinct());
        }

        [AllowAnonymous]
        public override Task<OdataResult<Feature>> GetPublic(ODataQueryOptions<Feature> options, string ids)
        {
            return base.GetPublic(options, ids);
        }

        public override async Task<ActionResult<Feature>> CreateAsync([FromBody] Feature entity)
        {
            var res = await base.CreateAsync(entity);
            //var minRoleLevel = await GetTopRole();
            var maxRoleLevel = await db.Role.FirstOrDefaultAsync(x => x.Active == true && x.Id == 8);
            await AddDefaultPolicy(entity, maxRoleLevel);
            await db.SaveChangesAsync();
            return res;
        }

        [HttpPost("api/[Controller]/Clone")]
        public async Task<ActionResult<bool>> CloneFeatureAsync([FromBody] int? id)
        {
            if (id == null)
            {
                return false;
            }
            var updateCommand = string.Format("EXECUTE dbo.[CloneFeature] @target= {0}", id);
            await ctx.Database.ExecuteSqlRawAsync(updateCommand);
            return true;
        }

        public override async Task<ActionResult<Feature>> UpdateAsync([FromBody] Feature entity, string reasonOfChange = "")
        {
            var res = await base.UpdateAsync(entity, reasonOfChange);
            await InheritParentPolicy(entity);
            var serviceProvider = _httpContext.HttpContext.RequestServices.GetService(typeof(IServiceProvider)) as IServiceProvider;
            var configuration = _httpContext.HttpContext.RequestServices.GetService(typeof(IConfiguration)) as IConfiguration;
            var connectionString = Startup.GetConnectionString(serviceProvider, configuration, "fastweb");

            // Create a SqlConnection using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Get the database names
                SqlCommand command = new SqlCommand("SELECT name FROM sys.databases where name like N'tms_%'", connection);
                SqlDataReader reader = command.ExecuteReader();

                // Iterate over the result set and print the database names
                while (reader.Read())
                {
                    string databaseName = reader["name"].ToString();
                    Console.WriteLine(databaseName);
                }

                // Close the reader and the connection
                reader.Close();
            }
            return res;
        }

        private async Task AddDefaultPolicy(Feature feature, Role minRoleLevel)
        {
            var featurePolicy = new FeaturePolicy
            {
                Active = true,
                CanRead = true,
                CanWrite = true,
                CanDelete = true,
                CanDeactivate = true,
                CanDeleteAll = true,
                CanShare = true,
                CanWriteAll = true,
                RoleId = minRoleLevel.Id,
                FeatureId = feature.Id,
            };
            SetAuditInfo(featurePolicy);
            db.FeaturePolicy.Add(featurePolicy);
            await db.SaveChangesAsync();
            await InheritParentPolicy(feature);
        }

        private async Task InheritParentPolicy(Feature feature)
        {
            if (!feature.InheritParentFeature || feature.ParentId is null)
            {
                return;
            }
            var currentPolicy = await db.FeaturePolicy
                .Where(x => x.Active && x.CanRead && x.FeatureId == feature.Id && x.RoleId != null && x.RecordId == 0).ToListAsync();
            db.RemoveRange(currentPolicy);
            var parentPolicy = await db.FeaturePolicy.AsNoTracking()
                .Where(x => x.Active && x.CanRead && x.FeatureId == feature.ParentId && x.RoleId != null && x.RecordId == 0).ToListAsync();
            parentPolicy
                .ForEach(policy =>
                {
                    policy.Id = 0;
                    policy.FeatureId = feature.Id;
                    _userSvc.SetAuditInfo(policy);
                    db.FeaturePolicy.Add(policy);
                });
            await db.SaveChangesAsync();
        }

        private async Task<Role> GetTopRole()
        {
            var roles =
                from role in db.Role
                where AllRoleIds.Contains(role.Id)
                orderby role.Path descending
                select role;
            var minRoleLevel = await roles.FirstOrDefaultAsync();
            return minRoleLevel;
        }

        public override async Task<ActionResult<bool>> DeactivateAsync([FromBody] List<int> ids)
        {
            var hasSystemRole = await HasSystemRole();
            if (!hasSystemRole)
            {
                throw new UnauthorizedAccessException("You dont have system role to delete this feature");
            }
            return await base.DeactivateAsync(ids);
        }

        public override async Task<ActionResult<bool>> HardDeleteAsync([FromBody] List<int> ids)
        {
            var hasSystemRole = await HasSystemRole();
            if (!hasSystemRole)
            {
                throw new UnauthorizedAccessException("You dont have system role to delete this feature");
            }
            var policies = db.FeaturePolicy.Where(x => x.FeatureId != null && ids.Contains(x.FeatureId.Value));
            db.FeaturePolicy.RemoveRange(policies);
            return await base.HardDeleteAsync(ids);
        }

        [HttpPost("api/[Controller]/CopyFromTo")]
        public async Task<ActionResult<bool>> CopyFromTo([FromBody] int? id, [FromQuery] string te, [FromQuery] string system = "fastweb", [FromQuery] string key = "tms_core")
        {
            if (id == null)
            {
                return false;
            }
            var serviceProvider = _httpContext.HttpContext.RequestServices.GetService(typeof(IServiceProvider)) as IServiceProvider;
            var configuration = _httpContext.HttpContext.RequestServices.GetService(typeof(IConfiguration)) as IConfiguration;
            var connectionStr = Startup.GetConnectionString(serviceProvider, configuration, system);
            if (!te.IsNullOrWhiteSpace())
            {
                connectionStr = connectionStr.Replace($"{key}", $"{te}");
            }
            var builder = new DbContextOptionsBuilder<TMSContext>().UseSqlServer(connectionStr).Options;
            using (var _db = new TMSContext(builder))
            {
                var feature = await db.Feature.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
                var feature1 = await _db.Feature.FirstOrDefaultAsync(x => x.Name == feature.Name && !x.Active);
                if (feature1 is null)
                {
                    feature1 = new Feature();
                    feature1.CopyPropFrom(feature, nameof(Feature.Id), nameof(Feature.ParentId));
                    SetAuditInfo(feature1);
                    _db.Add(feature1);
                    await _db.SaveChangesAsync();
                    var featurePolicy = await db.FeaturePolicy.AsNoTracking().Where(x => x.FeatureId == feature.Id && x.RoleId != null && x.RoleId == (int)RoleEnum.System).ToListAsync();
                    var featurePolicy1 = featurePolicy.Select(x =>
                    {
                        var f = new FeaturePolicy();
                        f.CopyPropFrom(x, nameof(Feature.Id));
                        f.FeatureId = feature1.Id;
                        SetAuditInfo(f);
                        return f;
                    }).ToList();
                    _db.AddRange(featurePolicy1);
                    await _db.SaveChangesAsync();
                    var gridPolicy = await db.GridPolicy.AsNoTracking().Where(x => x.FeatureId == feature.Id).ToListAsync();
                    var gridPolicy1 = gridPolicy.Select(x =>
                    {
                        var f = new GridPolicy();
                        f.CopyPropFrom(x, nameof(Feature.Id));
                        f.FeatureId = feature1.Id;
                        SetAuditInfo(f);
                        return f;
                    }).ToList();
                    _db.AddRange(gridPolicy1);
                    await _db.SaveChangesAsync();
                    var componentGroup = await db.ComponentGroup.AsNoTracking().Where(x => x.FeatureId == feature.Id && x.ParentId == null).ToListAsync();
                    await CreateComponentGroup(feature1, feature, componentGroup, null, _db);
                }
            }
            return true;
        }

        private async Task CreateComponentGroup(Feature feature1, Feature feature, List<ComponentGroup> componentGroup, int? parentId, TMSContext _db)
        {
            foreach (var comG in componentGroup)
            {
                var comG1 = new ComponentGroup();
                comG1.CopyPropFrom(comG, nameof(ComponentGroup.Id));
                comG1.FeatureId = feature1.Id;
                comG1.ParentId = parentId;
                SetAuditInfo(comG1);
                _db.Add(comG1);
                await _db.SaveChangesAsync();
                var component = await db.Component.AsNoTracking().Where(x => x.ComponentGroupId == comG.Id).ToListAsync();
                var component1 = component.Select(x =>
                {
                    var f = new Component();
                    f.CopyPropFrom(x, nameof(Feature.Id));
                    f.ComponentGroupId = comG1.Id;
                    SetAuditInfo(f);
                    return f;
                }).ToList();
                _db.AddRange(component1);
                await _db.SaveChangesAsync();
                var componentGroup2 = await db.ComponentGroup.AsNoTracking().Where(x => x.FeatureId == feature.Id && x.ParentId == comG.Id).ToListAsync();
                if (componentGroup2.Any())
                {
                    await CreateComponentGroup(feature1, feature, componentGroup2, comG1.Id, _db);
                }
            }
        }

    }
}
