using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class COFormMaterialList
    {
        public decimal IDKey { get; set; }
        public decimal? IDKeyLinked { get; set; }
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
