using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class PartnerCategory
    {
        public int Id { get; set; }
        public int? PartnerId { get; set; }
        public int? CategoryId { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Category Category { get; set; }
        public virtual Partners Partner { get; set; }
    }
}
