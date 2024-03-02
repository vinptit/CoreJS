using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class SeaFreightPricing
    {
        public decimal IDKey { get; set; }
        public string NoID { get; set; }
        public string POL { get; set; }
        public string POD { get; set; }
        public string Destination { get; set; }
        public bool? ImportMode { get; set; }
        public string Lines { get; set; }
        public string Service { get; set; }
        public string Commodity { get; set; }
        public string AccountRef { get; set; }
        public double? LCL { get; set; }
        public double? DC20 { get; set; }
        public double? RF20 { get; set; }
        public double? DC40 { get; set; }
        public double? RF40 { get; set; }
        public double? HC40 { get; set; }
        public double? HC45 { get; set; }
        public double? DB20 { get; set; }
        public double? Others { get; set; }
        public string ContType { get; set; }
        public string Currency { get; set; }
        public string TT { get; set; }
        public string InlAddon { get; set; }
        public string EmptyReturn { get; set; }
        public string Amend { get; set; }
        public string Freq { get; set; }
        public string Cutoff { get; set; }
        public string Baf { get; set; }
        public string Caf { get; set; }
        public string Isps { get; set; }
        public string Pss { get; set; }
        public string Gri { get; set; }
        public DateTime? EffectDate { get; set; }
        public DateTime? Validity { get; set; }
        public string Note { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public double? VAT { get; set; }
        public bool? VATContractor { get; set; }
        public string UserInput { get; set; }
        public string Carrier { get; set; }
        public double? LCLMin { get; set; }
        public bool? PublicPrice { get; set; }
        public int? DEM { get; set; }
        public int? DET { get; set; }
        public int? STO { get; set; }
        public double? SalesMakeup { get; set; }
        public bool? LockedRCD { get; set; }

        public virtual Partners LinesNavigation { get; set; }
    }
}
