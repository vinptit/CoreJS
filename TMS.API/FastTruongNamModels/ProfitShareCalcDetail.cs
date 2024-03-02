using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ProfitShareCalcDetail
    {
        public string FieldKeyID { get; set; }
        public string RefNo { get; set; }
        public string GroupName { get; set; }
        public string HBLNo { get; set; }
        public string Description { get; set; }
        public double? Quantity { get; set; }
        public string Unit { get; set; }
        public double? UnitPrice { get; set; }
        public string Curr { get; set; }
        public double? TotalValue { get; set; }
        public double? VAT { get; set; }
        public bool? Dbt { get; set; }
        public bool? Collect { get; set; }
        public bool? Linkto { get; set; }
        public bool? OBH { get; set; }
        public string Notes { get; set; }
        public int? lIndex { get; set; }

        public virtual ProfitShareCalc RefNoNavigation { get; set; }
    }
}
