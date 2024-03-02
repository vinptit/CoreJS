using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class CrossTabTable
    {
        public string TransID { get; set; }
        public string InvoiceNo { get; set; }
        public string HBL { get; set; }
        public string Shipper { get; set; }
        public string Dest { get; set; }
        public double? Volume { get; set; }
        public string Unit { get; set; }
        public double? DBFee1 { get; set; }
        public double? DBFee2 { get; set; }
        public double? DBFee3 { get; set; }
        public double? DBFee4 { get; set; }
        public double? DBFee5 { get; set; }
        public double? DBFee6 { get; set; }
        public double? DBFee7 { get; set; }
        public double? CDFee1 { get; set; }
        public double? CDFee2 { get; set; }
        public double? CDHFee1 { get; set; }
        public double? CDHFee2 { get; set; }
        public double? CDHFee3 { get; set; }
    }
}
