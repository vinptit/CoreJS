using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class Contract
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string Code { get; set; }
        public int? CustomerId { get; set; }
        public int? Type { get; set; }
        public DateTime? ContractDate { get; set; }
        public int? Status { get; set; }
        public string Note { get; set; }

        public virtual Vendor Customer { get; set; }
    }
}
