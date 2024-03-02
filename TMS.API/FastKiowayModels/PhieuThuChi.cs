using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class PhieuThuChi
    {
        public PhieuThuChi()
        {
            PhieuThuChiDetail = new HashSet<PhieuThuChiDetail>();
            PhieuThuChiDetails = new HashSet<PhieuThuChiDetails>();
            PhieuThuChiTaxReport = new HashSet<PhieuThuChiTaxReport>();
        }

        public string MaLoaiPhieu { get; set; }
        public string Maso { get; set; }
        public DateTime? DateModify { get; set; }
        public DateTime? Ngay { get; set; }
        public bool PhieuThu { get; set; }
        public bool PhieuKhac { get; set; }
        public string Hinhthuc { get; set; }
        public double? Tygia { get; set; }
        public string Nguoinoptien { get; set; }
        public string Donvi { get; set; }
        public string Diachi { get; set; }
        public string Lydo { get; set; }
        public double? Sotien { get; set; }
        public string LoaiTien { get; set; }
        public double? SotienNT { get; set; }
        public string LoaitienNT { get; set; }
        public string BangChu { get; set; }
        public string Diengiai { get; set; }
        public string Ghichu { get; set; }
        public string Nguoilap { get; set; }
        public string Cashier { get; set; }
        public string ReceiverBank { get; set; }
        public string ReceiverBankAddress { get; set; }
        public string ReceiverSwiftCode { get; set; }
        public string ReceiverAccountNo { get; set; }
        public string MidBankName { get; set; }
        public string MidBankSwiftCode { get; set; }
        public bool? ChargesInside { get; set; }
        public bool? ChargesOutside { get; set; }
        public string Log { get; set; }
        public bool CancelVc { get; set; }
        public bool Paid { get; set; }
        public string PartnerID { get; set; }
        public string ReportName { get; set; }
        public string SoTaikhoan { get; set; }
        public bool? VCLock { get; set; }
        public DateTime? VCLockDate { get; set; }
        public string VCOpenTrans { get; set; }
        public bool? ReportTax { get; set; }
        public string CompID { get; set; }
        public string RealPartnerID { get; set; }
        public int? RefTransferNo { get; set; }
        public bool? Roundable { get; set; }
        public string MasoRefNo { get; set; }
        public bool? CashChecked { get; set; }
        public DateTime? DateChecked { get; set; }
        public string CashComment { get; set; }
        public string CashedUser { get; set; }
        public decimal? PayrollRefNo { get; set; }
        public decimal? MultiACRefNo { get; set; }
        public string GroupRefID { get; set; }
        public string Description2 { get; set; }
        public string DebitedAC { get; set; }
        public string GLCode { get; set; }
        public string OriginRefNo { get; set; }
        public int? SourceLinkedID { get; set; }
        public string ConnectStringOrigin { get; set; }
        public bool? ChangeEditLinked { get; set; }
        public DateTime? ChangeDateTime { get; set; }
        public bool? LinkedDeleted { get; set; }
        public string RMUpdatedUser { get; set; }
        public string CashFlowCode { get; set; }
        public bool? MarkImported { get; set; }
        public string BFAllocationRefNo { get; set; }
        public DateTime? ImportedDate { get; set; }
        public DateTime? PrintedDate { get; set; }
        public bool? AdvanceVC { get; set; }
        public string SOANo { get; set; }
        public string OtherRefNo { get; set; }
        public string TypeID { get; set; }
        public string BankRefNo { get; set; }
        public string WareHID { get; set; }
        public double? SotienNTCR { get; set; }
        public bool? GainLossCalc { get; set; }

        public virtual Partners Partner { get; set; }
        public virtual ICollection<PhieuThuChiDetail> PhieuThuChiDetail { get; set; }
        public virtual ICollection<PhieuThuChiDetails> PhieuThuChiDetails { get; set; }
        public virtual ICollection<PhieuThuChiTaxReport> PhieuThuChiTaxReport { get; set; }
    }
}
