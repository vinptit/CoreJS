using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ACDescripeReportDetailConfig
    {
        public decimal IDKey { get; set; }
        public string Item { get; set; }
        public string RPSource { get; set; }
        public string FormName { get; set; }
        public string ItemID { get; set; }
        public string AccountRef { get; set; }
        public string ExAccountRef { get; set; }
        public string Formular { get; set; }
        public bool? UseOpenAMT { get; set; }
        public bool? Debt { get; set; }
        public bool? CreditBL { get; set; }
        public bool? DebitBL { get; set; }
        public bool? MinusAC { get; set; }
        public int? ExcelRow { get; set; }
        public int? ExcelCol { get; set; }
        public int? LIndex { get; set; }
        public string ACReportID { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string UserInput { get; set; }
        public bool? Activate { get; set; }

        public virtual ACDescripeReportConfig ACReport { get; set; }
    }
}
