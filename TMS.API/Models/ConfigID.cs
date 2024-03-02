using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class ConfigID
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool? Export { get; set; }
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string P3 { get; set; }
        public string P4 { get; set; }
        public string P5 { get; set; }
        public int? Increment { get; set; }
        public int? ConfigTypeId { get; set; }
        public int? MaxValue { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DateToReset { get; set; }
        public int? BillType { get; set; }
        public bool? ResetOnMonth { get; set; }
        public bool? ResetOnQuarter { get; set; }
        public bool? ResetOnYear { get; set; }
    }
}
