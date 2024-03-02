﻿using Core.Extensions;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Authorization;
using TMS.API.Models;

namespace TMS.API.Controllers
{
    public class UserSettingController : TMSController<UserSetting>
    {
        public UserSettingController(TMSContext context,EntityService entityService, IHttpContextAccessor httpContextAccessor) : base(context, entityService, httpContextAccessor)
        {

        }

        [AllowAnonymous]
        public override Task<OdataResult<UserSetting>> Get(ODataQueryOptions<UserSetting> options)
        {
            var query =
                from setting in db.UserSetting
                from role in db.UserRole.Where(x => x.UserId == UserId && (setting.UserId == UserId || x.RoleId == setting.RoleId))
                where setting.Active
                select setting;
            return ApplyQuery(options, query.Distinct());
        }
    }
}
