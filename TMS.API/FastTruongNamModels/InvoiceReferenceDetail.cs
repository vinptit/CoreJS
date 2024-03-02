using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class InvoiceReferenceDetail
    {
        public string InvoiceNo { get; set; }
        public double? Amount { get; set; }
        public string Curr { get; set; }
        public bool Dpt { get; set; }
        public double? ExtVND { get; set; }

        public virtual InvoiceReference InvoiceNoNavigation { get; set; }
    }
}
