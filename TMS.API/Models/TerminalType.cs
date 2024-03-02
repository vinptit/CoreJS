using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class TerminalType
    {
        public int Id { get; set; }
        public int? TerminalId { get; set; }
        public int? TypeId { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Terminal Terminal { get; set; }
    }
}
