using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class SystemIDConfig
    {
        public SystemIDConfig()
        {
            SystemIDConfigDTLS = new HashSet<SystemIDConfigDTLS>();
        }

        public string ID { get; set; }
        public string Description { get; set; }
        public string Sign { get; set; }
        public string sMonth { get; set; }
        public string No { get; set; }
        public string Ys { get; set; }
        public string sYear { get; set; }
        public string Increment { get; set; }
        public int? IDResetOn { get; set; }
        public bool Activate { get; set; }

        public virtual ICollection<SystemIDConfigDTLS> SystemIDConfigDTLS { get; set; }
    }
}
