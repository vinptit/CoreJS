using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class AuthorizedApproval
    {
        public string RefNo { get; set; }
        public string WhoisID { get; set; }
        public string ContactID { get; set; }
        public bool? AirQuoApp { get; set; }
        public bool? SeaQuoApp { get; set; }
        public bool? AdvManagerApp { get; set; }
        public bool? AdvAccsMngApp { get; set; }
        public bool? AdvPBOBApp { get; set; }
        public bool? AdvAccsFNApp { get; set; }
        public bool? SettleManagerApp { get; set; }
        public bool? SettleAccsMngApp { get; set; }
        public bool? SettlePBOBApp { get; set; }
        public bool? SettleAccsFNApp { get; set; }
        public bool? AppActive { get; set; }
        public DateTime? Datefrom { get; set; }
        public DateTime? Dateto { get; set; }
        public DateTime? DateApply { get; set; }
        public bool? AppDeleted { get; set; }
        public DateTime? AppDatedeleted { get; set; }
        public string AppDeletedNote { get; set; }
        public string UserInput { get; set; }
        public bool? JobApproval { get; set; }
        public bool? UnJobApproval { get; set; }
    }
}
