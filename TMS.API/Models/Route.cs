using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class Route
    {
        public int Id { get; set; }
        public int? HouseBillId { get; set; }
        public int? PolId { get; set; }
        public int? PodId { get; set; }
        public DateTime? EtdDate { get; set; }
        public DateTime? EtaDate { get; set; }
        public int? VesselId { get; set; }
        public string Voy { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int? TransactionId { get; set; }

        public virtual HouseBill HouseBill { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
