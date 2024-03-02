using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class ImportExcel
    {
        public int Id { get; set; }
        public string Attachment { get; set; }
        public int? EntityId { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
