using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class VehicleAlerterConfig
    {
        public decimal ID { get; set; }
        public string AlerterTypeId { get; set; }
        public string AlerterTypeName { get; set; }
        public int? AlertedDay { get; set; }
    }
}
