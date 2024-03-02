using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ArrivalFreightChargesDefault
    {
        public string Service { get; set; }
        public string Routing { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public double? TotalValue { get; set; }
        public string Curr { get; set; }
        public double? VAT { get; set; }
        public string Notes { get; set; }
        public string AccsRefNo { get; set; }
        public bool? OBH { get; set; }
        public string OBHPartnerID { get; set; }
        public bool blnStick { get; set; }
        public bool blnShow { get; set; }
        public bool blnRoot { get; set; }
        public bool blnOne { get; set; }
        public int? intIndex { get; set; }
        public string UserDefault { get; set; }
        public bool? Collect { get; set; }
        public string BLNo { get; set; }
    }
}
