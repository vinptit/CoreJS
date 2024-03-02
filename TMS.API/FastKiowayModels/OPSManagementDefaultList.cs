using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class OPSManagementDefaultList
    {
        public int IDKey { get; set; }
        public string ServiceMode { get; set; }
        public string ServiceName { get; set; }
        public int? IIndex { get; set; }
        public string UserDefault { get; set; }
        public string CompID { get; set; }
    }
}
