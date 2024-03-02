using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class HAWBRATE
    {
        public decimal IDKeyIX { get; set; }
        public string HWBNO { get; set; }
        public string FreightCharges { get; set; }
        public string RevenueTons { get; set; }
        public string RateCharges { get; set; }
        public string Curr { get; set; }
        public string PerCharges { get; set; }
        public bool? Shmt { get; set; }
        public bool? Collect { get; set; }
        public bool? FC { get; set; }
        public bool? DueCarr { get; set; }
        public int? iIndex { get; set; }

        public virtual HAWB HWBNONavigation { get; set; }
    }
}
