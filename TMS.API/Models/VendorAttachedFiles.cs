using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class VendorAttachedFiles
    {
        public int Id { get; set; }
        public int? VendorId { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string FileExt { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Type { get; set; }
        public string FileContent { get; set; }
    }
}
