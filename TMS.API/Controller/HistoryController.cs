using Core.Extensions;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using TMS.API.Models;

namespace TMS.API.Controllers
{
    public class HistoryController : GenericController<ACC_History>
    {
        private readonly HistoryContext db;
        public HistoryController(HistoryContext context, EntityService entityService, IHttpContextAccessor httpContextAccessor) : base(context, entityService, httpContextAccessor)
        {
            db = context;
        }

        public override Task<OdataResult<ACC_History>> Get(ODataQueryOptions<ACC_History> options)
        {
            var query = db.ACC_History.AsQueryable();
            return ApplyQuery(options, query);
        }

        public override Task<ActionResult<ACC_History>> CreateAsync([FromBody] ACC_History entity)
        {
            entity.TanentCode = _userSvc.VendorId.ToString();
            return base.CreateAsync(entity);
        }
    }
}