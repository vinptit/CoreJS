using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class AirFreightAdjust
    {
        public int IDKey { get; set; }
        public bool? FreightCharges { get; set; }
        public double? FreightMin { get; set; }
        public bool? FreightMinPercent { get; set; }
        public double? FreightLevel1 { get; set; }
        public bool? FreightLevel1Percent { get; set; }
        public double? FreightLevel2 { get; set; }
        public bool? FreightLevel2Percent { get; set; }
        public double? FreightLevel3 { get; set; }
        public bool? FreightLevel3Percent { get; set; }
        public double? FreightLevel4 { get; set; }
        public bool? FreightLevel4Percent { get; set; }
        public double? FreightLevel5 { get; set; }
        public bool? FreightLevel5Percent { get; set; }
        public double? FreightLevel6 { get; set; }
        public bool? FreightLevel6Percent { get; set; }
        public bool? OtherCharges { get; set; }
        public double? OtherMin { get; set; }
        public bool? OtherMinPercent { get; set; }
        public double? OtherLevel1 { get; set; }
        public bool? OtherLevel1Percent { get; set; }
        public double? OtherLevel2 { get; set; }
        public bool? OtherLevel2Percent { get; set; }
        public double? OtherLevel3 { get; set; }
        public bool? OtherLevel3Percent { get; set; }
        public double? OtherLevel4 { get; set; }
        public bool? OtherLevel4Percent { get; set; }
        public double? OtherLevel5 { get; set; }
        public bool? OtherLevel5Percent { get; set; }
        public double? OtherLevel6 { get; set; }
        public bool? OtherLevel6Percent { get; set; }
        public string FormID { get; set; }
        public string Username { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? SeaQuo { get; set; }
        public bool? InlQuo { get; set; }
    }
}
