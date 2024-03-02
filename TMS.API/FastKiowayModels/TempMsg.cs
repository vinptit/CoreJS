using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class TempMsg
    {
        public string MsgID { get; set; }
        public string MsgContents { get; set; }
        public DateTime? DateModify { get; set; }
        public string UserName { get; set; }
        public string PCName { get; set; }
        public string TypeUpdate { get; set; }
        public string RefNo { get; set; }
    }
}
