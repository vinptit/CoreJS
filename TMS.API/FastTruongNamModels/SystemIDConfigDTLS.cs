using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class SystemIDConfigDTLS
    {
        public string ID { get; set; }
        public string Description { get; set; }
        public string Sign { get; set; }
        public string sMonth { get; set; }
        public string No { get; set; }
        public string Ys { get; set; }
        public string sYear { get; set; }
        public string Increment { get; set; }
        public int? IDResetOn { get; set; }
        public string ContactList { get; set; }
        public bool Activate { get; set; }
        public string CompID { get; set; }

        public virtual SystemIDConfig IDNavigation { get; set; }
    }
}
