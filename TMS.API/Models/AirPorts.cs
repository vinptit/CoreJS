using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class AirPorts
    {
        public AirPorts()
        {
            AirPortPerKGSChargeable = new HashSet<AirPortPerKGSChargeable>();
        }

        public int Id { get; set; }
        public string AirPortID { get; set; }
        public string AirPortCode { get; set; }
        public string AirPortName { get; set; }
        public int? TypeServiceId { get; set; }
        public int? CountryId { get; set; }
        public int? ZoneId { get; set; }
        public int? RegionId { get; set; }
        public int? GateId { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public double? KGSPERCBM { get; set; }
        public string CBPCode { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Gate Gate { get; set; }
        public virtual ICollection<AirPortPerKGSChargeable> AirPortPerKGSChargeable { get; set; }
    }
}
