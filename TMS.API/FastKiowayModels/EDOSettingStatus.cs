using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class EDOSettingStatus
    {
        public int IDKey { get; set; }
        public int? IDLinked { get; set; }
        public string StatusType { get; set; }
        public string StatusCode { get; set; }
        public string StatusDescription { get; set; }
    }
}
