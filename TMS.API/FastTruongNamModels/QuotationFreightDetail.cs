using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class QuotationFreightDetail
    {
        public string QuoID { get; set; }
        public string POL { get; set; }
        public string POD { get; set; }
        public double? MinQty { get; set; }
        public double? Level1 { get; set; }
        public double? Level2 { get; set; }
        public double? Level3 { get; set; }
        public double? Level4 { get; set; }
        public double? Level5 { get; set; }
        public double? Level6 { get; set; }
        public double? Level7 { get; set; }
        public string Level1TACT { get; set; }
        public string Level2TACT { get; set; }
        public string Level3TACT { get; set; }
        public string Level4TACT { get; set; }
        public string Level5TACT { get; set; }
        public string Level6TACT { get; set; }
        public string Level7TACT { get; set; }
        /// <summary>
        /// Phu phi xang dau
        /// </summary>
        public double? FSC { get; set; }
        /// <summary>
        /// Phu phi chuien tranh
        /// </summary>
        public double? SSC { get; set; }
        public bool? GW { get; set; }
        public string Carrier { get; set; }
        public string CarrierID { get; set; }
        public string VendorID { get; set; }
        public string TT { get; set; }
        public string Freq { get; set; }
        public string Cutoff { get; set; }
        public string Notes { get; set; }
        public int? lIndex { get; set; }
        public string PricingID { get; set; }

        public virtual QUOTATIONS Quo { get; set; }
    }
}
