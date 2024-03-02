using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class Gate
    {
        public Gate()
        {
            AirPorts = new HashSet<AirPorts>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? CustomsDeptID { get; set; }
        public int? IsShow { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CustomsDepartment CustomsDept { get; set; }
        public virtual ICollection<AirPorts> AirPorts { get; set; }
    }
}
