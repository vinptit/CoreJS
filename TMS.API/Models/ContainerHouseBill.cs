using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class ContainerHouseBill
    {
        public int Id { get; set; }
        public int? ContainerTypeId { get; set; }
        public string ContainerNo { get; set; }
        public string SealNo { get; set; }
        public int? UnitId { get; set; }
        public decimal? GrossWeight { get; set; }
        public decimal? Cbm { get; set; }
        public string Notes { get; set; }
        public decimal? Vgm { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int? HouseBillId { get; set; }
        public int? ContainerTypeEnum { get; set; }
        public int? TransactionId { get; set; }
        public int? ParentId { get; set; }

        public virtual HouseBill HouseBill { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
