using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class SeaFreightPricingDetail
    {
        public int IDKey { get; set; }
        public string NoID { get; set; }
        public string Nameofservice { get; set; }
        public double? MinLCL { get; set; }
        public double? LCL { get; set; }
        public string Currency { get; set; }
        public string Unit { get; set; }
        public string UnitCtnr { get; set; }
        public double? Ctnr20 { get; set; }
        public double? Ctnr20RF { get; set; }
        public double? Ctnr40 { get; set; }
        public double? Ctnr40RF { get; set; }
        public double? Ctnr40HQ { get; set; }
        public double? Ctnr45HQ { get; set; }
        public double? CtnrDB20 { get; set; }
        public double? Others { get; set; }
        public string ContType { get; set; }
        public double? VAT { get; set; }
        public bool? VATContractor { get; set; }
        public bool? KOOF { get; set; }
        public bool? CC { get; set; }
        public bool? TT { get; set; }
        public string CCPartnerID { get; set; }
        public string Notes { get; set; }
        public int? iIndex { get; set; }
        public bool? OBH { get; set; }
    }
}
