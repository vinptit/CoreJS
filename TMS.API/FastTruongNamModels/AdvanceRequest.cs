using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class AdvanceRequest
    {
        public string RefNo { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public string JobNo { get; set; }
        public string HBLNo { get; set; }
        public string PayeeID { get; set; }
        public string Description { get; set; }
        public double? AvdAmount { get; set; }
        public string Curr { get; set; }
        public double? ExchangeRate { get; set; }
        public DateTime? Deadline { get; set; }
        public string PaymentMethod { get; set; }
        public string RequesterID { get; set; }
        public string RequesterName { get; set; }
        public string UserName { get; set; }
        public string ContactName { get; set; }
        public bool? Locked { get; set; }
        public bool? Advanced { get; set; }
        public string AdvanceNo { get; set; }
        public string Remarks { get; set; }
        public string SettleNo { get; set; }
        public string VoucherID { get; set; }
        public string VoucherIDSE { get; set; }
        public string DVHistory { get; set; }
        public string Attached { get; set; }
        public bool? FromShipment { get; set; }
        public bool? MultiPartner { get; set; }
        public bool? Decline { get; set; }
        public DateTime? DeclineDate { get; set; }
        public bool? Cancelled { get; set; }
        public DateTime? CancelledDate { get; set; }
        public bool? AdvanceAR { get; set; }
        public string DescriptionLC { get; set; }
        public string UserLock { get; set; }

        public virtual Partners Payee { get; set; }
    }
}
