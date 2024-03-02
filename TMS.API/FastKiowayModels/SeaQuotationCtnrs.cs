using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class SeaQuotationCtnrs
    {
        public string QuoID { get; set; }
        public string POL { get; set; }
        public string POD { get; set; }
        public string Carrier { get; set; }
        public string Volume { get; set; }
        public string VolumeB { get; set; }
        public double? LCL { get; set; }
        public double? LCLB { get; set; }
        public double? Ctnr20 { get; set; }
        public double? Ctnr20B { get; set; }
        public double? Ctnr40 { get; set; }
        public double? Ctnr40B { get; set; }
        public double? Ctnr40HQ { get; set; }
        public double? Ctnr40HQB { get; set; }
        public double? Ctnr45 { get; set; }
        public double? Ctnr45B { get; set; }
        public double? Ctnr45DB { get; set; }
        public double? Ctnr45BDB { get; set; }
        public double? OtherPrice { get; set; }
        public double? OtherPriceB { get; set; }
        public string CUnit { get; set; }
        public double? Quantity { get; set; }
        public double? MaxWeight { get; set; }
        public double? VAT { get; set; }
        public string VIA { get; set; }
        public string Freq { get; set; }
        public string TT { get; set; }
        public string Notes { get; set; }
        public string CarrierID { get; set; }
        public string Curr { get; set; }
        public bool? Inland { get; set; }
        public string ContType { get; set; }
        public string EmptyReturn { get; set; }
        public string ReceiptAt { get; set; }
        public string DeliveryPlace { get; set; }
        public string PricingID { get; set; }
        public DateTime? Validity { get; set; }
    }
}
