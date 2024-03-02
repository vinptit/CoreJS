using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class SeaBookingContainer
    {
        public string BookingID { get; set; }
        public int? Qty { get; set; }
        public string Container { get; set; }
        public string Notes { get; set; }
    }
}
