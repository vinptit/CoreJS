using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class AcsInstallPayment
    {
        public int KeyField { get; set; }
        public string SoCT { get; set; }
        public string Source_data { get; set; }
        public string KeyFieldSource { get; set; }
        public string JobID { get; set; }
        public string HBLNo { get; set; }
        public string InvoiceNo { get; set; }
        public string Description { get; set; }
        public string RefNo { get; set; }
        public string SoTKDU { get; set; }
        public double? Ngoaite { get; set; }
        public string Curr { get; set; }
        public double? USDEx { get; set; }
        public double? Tygia { get; set; }
        public double? TienVND { get; set; }
        public double? TotalVND { get; set; }
        public double? VAT { get; set; }
        public string SoTKVAT { get; set; }
        public double? NgoaiteVAT { get; set; }
        public double? TienVNDVAT { get; set; }
        public string SoHD { get; set; }
        public DateTime? NgayHD { get; set; }
        public string SoSeriVAT { get; set; }
        public string VATInvoiceID { get; set; }
        public string MathangVAT { get; set; }
        public string DoituongVAT { get; set; }
        public string MSTVAT { get; set; }
        public string PartnerID { get; set; }
        public string UserInput { get; set; }
        public DateTime? DateInput { get; set; }
        public string PCUser { get; set; }
        public bool? Paid { get; set; }
        public DateTime? PaidDate { get; set; }
        public bool? Dpt { get; set; }
        public int? SIndex { get; set; }
        public double? LCBFTaxAmount { get; set; }
        public double? LCTaxAmount { get; set; }
        public string FieldKey { get; set; }

        public virtual HAWB HBLNoNavigation { get; set; }
    }
}
