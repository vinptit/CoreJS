using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class MainMenu
    {
        public string MenuID { get; set; }
        public string MenuDisplay { get; set; }
        public string MenuDisplaySND { get; set; }
        public short? iIndex { get; set; }
        public string Acerator { get; set; }
        public bool mnVisible { get; set; }
        public bool mnEnable { get; set; }
        public string InvisibleUsernameList { get; set; }
    }
}
