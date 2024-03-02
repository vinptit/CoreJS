using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ContainerTransactionDetails
    {
        public int IDKey { get; set; }
        public int? IDKeyLinked { get; set; }
        public string RefNo { get; set; }
        public DateTime? TransDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Terminal { get; set; }
        public string Depot { get; set; }
        public string TransMode { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string UserInput { get; set; }
        public int? Priority { get; set; }
        public string ContainerNo { get; set; }

        public virtual ContainerTransactions IDKeyLinkedNavigation { get; set; }
        public virtual ContainerTransType TransModeNavigation { get; set; }
    }
}
