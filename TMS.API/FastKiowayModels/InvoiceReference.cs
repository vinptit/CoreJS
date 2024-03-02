using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class InvoiceReference
    {
        public InvoiceReference()
        {
            InvoiceReferenceDetail = new HashSet<InvoiceReferenceDetail>();
        }

        public string InvID { get; set; }
        public string TransID { get; set; }
        public string VoidTransID { get; set; }
        public string DateInvoice { get; set; }
        public DateTime? IssuedDate { get; set; }
        public bool Debt { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public string DepositCurr { get; set; }
        public string OtherRef { get; set; }
        public string DebitCurrency { get; set; }
        public string CreditCurrency { get; set; }
        public string ShipperID { get; set; }
        public string ShipperName { get; set; }
        public string ShipperAddress { get; set; }
        public short? PartnerMode { get; set; }
        public bool VoidInvoice { get; set; }
        public DateTime? VoidDate { get; set; }
        public string WhoisVoid { get; set; }
        public bool Revised { get; set; }
        public DateTime? ReviseDate { get; set; }
        public bool Paid { get; set; }
        public DateTime? PaidDate { get; set; }
        public string WhoisPaid { get; set; }
        public string WhoisIssued { get; set; }
        public bool? InvLock { get; set; }
        public bool? InvUnlock { get; set; }
        public DateTime? DateofLock { get; set; }
        public bool? ManagerChecked { get; set; }
        public DateTime? MngCheckedDate { get; set; }
        public string MngWhois { get; set; }
        public bool? AccsChecked { get; set; }
        public DateTime? AccsCheckedDate { get; set; }
        public string AccsWhois { get; set; }
        public string InvLockOpenTrans { get; set; }
        public bool? InvExported { get; set; }
        public DateTime? InvExportDate { get; set; }
        public string InvWhosExport { get; set; }
        public bool? Payment { get; set; }
        public DateTime? PaymentDateAssign { get; set; }
        public bool? ApprovedPayment { get; set; }
        public DateTime? ApprovedPaymentDate { get; set; }
        public bool? IssueInvoice { get; set; }
        public DateTime? IssueVATDateAsign { get; set; }
        public bool? ApprovedIssued { get; set; }
        public DateTime? ApprovedIssuedDate { get; set; }
        public string AssigntoUser { get; set; }
        public string SOANO { get; set; }
        public bool? InnerInvoice { get; set; }
        public bool? StatementINV { get; set; }
        public string Notes { get; set; }
        public string ReportName { get; set; }
        public string InvSeriNo { get; set; }
        public bool? NoIssueVATInv { get; set; }
        public string ServiceID { get; set; }
        public bool? RevenueOP { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string DateMode { get; set; }
        public bool? PaymentAssignReceived { get; set; }
        public DateTime? PaymentAssignReceivedDate { get; set; }
        public bool? VATIssueAssignReceived { get; set; }
        public DateTime? VATIssueAssignReceivedDate { get; set; }
        public string ReceiverRead { get; set; }
        public int? CreditTermDays { get; set; }

        public virtual InvoiceSOA SOANONavigation { get; set; }
        public virtual Partners Shipper { get; set; }
        public virtual Transactions Trans { get; set; }
        public virtual ICollection<InvoiceReferenceDetail> InvoiceReferenceDetail { get; set; }
    }
}
