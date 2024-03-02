using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class VendorTransaction
    {
        public int Id { get; set; }
        public int? VendorId { get; set; }
        public DateTime? DateInput { get; set; }
        public DateTime? TransDate { get; set; }
        public string Description { get; set; }
        public string Guests { get; set; }
        public string Category { get; set; }
        public string Field_Interested { get; set; }
        public string Competitor { get; set; }
        public string Status { get; set; }
        public DateTime? NextTime { get; set; }
        public string AlertBefore { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
