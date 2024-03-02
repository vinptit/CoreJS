using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class PhieuThuChiMULTI
    {
        public PhieuThuChiMULTI()
        {
            PhieuThuChiMULTIDT = new HashSet<PhieuThuChiMULTIDT>();
        }

        public decimal IDKEY { get; set; }
        public string VoucherNo { get; set; }
        public DateTime? DATECREATE { get; set; }
        public DateTime? DATEMODIFY { get; set; }
        public DateTime? VCDATE { get; set; }
        public string USEREDIT { get; set; }
        public string ACDescription { get; set; }
        public string NOTES { get; set; }
        public bool? VCLocked { get; set; }
        public string ReportName { get; set; }
        public bool? Paid { get; set; }

        public virtual ICollection<PhieuThuChiMULTIDT> PhieuThuChiMULTIDT { get; set; }
    }
}
