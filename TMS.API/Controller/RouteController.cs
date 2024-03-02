using Core.Extensions;
using TMS.API.Controllers;
using TMS.API.Models;
namespace TMS.API.Controller
{
    public class RouteController : TMSController<Models.Route>
    {
        public RouteController(TMSContext context, EntityService entityService, IHttpContextAccessor httpContextAccessor) : base(context, entityService, httpContextAccessor)
        {

        }
    }
}
