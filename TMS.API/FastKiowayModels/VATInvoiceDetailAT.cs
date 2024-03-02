using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class VATInvoiceDetailAT
    {
        public string ID { get; set; }
        public string InvoiceNo { get; set; }
        public string Description { get; set; }
        public string HBLNo { get; set; }
        public double? Quantity { get; set; }
        public string Unit { get; set; }
        public double? UnitPrice { get; set; }
        public string Curr { get; set; }
        public double? ExtVND { get; set; }
        public double? TotalBFTax { get; set; }
        public double? VATRate { get; set; }
        public double? VATTotal { get; set; }
        public double? Amount { get; set; }
        public string DeptCode { get; set; }
        public int No { get; set; }

        public virtual VATInvoice I { get; set; }
    }
}
