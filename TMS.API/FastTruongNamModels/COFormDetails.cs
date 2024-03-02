using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class COFormDetails
    {
        public string CORefNo { get; set; }
        public decimal IDKey { get; set; }
        public string HSCode { get; set; }
        public string GoodsDesc { get; set; }
        public string ACFTA { get; set; }
        public int? CTNS { get; set; }
        public string CNTSUnit { get; set; }
        public double? GW { get; set; }
        public double? FOBAmount { get; set; }
        public string CurrFOB { get; set; }
        public string ShippingMark { get; set; }
        public string Description { get; set; }
        public string ApplyRule { get; set; }
        public string Notes { get; set; }
        public int? lIndex { get; set; }

        public virtual COForm CORefNoNavigation { get; set; }
    }
}
