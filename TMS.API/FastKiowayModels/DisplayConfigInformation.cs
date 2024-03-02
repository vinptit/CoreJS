using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class DisplayConfigInformation
    {
        public string ConfigID { get; set; }
        public string FrameBackcolor { get; set; }
        public string DTPCalendarBackColor { get; set; }
        public string DTPCalendarForeColor { get; set; }
        public string DTPCalendarTitleBackColor { get; set; }
        public string DTPCalendarTitleForeColor { get; set; }
        public string LBLForeColor { get; set; }
        public string LBLFont { get; set; }
        public string VSFlexGridBackColorBkg { get; set; }
        public string VSFlexGridBackColorSel { get; set; }
        public string VSFlexGridForeColorSel { get; set; }
        public string VSFlexGridAppearance { get; set; }
        public string VSFlexGridSheetBorder { get; set; }
        public string MaskEdBoxFormat { get; set; }
        public string MaskEdBoxDefault { get; set; }
        public string TextBoxBackColor { get; set; }
        public string TextBoxForeColor { get; set; }
        public string TextBoxFontName { get; set; }
        public int? cmbListRowsCount { get; set; }
    }
}
