using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class HAWBDETAILS
    {
        public string HWBNO { get; set; }
        public string NoPieces { get; set; }
        public string NoPiecesSe { get; set; }
        public double? GrossWeight { get; set; }
        public double? CBM { get; set; }
        public string Wlbs { get; set; }
        public string RateClass { get; set; }
        public string ItemNo { get; set; }
        public double? WChargeable { get; set; }
        public double? RateCharge { get; set; }
        public double? Total { get; set; }
        public string Description { get; set; }
        public string SIDescription { get; set; }
        public string MaskNos { get; set; }
        public string Unit { get; set; }
        public string HSCode { get; set; }
        public double? NetWeight { get; set; }

        public virtual HAWB HWBNONavigation { get; set; }
    }
}
