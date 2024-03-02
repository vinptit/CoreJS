using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class SalesIncentiveDetails
    {
        public decimal IDKeyIndex { get; set; }
        public string IDKeyLinked { get; set; }
        public string CompID { get; set; }
        public string ContactID { get; set; }
        public double? TargetQ1 { get; set; }
        public double? AchieveQ1 { get; set; }
        public double? BonusQ1 { get; set; }
        public double? PFConvertQ1 { get; set; }
        public double? TargetQ2 { get; set; }
        public double? AchieveQ2 { get; set; }
        public double? BonusQ2 { get; set; }
        public double? PFConvertQ2 { get; set; }
        public double? TargetQ3 { get; set; }
        public double? AchieveQ3 { get; set; }
        public double? BonusQ3 { get; set; }
        public double? PFConvertQ3 { get; set; }
        public double? TargetQ4 { get; set; }
        public double? AchieveQ4 { get; set; }
        public double? BonusQ4 { get; set; }
        public double? PFConvertQ4 { get; set; }
        public double? PFConvertNY { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
