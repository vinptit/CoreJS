using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class AirFreightTracking
    {
        public string HWBNO { get; set; }
        public string ConnectingFlight { get; set; }
        public string Location { get; set; }
        public DateTime? ETD { get; set; }
        public string ETDTimes { get; set; }
        public DateTime? ETA { get; set; }
        public string ETATimes { get; set; }
        public double? CTNS { get; set; }
        public double? Weight { get; set; }
        public bool Done { get; set; }
        public string Notes { get; set; }

        public virtual HAWB HWBNONavigation { get; set; }
    }
}
