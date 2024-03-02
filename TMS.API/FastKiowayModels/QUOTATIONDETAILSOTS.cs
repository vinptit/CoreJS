using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class QUOTATIONDETAILSOTS
    {
        public string QuotationID { get; set; }
        /// <summary>
        /// Weightable
        /// </summary>
        public string Nameofservice { get; set; }
        public double? Fee { get; set; }
        public string Currency { get; set; }
        public string Unit { get; set; }
        public bool? GW { get; set; }
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
        public double? VAT { get; set; }
        public string Notes { get; set; }
        public int? iIndex { get; set; }
        public string PricingACID { get; set; }
        public string QuoACID { get; set; }
        public string PricingMID { get; set; }
        public string PayableACID { get; set; }
        public bool? OBH { get; set; }

        public virtual QUOTATIONS Quotation { get; set; }
    }
}
