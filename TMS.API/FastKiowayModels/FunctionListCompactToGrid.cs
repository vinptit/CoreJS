using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class FunctionListCompactToGrid
    {
        public decimal IDKey { get; set; }
        public string FieldsListID { get; set; }
        public string ColIndex { get; set; }
        public string DisplayName { get; set; }
        public double? ColWidth { get; set; }
        public int? ColDataType { get; set; }
        public int? LIndex { get; set; }
        public string CompID { get; set; }
        public string ColDataFormat { get; set; }
        public bool? PrintTotal { get; set; }
        public bool? NoIndex { get; set; }
        public int? GroupCol1 { get; set; }
        public int? GroupCol2 { get; set; }
        public int? GroupCol3 { get; set; }
        public bool? GroupCol1Total { get; set; }
        public bool? GroupCol2Total { get; set; }
        public bool? GroupCol3Total { get; set; }
        public int? GroupOn1 { get; set; }
        public int? GroupOn2 { get; set; }
        public int? GroupOn3 { get; set; }
        public bool? RunningTotal { get; set; }
    }
}
