using Core.Extensions;
using TMS.API.Models;
namespace TMS.API.Controllers
{
    public class AttachedFileController : TMSController<AttachedFile>
    {
        public AttachedFileController(TMSContext context, EntityService entityService, IHttpContextAccessor httpContextAccessor) : base(context, entityService, httpContextAccessor)
        {

        }
    }
}
