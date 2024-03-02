﻿using Aspose.Cells;
using ClosedXML.Excel;
using Core.Enums;
using Core.Exceptions;
using Core.Extensions;
using Core.ViewModels;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Management.Smo.Agent;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Text.RegularExpressions;
using TMS.API.Enums;
using TMS.API.Models;
using TMS.API.ViewModels;
using ApprovalStatusEnum = Core.Enums.ApprovalStatusEnum;
using AuthVerEnum = Core.Enums.AuthVerEnum;
using EntityActionEnum = Core.Enums.EntityActionEnum;
using FileIO = System.IO.File;
using HttpMethod = Core.Enums.HttpMethod;
using ResponseApproveEnum = Core.Enums.ResponseApproveEnum;
using SystemHttpMethod = System.Net.Http.HttpMethod;

namespace TMS.API.Controllers
{
    [Authorize]
    public class TMSController<T> : GenericController<T> where T : class
    {
        protected readonly TMSContext db;
        protected readonly ILogger<TMSController<T>> _logger;
        protected HttpClient _client;
        protected string PathField = "Path";
        protected string ParentIdField = "ParentId";
        protected string ChildrenField = "InverseParent";
        private string _address;

        public TMSController(TMSContext context, EntityService entityService, IHttpContextAccessor httpContextAccessor) : base(context, entityService, httpContextAccessor)
        {
            db = context;
            _logger = (ILogger<TMSController<T>>)httpContextAccessor.HttpContext.RequestServices.GetService(typeof(ILogger<TMSController<T>>));
            _config = _httpContext.HttpContext.RequestServices.GetService(typeof(IConfiguration)) as IConfiguration;
            _address = _config["ServiceAddress"];
        }

        [HttpPost("api/[Controller]", Order = 0)]
        public async Task<ActionResult<T>> CreateAndWebhookAsync([FromBody] T entity)
        {
            var res = await CreateAsync(entity);
            WebhookActionWrapper(EntityActionEnum.Create, entity);
            return res;
        }

        [HttpPut("api/[Controller]", Order = 0)]
        public async Task<ActionResult<T>> UpdateAndWebhookAsync([FromBody] T entity, string reasonOfChange = "")
        {
            var res = await UpdateAsync(entity, reasonOfChange);
            WebhookActionWrapper(EntityActionEnum.Update, entity);
            return res;
        }

        [HttpPost("api/[Controller]/Delete", Order = 0)]
        public async Task<ActionResult<bool>> DeactivateAndWebhookAsync([FromRoute] int id)
        {
            var res = await DeactivateAsync(new List<int> { id });
            WebhookActionWrapper(EntityActionEnum.Deactivate, id);
            return res;
        }

        [HttpPost("api/[Controller]/HardDelete", Order = 0)]
        public async Task<ActionResult<bool>> HardDeleteAndWebhookAsync([FromBody] List<int> ids)
        {
            var res = await HardDeleteAsync(ids);
            WebhookActionWrapper(EntityActionEnum.Delete, ids);
            return res;
        }

        [HttpPost("api/[Controller]/Cmd")]
        public virtual async Task<object> ExecuteSqlCmd([FromBody] SqlViewModel sqlCmd)
        {
            if (sqlCmd is null)
            {
                return BadRequest("Cmd arg is null");
            }
            var sv = await db.Services.FirstOrDefaultAsync(x => x.ComId == sqlCmd.CmdId && x.CmdType == sqlCmd.CmdType);
            if (sv is null)
            {
                throw new ApiException($"Service {sqlCmd.CmdType} not found");
            }

            try
            {
                var client = new HttpClient();
                var res = await client.PostAsJsonAsync(sv.Address ?? _address, new { path = sv.Path ?? "./" + sv.CmdType + ".js", entity = sqlCmd.Entity });
                var result = await res.Content.ReadAsStringAsync();
                var sqlQuery = JsonConvert.DeserializeObject<SqlQueryResult>(result);
                if (sqlQuery != null && sqlQuery.Query.HasAnyChar())
                {
                    var dataSet = await ReportDataSet(sqlQuery.Query, sqlQuery.System);
                    return dataSet;
                }
                return sqlQuery.Message;
            }
            catch (Exception ex)
            {
                _logger.LogError("Node service ran into error at {0} {1} {2}", DateTimeOffset.Now, ex.Message, ex.StackTrace);
                throw;
            }
        }

