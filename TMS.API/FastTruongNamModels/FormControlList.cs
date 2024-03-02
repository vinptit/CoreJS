using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class FormControlList
    {
        public string FormID { get; set; }
        public string ControlID { get; set; }
        public short ControlIndex { get; set; }
        public string ControlCaption { get; set; }
        public string ControlCaptionSND { get; set; }
        public bool? InredColor { get; set; }
        public string ControlType { get; set; }
        public string ExpressKeywords { get; set; }
        public string DefaultValue { get; set; }
        public bool? SelectOnly { get; set; }
        public string ToolTipText { get; set; }

        public virtual FormList Form { get; set; }
    }
}
