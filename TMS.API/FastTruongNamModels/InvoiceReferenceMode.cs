using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class InvoiceReferenceMode
    {
        public int IDKey { get; set; }
        public short? InvMode { get; set; }
        public string ServiceID { get; set; }
        public string ReportName { get; set; }
        public string UserName { get; set; }
        public string CompID { get; set; }
        public string ReportNameList { get; set; }

        public virtual TransactionType Service { get; set; }
    }
}
