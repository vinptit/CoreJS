using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class QUOTATIONDETAILS
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
        public double? VAT { get; set; }
        public double? ZoneAdt { get; set; }
        public double? ZoneBdt { get; set; }
        public double? ZoneCdt { get; set; }
        public double? ZoneDdt { get; set; }
        public double? ZoneEdt { get; set; }
        public double? ZoneFdt { get; set; }
        public double? ZoneGdt { get; set; }
        public double? ZoneHdt { get; set; }
        public double? ZoneIdt { get; set; }
        public double? ZoneJdt { get; set; }
        public double? ZoneKdt { get; set; }
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
        public string Notes { get; set; }
        public int? iIndex { get; set; }
        public string PricingACID { get; set; }
        public string QuoACID { get; set; }
        public string PricingMID { get; set; }
        public double? ZoneLdt { get; set; }
        public double? ZoneMdt { get; set; }
        public double? ZoneNdt { get; set; }
        public double? ZoneOdt { get; set; }
        public double? ZonePdt { get; set; }
        public double? ZoneQdt { get; set; }
        public double? ZoneRdt { get; set; }
        public double? ZoneSdt { get; set; }
        public double? ZoneTdt { get; set; }
        public double? ZoneUdt { get; set; }
        public double? ZoneVdt { get; set; }
        public double? ZoneWdt { get; set; }
        public double? ZoneXdt { get; set; }
        public double? ZoneYdt { get; set; }
        public double? ZoneZdt { get; set; }
        public bool? OBH { get; set; }

        public virtual QUOTATIONS Quotation { get; set; }
    }
}
