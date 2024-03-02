using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class COMaterialNorm
    {
        public decimal IDKey { get; set; }
        public string ProductID { get; set; }
        public string RefNo { get; set; }
        public int? TIndex { get; set; }
        public string HSCode { get; set; }
        public string MaterialDesc { get; set; }
        public string MTUnit { get; set; }
        public double? WastageNorm { get; set; }
        public double? Quantity { get; set; }
        public double? CIFPrice { get; set; }
        public string CountryOrigin { get; set; }
        public string CDSNo { get; set; }
        public DateTime? CDSDate { get; set; }
        public string Notes { get; set; }
    }
}
