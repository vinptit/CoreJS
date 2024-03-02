using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class VehicleAlerterHistory
    {
        public decimal ID { get; set; }
        public string maxFkey { get; set; }
        public string VehicleNo { get; set; }
        public string AlerterTypeId { get; set; }
        public DateTime? DeadLine { get; set; }
        public int? AlertedDay { get; set; }
        public string ContactID { get; set; }
    }
}
