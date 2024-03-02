using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class PhieuThuChiTaxReport
    {
        public string KeyfieldID { get; set; }
        public string RefNo { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvDate { get; set; }
        public string InvSection { get; set; }
        public string Kindof { get; set; }
        public string SeriesID { get; set; }
        public string PartnerName { get; set; }
        public string PartnerTaxCode { get; set; }
        public string Description { get; set; }
        public double? Amount { get; set; }
        public double? VAT { get; set; }
        public bool? VATNull { get; set; }
        public double? VATAmount { get; set; }
        public DateTime? DateofReport { get; set; }
        public string Notes { get; set; }
        public string HBLNo { get; set; }
        public string MBLNo { get; set; }
        public string DtSource { get; set; }
        public decimal? MultRefNo { get; set; }
        public bool? OBH { get; set; }
        public bool? TaxExported { get; set; }
        public DateTime? TaxDateExport { get; set; }
        public string ExportLog { get; set; }
        public double? VATRate { get; set; }
        public string INVLink { get; set; }

        public virtual PhieuThuChi RefNoNavigation { get; set; }
    }
}
