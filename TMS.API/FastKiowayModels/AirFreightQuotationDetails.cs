using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class AirFreightQuotationDetails
    {
        public string QuoID { get; set; }
        public string Routine { get; set; }
        public string WeightLevel { get; set; }
        public string Price { get; set; }
        public string FuelSurcharge { get; set; }
        public string WarRistlSurcharge { get; set; }

        public virtual AirFreightQuotations Quo { get; set; }
    }
}
