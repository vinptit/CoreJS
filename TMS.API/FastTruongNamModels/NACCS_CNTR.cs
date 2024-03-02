using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class NACCS_CNTR
    {
        public int IDKey { get; set; }
        public int? IDLinked { get; set; }
        public string HBLNo { get; set; }
        public string CNTR_NO { get; set; }
        public string CNTR_FM_IND { get; set; }
        public string CNTR_SZ_CD { get; set; }
        public string CNTR_TP_CD { get; set; }
        public string CNTR_SUPL_CD { get; set; }
        public string SEAL_NO { get; set; }
        public string Creator { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual NACCS_HBL IDLinkedNavigation { get; set; }
    }
}
