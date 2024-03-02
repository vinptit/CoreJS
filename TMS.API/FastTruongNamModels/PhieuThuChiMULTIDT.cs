using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class PhieuThuChiMULTIDT
    {
        public decimal IDKey { get; set; }
        public decimal? IDLINKED { get; set; }
        public string ACNO { get; set; }
        public string ACREF { get; set; }
        public string ACNAME { get; set; }
        public double? BAMTDN { get; set; }
        public double? BAMTCN { get; set; }
        public string CURR { get; set; }
        public double? EXRATE { get; set; }
        public double? EXAMTDN { get; set; }
        public double? EXAMTCN { get; set; }
        public string PARTNERID { get; set; }
        public string VATINVNO { get; set; }
        public DateTime? VATINVDATE { get; set; }
        public string VATINVSERINO { get; set; }
        public string VATINVID { get; set; }
        public DateTime? VATINDATEREPORT { get; set; }
        public string HBLNO { get; set; }
        public string JBOBNO { get; set; }
        public decimal? KEYFIELD { get; set; }
        public string TSOURCE { get; set; }
        public string INVNO { get; set; }
        public bool? VATM { get; set; }
        public bool? OBHM { get; set; }
        public DateTime? DATECREATE { get; set; }
        public DateTime? DATEMODIFY { get; set; }
        public string USERINPUTED { get; set; }
        public string ACCode { get; set; }
        public string GroupID { get; set; }
        public int? LINIDEX { get; set; }

        public virtual PhieuThuChiMULTI IDLINKEDNavigation { get; set; }
        public virtual Partners PARTNER { get; set; }
    }
}
