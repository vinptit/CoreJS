using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class InvoiceForm
    {
        public InvoiceForm()
        {
            VATInvoice = new HashSet<VATInvoice>();
        }

        public string ID { get; set; }
        public string InvoiceID { get; set; }
        public string Description { get; set; }
        public string Sign { get; set; }
        public decimal? StartInvoiceNo { get; set; }
        public decimal? EndInvoiceNo { get; set; }
        public int? InvSize { get; set; }
        public bool InvActive { get; set; }
        public bool? VATSyn { get; set; }
        public string PageDetail { get; set; }
        public bool? HBLdetail { get; set; }
        public string ReportName { get; set; }
        public string CompID { get; set; }
        public bool? isActiveSync { get; set; }
        public string CreatedUser { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public string InvoiceDateFormat { get; set; }
        public string DateMask { get; set; }
        public string API_URL { get; set; }
        public string APIHeader { get; set; }
        public string APIName { get; set; }
        public bool? LIndex { get; set; }
        public string APIEdit_URL { get; set; }
        public string APIGET_URL { get; set; }
        public bool? DisableChangeInvNoAndDate { get; set; }
        public string PartnerGUID { get; set; }
        public string PartnerToken { get; set; }
        public bool GetOnlyLockInvoice { get; set; }
        public bool AutoGenerateInvoiceNo { get; set; }
        public bool GroupByJobAndHBLFooter { get; set; }
        public bool InvoiceNoOnlyNummber { get; set; }
        public bool GroupFooter { get; set; }
        public string ID_IHOADON { get; set; }
        public string FORM_TYPE_ID_IHOADON { get; set; }
        public bool GroupByFooter { get; set; }
        public bool? IgnoreInvNoLen { get; set; }

        public virtual ICollection<VATInvoice> VATInvoice { get; set; }
    }
}
