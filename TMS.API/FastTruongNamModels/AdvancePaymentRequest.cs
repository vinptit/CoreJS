using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class AdvancePaymentRequest
    {
        public AdvancePaymentRequest()
        {
            AdvancePaymentRequestDetails = new HashSet<AdvancePaymentRequestDetails>();
        }

        public string AdvID { get; set; }
        public string RefNo { get; set; }
        public DateTime? AdvRealDate { get; set; }
        public string PaymentNo { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? AdvDate { get; set; }
        public string AdvTo { get; set; }
        public string AdvContactID { get; set; }
        public string AdvContact { get; set; }
        public string AdvAddress { get; set; }
        public double? AdvValue { get; set; }
        public string AdvCurrency { get; set; }
        public string AdvCondition { get; set; }
        public string AdvRef { get; set; }
        public string AdvHBL { get; set; }
        public string AdvInvoiceNo { get; set; }
        public DateTime? AdvPaymentDate { get; set; }
        public string AdvPaymentNote { get; set; }
        public string AdvSCID { get; set; }
        public string AdvCSName { get; set; }
        public bool? AdvCSStickDeny { get; set; }
        public bool? AdvCSStickApp { get; set; }
        public bool? AdvCSStickWait { get; set; }
        public DateTime? AdvCSSignDate { get; set; }
        public string AdvDpManagerID { get; set; }
        public string AdvDpManagerAuID { get; set; }
        public bool AdvDpManagerStickDeny { get; set; }
        public bool AdvDpManagerStickApp { get; set; }
        public bool AdvDpManagerStickWait { get; set; }
        public string AdvDpManagerName { get; set; }
        public string AdvDpManagerAuName { get; set; }
        public DateTime? AdvDpSignDate { get; set; }
        public string AdvAcsDpManagerID { get; set; }
        public string AdvAcsDpManagerAuID { get; set; }
        public string AdvAcsDpManagerAu2ID { get; set; }
        public bool AdvAcsDpManagerStickDeny { get; set; }
        public bool AdvAcsDpManagerStickApp { get; set; }
        public bool AdvAcsDpManagerStickWait { get; set; }
        public string AdvAcsDpManagerName { get; set; }
        public string AdvAcsDpManagerAuName { get; set; }
        public string AdvAcsDpManagerAu2Name { get; set; }
        public DateTime? AdvAcsSignDate { get; set; }
        public string AdvBODID { get; set; }
        public string AdvBODAuID { get; set; }
        public bool AdvBODStickDeny { get; set; }
        public bool AdvBODStickApp { get; set; }
        public bool AdvBODStickWait { get; set; }
        public string AdvBODName { get; set; }
        public string AdvBODAuName { get; set; }
        public DateTime? AdvBODSignDate { get; set; }
        public bool Saved { get; set; }
        public string SettleNo { get; set; }
        public DateTime? PaidDate { get; set; }
        public double? AmountSettle { get; set; }
        public string SettleCurrency { get; set; }
        public bool AcsApproval { get; set; }
        public DateTime? AcsApprovalDate { get; set; }
        public bool ClearStatus { get; set; }
        public string Status { get; set; }
        public DateTime? ClearDate { get; set; }
        public string WhoisClear { get; set; }
        public string AdvCashier { get; set; }
        public bool AcsCashWait { get; set; }
        public string AdvCashierName { get; set; }
        public string AdvPaymentCheck { get; set; }
        public string AdvNote { get; set; }
        public bool Advance { get; set; }
        public bool Payment { get; set; }
        public bool OutPayment { get; set; }
        public string OTPayment { get; set; }
        public bool Preview { get; set; }
        public string GroupVoucherID { get; set; }
        public string Attached { get; set; }
        public bool? Deposit { get; set; }
        public string DepositType { get; set; }
        public string DepositDesc { get; set; }
        public string DepositPIC { get; set; }
        public DateTime? DateDepositForward { get; set; }
        public DateTime? DateReceivedForard { get; set; }
        public string SettleVCNo { get; set; }
        public bool? VCEditing { get; set; }
        public string OLDADVCONTACTID { get; set; }

        public virtual ICollection<AdvancePaymentRequestDetails> AdvancePaymentRequestDetails { get; set; }
    }
}
