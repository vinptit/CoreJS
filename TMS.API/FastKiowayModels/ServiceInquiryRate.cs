using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ServiceInquiryRate
    {
        public int IDKey { get; set; }
        public int? IDLinked { get; set; }
        public string PartnerID { get; set; }
        public double? Quantity { get; set; }
        public string Unit { get; set; }
        public double? UnitPrice { get; set; }
        public string Curr { get; set; }
        public double? VAT { get; set; }
        public double? TotalValue { get; set; }
        public bool Collect { get; set; }
        public double? ExtRate { get; set; }
        public double? ExtVND { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public bool Dpt { get; set; }
        public bool? KB { get; set; }
        public bool? NoInv { get; set; }
        public int? DataIndex { get; set; }
    }
}
