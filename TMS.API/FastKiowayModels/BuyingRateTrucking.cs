using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class BuyingRateTrucking
    {
        public int? VehicleId { get; set; }
        public string VehicleNo { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Description { get; set; }
        public string PartnerId { get; set; }
        public double? Quantity { get; set; }
        public string Unit { get; set; }
        public double? UnitPrice { get; set; }
        public double? VAT { get; set; }
        public double? TotalValue { get; set; }
        public double? ExtVND { get; set; }
        public decimal ID { get; set; }
        public DateTime? MODIFIEDON { get; set; }
        public string CURRENCY { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string SortDesc { get; set; }
        public bool ISDISTRIBUTED { get; set; }
        public string DOCS { get; set; }
    }
}
