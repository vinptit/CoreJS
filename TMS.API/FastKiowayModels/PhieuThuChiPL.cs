using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class PhieuThuChiPL
    {
        public PhieuThuChiPL()
        {
            PhieuThuChiPLDetail = new HashSet<PhieuThuChiPLDetail>();
        }

        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public bool Income { get; set; }
        public string AccountReferrence { get; set; }
        public string CompID { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<PhieuThuChiPLDetail> PhieuThuChiPLDetail { get; set; }
    }
}
