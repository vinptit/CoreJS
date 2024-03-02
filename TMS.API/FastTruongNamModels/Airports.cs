using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class Airports
    {
        public string AirPortID { get; set; }
        public string AirPortName { get; set; }
        public string TypeService { get; set; }
        public string Country { get; set; }
        public string Zone { get; set; }
        public string Notes { get; set; }
        public string MaCK { get; set; }
        public string Address { get; set; }
        public string PersonIncharge { get; set; }
        public string TelNo { get; set; }
        public double? KGSPERCBM { get; set; }
        public string CBPCode { get; set; }

        public virtual EcusCuakhau MaCKNavigation { get; set; }
    }
}
