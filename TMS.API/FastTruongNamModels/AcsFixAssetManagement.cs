using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class AcsFixAssetManagement
    {
        public AcsFixAssetManagement()
        {
            AcsAssetDepreciation = new HashSet<AcsAssetDepreciation>();
        }

        public string FixAssetID { get; set; }
        public string FixAssetName { get; set; }
        public string Unit { get; set; }
        public string OriginCountry { get; set; }
        public int? YearMaking { get; set; }
        public string Description { get; set; }
        public bool? Depreciation { get; set; }
        public double? BuyingAmount { get; set; }
        public int? MonthAmount { get; set; }
        public DateTime? BuyingDate { get; set; }
        public DateTime? GTGLDate { get; set; }
        public DateTime? DepreciationStart { get; set; }
        public string TS1 { get; set; }
        public string TS2 { get; set; }
        public string TS3 { get; set; }
        public string TKTSCD { get; set; }
        public string TKKH { get; set; }
        public string TKCP { get; set; }
        public string DeptID { get; set; }
        public string ContactID { get; set; }
        public double? FundNS { get; set; }
        public double? FundSelf { get; set; }
        public double? FundJoint { get; set; }
        public double? FundOthers { get; set; }
        public string Notes { get; set; }
        public string CompID { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string UserInput { get; set; }
        public bool? AssetLockEdit { get; set; }
        public bool? Liquidation { get; set; }
        public DateTime? LiquidationDate { get; set; }
        public string ChargeCode { get; set; }
        public string LiquidationDesc { get; set; }

        public virtual ICollection<AcsAssetDepreciation> AcsAssetDepreciation { get; set; }
    }
}
