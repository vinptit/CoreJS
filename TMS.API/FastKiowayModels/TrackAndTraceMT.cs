using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class TrackAndTraceMT
    {
        public decimal IDKey { get; set; }
        public string POLC { get; set; }
        public string PODC { get; set; }
        public string VesselFlightNo { get; set; }
        public DateTime? ETD { get; set; }
        public DateTime? ETA { get; set; }
        public DateTime? ATD { get; set; }
        public DateTime? ATA { get; set; }
        public string TransStatus { get; set; }
        public string TransJobNo { get; set; }
        public string TransMode { get; set; }
        public string UserEdit { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? LIndex { get; set; }
    }
}
