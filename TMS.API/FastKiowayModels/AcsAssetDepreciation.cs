using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class AcsAssetDepreciation
    {
        public int IDKey { get; set; }
        public string AssetID { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserInput { get; set; }
        public int? MonthKH { get; set; }
        public int? YearKH { get; set; }
        public double? FundNS { get; set; }
        public double? FundSelf { get; set; }
        public double? FundJoint { get; set; }
        public double? FundOthers { get; set; }
        public string Notes { get; set; }
        public string VoucherID { get; set; }

        public virtual AcsFixAssetManagement Asset { get; set; }
    }
}
