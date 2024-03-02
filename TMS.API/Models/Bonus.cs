using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class Bonus
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? DeptId { get; set; }
        public decimal? DptSalesTarget { get; set; }
        public decimal? ExtNo { get; set; }
        public decimal? DptBonus { get; set; }
        public decimal? Vnd { get; set; }
        public decimal? Usd { get; set; }
        public string Note { get; set; }
    }
}
