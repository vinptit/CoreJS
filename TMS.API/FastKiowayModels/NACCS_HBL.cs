using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class NACCS_HBL
    {
        public NACCS_HBL()
        {
            NACCS_CNTR = new HashSet<NACCS_CNTR>();
            NACCS_PARTY = new HashSet<NACCS_PARTY>();
        }

        public int IDKey { get; set; }
        public int? IDLinked { get; set; }
        public string HBLMSG_ID { get; set; }
        public string HBLMSG_TYPE { get; set; }
        public string BL_NO { get; set; }
        public string MSG_NO { get; set; }
        public string HBL_F_IND { get; set; }
        public string MBL_NO { get; set; }
        public string POD_CD { get; set; }
        public string POD_ETA { get; set; }
        public string ORG_POL_CD { get; set; }
        public string ORG_POL_NAME { get; set; }
        public string DEL_CD { get; set; }
        public string DEL_NAME { get; set; }
        public string FINAL_DEST_CD { get; set; }
        public string FINAL_DEST_NAME { get; set; }
        public string GOODS_DESC { get; set; }
        public string GOODS_HS_CD { get; set; }
        public string MARK_NO { get; set; }
        public string PKG_QTY { get; set; }
        public string PKG_CD { get; set; }
        public double? TOT_WGT_QTY { get; set; }
        public string TOT_WGT_CD { get; set; }
        public double? NET_WGT_QTY { get; set; }
        public string NET_WGT_CD { get; set; }
        public double? MEA_QTY { get; set; }
        public string MEA_CD { get; set; }
        public string ORG_CNT_CD { get; set; }
        public string DGS_IMO_CD { get; set; }
        public string DGS_IMDG_CD { get; set; }
        public string DGS_UN_NO { get; set; }
        public string FREIGHT { get; set; }
        public string FREIGHT_CURR_CD { get; set; }
        public string VALUE { get; set; }
        public string VALUE_CURR_CD { get; set; }
        public string TEMP_DSC_IND { get; set; }
        public string TEMP_DSC_REASON { get; set; }
        public string TEMP_DSC_DUR { get; set; }
        public string IT_ETD { get; set; }
        public string IT_ETA { get; set; }
        public string IT_MODE { get; set; }
        public string IT_ARR_CD { get; set; }
        public string IT_ARR_NAME { get; set; }
        public string REMARK { get; set; }
        public string CUST_REF_NO { get; set; }
        public string NOTI_PARTY_CD { get; set; }
        public string NOTI_PARTY_CD2 { get; set; }
        public string NOTI_PARTY_CD3 { get; set; }
        public string LAW_CD { get; set; }
        public string Creator { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string PARTNER_NOTI_EMAIL { get; set; }
        public string SPC_CGO_CD { get; set; }
        public byte[] FileContent { get; set; }
        public DateTime? Uploaded { get; set; }
        public string UploadedUser { get; set; }
        public string NStatus { get; set; }
        public string FileName { get; set; }

        public virtual NACCS_MBL IDLinkedNavigation { get; set; }
        public virtual ICollection<NACCS_CNTR> NACCS_CNTR { get; set; }
        public virtual ICollection<NACCS_PARTY> NACCS_PARTY { get; set; }
    }
}