        public static Task<string> RunNodeFunction(string process, string args, string fileName, bool shouldGen = false)
        {
            var tcs = new TaskCompletionSource<string>();
            Task.Run(async () =>
            {
                if (shouldGen)
                {
                    EnsureDirectoryExist(fileName);
                    await FileIO.WriteAllTextAsync(fileName, args);
                }
                var p = new Process();
                p.StartInfo.FileName = process;
                p.StartInfo.Arguments = string.Concat(fileName, " ", args);
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardInput = false;
                p.OutputDataReceived += (a, b) => tcs.TrySetResult(b.Data);
                p.ErrorDataReceived += (object a, DataReceivedEventArgs b) => tcs.TrySetException(new Exception(b.Data));
                p.Start();
                p.BeginErrorReadLine();
                p.BeginOutputReadLine();
                await p.WaitForExitAsync();
            });
            return tcs.Task;

        }

        public void WebhookActionWrapper<K>(EntityActionEnum action, K entity)
        {
            var serviceProvider = _httpContext.HttpContext.RequestServices.GetService(typeof(IServiceProvider)) as IServiceProvider;
            var configuration = _httpContext.HttpContext.RequestServices.GetService(typeof(IConfiguration)) as IConfiguration;
            var connStr = Startup.GetConnectionString(serviceProvider, configuration, "acc");
            var db = Startup.GetConnectionString(serviceProvider, configuration, "acc");
            var thead = new Thread(() =>
            {
            });
            thead.Start();
        }

        private async Task WebhookAction<K>(TMSContext db, EntityActionEnum action, K entity)
        {
            var entityId = _entitySvc.GetEntity(typeof(K).Name).Id;
            var actions = await db.Webhook
                .Where(x => x.Active && x.EntityId == entityId)
                .Where(x => x.EventTypeId == (int)action)
                .ToListAsync();
            if (actions.Nothing())
            {
                return;
            }
            var tokenLoaded = await Task.WhenAll(actions.Select(action => CreateRequest(action, entity)));
            if (tokenLoaded.Any(x => x == true))
            {
                await db.SaveChangesAsync();
            }
        }

