using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class AirfreightPrcingDetail
    {
        public string PricingCode { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public string Curr { get; set; }
        /// <summary>
        /// 01/10/2010
        /// </summary>
        public double? Min { get; set; }
        /// <summary>
        /// -45
        /// </summary>
        public double? Normal { get; set; }
        /// <summary>
        /// 45
        /// </summary>
        public double? Level3 { get; set; }
        /// <summary>
        /// 100
        /// </summary>
        public double? Level4 { get; set; }
        /// <summary>
        /// 300
        /// </summary>
        public double? Level5 { get; set; }
        /// <summary>
        /// 500
        /// </summary>
        public double? Level6 { get; set; }
        /// <summary>
        /// 1000
        /// </summary>
        public double? Level7 { get; set; }
        /// <summary>
        /// Phu phi xang dau
        /// </summary>
        public double? ExLavel { get; set; }
        public double? VAT { get; set; }
        public bool? GW { get; set; }
        public string Notes { get; set; }
        public bool? CC { get; set; }
        public bool? TT { get; set; }
        public short? lIndex { get; set; }
        public string AccsRef { get; set; }
        public string VendorID { get; set; }
        public bool? OBH { get; set; }

        public virtual AirfreightPrcing PricingCodeNavigation { get; set; }
    }
}
