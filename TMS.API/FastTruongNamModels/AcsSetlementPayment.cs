using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class AcsSetlementPayment
    {
        public AcsSetlementPayment()
        {
            AcsSetlementPaymentAttachedFiles = new HashSet<AcsSetlementPaymentAttachedFiles>();
            AdvanceSettlementPayment = new HashSet<AdvanceSettlementPayment>();
        }

        public string SetleID { get; set; }
        public string AdvNo { get; set; }
        public string AdvNo2 { get; set; }
        public string AdvNo3 { get; set; }
        public string AdvNo4 { get; set; }
        public string AdvNo5 { get; set; }
        public string AdvListNo { get; set; }
        public string RefNo { get; set; }
        public DateTime? StltRealDate { get; set; }
        public DateTime? StltDate { get; set; }
        public DateTime? SltCashierDate { get; set; }
        public string SltContactID { get; set; }
        public string SltContact { get; set; }
        public string SltAddress { get; set; }
        public string StlDescription { get; set; }
        public string SltPaymentNote { get; set; }
        public string SltSCID { get; set; }
        public string SltCSName { get; set; }
        public bool? SltCSStickDeny { get; set; }
        public bool? SltCSStickApp { get; set; }
        public bool? SltCSStickWait { get; set; }
        public DateTime? SltCSSignDate { get; set; }
        public string SltDpManagerID { get; set; }
        public string SltDpManagerAuID { get; set; }
        public bool SltDpManagerStickDeny { get; set; }
        public bool SltDpManagerStickApp { get; set; }
        public bool SltDpManagerStickWait { get; set; }
        public string SltDpManagerName { get; set; }
        public string SltDpManagerAuName { get; set; }
        public DateTime? SltDpSignDate { get; set; }
        public string SltDpComment { get; set; }
        public string SltAcsDpManagerID { get; set; }
        public string SltAcsDpManagerAuID { get; set; }
        public string SltAcsDpManagerAu2ID { get; set; }
        public bool SltAcsDpManagerStickDeny { get; set; }
        public bool SltAcsDpManagerStickApp { get; set; }
        public bool SltAcsDpManagerStickWait { get; set; }
        public string SltAcsDpManagerName { get; set; }
        public string SltAcsDpManagerAuName { get; set; }
        public string SltAcsDpManagerAu2Name { get; set; }
        public DateTime? SltAcsSignDate { get; set; }
        public string SltBODID { get; set; }
        public string SltBOAuDID { get; set; }
        public bool SltBODStickDeny { get; set; }
        public bool SltBODStickApp { get; set; }
        public bool SltBODStickWait { get; set; }
        public string SltBODName { get; set; }
        public string SltBODAuName { get; set; }
        public DateTime? SltBODSignDate { get; set; }
        public bool Saved { get; set; }
        public DateTime? PaidDate { get; set; }
        public double? AmountSettle { get; set; }
        public string SettleCurrency { get; set; }
        public bool AcsApproval { get; set; }
        public DateTime? AcsApprovalDate { get; set; }
        public bool ClearStatus { get; set; }
        public string Status { get; set; }
        public DateTime? ClearDate { get; set; }
        public string WhoisClear { get; set; }
        public string SltCashier { get; set; }
        public bool StlCashWait { get; set; }
        public string SltAcsCashierName { get; set; }
        public string SltPaymentCheck { get; set; }
        public string SltNote { get; set; }
        public bool StlPayment { get; set; }
        public bool Preview { get; set; }
        public string Attached { get; set; }
        public string GroupVoucherID { get; set; }
        public bool? NoLink { get; set; }
        public string AdvNo6 { get; set; }
        public string AdvNo7 { get; set; }
        public string AdvNo8 { get; set; }
        public string AdvNo9 { get; set; }
        public string AdvNo10 { get; set; }
        public bool? ViceChecked { get; set; }
        public DateTime? ViceCheckedDate { get; set; }
        public string ViceCheckedUser { get; set; }
        public DateTime? StltModifyDate { get; set; }
        public string InvoiceNoList { get; set; }
        public string PMRequisitionID { get; set; }
        public bool? Cancelled { get; set; }
        public DateTime? CancelledDate { get; set; }
        public string StlCurr { get; set; }
        public bool? ISREAD { get; set; }
        public bool NoJob { get; set; }
        public bool ISMOBILE { get; set; }
        public string PARTNERID { get; set; }
        public string OldSltContactID { get; set; }

        public virtual ContactsList SltContactNavigation { get; set; }
        public virtual ICollection<AcsSetlementPaymentAttachedFiles> AcsSetlementPaymentAttachedFiles { get; set; }
        public virtual ICollection<AdvanceSettlementPayment> AdvanceSettlementPayment { get; set; }
    }
}
