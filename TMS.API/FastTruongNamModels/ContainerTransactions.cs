using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ContainerTransactions
    {
        public ContainerTransactions()
        {
            ContainerTransactionDetails = new HashSet<ContainerTransactionDetails>();
        }

        public int IDKey { get; set; }
        public string ContainerNo { get; set; }
        public int? SPKeyIDLink { get; set; }
        public DateTime? OutDate { get; set; }
        public DateTime? InDate { get; set; }
        public bool? OnHire { get; set; }
        public bool? OffHire { get; set; }
        public string RefNo { get; set; }
        public DateTime? DateofHire { get; set; }
        public string Remarks { get; set; }
        public string UserInput { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public int? SPKeyIDLinkCtnr { get; set; }
        public string BKNo { get; set; }

        public virtual ContainersList ContainerNoNavigation { get; set; }
        public virtual ContainerListOnHBL SPKeyIDLinkNavigation { get; set; }
        public virtual ICollection<ContainerTransactionDetails> ContainerTransactionDetails { get; set; }
    }
}
