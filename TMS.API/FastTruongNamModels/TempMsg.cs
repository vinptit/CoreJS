using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
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
        public string HostName { get; set; }
        public string IPAddress { get; set; }
        public string XMLContent { get; set; }
    }
}
