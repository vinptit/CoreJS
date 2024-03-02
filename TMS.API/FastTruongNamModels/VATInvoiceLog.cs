using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class VATInvoiceLog
    {
        public decimal IDKey { get; set; }
        public decimal? IDKeyLinked { get; set; }
        public string Description { get; set; }
        public bool? Notify { get; set; }
        public DateTime? NotifyDate { get; set; }
        public string NotifyContent { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string UserInput { get; set; }
        public string InvoiceType { get; set; }

        public virtual VATInvoice IDKeyLinkedNavigation { get; set; }
    }
}
