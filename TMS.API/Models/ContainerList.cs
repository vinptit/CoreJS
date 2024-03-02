using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class ContainerList
    {
        public int Id { get; set; }
        public string ContainerNo { get; set; }
        public string SealNo { get; set; }
        public int? ContainerTypeId { get; set; }
        public int? ContainerEnum { get; set; }
        public int? SizeEnum { get; set; }
        public int? HouseBillId { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual HouseBill HouseBill { get; set; }
    }
}
