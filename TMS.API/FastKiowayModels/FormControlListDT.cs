using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class FormControlListDT
    {
        public decimal IDKey { get; set; }
        public string FormID { get; set; }
        public string ControlID { get; set; }
        public short ControlIndex { get; set; }
        public string ControlCaption { get; set; }
        public string ControlCaptionSND { get; set; }
        public bool? InredColor { get; set; }
        public string ControlType { get; set; }
        public string ExpressKeywords { get; set; }
        public string DefaultValue { get; set; }
        public string Username { get; set; }
    }
}
