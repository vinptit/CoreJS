using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ProfitShares
    {
        public string HAWBNO { get; set; }
        public string PartnerID { get; set; }
        public string GroupName { get; set; }
        public string AutoDivide { get; set; }
        public string FieldName { get; set; }
        public double? Quantity { get; set; }
        public string QUnit { get; set; }
        public double? UnitPrice { get; set; }
        public string CurrencyConvertRate { get; set; }
        public double? VAT { get; set; }
        public double? TotalValue { get; set; }
        public double? ExtRate { get; set; }
        public double? ExtRateVND { get; set; }
        public double? ExtVND { get; set; }
        public double? ExtVNDP { get; set; }
        public double? Amount { get; set; }
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
        public string VATInvID { get; set; }
        public DateTime? VATDate { get; set; }
        public string VATName { get; set; }
        public string VATTaxCode { get; set; }
        public string VoucherID { get; set; }
        public string VoucherIDSE { get; set; }
        public string SettlementRefNo { get; set; }
        public string InoiceNo { get; set; }
        public bool SortInv { get; set; }
        public string SortDes { get; set; }
        public DateTime? AccsDateKey { get; set; }
        public string AccsUserKey { get; set; }
        public bool? AccsLock { get; set; }
        public string AccsLog { get; set; }
        public string FieldKey { get; set; }
        public string OBHFieldKey { get; set; }
        public string DataInput { get; set; }
        public bool? OBHLink { get; set; }
        public bool? FixedCost { get; set; }
        public string RequisitionID { get; set; }
        public int? IDKeyLinked { get; set; }
        public string CostSheetIDLinked { get; set; }
        public int? ContMnIDLinked { get; set; }
        public bool? CC { get; set; }
        public bool? TT { get; set; }
        public string VATSOANo { get; set; }
        public string INVSOANo { get; set; }
        public decimal IDKeyIndex { get; set; }
        public decimal? IDKeyShipmentDT { get; set; }
        public bool? GWHeavyW { get; set; }
        public decimal? CIDIndex { get; set; }
        public bool? Gainloss { get; set; }
        public DateTime? InvDate { get; set; }
        public double? MQty { get; set; }
        public string MUnit { get; set; }
        public double? MPrice { get; set; }
        public double? MVAT { get; set; }
        public double? MTotalValue { get; set; }
        public double? LCBFTaxAmount { get; set; }
        public double? LCTaxAmount { get; set; }
        public double? USDEx { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public bool? AutoInput { get; set; }
        public string UserInputRCD { get; set; }
        public DateTime? EffectDate { get; set; }
        public int? DueDays { get; set; }
        public bool? Advanced { get; set; }
        public bool? RemoteCharges { get; set; }
        public string RemoteChargesRef { get; set; }
        public decimal? SettleIDLinked { get; set; }
        public double? USDExPM { get; set; }
        public string MTKeyLinked { get; set; }
        public string PFSNotes { get; set; }
        public int? PaymentTime { get; set; }
        public string AdvVoucherID { get; set; }
        public double? PMAMTBFT { get; set; }
        public double? PMAMTTAX { get; set; }
        public bool? SettleExisting { get; set; }

        public virtual HAWB HAWBNONavigation { get; set; }
        public virtual Partners Partner { get; set; }
    }
}
