using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class NameFeeDescription
    {
        public string FeeID { get; set; }
        public string FeeCode { get; set; }
        public string FeeDescEn { get; set; }
        public string FeeDescLocal { get; set; }
        public string UnitEn { get; set; }
        public string UnitLocal { get; set; }
        public string GroupName { get; set; }
        public int? FeeMode { get; set; }
        public bool? dbt { get; set; }
        public bool? KBCK { get; set; }
        public bool? Freight { get; set; }
        public bool? LocalCharges { get; set; }
        public bool? CSCharges { get; set; }
        public bool? Logistics { get; set; }
        public bool? Trucking { get; set; }
        public bool? GWHeavyW { get; set; }
        public bool? ExpRate { get; set; }
        public bool? ExpFSC { get; set; }
        public bool? ExpAdmin { get; set; }
        public bool? ExpOthers { get; set; }
        public string DeptCode { get; set; }
        public string MapDeptCode { get; set; }
        public string MapFeeCode { get; set; }
        public string AccNo { get; set; }
        public string AccCo { get; set; }
        public string GainAC { get; set; }
        public string LossAC { get; set; }
        public double? UnitPrice { get; set; }
        public string CurrUnit { get; set; }
        public string VAT { get; set; }
        public bool? VATRequired { get; set; }
        public string VATCode { get; set; }
        public string UserInput { get; set; }
        public DateTime? DateModify { get; set; }
        public string CompID { get; set; }
        public string IssueMoreACCode { get; set; }
        public string IssueFrom { get; set; }
        public string IssueTo { get; set; }
        public double? Qty { get; set; }
        public bool? QtyPercent { get; set; }
        public string PayablePartnerID { get; set; }
        public bool? KBMode { get; set; }
        public string UserIssued { get; set; }
        public bool? UpdateToLinkedHBL { get; set; }
        public double? MinAmount { get; set; }
        public double? TotalPercentCharges { get; set; }
        public double? MaxPercentCharges { get; set; }
        public string PartnerIDCharges { get; set; }
        public bool? EffectToShipmentProfit { get; set; }
        public string InnerPartnerIDCharges { get; set; }
        public string CostInsChargeCode { get; set; }
        public string CompChargeCode { get; set; }
        public string FormularAC { get; set; }
        public string FormularACCond { get; set; }
        public bool? AirFreight { get; set; }
        public bool? SeaFreight { get; set; }
        public bool? TruckingRate { get; set; }
        public bool? Domestics { get; set; }
        public string SOAGroupName { get; set; }
        public bool? VATCharge { get; set; }
        public bool? GainLossCharge { get; set; }
        public bool? NoUpdateKBCharge { get; set; }
    }
}
