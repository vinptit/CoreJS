﻿using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class SellingRate
    {
        public string HAWBNO { get; set; }
        public string Description { get; set; }
        public string GroupName { get; set; }
        public string FieldName { get; set; }
        public double? Quantity { get; set; }
        public string QUnit { get; set; }
        public string Unit { get; set; }
        public double? UnitPrice { get; set; }
        public string CurrencyConvertRate { get; set; }
        public double? VAT { get; set; }
        public float? TotalValue { get; set; }
        public double? ExtRateVND { get; set; }
        public double? ExtVND { get; set; }
        public double? ExtVNDP { get; set; }
        public double? Amount { get; set; }
        public bool Collect { get; set; }
        public string Notes { get; set; }
        public bool? OBH { get; set; }
        public string OBHPartnerID { get; set; }
        public string NameOfCollect { get; set; }
        public string ContactCollect { get; set; }
        public string TaxCode { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public bool Paid { get; set; }
        public DateTime? PaidDate { get; set; }
        public string DocNo { get; set; }
        public string SeriNo { get; set; }
        public string VATInvID { get; set; }
        public string VoucherID { get; set; }
        public string VoucherIDSE { get; set; }
        public string InoiceNo { get; set; }
        public bool? NoInv { get; set; }
        public bool? SortInv { get; set; }
        public string SortDes { get; set; }
        public DateTime? AccsDateKey { get; set; }
        public string AccsUserKey { get; set; }
        public bool? AccsLock { get; set; }
        public string AccsLog { get; set; }
        public string FieldKey { get; set; }
        public string InputData { get; set; }
        public double? CurrencyRate { get; set; }
        public string RequisitionID { get; set; }
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
        public bool? SExpRate { get; set; }
        public bool? SExpFSC { get; set; }
        public bool? SExpAdmin { get; set; }
        public bool? AutoInput { get; set; }
        public DateTime? EffectDate { get; set; }
        public int? DueDays { get; set; }
        public DateTime? VATDate { get; set; }
        public int? InnerImported { get; set; }
        public int? InnerID { get; set; }
        public DateTime? DateUpdate { get; set; }
        public bool? Advanced { get; set; }
        public string CostSheetIDLinked { get; set; }
        public double? USDExPM { get; set; }
        public int? PaymentTime { get; set; }
        public string AdvVoucherID { get; set; }
        public double? PMAMTBFT { get; set; }
        public double? PMAMTTAX { get; set; }
        public string SettlementRefNo { get; set; }

        public virtual HAWB HAWBNONavigation { get; set; }
    }
}
