using Core.Extensions;
using TMS.API.Models;
namespace TMS.API.Controllers
{
    public class TaskListController : TMSController<TaskList>
    {
        public TaskListController(TMSContext context, EntityService entityService, IHttpContextAccessor httpContextAccessor) : base(context, entityService, httpContextAccessor)
        {

        }
    }
}
