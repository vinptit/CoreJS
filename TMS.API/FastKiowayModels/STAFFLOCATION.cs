using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class STAFFLOCATION
    {
        public decimal IDKey { get; set; }
        public string ContactId { get; set; }
        public DateTime? UPLOADEDTIME { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string DeviceId { get; set; }
    }
}
