using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class CustomsDeclaration
    {
        public CustomsDeclaration()
        {
            CustomsDeclarationDetail = new HashSet<CustomsDeclarationDetail>();
            TransactionDetails = new HashSet<TransactionDetails>();
        }

        public string MasoTK { get; set; }
        public string TKSo { get; set; }
        public string TKSoAfter { get; set; }
        public string TKSoAfter1 { get; set; }
        public DateTime? NgayGui { get; set; }
        public string TransID { get; set; }
        public string ShipmentID { get; set; }
        public DateTime? NgayDangKy { get; set; }
        public string SoluongTK { get; set; }
        public string CucHQ { get; set; }
        public string ChiCucHQ { get; set; }
        public string CanBoDangKy { get; set; }
        public string NguoiGui { get; set; }
        public string NguoiNhan { get; set; }
        public string NguoiUyQuyen { get; set; }
        public string SoCMTNguoiGui { get; set; }
        public string SoCMTNguoiNhan { get; set; }
        public string SoCMTNguoiUyQuyen { get; set; }
        public string CoQuanCapNguoiGui { get; set; }
        public string CoQuanCapNguoiNhan { get; set; }
        public string CoQuanCapNguoiUyQuyen { get; set; }
        public DateTime? NgayCapNguoiGui { get; set; }
        public DateTime? NgayCapNguoiNhan { get; set; }
        public DateTime? NgayCapNguoiUyQuyen { get; set; }
        public string MSTNguoiGui { get; set; }
        public string MSTNguoiNhan { get; set; }
        public string MSTNguoiUyQuyen { get; set; }
        public bool LoaiHinh1 { get; set; }
        public bool LoaiHinh2 { get; set; }
        public bool LoaiHinh3 { get; set; }
        public bool LoaiHinh4 { get; set; }
        public bool LoaiHinh5 { get; set; }
        public bool LoaiHinh6 { get; set; }
        public bool LoaiHinh7 { get; set; }
        public bool LoaiHinh8 { get; set; }
        public bool LoaiHinh9 { get; set; }
        public bool LoaiHinh10 { get; set; }
        public string GiayPhepCoQuanCap { get; set; }
        public string SoGiayPhep { get; set; }
        public DateTime? NgayGP { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public string GiayToKemTheo { get; set; }
        public string NguoiKhai { get; set; }
        public string Currency { get; set; }
        public bool NonTrading { get; set; }
        public string CangXep { get; set; }
        public string CangDo { get; set; }
        public string CangXepEng { get; set; }
        public string Crate { get; set; }
        public string TauDi { get; set; }
        public DateTime? NgayDi { get; set; }
        public DateTime? CustomsDate { get; set; }
        public string FooterNote { get; set; }
        public string DetailNotes { get; set; }
        public string DescriptionM { get; set; }
        public string NoteOfNonVAT { get; set; }
        public string SoHpdong { get; set; }
        public string NgayHD { get; set; }
        public string NgayHetHD { get; set; }
        public string NuocNhapKhau { get; set; }
        public string NuocNKID { get; set; }
        public string CuakhauXH { get; set; }
        public string MaCK { get; set; }
        public string DieuKienGH { get; set; }
        public string DieuKienDG { get; set; }
        public DateTime? NgayGH { get; set; }
        public double? TygiaTinhThue { get; set; }
        public string PhuongthucTT { get; set; }
        public string PhuongthucTDetail { get; set; }
        public string ChungTuTT { get; set; }
        public string ContSize { get; set; }
        public string ContQty { get; set; }
        public bool LHCothue { get; set; }
        public bool LHKoCothue { get; set; }
        public bool LHKD { get; set; }
        public bool LHDT { get; set; }
        public bool LHXTN { get; set; }
        public bool LHGC { get; set; }
        public bool LHSXXK { get; set; }
        public bool LHTX { get; set; }
        public bool LHOthers { get; set; }
        public string ChungTuDiKem1 { get; set; }
        public string ChungTuDiKem2 { get; set; }
        public string ChungTuDiKem3 { get; set; }
        public string ChungTuDiKem4 { get; set; }
        public string BC1 { get; set; }
        public string BC2 { get; set; }
        public string BC3 { get; set; }
        public string BC4 { get; set; }
        public string BC5 { get; set; }
        public string BC6 { get; set; }
        public string BC7 { get; set; }
        public string BC8 { get; set; }
        public string BS1 { get; set; }
        public string BS2 { get; set; }
        public string BS3 { get; set; }
        public string BS4 { get; set; }
        public string BS5 { get; set; }
        public string BS6 { get; set; }
        public string BS7 { get; set; }
        public string BS8 { get; set; }
        public string BI1 { get; set; }
        public string BI2 { get; set; }
        public string BI3 { get; set; }
        public string BI4 { get; set; }
        public string BI5 { get; set; }
        public string BI6 { get; set; }
        public string BI7 { get; set; }
        public string BI8 { get; set; }
        public string DaiLy { get; set; }
        public string SCMTDaiLy { get; set; }
        public double? GrossW { get; set; }
        public double? MCBM { get; set; }
        public string SoKien { get; set; }
        public string SoHDTM { get; set; }
        public DateTime? NgayHDTM { get; set; }
        public string SoHieuPTVT { get; set; }
        public DateTime? NgayDen { get; set; }
        public string BillofLadingNo { get; set; }
        public DateTime? BillDate { get; set; }
        public string NuocXuatkhau { get; set; }
        public string PortofDischarge { get; set; }
        public string MaCKXH { get; set; }
        public string PlaceofDelivery { get; set; }
        public string MaCangXH { get; set; }
        public string STT { get; set; }
        public string TenhangHoa { get; set; }
        public string MasoHH { get; set; }
        public string Xuatxu { get; set; }
        public string LuongHH { get; set; }
        public string DonVT { get; set; }
        public string DongiaNguyenTe { get; set; }
        public double? TriGiaNguyenTe { get; set; }
        public string TrigiaTinhthue { get; set; }
        public string ThueSuat { get; set; }
        public string TienThue { get; set; }
        public string GTGTTrigiaTT { get; set; }
        public string GTGTThuesuat { get; set; }
        public string GTGTTienthue { get; set; }
        public string ThukhacTyle { get; set; }
        public string ThukhacSotien { get; set; }
        public int? TongTGTT { get; set; }
        public int? TongTienthue { get; set; }
        public int? TongGTGTTienthue { get; set; }
        public int? TongthuKhac { get; set; }
        public double? TongCongBS { get; set; }
        public string TongBangChu { get; set; }
        public bool Import { get; set; }
        public string CTNSType { get; set; }
        public string Loaihinh { get; set; }
        public string Maloaihinh { get; set; }
        public string PLUONG { get; set; }

        public virtual ICollection<CustomsDeclarationDetail> CustomsDeclarationDetail { get; set; }
        public virtual ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
