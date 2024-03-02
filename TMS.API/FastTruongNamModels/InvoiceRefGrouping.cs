using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class InvoiceRefGrouping
    {
        public string IDTransType { get; set; }
        public string Description { get; set; }
        public int GroupOn { get; set; }
        public string UserNotes { get; set; }
    }
}
