using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class PhieuThuChiDetails
    {
        public string SoCT { get; set; }
        public string KeyField { get; set; }
        public string Source_data { get; set; }
        public string KeyFieldSource { get; set; }
        public string JobID { get; set; }
        public string HBLNo { get; set; }
        public string InvoiceNo { get; set; }
        public string Description { get; set; }
        public string RefNo { get; set; }
        public string SoTKDU { get; set; }
        public double? Quantity { get; set; }
        public string Unit { get; set; }
        public double? UnitPrice { get; set; }
        public double? Ngoaite { get; set; }
        public string Curr { get; set; }
        public double? Tygia { get; set; }
        public double? TienVND { get; set; }
        public double? VAT { get; set; }
        public string SoTKVAT { get; set; }
        public double? NgoaiteVAT { get; set; }
        public double? TienVNDVAT { get; set; }
        public string SoTKGainLoss { get; set; }
        public double? GainLossAmount { get; set; }
        public string SoTKOBH { get; set; }
        public string MaDoituongOBH { get; set; }
        public string SoHD { get; set; }
        public DateTime? NgayHD { get; set; }
        public string SoSeriVAT { get; set; }
        public string InvoiceID { get; set; }
        public string MathangVAT { get; set; }
        public string DoituongVAT { get; set; }
        public string MSTVAT { get; set; }
        public string DepCode { get; set; }
        public int? SIndex { get; set; }
        public decimal? IndexKeySource { get; set; }
        public bool? Reduce { get; set; }
        public double? TygiaFix { get; set; }

        public virtual PhieuThuChi SoCTNavigation { get; set; }
    }
}
