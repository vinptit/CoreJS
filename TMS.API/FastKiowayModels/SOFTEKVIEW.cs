using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class SOFTEKVIEW
    {
        public int? RCIndex { get; set; }
        public string DateInvoice { get; set; }
        public string InvID { get; set; }
        public int? D_C { get; set; }
        public string BranchCode { get; set; }
        public string InvNo { get; set; }
        public DateTime? InvDate { get; set; }
        public double? Quantity { get; set; }
        public string Unit { get; set; }
        public double? UnitPrice { get; set; }
        public string Curr { get; set; }
        public double? BeforeTax { get; set; }
        public double? VAT { get; set; }
        public double? VATAmount { get; set; }
        public double? AfterTax { get; set; }
        public string JobNo { get; set; }
        public string HBLNO { get; set; }
        public string MBLNO { get; set; }
        public string CDSNo { get; set; }
        public string PartnerID { get; set; }
        public string PartnerName { get; set; }
        public string FeeCode { get; set; }
        public string Description { get; set; }
        public string DeptID { get; set; }
        public string Department { get; set; }
        public string Notes { get; set; }
        public string RPartnerID { get; set; }
        public string RPartnerName { get; set; }
        public string VATNo { get; set; }
        public string PONo { get; set; }
    }
}
