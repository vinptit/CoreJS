using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class CustomsDepartment
    {
        public CustomsDepartment()
        {
            Gate = new HashSet<Gate>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? TypeId { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<Gate> Gate { get; set; }
    }
}
