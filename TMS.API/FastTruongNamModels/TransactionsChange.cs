using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class TransactionsChange
    {
        public decimal IDKey { get; set; }
        public DateTime? DateInsert { get; set; }
        public string TransID { get; set; }
        public string HBLNo { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string ChangeMode { get; set; }
        public string Notes { get; set; }
        public bool? Received { get; set; }
        public DateTime? DateReceipt { get; set; }
        public string Userchange { get; set; }
        public string PCName { get; set; }
    }
}
