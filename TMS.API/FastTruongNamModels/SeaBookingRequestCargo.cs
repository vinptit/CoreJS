using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class SeaBookingRequestCargo
    {
        public string BKRefNo { get; set; }
        public decimal IDKey { get; set; }
        public string CargoDescription { get; set; }
        public string HSCode { get; set; }
        public double? TareWeight { get; set; }
        public string TareUnit { get; set; }
        public double? GrossVolume { get; set; }
        public string GVUnit { get; set; }
        public int? Packages { get; set; }
        public string PackageUnit { get; set; }
        public int? LIndex { get; set; }
        public string NatureOfCargo { get; set; }
        public string IMOClassCode { get; set; }
        public string UNDGNumber { get; set; }
        public string ProperShippingName { get; set; }

        public virtual SeaBookingRequest BKRefNoNavigation { get; set; }
    }
}
