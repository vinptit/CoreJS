using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ECusCucHQ
    {
        public ECusCucHQ()
        {
            EcusCuakhau = new HashSet<EcusCuakhau>();
        }

        public string MaCuc { get; set; }
        public string TenCuc { get; set; }
        public string PhanLoai { get; set; }

        public virtual ICollection<EcusCuakhau> EcusCuakhau { get; set; }
    }
}
