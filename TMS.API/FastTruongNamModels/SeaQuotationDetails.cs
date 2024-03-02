﻿using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class SeaQuotationDetails
    {
        public string QuotationID { get; set; }
        /// <summary>
        /// Weightable
        /// </summary>
        public string Nameofservice { get; set; }
        public double? Fee { get; set; }
        public double? LCLB { get; set; }
        public string Currency { get; set; }
        public string CurrB { get; set; }
        public string Unit { get; set; }
        public string UnitCtnr { get; set; }
        public double? Ctnr20 { get; set; }
        public double? Ctnr20B { get; set; }
        public double? Ctnr40 { get; set; }
        public double? Ctnr40B { get; set; }
        public double? Ctnr40HQ { get; set; }
        public double? Ctnr40HQB { get; set; }
        public double? Ctnr45 { get; set; }
        public double? Ctnr45B { get; set; }
        public double? Quantity { get; set; }
        public double? VAT { get; set; }
        public double? VATB { get; set; }
        public string Notes { get; set; }
        public bool? KB { get; set; }
        public string PartnerID { get; set; }
        public double? MinS { get; set; }
        public double? MinB { get; set; }
        public int? iIndex { get; set; }
        public bool? OBH { get; set; }

        public virtual SeaQuotations Quotation { get; set; }
    }
}