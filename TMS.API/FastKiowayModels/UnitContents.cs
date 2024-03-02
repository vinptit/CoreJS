using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class UnitContents
    {
        public string UnitID { get; set; }
        public string Description { get; set; }
        public string OrgeCountry { get; set; }
        public string KGs { get; set; }
        public double? Lenght { get; set; }
        public double? Height { get; set; }
        public double? Width { get; set; }
        public string LocalUnit { get; set; }
        public string Notes { get; set; }
        public string InttraUnit { get; set; }
        public string LocalUnitVAT { get; set; }
        public string AMSCode { get; set; }
    }
}
