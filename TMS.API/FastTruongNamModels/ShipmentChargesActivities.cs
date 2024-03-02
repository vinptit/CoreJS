using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ShipmentChargesActivities
    {
        public decimal IDKey { get; set; }
        public string ConditionDesc { get; set; }
        public string TransID { get; set; }
        public string HBLNo { get; set; }
        public string ChargeCode { get; set; }
        public string ChargeDescription { get; set; }
        public double? Qty { get; set; }
        public string QtyUnit { get; set; }
        public double? UnitPrice { get; set; }
        public string Curr { get; set; }
        public double? VAT { get; set; }
        public double? TotalValue { get; set; }
        public string Notes { get; set; }
        public bool? Debt { get; set; }
        public bool? TransDelete { get; set; }
        public bool? TransUpdate { get; set; }
        public bool? TransNew { get; set; }
        public bool? SendRQ { get; set; }
        public string UpdateChargeDescription { get; set; }
        public double? UpdateQty { get; set; }
        public string UpdateQtyUnit { get; set; }
        public double? UpdateUnitPrice { get; set; }
        public string UpdateCurr { get; set; }
        public double? UpdateVAT { get; set; }
        public double? UpdateTotalValue { get; set; }
        public string UpdateNotes { get; set; }
        public string TableSource { get; set; }
        public string UserApp { get; set; }
        public bool? Approved { get; set; }
        public bool? Decline { get; set; }
        public DateTime? UserAppReadDate { get; set; }
        public DateTime? UserReceivedReadDate { get; set; }
        public string CommentAPPDECL { get; set; }
        public DateTime? DateProcess { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string UpdateUser { get; set; }
        public string FieldKeyCharge { get; set; }
        public double? USDProfitAMT { get; set; }
        public double? ExtVND { get; set; }
        public double? USDExPM { get; set; }
        public double? USDAmount { get; set; }
        public double? USDEx { get; set; }
        public double? ExtRateVND { get; set; }
        public double? ShipmentDate { get; set; }
        public string PartnerID { get; set; }
        public string OBHPartnerID { get; set; }
    }
}
