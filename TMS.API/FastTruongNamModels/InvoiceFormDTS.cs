using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class InvoiceFormDTS
    {
        public string ID { get; set; }
        public string Whois { get; set; }
        public int? StartNo { get; set; }
        public int? EndNo { get; set; }
        public int? InvSize { get; set; }
        public bool InvActivate { get; set; }
        public string ReportName { get; set; }
    }
}
