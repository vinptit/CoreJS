using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class NACCS_MBL
    {
        public NACCS_MBL()
        {
            NACCS_HBL = new HashSet<NACCS_HBL>();
        }

        public int IDKey { get; set; }
        public string SenderID { get; set; }
        public string MSG_TYPE { get; set; }
        public string MSG_ID { get; set; }
        public string FUNC_CD { get; set; }
        public string RPT_ID { get; set; }
        public string RPT_PW { get; set; }
        public string VSL_CD { get; set; }
        public string VSL_NAME { get; set; }
        public string VSL_CNT_CD { get; set; }
        public string VOYAGE_NO { get; set; }
        public string SCAC { get; set; }
        public string POL_CD { get; set; }
        public string POL_NAME { get; set; }
        public string POL_SFX { get; set; }
        public DateTime? ETD_DATE { get; set; }
        public string ETD_TIME { get; set; }
        public string GMT_TIME_GAP { get; set; }
        public string APP_AREA_IND { get; set; }
        public string CUST_ID { get; set; }
        public string JobNo { get; set; }
        public string Creator { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string VSL_INFO_CHNG_IND { get; set; }

        public virtual Transactions JobNoNavigation { get; set; }
        public virtual ICollection<NACCS_HBL> NACCS_HBL { get; set; }
    }
}
