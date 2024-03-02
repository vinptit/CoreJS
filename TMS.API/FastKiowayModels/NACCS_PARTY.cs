using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class NACCS_PARTY
    {
        public int IDKey { get; set; }
        public int? IDLinked { get; set; }
        public string HBLNo { get; set; }
        public string PARTY_TP { get; set; }
        public string PARTY_CD { get; set; }
        public string PARTY_NAME { get; set; }
        public string PARTY_ADD { get; set; }
        public string PARTY_STREET1 { get; set; }
        public string PARTY_STREET2 { get; set; }
        public string PARTY_CITY { get; set; }
        public string PARTY_CNT_NAME { get; set; }
        public string PARTY_ZIP_CD { get; set; }
        public string PARTY_CNT_CD { get; set; }
        public string PARTY_TEL_NO { get; set; }
        public string Creator { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual NACCS_HBL IDLinkedNavigation { get; set; }
    }
}
