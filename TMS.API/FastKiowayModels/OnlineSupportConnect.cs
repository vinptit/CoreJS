using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class OnlineSupportConnect
    {
        public decimal IDKey { get; set; }
        public string ServerName { get; set; }
        public string DBName { get; set; }
        public string UserDB { get; set; }
        public string DBPwd { get; set; }
        public bool? EncodeST { get; set; }
        public bool? Activate { get; set; }
    }
}
