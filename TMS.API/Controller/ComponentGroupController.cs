using Core.Extensions;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TMS.API.Models;

namespace TMS.API.Controllers
{
    public class ComponentGroupController : TMSController<ComponentGroup>
    {
        public ComponentGroupController(TMSContext context,EntityService entityService, IHttpContextAccessor httpContextAccessor) : base(context, entityService, httpContextAccessor)
        {
        }

        [AllowAnonymous]
        public override Task<OdataResult<ComponentGroup>> Get(ODataQueryOptions<ComponentGroup> options)
        {
            return ApplyQuery(options, db.ComponentGroup);
        }

        [HttpPost("api/[Controller]/CloneComponentGroup")]
        public async Task<ActionResult<bool>> CopyFromTo([FromBody] ComponentGroup com)
        {
            var _com = com;
            var nComponentGroup = new ComponentGroup();
            nComponentGroup.CopyPropFrom(_com, nameof(ComponentGroup.Id));
            SetAuditInfo(nComponentGroup);
            db.Add(nComponentGroup);
            await db.SaveChangesAsync();
            var component = await db.Component.AsNoTracking().Where(x => x.ComponentGroupId == com.Id).ToListAsync();
            var component1 = component.Select(x =>
            {
                var f = new Component();
                f.CopyPropFrom(x, nameof(Feature.Id));
                f.ComponentGroupId = nComponentGroup.Id;
                SetAuditInfo(f);
                return f;
            }).ToList();
            db.AddRange(component1);
            await db.SaveChangesAsync();
            var componentGroup = await db.ComponentGroup.AsNoTracking().Where(x => x.FeatureId == com.FeatureId && x.ParentId == com.Id).ToListAsync();
            await CloneChildComponentGroup(componentGroup, nComponentGroup);
            return true;
        }

        private async Task CloneChildComponentGroup(List<ComponentGroup> componentGroup, ComponentGroup newComponentGroup)
        {
            foreach (var comG in componentGroup)
            {
                var comG1 = new ComponentGroup();
                comG1.CopyPropFrom(comG, nameof(ComponentGroup.Id));
                comG1.ParentId = newComponentGroup.Id;
                SetAuditInfo(comG1);
                db.Add(comG1);
                await db.SaveChangesAsync();
                var component = await db.Component.AsNoTracking().Where(x => x.ComponentGroupId == comG.Id).ToListAsync();
                var component1 = component.Select(x =>
                {
                    var f = new Component();
                    f.CopyPropFrom(x, nameof(Feature.Id));
                    f.ComponentGroupId = comG1.Id;
                    SetAuditInfo(f);
                    return f;
                }).ToList();
                db.AddRange(component1);
                await db.SaveChangesAsync();
                var componentGroup2 = await db.ComponentGroup.AsNoTracking().Where(x => x.FeatureId == newComponentGroup.FeatureId && x.ParentId == comG.Id).ToListAsync();
                if (componentGroup2.Any())
                {
                    await CloneChildComponentGroup(componentGroup2, comG1);
                }
            }
        }
    }
}
