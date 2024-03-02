using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class PackageType
    {
        public int IDKey { get; set; }
        public string PACKAGE_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public bool? Cont { get; set; }
        public string MapedUnit { get; set; }
    }
}
