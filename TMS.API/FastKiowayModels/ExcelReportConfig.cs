using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ExcelReportConfig
    {
        public ExcelReportConfig()
        {
            ExcelReportConfigDetails = new HashSet<ExcelReportConfigDetails>();
        }

        public string ReportID { get; set; }
        public string FileTemplate { get; set; }
        public string FormID { get; set; }
        public string SQLSource { get; set; }
        public string FieldCondName { get; set; }
        public bool? EnableProgressBar { get; set; }

        public virtual ICollection<ExcelReportConfigDetails> ExcelReportConfigDetails { get; set; }
    }
}
