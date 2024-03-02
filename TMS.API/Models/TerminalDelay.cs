using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class TerminalDelay
    {
        public int Id { get; set; }
        public int? TerminalId { get; set; }
        public int? CommodityTypeId { get; set; }
        public decimal? SpecVolume { get; set; }
        public int? Loading { get; set; }
        public int? Unloading { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Terminal Terminal { get; set; }
    }
}
