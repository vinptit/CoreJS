using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class AcsVoucherLockConfig
    {
        public AcsVoucherLockConfig()
        {
            AcsVoucherLockConfigHis = new HashSet<AcsVoucherLockConfigHis>();
        }

        public int IDKey { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string Description { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string UserName { get; set; }
        public string CompID { get; set; }
        public string PCName { get; set; }
        public bool? Locked { get; set; }
        public string ACLock { get; set; }

        public virtual ICollection<AcsVoucherLockConfigHis> AcsVoucherLockConfigHis { get; set; }
    }
}
