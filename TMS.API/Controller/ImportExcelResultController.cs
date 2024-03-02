using Core.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TMS.API.Models;
using TMS.API.ViewModels;

namespace TMS.API.Controllers
{
    public class ImportExcelResultController : TMSController<ImportExcelResult>
    {
        public ImportExcelResultController(TMSContext context, EntityService entityService, IHttpContextAccessor httpContextAccessor) : base(context, entityService, httpContextAccessor)
        {

        }
        
    }
}