        private async Task<bool> CreateRequest<K>(Webhook action, K entity)
        {
            entity.ClearReferences();
            JwtSecurityToken jwtSecurity = null;
            bool shouldLoadToken = false;
            var actionMethod = Enum.Parse<HttpMethod>(action.Method.ToUpper());
            var method = actionMethod switch
            {
                HttpMethod.POST => SystemHttpMethod.Post,
                HttpMethod.PUT => SystemHttpMethod.Put,
                HttpMethod.DELETE => SystemHttpMethod.Delete,
                HttpMethod.GET => throw new NotImplementedException(),
                _ => throw new NotImplementedException(),
            };
            var uri = action.SubUrl;
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(uri),
                Method = method,
                Content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, Utils.ApplicationJson),
            };
            if (action.AuthVersionId == (int)AuthVerEnum.ApiKey)
            {
                request.Headers.Add(action.ApiKeyHeader, action.ApiKey);
            }
            else if (action.AuthVersionId == (int)AuthVerEnum.Simple)
            {
                request.Headers.Add(action.UsernameKey, action.SubUsername);
                request.Headers.Add(action.PasswordKey, action.SubPassword);
            }
            else if (action.AuthVersionId == (int)AuthVerEnum.OAuth2)
            {
                if (action.SavedToken.HasAnyChar())
                {
                    jwtSecurity = TryReadSavedToken(action, jwtSecurity);
                }
                if (jwtSecurity is not null && jwtSecurity.ValidTo > DateTime.Now.AddMinutes(1))
                {
                    request.Headers.Add(action.ApiKeyHeader, action.TokenPrefix + action.SavedToken);
                }
                else
                {
                    var token = await GetNewToken(action);
                    if (token.IsNullOrEmpty())
                    {
                        return false;
                    }
                    action.SavedToken = token;
                    shouldLoadToken = true;
                    request.Headers.Add(action.ApiKeyHeader, action.TokenPrefix + token);
                }
                request.RequestUri = new Uri($"{action.SubUrl}/?{action.ApiKeyHeader}={action.ApiKey}&EntityName={typeof(T).Name}");
            }
            var res = await _client.SendAsync(request);
            return shouldLoadToken;
        }

        private async Task<string> GetNewToken(Webhook action)
        {
            try
            {
                var json = $"{{\"{action.UsernameKey}\": \"{action.SubUsername}\", \"{action.PasswordKey}\": \"{action.SubPassword}\", \"{action.ApiKeyHeader}\": \"{action.ApiKey}\"}}";
                var tokenRequest = await _client.PostAsync(action.LoginUrl, new StringContent(json, Encoding.UTF8, Utils.ApplicationJson));
                var tokenStr = await tokenRequest.Content.ReadAsStringAsync();
                JObject tokenJson = JObject.Parse(tokenStr);
                var token = action.AccessTokenField.HasAnyChar() ? tokenJson.SelectToken(action.AccessTokenField)?.ToString() : tokenStr;
                return token;
            }
            catch
            {
                return null;
            }
        }

        private static JwtSecurityToken TryReadSavedToken(Webhook action, JwtSecurityToken jwtSecurity)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                jwtSecurity = tokenHandler.ReadJwtToken(action.SavedToken);
            }
            catch
            {
            }

            return jwtSecurity;
        }

        [HttpPost("api/listener/[Controller]")]
        public virtual Task<ActionResult<T>> CreateListenerAsync([FromBody] T entity)
        {
            return CreateAsync(entity);
        }

        [HttpPut("api/listener/[Controller]")]
        public virtual Task<ActionResult<T>> UpdateListenerAsync([FromBody] T entity)
        {
            return UpdateAsync(entity);
        }

        [HttpDelete("api/listener/[Controller]/{id}")]
        public virtual Task<ActionResult<bool>> HardDeleteListenerAsync([FromRoute] int id)
        {
            return HardDeleteAsync(id);
        }

        protected async Task<bool> HasSystemRole()
        {
            return await db.Role.AnyAsync(x => AllRoleIds.Contains(x.Id) && x.RoleName.Contains("system"));
        }


        [HttpPost("api/[Controller]/RequestApprove")]
        public virtual async Task<ActionResult<bool>> RequestApprove([FromBody] T entity)
        {
            var id = entity.GetPropValue(nameof(GridPolicy.Id)) as int?;
            var (statusField, value) = entity.GetComplexProp("StatusId");
            if (statusField)
            {
                entity.SetPropValue("StatusId", (int)ApprovalStatusEnum.Approving);
            }

            if (id <= 0)
            {
                await CreateAsync(entity);
            }
            var approvalConfig = await GetApprovalConfig(entity);
            if (approvalConfig.Nothing())
            {
                throw new ApiException("Quy trình duyệt chưa được cấu hình");
            }
            await NotifyApprovalLevel(entity, approvalConfig, 1);
            await Approving(entity);
            return true;
        }

        protected virtual async Task Approving(T entity)
        {
            var oldEntity = await db.Set<T>().FindAsync((int)entity.GetComplexPropValue(IdField));
            oldEntity.CopyPropFrom(entity);
            await db.SaveChangesAsync();
        }

        protected virtual Task<List<TaskNotification>> InitTaskNotification(T record, IEnumerable<User> users)
        {
            return Task.FromResult(Enumerable.Empty<TaskNotification>().ToList());
        }

        protected async Task<List<User>> GetApprovalUsers(T entity, ApprovalConfig approvalConfig)
        {
            if (entity is null)
            {
                return null;
            }
            if (approvalConfig is null)
            {
                throw new ApiException("Quy trình duyệt chưa được cấu hình");
            }
            var users = await (
                from user in db.User
                join userRole in db.UserRole on user.Id equals userRole.UserId
                join role in db.Role on userRole.RoleId equals role.Id
                where userRole.RoleId == approvalConfig.RoleId
                select user
            ).ToListAsync();
            return users;
        }

        protected virtual async Task<List<ApprovalConfig>> GetApprovalConfig(T entity)
        {
            var entityType = _entitySvc.GetEntity(typeof(T).Name);
            return await db.ApprovalConfig.AsNoTracking().OrderBy(x => x.Level)
                .Where(x => x.Active && x.EntityId == entityType.Id).ToListAsync();
        }

        [HttpPost("api/[Controller]/Approve/")]
        public virtual async Task<ActionResult<bool>> Approve([FromBody] T entity, string reasonOfChange = "")
        {
            entity.ClearReferences();
            var id = (int)entity.GetPropValue(IdField);
            var approvalConfig = await GetApprovalConfig(entity);
            if (approvalConfig.Nothing())
            {
                throw new ApiException("Quy trình duyệt chưa được cấu hình");
            }
            var maxLevel = approvalConfig.Max(x => x.Level);
            var entityType = _entitySvc.GetEntity(typeof(T).Name);
            var approvements = await db.Approvement
                .Where(x => x.EntityId == entityType.Id && x.RecordId == id && x.Active)
                .OrderByDescending(x => x.CurrentLevel).ToListAsync();
            if (approvements.Any(x => x.CurrentLevel == maxLevel && x.Approved))
            {
                await EndApproval(entity, reasonOfChange);
                await db.SaveChangesAsync();
                return true;
            }
            var currentLevel = approvements.FirstOrDefault()?.CurrentLevel ?? 1;
            if (currentLevel <= 1)
            {
                currentLevel = 1;
            }
            else
            {
                currentLevel++;
            }
            var currentConfig = approvalConfig.FirstOrDefault(x => x.Level == currentLevel);
            var hasRoleLevel = currentConfig.IsSupervisor || currentConfig.RoleId.HasValue && AllRoleIds.Contains(currentConfig.RoleId.Value);
            if (!hasRoleLevel)
            {
                throw new ApiException(ResponseApproveEnum.NonRole.GetEnumDescription());
            }
            var approvalUserIds = await GetApprovalUsers(entity, currentConfig);
            SetApproved(entity, currentConfig);
            if (approvalConfig.Where(x => x.Level == currentLevel + 1).Nothing())
            {
                await EndApproval(entity, reasonOfChange);
            }
            else
            {
                await NotifyApprovalLevel(entity, approvalConfig, currentLevel + 1);
            }
            db.Set<T>().Update(entity);
            await db.SaveChangesAsync();
            entity.ClearReferences();
            return true;
        }

        protected virtual async Task EndApproval(T entity, string reasonOfChange)
        {
            entity.SetPropValue("StatusId", (int)ApprovalStatusEnum.Approved);
            var user = await db.User.FindAsync((int)entity.GetPropValue(InsertedByField));
            var tasks = await InitTaskNotification(entity, new List<User>() { user });
            tasks.ForEach(x =>
            {
                x.Title ??= "Thông báo đã duyệt";
                x.Description ??= "Duyệt thành công yêu cầu";
            });
            await _taskService.NotifyAsync(tasks);
            tasks.ForEach(SetAuditInfo);
            db.AddRange(tasks);
            db.Set<T>().Update(entity);
            await db.SaveChangesAsync();
        }

        [HttpPost("api/[Controller]/Reject/")]
        public virtual async Task<bool> Reject([FromBody] T entity, string reasonOfChange)
        {
            entity.ClearReferences();
            var id = (int)entity.GetPropValue(nameof(Role.Id));
            var insertedBy = (int)entity.GetPropValue(nameof(Role.InsertedBy));
            var type = typeof(T);
            var entityType = _entitySvc.GetEntity(typeof(T).Name);
            entity.SetPropValue("StatusId", (int)ApprovalStatusEnum.Rejected);
            db.Set<T>().Update(entity);
            var approved = await db.Approvement.Where(x => x.EntityId == entityType.Id && x.RecordId == id).ToListAsync();
            var taskNotification = new TaskNotification
            {
                Title = $"Trả về {entityType.Name}",
                Description = $"{entityType.Name} đã trả về. Lý do trả về: {reasonOfChange}",
                EntityId = entityType.Id,
                Attachment = "fas fa-cart-plus",
                AssignedId = insertedBy,
                StatusId = (int)TaskStateEnum.UnreadStatus,
                RemindBefore = 540,
                Deadline = DateTime.Now,
            };
            await _taskService.NotifyAsync(new List<TaskNotification>() { taskNotification });
            SetAuditInfo(taskNotification);
            db.Add(taskNotification);
            await db.SaveChangesAsync();
            return true;
        }

        private async Task NotifyApprovalLevel(T entity, List<ApprovalConfig> approvalConfig, int currentLevel)
        {
            var matchApprovalConfig = approvalConfig.FirstOrDefault(x => x.Level == currentLevel);
            if (matchApprovalConfig is null)
            {
                throw new ApiException("Quy trình duyệt chưa được cấu hình");
            }
            var id = (int)entity.GetPropValue(IdField);
            if (matchApprovalConfig is null)
            {
                return;
            }
            var listUser = await GetApprovalUsers(entity, matchApprovalConfig);
            if (listUser.HasElement())
            {
                var tasks = await InitTaskNotification(entity, listUser);
                await _taskService.NotifyAsync(tasks);
                tasks.ForEach(SetAuditInfo);
                db.AddRange(tasks);
            }
        }

        protected virtual void SetApproved(T entity, ApprovalConfig currentConfig)
        {
            var _entityEnum = _entitySvc.GetEntity(typeof(T).Name);
            var id = (int)entity.GetPropValue(IdField);
            var currentLevel = currentConfig.Level;
            var approval = new Approvement
            {
                Approved = true,
                CurrentLevel = currentLevel,
                NextLevel = currentLevel + 1,
                EntityId = _entityEnum.Id,
                RecordId = id,
                LevelName = currentConfig.Description,
                StatusId = (int)ApprovalStatusEnum.Approved,
                UserApproveId = UserId,
                ApprovedBy = UserId,
                ApprovedDate = DateTime.Now,
            };
            SetAuditInfo(approval);
            db.Add(approval);
        }

        public async Task<ActionResult<T>> UpdateTreeNodeAsync([FromBody] T entity, string reasonOfChange = "")
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var res = await base.UpdateAsync(entity, reasonOfChange);
            var parentId = (int?)entity.GetPropValue(ParentIdField);
            var id = (int)entity.GetPropValue(IdField);
            var path = entity.GetPropValue(PathField) as string;
            var entityChildren = entity.GetPropValue(ChildrenField) as ICollection<T>;
            if (parentId != null)
            {
                var parentEntity = await db.Set<T>().FindAsync(parentId);
                var pathParent = parentEntity.GetPropValue(nameof(MasterData.Path));
                entity.SetPropValue(PathField, @$"\{pathParent}\{parentId}\".Replace(@"\\", @"\"));
            }
            else
            {
                entity.SetPropValue(PathField, null);
            }
            SetLevel(entity);
            var folderPath = "\\" + id + "\\";
            var query = $"select * from [{typeof(T).Name}] where charindex('{folderPath}', [Path]) >= 1 or Id = {id} or {ParentIdField} = {id} order by [Path] desc";
            var allNodes = await db.Set<T>().FromSqlRaw(query).ToListAsync();
            if (allNodes.Nothing())
            {
                return res;
            }
            var nodeMap = BuildTreeNode(allNodes);
            var directChildren = nodeMap.Values.Where(x => (int?)x.GetPropValue(ParentIdField) == id);
            SetChildrenPath(directChildren, nodeMap, new HashSet<T>() { entity });
            await db.SaveChangesAsync();
            return res;
        }

        private Dictionary<int, T> BuildTreeNode(List<T> allNode)
        {
            var nodeMap = allNode.Where(x => x != null).DistinctBy(x => (int)x.GetPropValue(IdField)).ToDictionary(x => (int)x.GetPropValue(IdField));
            nodeMap.Values.ForEach(x =>
            {
                var parentId = (int?)x.GetPropValue(ParentIdField);
                var id = (int)x.GetPropValue(IdField);
                var path = (string)x.GetPropValue(PathField);
                if (parentId is null || parentId is null || !nodeMap.ContainsKey(parentId.Value))
                {
                    return;
                }
                var parent = nodeMap[parentId.Value];
                x.SetPropValue(ParentIdField, parent.GetPropValue(IdField));
            });
            return nodeMap;
        }

        protected void SetChildrenPath(IEnumerable<T> directChildren, Dictionary<int, T> nodeMap, HashSet<T> visited)
        {
            if (directChildren.Nothing())
            {
                return;
            }
            directChildren.ForEach(child =>
            {
                var id = (int)child.GetPropValue(IdField);
                var parentId = child.GetPropValue(ParentIdField) as int?;
                if (parentId is not null && nodeMap.ContainsKey(parentId.Value))
                {
                    var parent = nodeMap[parentId.Value];
                    var parentPath = parent.GetPropValue(PathField) as string;
                    child.SetPropValue(PathField, @$"\{parentPath}\{parentId}\".Replace(@"\\", @"\"));
                }
                SetLevel(child);
                SetChildrenPath(nodeMap.Values.Where(x => (int?)x.GetPropValue(ParentIdField) == id), nodeMap, visited);
            });
        }

        protected void SetLevel(T entity)
        {
            var path = entity.GetPropValue(PathField) as string;
            entity.SetPropValue("Level", path.IsNullOrWhiteSpace() ? 0 : path.Split(@"\").Where(x => !x.IsNullOrWhiteSpace()).Count());
        }

        private void OrderHeaderGroup(List<GridPolicy> headers)
        {
            GridPolicy tmp;
            for (int i = 0; i < headers.Count - 1; i++)
            {
                for (int j = i + 2; j < headers.Count; j++)
                {
                    if (headers[i].GroupName.HasAnyChar()
                        && headers[i].GroupName == headers[j].GroupName
                        && headers[i + 1].GroupName != headers[j].GroupName)
                    {
                        tmp = headers[i + 1];
                        headers[i + 1] = headers[j];
                        headers[j] = tmp;
                    }
                }
            }
        }

        public string DecodeEntity(string entity)
        {
            switch (entity)
            {
                case "amp":
                    return "&";
                case "quot":
                    return "\"";
                case "gt":
                    return ">";
                case "lt":
                    return "<";
                case "nbsp":
                    return " ";
                default:
                    return entity;
            }
        }

        public string ConvertHtmlToPlainText(string htmlContent)
        {
            // Remove HTML tags using regular expression
            string plainText = Regex.Replace(htmlContent, @"<[^>]+>|&nbsp;", "").Trim();

            // Decode HTML entities using regular expression
            plainText = Regex.Replace(plainText, @"&(amp|quot|gt|lt|nbsp);", m => DecodeEntity(m.Groups[1].Value));

            return plainText;
        }

        [HttpGet("api/[Controller]/ExportExcel")]
        public async Task<string> ExportExcel([FromServices] IServiceProvider serviceProvider
            , [FromServices] IConfiguration config
            , [FromQuery] int componentId
            , [FromQuery] string sql
            , [FromQuery] string where
            , [FromQuery] bool custom
            , [FromQuery] int featureId
            , [FromQuery] string order
            , [FromQuery] bool showNull
            , [FromQuery] string orderby
            , [FromQuery] string join)
        {
            var component = await db.Component.FindAsync(componentId);
            var userSetting = await db.UserSetting.FirstOrDefaultAsync(x => x.Name == $"{(custom ? "Export" : "ListView")}-" + componentId && x.UserId == UserId);
            var gridPolicySys = new List<GridPolicy>();
            if (userSetting != null)
            {
                gridPolicySys = JsonConvert.DeserializeObject<List<GridPolicy>>(userSetting.Value);
            }
            var gridPolicy = await db.GridPolicy.Where(x => x.EntityId == component.ReferenceId && x.FeatureId == featureId && x.Active && !x.Hidden).ToListAsync();
            var permission = await db.FeaturePolicy
                    .Where(x => x.RoleId.HasValue && AllRoleIds.Contains(x.RoleId.Value) || (x.UserId.HasValue && UserId == x.UserId))
                    .Where(x => x.EntityId == 2077 && gridPolicy.Select(x => x.Id).ToList().Contains(x.RecordId))
                    .ToListAsync();
            gridPolicy = gridPolicy
                .Where(header => !header.IsPrivate || permission.Where(x => x.RecordId == header.Id).HasElementAndAll(policy => policy.CanRead)).ToList();
            var specificComponent = gridPolicy.Any(x => x.ComponentId == component.Id);
            if (specificComponent)
            {
                gridPolicy = gridPolicy.Where(x => x.ComponentId == component.Id).ToList();
            }
            else
            {
                gridPolicy = gridPolicy.Where(x => x.ComponentId == null).ToList();
            }
            if (gridPolicySys != null)
            {
                var gridPolicys = new List<GridPolicy>();
                var userSettings = gridPolicySys.ToDictionary(x => x.Id);
                gridPolicy.ForEach(x =>
                {
                    var current = userSettings.GetValueOrDefault(x.Id);
                    if (current != null)
                    {
                        x.IsExport = current.IsExport;
                        x.Order = current.Order;
                        x.OrderExport = current.OrderExport;
                    }
                });
            }
            gridPolicy = gridPolicy.Where(x => x.ComponentType != "Button" && !x.ShortDesc.IsNullOrWhiteSpace() && ((custom && x.IsExport) || !custom)).OrderBy(x => custom ? x.OrderExport : x.Order).ToList().ToList();
            OrderHeaderGroup(gridPolicy);
            var reportQuery = string.Empty;
            var pros = typeof(T).GetProperties().Where(x => x.CanRead && x.PropertyType.IsSimple()).Select(x => x.Name).ToList();
            var selects = gridPolicy.Where(x => x.ComponentType == "Dropdown" && pros.Contains(x.FieldName)).ToList().Select(x =>
            {
                if (x.ExcelFieldName.IsNullOrWhiteSpace())
                {
                    var format = x.FormatCell.Split("}")[0].Replace("{", "");
                    var objField = x.FieldName.Substring(0, x.FieldName.Length - 2);
                    return $"[{objField}].[{format}] as [{objField}]";
                }
                else
                {
                    return x.ExcelFieldName;
                }
            });
            var joins = gridPolicy.Where(x => x.ComponentType == "Dropdown").ToList().Select(x =>
            {
                var objField = x.FieldName.Substring(0, x.FieldName.Length - 2);
                return $"left join {(!x.DatabaseName.IsNullOrWhiteSpace() ? $"{x.DatabaseName}.dbo." : "")}[{x.RefName}] as [{objField}] on [{objField}].Id = [{component.RefName}].{x.FieldName}";
            }).Distinct().ToList();

            var idFields = gridPolicy.Where(x => x.ComponentType == "Dropdown").ToList().Select(x =>
            {
                return $"[{component.RefName}].{x.FieldName}";
            }).Distinct().ToList();
            var select1s = gridPolicy.Where(x => x.ComponentType != "Dropdown").Distinct().ToList().Select(x =>
            {
                if (x.ExcelFieldName.IsNullOrWhiteSpace())
                {
                    return $"[{component.RefName}].[{x.FieldName}]";
                }
                else
                {
                    return x.ExcelFieldName;
                }
            }).Distinct().ToList();
            var fieldNames = select1s.Union(selects.Union(idFields)).ToList();
            fieldNames.Add($"[{component.RefName}].Id");
            fieldNames = fieldNames.Distinct().ToList();
            if (!sql.IsNullOrWhiteSpace())
            {
                reportQuery = $@"select {fieldNames.Combine()}
                                  from ({sql})  as [{component.RefName}]
                                  {join}
                                  {joins.Combine(" ")}
                                  where Active=1 {(where.IsNullOrWhiteSpace() ? $"" : $" and {where}")}";
            }
            else
            {
                reportQuery = $@"select {fieldNames.Combine()}
                                  from [{component.RefName}] as [{component.RefName}]
                                  {join}
                                  {joins.Combine(" ")}
                                  where Active=1 {(where.IsNullOrWhiteSpace() ? $"" : $" and {where}")}";
            }
            if (!orderby.IsNullOrWhiteSpace() && !orderby.Contains(",Id desc") && !orderby.Contains(",Id asc") && !orderby.Contains($",[{component.RefName}].Id desc") && !orderby.Contains($",[{component.RefName}].Id asc") && orderby != "Id desc" && orderby != "Id asc" && orderby != $"[{component.RefName}].Id asc" && orderby != $"[{component.RefName}].Id desc")
            {
                reportQuery += $" order by {orderby},[{component.RefName}].Id asc";
            }
            else
            {
                if (orderby == $"[{component.RefName}].Id asc" || orderby == $"[{component.RefName}].Id desc")
                {
                    reportQuery += $" order by {orderby}";
                }
                else
                {
                    reportQuery += $" order by {orderby}".Replace(" Id desc", $" [{component.RefName}].Id desc").Replace(" Id asc", $" [{component.RefName}].Id asc");
                }
            }
            var s = $"";
            var connectionStr = Startup.GetConnectionString(_serviceProvider, _config, "acc");
            using var con = new SqlConnection(connectionStr);
            var sqlCmd = new SqlCommand(reportQuery, con)
            {
                CommandType = CommandType.Text
            };
            con.Open();
            var tables = new List<List<Dictionary<string, object>>>();
            try
            {
                using (var reader = await sqlCmd.ExecuteReaderAsync())
                {
                    do
                    {
                        var table = new List<Dictionary<string, object>>();
                        while (await reader.ReadAsync())
                        {
                            table.Add(Read(reader));
                        }
                        tables.Add(table);
                    } while (reader.NextResult());
                }
            }
            catch (Exception e)
            {
                throw new ApiException(e.Message);
            }
            bool anyGroup = gridPolicy.Any(x => !string.IsNullOrEmpty(x.GroupName));
            using var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add(typeof(T).Name);
            worksheet.Cell("A1").Value = component.Label.IsNullOrWhiteSpace() ? component.RefName : component.Label;
            worksheet.Cell("A1").Style.Font.Bold = true;
            worksheet.Cell("A1").Style.Font.FontSize = 14;
            worksheet.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            worksheet.Cell("A1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            worksheet.Range(1, 1, gridPolicy.Count + 1, gridPolicy.Count + 1).Row(1).Merge();
            worksheet.Style.Font.SetFontName("Times New Roman");
            var i = 2;
            worksheet.Cell(2, 1).SetValue("STT");
            worksheet.Cell(2, 1).Style.Font.Bold = true;
            worksheet.Cell(2, 1).Style.Border.RightBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(2, 1).Style.Border.TopBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(2, 1).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(2, 1).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            if (anyGroup)
            {
                worksheet.Range(2, 1, 3, 1).Merge();
            }
            foreach (var item in gridPolicy)
            {
                if (anyGroup && !string.IsNullOrEmpty(item.GroupName))
                {
                    var colspan = gridPolicy.Count(x => x.GroupName == item.GroupName);
                    if (item != gridPolicy.FirstOrDefault(x => x.GroupName == item.GroupName))
                    {
                        i++;
                        continue;
                    }
                    worksheet.Cell(2, i).SetValue(ConvertHtmlToPlainText(item.GroupName));
                    worksheet.Range(2, i, 2, i + colspan - 1).Merge();
                    worksheet.Range(2, i, 2, i + colspan - 1).Style.Font.Bold = true;
                    worksheet.Range(2, i, 2, i + colspan - 1).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                    worksheet.Range(2, i, 2, i + colspan - 1).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                    worksheet.Range(2, i, 2, i + colspan - 1).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                    worksheet.Range(2, i, 2, i + colspan - 1).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                    worksheet.Range(2, i, 2, i + colspan - 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    worksheet.Range(2, i, 2, i + colspan - 1).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    i++;
                    continue;
                }
                worksheet.Cell(2, i).SetValue(ConvertHtmlToPlainText(item.ShortDesc));
                worksheet.Cell(2, i).Style.Font.Bold = true;
                worksheet.Cell(2, i).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(2, i).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(2, i).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(2, i).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(2, i).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                worksheet.Cell(2, i).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                if (anyGroup && string.IsNullOrEmpty(item.GroupName))
                {
                    worksheet.Range(2, i, 3, i).Merge();
                    worksheet.Cell(3, i).Style.Font.Bold = true;
                    worksheet.Cell(3, i).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(3, i).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(3, i).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(3, i).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(3, i).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    worksheet.Cell(3, i).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                }
                i++;
            }
            var h = 2;
            if (anyGroup)
            {
                foreach (var item in gridPolicy)
                {
                    if (anyGroup && !string.IsNullOrEmpty(item.GroupName))
                    {
                        worksheet.Cell(3, h).SetValue(ConvertHtmlToPlainText(item.ShortDesc));
                        worksheet.Cell(3, h).Style.Font.Bold = true;
                        worksheet.Cell(3, h).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                        worksheet.Cell(3, h).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                        worksheet.Cell(3, h).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                        worksheet.Cell(3, h).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                        worksheet.Cell(3, h).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet.Cell(3, h).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    }
                    h++;
                }
            }
            var x = 3;
            if (anyGroup)
            {
                x++;
            }
            var j = 1;
            foreach (var item in tables[0])
            {
                var y = 2;
                worksheet.Cell(x, 1).SetValue(j);
                worksheet.Cell(x, 1).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(x, 1).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(x, 1).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(x, 1).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                foreach (var itemDetail in gridPolicy)
                {
                    var vl = item.GetValueOrDefault(itemDetail.FieldName);
                    switch (itemDetail.ComponentType)
                    {
                        case "Input":
                            var vl1 = vl is null ? null : vl.ToString().DecodeSpecialChar();
                            worksheet.Cell(x, y).SetValue(vl1);
                            break;
                        case "Textarea":
                            var vl2 = vl is null ? null : vl.ToString().DecodeSpecialChar();
                            worksheet.Cell(x, y).SetValue(vl2);
                            break;
                        case "Label":
                            var vl3 = vl is null ? null : vl.ToString().DecodeSpecialChar();
                            worksheet.Cell(x, y).SetValue(vl3);
                            break;
                        case "Datepicker":
                            worksheet.Cell(x, y).SetValue((DateTime?)vl);
                            break;
                        case "Number":
                            if (vl is int)
                            {
                                worksheet.Cell(x, y).SetValue(vl is null ? default(int) : (int)vl);
                            }
                            else
                            {
                                worksheet.Cell(x, y).SetValue(vl is null ? default(decimal) : (decimal)vl);
                                worksheet.Cell(x, y).Style.NumberFormat.Format = "#,##";
                            }
                            break;
                        case "Dropdown":
                            var objField = itemDetail.FieldName.Substring(0, itemDetail.FieldName.Length - 2);
                            vl = item.GetValueOrDefault(objField);
                            var vl4 = vl is null ? null : vl.ToString().DecodeSpecialChar();
                            worksheet.Cell(x, y).SetValue(vl4);
                            break;
                        case "Checkbox":
                            worksheet.Cell(x, y).SetValue(vl.ToString() == "False" ? default(int) : 1);
                            break;
                        default:
                            break;
                    }
                    worksheet.Cell(x, y).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(x, y).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(x, y).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                    worksheet.Cell(x, y).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                    y++;
                }
                j++;
                x++;
            }
            var k = 2;
            var last = tables[0].Count + 3;
            worksheet.Cell(last, 1).Value = "Total";
            worksheet.Cell(last, 1).Style.Border.RightBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(last, 1).Style.Border.TopBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(last, 1).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            worksheet.Cell(last, 1).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            foreach (var item in gridPolicy)
            {
                if (item.ComponentType == "Number")
                {
                    var value = tables[0].Select(x => x[item.FieldName]).Where(x => x != null).Sum(x =>
                    {
                        if (x is int)
                        {
                            return x is null ? default(int) : (int)x;
                        }
                        else
                        {
                            return x is null ? default(decimal) : (decimal)x;
                        }
                    });
                    worksheet.Cell(last, k).SetValue(value);
                    worksheet.Cell(last, k).Style.Font.Bold = true;
                    worksheet.Cell(last, k).Style.NumberFormat.Format = "#,##";
                }
                worksheet.Cell(last, k).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(last, k).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(last, k).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                worksheet.Cell(last, k).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                k++;
            }
            var url = $"{component.RefName}{DateTime.Now:ddMMyyyyhhmm}.xlsx";
            worksheet.Columns().AdjustToContents();
            workbook.SaveAs($"wwwroot\\excel\\Download\\{url}");
            return url;
        }

        public async Task ExecSql(string sql, string disableTrigger, string enableTrigger)
        {
            using (SqlConnection connection = new SqlConnection(Startup.GetConnectionString(_serviceProvider, _config, "fastweb")))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Transaction = transaction;
                        command.Connection = connection;
                        command.CommandText += disableTrigger;
                        command.CommandText += sql;
                        command.CommandText += enableTrigger;
                        await command.ExecuteNonQueryAsync();
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
        }
        
    }
}
