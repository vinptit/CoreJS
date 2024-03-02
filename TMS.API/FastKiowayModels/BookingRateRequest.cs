using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class BookingRateRequest
    {
        public string BkgID { get; set; }
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
        public string ChargeCode { get; set; }
        public bool? CC { get; set; }
        public bool? TT { get; set; }
        public bool? RateApp { get; set; }
        public bool? Gainloss { get; set; }
        public bool? AutoInputPS { get; set; }
        public decimal IDKeyIndexPS { get; set; }
        public decimal? IDKeyIndexAU { get; set; }
        public bool? OBH { get; set; }

        public virtual Partners Partner { get; set; }
    }
}
