using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class GAGENT
    {
        public string GAGENTID { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string GAGENT1 { get; set; }
        public string ADDRGAGENT { get; set; }
        public string COUNTRYCODE { get; set; }
        public string AREACODE { get; set; }
        public string TELGAGENT { get; set; }
        public string COUNTRYCODEFAX { get; set; }
        public string AREACODEFAX { get; set; }
        public string FAXGAGENT { get; set; }
        public string EMAILGAGENT { get; set; }
        public string PICGAGENT { get; set; }
        public string ZIPCODEGAGENT { get; set; }
        public string ACCGAGENT { get; set; }
        public string WUSERNAME { get; set; }
        public string WPASSWORD { get; set; }
        public DateTime? CLOSEDATE { get; set; }
        public string WEBSITE { get; set; }
        public string COUNTRYID { get; set; }
        public bool? IsTranAgent { get; set; }
        public bool? ISPRINCIPAL { get; set; }
        public string USERUPDATE { get; set; }
        public bool? IsAir { get; set; }
        public bool? IsSea { get; set; }
        public string NOTE { get; set; }
        public bool? CLOSED { get; set; }
        public DateTime? DATEUPDATE { get; set; }
        public string PORT { get; set; }
        public string DEPT { get; set; }
        public string LASTUSERUPDATE { get; set; }
        public DateTime? LASTDATEUPDATE { get; set; }
    }
}
