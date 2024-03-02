using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ExcelReportConfigDetails
    {
        public decimal IDKey { get; set; }
        public string ReportID { get; set; }
        public int? ColNumber { get; set; }
        public int? RowNumber { get; set; }
        public string ExportFieldName { get; set; }
        public string SubSQLSource { get; set; }
        public string SubFieldCondName { get; set; }
        public string FieldNameValue { get; set; }
        public bool? InsertRow { get; set; }
        public int? LIndex { get; set; }

        public virtual ExcelReportConfig Report { get; set; }
    }
}
