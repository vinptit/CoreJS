using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class PhieuThuChiDetail
    {
        public string MasoPhieu { get; set; }
        public string Taikhoan { get; set; }
        public string MaDonVi { get; set; }
        public double? SotienNoNT { get; set; }
        public double? SotienCoNT { get; set; }
        public double? SotienNo { get; set; }
        public double? SotienCo { get; set; }
        public string DienGiai { get; set; }
        public bool? TKVAT { get; set; }
        public bool? GainLoss { get; set; }
        public bool? OBH { get; set; }
        public string OBHPartnerID { get; set; }
        public string Curr { get; set; }
        public double? Tygia { get; set; }
        public bool? ApplyNew { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string JobNo { get; set; }
        public string MBLNo { get; set; }
        public string HBLNo { get; set; }
        public string DNNo { get; set; }
        public string DepCode { get; set; }
        public int SIndex { get; set; }
        public bool? Reduce { get; set; }
        public string SeriNo { get; set; }
        public string TenDonVi { get; set; }
        public string DiaChiDonVi { get; set; }

        public virtual PhieuThuChi MasoPhieuNavigation { get; set; }
    }
}
