using Core.Extensions;
using Microsoft.AspNet.OData.Query;
using TMS.API.Models;

namespace TMS.API.Controllers
{
    public class RequestLogController : GenericController<RequestLog>
    {
        private readonly LogContext db;
        public RequestLogController(LogContext context, EntityService entityService, IHttpContextAccessor httpContextAccessor) : base(context, entityService, httpContextAccessor)
        {
            db = context;
        }

        public override Task<OdataResult<RequestLog>> Get(ODataQueryOptions<RequestLog> options)
        {
            var query = db.RequestLog.AsQueryable();
            return ApplyQuery(options, query);
        }
    }
}