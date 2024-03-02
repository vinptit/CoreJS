using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class AirPortPerKGSChargeable
    {
        public int Id { get; set; }
        public int? AirPortId { get; set; }
        public string PortCode { get; set; }
        public string PortName { get; set; }
        public string ChargeAC { get; set; }
        public int? ChargeNameId { get; set; }
        public decimal? PerKGS { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? VendorId { get; set; }
        public string ViaPortCode { get; set; }

        public virtual AirPorts AirPort { get; set; }
    }
}
