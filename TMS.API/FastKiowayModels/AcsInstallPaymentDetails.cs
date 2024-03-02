using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class AcsInstallPaymentDetails
    {
        public decimal IDKey { get; set; }
        public int? IDKeyLinked { get; set; }
        public string PartnerID { get; set; }
        public decimal? IDKeyIndex { get; set; }
        public string HBLNo { get; set; }
        public string Description { get; set; }
        public double? Quantity { get; set; }
        public string UnitQty { get; set; }
        public double? UnitPrice { get; set; }
        public string CurrUnit { get; set; }
        public double? VAT { get; set; }
        public double? TotalValue { get; set; }
        public double? ExchangeRate { get; set; }
        public double? TotalLCAmount { get; set; }
        public bool? Paid { get; set; }
        public DateTime? PaidDate { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateCreated { get; set; }
        public string InputBy { get; set; }
        public int? iIndex { get; set; }
        public string TableSource { get; set; }
        public bool? Partof { get; set; }
    }
}
