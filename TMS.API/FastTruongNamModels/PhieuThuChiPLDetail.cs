using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class PhieuThuChiPLDetail
    {
        public string MaLoaiPhi { get; set; }
        public string TenLoaiPhi { get; set; }
        public string GhiChu { get; set; }
        public string MaLoai { get; set; }

        public virtual PhieuThuChiPL MaLoaiNavigation { get; set; }
    }
}
