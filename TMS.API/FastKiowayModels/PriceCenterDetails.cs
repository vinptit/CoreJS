using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class PriceCenterDetails
    {
        public string PriceID { get; set; }
        public string Description { get; set; }
        public double? QtyKG { get; set; }
        public double? QtyEndKG { get; set; }
        public double? StepQty { get; set; }
        public double? ZoneLA { get; set; }
        public double? ZoneLB { get; set; }
        public double? ZoneLC { get; set; }
        public double? ZoneLD { get; set; }
        public double? ZoneLE { get; set; }
        public double? ZoneLF { get; set; }
        public double? ZoneLG { get; set; }
        public double? ZoneLH { get; set; }
        public double? ZoneLI { get; set; }
        public double? ZoneLJ { get; set; }
        public double? ZoneLK { get; set; }
        public string TypeMode { get; set; }
        public string PortofDestination { get; set; }
        public string LCL { get; set; }
        public string C20DC { get; set; }
        public string C20RF { get; set; }
        public string C40DC { get; set; }
        public string C40RF { get; set; }
        public string C40HC { get; set; }
        public string TT { get; set; }
        public string FREQ { get; set; }
        public string BAF { get; set; }
        public string CAF { get; set; }
        public string ISPS { get; set; }
        public double? ZoneLL { get; set; }
        public double? ZoneLM { get; set; }
        public double? ZoneLN { get; set; }
        public double? ZoneLO { get; set; }
        public double? ZoneLP { get; set; }
        public double? ZoneLQ { get; set; }
        public double? ZoneLR { get; set; }
        public double? ZoneLS { get; set; }
        public double? ZoneLT { get; set; }
        public double? ZoneLU { get; set; }
        public double? ZoneLV { get; set; }
        public double? ZoneLW { get; set; }
        public double? ZoneLX { get; set; }
        public double? ZoneLY { get; set; }
        public double? ZoneLZ { get; set; }

        public virtual PriceCenters Price { get; set; }
    }
}
