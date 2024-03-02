using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class AttachedFile
    {
        public int Id { get; set; }
        public int? TransId { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int? HBLId { get; set; }

        public virtual Transaction Trans { get; set; }
    }
}
