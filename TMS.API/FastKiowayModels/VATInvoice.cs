using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class VATInvoice
    {
        public VATInvoice()
        {
            VATInvoiceDetailAT = new HashSet<VATInvoiceDetailAT>();
            VATInvoiceDetailSource = new HashSet<VATInvoiceDetailSource>();
            VATInvoiceLog = new HashSet<VATInvoiceLog>();
        }

        public string ID { get; set; }
        public string InvoiceNo { get; set; }
        public string InvoiceID { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string OriginCustomerID { get; set; }
        public string CustomerID { get; set; }
        public string Attn { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string PaymentMethod { get; set; }
        public string Currency { get; set; }
        public string CurConvert { get; set; }
        public double? DiscountPer { get; set; }
        public double? DiscountAmount { get; set; }
        public double? VATRate { get; set; }
        public double? VATTotal { get; set; }
        public double? ExRate { get; set; }
        public bool InvDemage { get; set; }
        public bool InvHelpCollect { get; set; }
        public string InvHelpof { get; set; }
        public string Note { get; set; }
        public bool blnZeroVAT { get; set; }
        public bool? InvoiceMode { get; set; }
        public bool? InvoiceCombine { get; set; }
        public bool MultiVAT { get; set; }
        public bool? VATPaid { get; set; }
        public DateTime? VATPaidDate { get; set; }
        public bool? VATReceived { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public bool? ForeignCurr { get; set; }
        public string Inword { get; set; }
        public string Notes { get; set; }
        public string VesselVoy { get; set; }
        public string MBLNo { get; set; }
        public string JobNo { get; set; }
        public string DDHG { get; set; }
        public string DDNH { get; set; }
        public string Description { get; set; }
        public string SalesMethod { get; set; }
        public bool? Attached { get; set; }
        public string AttachNo { get; set; }
        public string AttachDescription { get; set; }
        public bool? Exported { get; set; }
        public DateTime? DateExport { get; set; }
        public string WhoisMaking { get; set; }
        public string WhoisPaid { get; set; }
        public int? PaymentTime { get; set; }
        public string ContractNo { get; set; }
        public DateTime? ContractDate { get; set; }
        public string SOANO { get; set; }
        public string WhoModify { get; set; }
        public DateTime? DateModify { get; set; }
        public string LogFile { get; set; }
        public bool? INVLocked { get; set; }
        public DateTime? INVLockDate { get; set; }
        public string INVOpenTrans { get; set; }
        public string TRSOANo { get; set; }
        public string CustomNo { get; set; }
        public bool? ACVoucher { get; set; }
        public string VoucherNo { get; set; }
        public string VoucherNoSE { get; set; }
        public string Status { get; set; }
        public string Fkey { get; set; }
        public string StatusReplace { get; set; }
        public string StatusCancel { get; set; }
        public bool? DraftInv { get; set; }
        public decimal RedInvIDKey { get; set; }
        public bool? TaxExported { get; set; }
        public DateTime? TaxDateExport { get; set; }
        public string ExportLog { get; set; }
        public string HostName { get; set; }
        public string IPAddress { get; set; }
        public string WhoSync { get; set; }
        public DateTime? DateSync { get; set; }
        public bool? DoingSync { get; set; }
        public string StatusAdjust { get; set; }
        public string TypeAdjust { get; set; }
        public bool? isDefaultInBill { get; set; }
        public DateTime? TMPETA { get; set; }
        public DateTime? TMPETD { get; set; }
        public string TMPDDHG { get; set; }
        public string TMPDDNH { get; set; }
        public string Consignee { get; set; }
        public string Consignor { get; set; }
        public bool? isShowBuyer { get; set; }
        public bool? isShowCusName { get; set; }
        public string FkeyRandom { get; set; }
        public Guid? FkeyTMP { get; set; }
        public Guid? InvoiceGUID { get; set; }
        public string InvoiceBkavLog { get; set; }
        public string InvoiceNoSync { get; set; }
        public string InvoiceCode { get; set; }
        public string OriginalInvoiceIdentify { get; set; }
        public string LinkedFkey { get; set; }
        public bool? IsIncrease { get; set; }
        public bool? isPush { get; set; }
        public bool? isPushAndSign { get; set; }
        public string OriginRefNo { get; set; }
        public int? SourceLinkedID { get; set; }
        public string ConnectStringOrigin { get; set; }
        public bool? ChangeEditLinked { get; set; }
        public DateTime? ChangeDateTime { get; set; }
        public bool? LinkedDeleted { get; set; }
        public string RMUpdatedUser { get; set; }
        public bool? eInvoiceUpdateCancelStatus { get; set; }
        public DateTime? DateReadCancelStatus { get; set; }
        public DateTime? ImportedDate { get; set; }
        public string StatusReplacedBy { get; set; }
        public string StatusReplaceTo { get; set; }
        public string StatusAdjustedBy { get; set; }
        public string StatusAdjustTo { get; set; }
        public string SoVanBan { get; set; }
        public DateTime? NgayVanBan { get; set; }
        public string InvoiceSyncLog { get; set; }
        public bool? DisplayBLDetail { get; set; }
        public bool? GroupByBLInv { get; set; }
        public bool? GroupByCharges { get; set; }
        public bool? GETEINV { get; set; }
        public DateTime? DateGET { get; set; }
        public bool? ESigned { get; set; }
        public string AttachUnit { get; set; }
        public bool? GroupByJob { get; set; }
        public string RefNoType { get; set; }
        public string SelectedPage { get; set; }
        public string LinkEInvoice { get; set; }
        public bool? InvEDIT { get; set; }
        public bool? VATEDIT { get; set; }
        public decimal? InvIDEDITOf { get; set; }
        public bool GroupByJobAndHBL { get; set; }
        public Guid? TempInvoiceGUID { get; set; }
        public string TempInvoiceCode { get; set; }
        public string TempInvoiceNoSync { get; set; }
        public DateTime? SignDate { get; set; }
        public string FKeyTemp { get; set; }
        public string Taxcode { get; set; }
        public bool? ISSYNC { get; set; }

        public virtual Partners Customer { get; set; }
        public virtual InvoiceForm IDNavigation { get; set; }
        public virtual VATInvSOA SOANONavigation { get; set; }
        public virtual ICollection<VATInvoiceDetailAT> VATInvoiceDetailAT { get; set; }
        public virtual ICollection<VATInvoiceDetailSource> VATInvoiceDetailSource { get; set; }
        public virtual ICollection<VATInvoiceLog> VATInvoiceLog { get; set; }
    }
}
