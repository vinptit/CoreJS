using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class HAWBSEPDetails
    {
        public decimal IDKey { get; set; }
        public string HAWBNo { get; set; }
        public string MarksNo { get; set; }
        public int? CTNS { get; set; }
        public string UnitCNTS { get; set; }
        public string GoodsDescription { get; set; }
        public double? GW { get; set; }
        public string UnitW { get; set; }
        public double? CBM { get; set; }
        public int? iIndex { get; set; }
        public double? CW { get; set; }

        public virtual HAWB HAWBNoNavigation { get; set; }
    }
}
