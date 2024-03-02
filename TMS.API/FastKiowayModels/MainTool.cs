using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class MainTool
    {
        public string sKey { get; set; }
        public string Tiptext { get; set; }
        public int? ImageIcon { get; set; }
        public string ButtonText { get; set; }
        public string ButtonTextSND { get; set; }
        public string ButonStyle { get; set; }
        public short? iIndex { get; set; }
        public bool TlbEnable { get; set; }
        public bool TblVisible { get; set; }
        public string InvisibleUsernameList { get; set; }
    }
}
