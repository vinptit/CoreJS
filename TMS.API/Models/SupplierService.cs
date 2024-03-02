using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class SupplierService
    {
        public int Id { get; set; }
        public int? SupplierId { get; set; }
        public int? ServiceId { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
