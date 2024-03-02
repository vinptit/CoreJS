using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class Category
    {
        public Category()
        {
            PartnerCategory = new HashSet<PartnerCategory>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CategoryName { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PartnerCategory> PartnerCategory { get; set; }
    }
}
