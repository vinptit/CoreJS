using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class CustomerCareLog
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int? ContactTypeId { get; set; }
        public int? CustomerContactId { get; set; }
        public int? NumberOfContainer { get; set; }
        public int? ContainerTypeId { get; set; }
        public string ContactNumber { get; set; }
        public DateTime? NextMeetingDate { get; set; }
        public decimal Volume { get; set; }
        public decimal Weight { get; set; }
        public decimal Distance { get; set; }
        public int? StatusId { get; set; }
        public int? QuotationId { get; set; }
        public decimal EstimatedCost { get; set; }
        public string Message { get; set; }
        public bool IsOfficalContact { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int? CommodityTypeId { get; set; }
        public int? OrderPeriodId { get; set; }
        public DateTime? ContactDate { get; set; }
    }
}
