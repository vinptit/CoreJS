using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ContainerLoadedHBL
    {
        public string HBLNo { get; set; }
        public int? Qty { get; set; }
        public string Container { get; set; }
        public string ContSealNo { get; set; }

        public virtual HAWB HBLNoNavigation { get; set; }
    }
}
