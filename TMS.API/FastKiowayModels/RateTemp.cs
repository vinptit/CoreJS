using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class RateTemp
    {
        public string TransID { get; set; }
        public string HawbNo { get; set; }
        public string Description { get; set; }
        public int? TotalValue { get; set; }
        public string Curr { get; set; }
        public bool Dept { get; set; }
    }
}
