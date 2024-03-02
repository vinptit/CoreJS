using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class InquiryFollowUpStatus
    {
        public int IDKey { get; set; }
        public string DisplayField { get; set; }
        public string FilterCond { get; set; }
        public int? iIndex { get; set; }
        public string FormID { get; set; }
        public string JasonStatement { get; set; }
        public string SQLFieldSource { get; set; }
    }
}
