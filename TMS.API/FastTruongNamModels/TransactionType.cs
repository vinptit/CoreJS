using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            InvoiceReferenceMode = new HashSet<InvoiceReferenceMode>();
            Transactions = new HashSet<Transactions>();
        }

        public string IDTransType { get; set; }
        public string Description { get; set; }
        public bool Request { get; set; }
        public bool Export { get; set; }
        public bool RateRequired { get; set; }
        public string Sign { get; set; }
        public string sMonth { get; set; }
        public string No { get; set; }
        public string Ys { get; set; }
        public string sYear { get; set; }
        public string Increment { get; set; }
        public int? IDResetOn { get; set; }
        public int? NoDaysLock { get; set; }
        public int? DayofLogisticsLock { get; set; }
        public int? LockAgainAfterUnlock { get; set; }
        public string ApproveManager { get; set; }
        public bool? MngAPP { get; set; }
        public string TypeList { get; set; }
        public string SignaturePre { get; set; }
        public int? DayofJobFinish { get; set; }
        public int? DeptCode { get; set; }
        public string ObjectList { get; set; }
        public bool? TypeListComboboxStyle { get; set; }

        public virtual ICollection<InvoiceReferenceMode> InvoiceReferenceMode { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
