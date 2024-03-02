using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class AirPortPerKGSChargeable
    {
        public decimal IDKey { get; set; }
        public string PortCode { get; set; }
        public string PortName { get; set; }
        public string ChargeAC { get; set; }
        public string ChargeName { get; set; }
        public double? PerKGS { get; set; }
        public bool? Activate { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateCreated { get; set; }
        public string UserInput { get; set; }
        public string VendorID { get; set; }
        public string ViaPortCode { get; set; }
    }
}
