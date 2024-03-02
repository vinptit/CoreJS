using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class Transaction
    {
        public Transaction()
        {
            AttachedFile = new HashSet<AttachedFile>();
            ContainerHouseBill = new HashSet<ContainerHouseBill>();
            HouseBill = new HashSet<HouseBill>();
            OtherSurcharge = new HashSet<OtherSurcharge>();
            Route = new HashSet<Route>();
            TaskList = new HashSet<TaskList>();
        }

        public int Id { get; set; }
        public string JobNo { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public int? LineId { get; set; }
        public string BillNo { get; set; }
        public int? BillTypeId { get; set; }
        public int? AgentId { get; set; }
        public int? ServiceId { get; set; }
        public int? ShipmentTypeId { get; set; }
        public int? PicId { get; set; }
        public int? PaymentTermId { get; set; }
        public string PoNo { get; set; }
        public int? DeliveryId { get; set; }
        public bool IsFullJob { get; set; }
        public bool IsInvRead { get; set; }
        public bool IsFinish { get; set; }
        public int? CommodityId { get; set; }
        public string Notes { get; set; }
        public int? TypeId { get; set; }
        public int? FreightId { get; set; }
        public string BookingNo { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int? ScnId { get; set; }
        public int? ProcessId { get; set; }
        public decimal? Containers { get; set; }
        public decimal? TotalGW { get; set; }
        public decimal? TotalCBM { get; set; }
        public int? PolId { get; set; }
        public DateTime? EtdDate { get; set; }
        public int? PodId { get; set; }
        public DateTime? EtaDate { get; set; }
        public int? VesselId { get; set; }
        public int? SeqKey { get; set; }
        public string FreightStateIds { get; set; }

        public virtual ICollection<AttachedFile> AttachedFile { get; set; }
        public virtual ICollection<ContainerHouseBill> ContainerHouseBill { get; set; }
        public virtual ICollection<HouseBill> HouseBill { get; set; }
        public virtual ICollection<OtherSurcharge> OtherSurcharge { get; set; }
        public virtual ICollection<Route> Route { get; set; }
        public virtual ICollection<TaskList> TaskList { get; set; }
    }
}
