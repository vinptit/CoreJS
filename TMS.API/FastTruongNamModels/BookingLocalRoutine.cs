using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class BookingLocalRoutine
    {
        public decimal Maso { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string RequestNo { get; set; }
        public string NoiLayRong { get; set; }
        public string NoiLayHang { get; set; }
        public string NoiHaHang { get; set; }
        public string NoiHaRong { get; set; }
        public string SoLenh { get; set; }
        public int? Qty { get; set; }
        public string UnitQty { get; set; }
        public string ContainerNo { get; set; }
        public string SealNo { get; set; }
        public DateTime? NgayCapLenh { get; set; }
        public DateTime? NgayDongHang { get; set; }
        public DateTime? NgayGiaoHang { get; set; }
        public string NguoiCap { get; set; }
        public string DiaChiDongHang { get; set; }
        public string DiaChiGiaHang { get; set; }
        public string NguoiLienHeDongHang { get; set; }
        public string NguoiLienHeGiaoHang { get; set; }
        public bool? BaoHiem { get; set; }
        public string TyLePhi { get; set; }
        public string DieuKien { get; set; }
        public string GhiChu { get; set; }
        public int? TIndex { get; set; }

        public virtual BookingLocal RequestNoNavigation { get; set; }
    }
}
