using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class BuyingRateInland
    {
        public string TransID { get; set; }
        public string PartnerID { get; set; }
        public string GroupName { get; set; }
        public double? Quantity { get; set; }
        public string QUnit { get; set; }
        public double? UnitPrice { get; set; }
        public string CurrencyConvertRate { get; set; }
        public double? VAT { get; set; }
        public double? TotalValue { get; set; }
        public double? Amount { get; set; }
        public double? ExtRate { get; set; }
        public double? ExtRateVND { get; set; }
        public double? ExtVND { get; set; }
        public string Notes { get; set; }
        public bool Dpt { get; set; }
        public bool? Obh { get; set; }
        public string OBHPartnerID { get; set; }
        public bool KBck { get; set; }
        public bool? NoInv { get; set; }
        public bool Paid { get; set; }
        public DateTime? PaidDate { get; set; }
        public string Docs { get; set; }
        public string SeriNo { get; set; }
        public string VoucherID { get; set; }
        public bool? SortInv { get; set; }
        public string SortDes { get; set; }
        public string FieldKey { get; set; }
        public string DataInput { get; set; }
        public DateTime? AccsDateKey { get; set; }
        public string AccsUserKey { get; set; }
        public bool? AccsLock { get; set; }
        public string AccsLog { get; set; }
        public string VoucherIDSE { get; set; }
        public string InoiceNo { get; set; }
        public decimal IDKeyIndex { get; set; }
        public bool? GWHeavyW { get; set; }
        public bool? Gainloss { get; set; }
        public double? USDEx { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public DateTime? EffectDate { get; set; }
        public bool? AutoInput { get; set; }
        public bool? Advanced { get; set; }
        public double? USDExPM { get; set; }
    }
}
