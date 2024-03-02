using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class ImportExcelResult
    {
        public int Id { get; set; }
        public string Job { get; set; }
        public string PartnerID { get; set; }
        public string HBL { get; set; }
        public string Description { get; set; }
        public string Quantity { get; set; }
        public string Unit { get; set; }
        public string UnitPrice { get; set; }
        public string Currency { get; set; }
        public string ExtRate { get; set; }
        public string VAT { get; set; }
        public decimal? Total { get; set; }
        public string Docs { get; set; }
        public string FeeCode { get; set; }
        public string OBHPartnerID { get; set; }
        public string TYPE { get; set; }
        public int? Status { get; set; }
        public string StatusFeeText { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int? FileImportId { get; set; }
    }
}
