using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class VATInvoiceSyncLog
    {
        public decimal ID { get; set; }
        public string IDKey { get; set; }
        public string InvoiceID { get; set; }
        public string InvoiceNo { get; set; }
        public string FkeyRandom { get; set; }
        public string ReferenceKey { get; set; }
        public DateTime? DateLog { get; set; }
        public string btnText { get; set; }
        public string TypeAdjust { get; set; }
        public string HostName { get; set; }
        public string IPAddress { get; set; }
        public string WhoSync { get; set; }
        public string SQLQuery { get; set; }
        public string Base64Inv { get; set; }
        public string ResultImportInv { get; set; }
    }
}
