using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class VehicleFuelConsumption
    {
        public string VHUnitNo { get; set; }
        public double? GW { get; set; }
        public double? GW2 { get; set; }
        public double? FuelCons { get; set; }
        public string Notes { get; set; }
        public int? iIndex { get; set; }

        public virtual VehicleList VHUnitNoNavigation { get; set; }
    }
}
