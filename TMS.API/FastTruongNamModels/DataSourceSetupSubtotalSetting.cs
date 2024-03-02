using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class DataSourceSetupSubtotalSetting
    {
        public decimal IDKey { get; set; }
        public string FuncID { get; set; }
        /// <summary>
        /// None=0, Clear=1, Sum=2, Percent=3, Count=4,Average-5, Max=6, Min=7, Std=8, Var=9
        /// </summary>
        public int? FunctionRef { get; set; }
        public int? GroupOn { get; set; }
        public int? TotalOn { get; set; }
        public string FormatStr { get; set; }
        public string BackColor { get; set; }
        public string ForeColor { get; set; }
        public bool? FontBold { get; set; }
        public string CaptionStr { get; set; }
        public string MatchFrom { get; set; }
        public bool? TotalOnly { get; set; }
        public int? IIndex { get; set; }
    }
}
