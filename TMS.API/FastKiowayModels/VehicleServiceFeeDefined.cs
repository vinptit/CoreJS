using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class VehicleServiceFeeDefined
    {
        public int IDKey { get; set; }
        public string VHUnitNo { get; set; }
        public string TransFrom { get; set; }
        public string TransTo { get; set; }
        public bool? DistanceApply { get; set; }
        public bool? TripApply { get; set; }
        public string ServiceName { get; set; }
        public double? ServiceFee { get; set; }
        public string Curr { get; set; }
        public bool? PerRev { get; set; }
        public string Unit { get; set; }
        public double? ExtraFeeDbl20c { get; set; }
        public bool? PerRevEx { get; set; }
        public string PartnerID { get; set; }
        public bool? ActiveSV { get; set; }
        public string UserInput { get; set; }
        public DateTime? DateInput { get; set; }
        public DateTime? DateModify { get; set; }
        public string FeeCode { get; set; }
        public string Notes { get; set; }
        public decimal? VAT { get; set; }
        public bool? DirecttoShipment { get; set; }
        public string TransEMPTYRETURN { get; set; }
    }
}
