using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class MenuSubList
    {
        public string MenuID { get; set; }
        public string SubMenuID { get; set; }
        public string SubMenuDisplay { get; set; }
        public string SubMenuDisplaySND { get; set; }
        public string SubMenuShortcutKey { get; set; }
        public string Acerator { get; set; }
        public short? IconNo { get; set; }
        public short? iIndex { get; set; }
        public string SubP2ID { get; set; }
        public bool StyleCheck { get; set; }
        public bool StypeCheckDefault { get; set; }
        public bool? SubmenuEnable { get; set; }
        public bool SubMenuVisible { get; set; }
        public string InvisibleUsernameList { get; set; }
    }
}
