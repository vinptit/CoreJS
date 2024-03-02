using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ShippingInstructionGoodsDetail
    {
        public decimal IDKey { get; set; }
        public string JobNo { get; set; }
        public string PackageDetailLevel { get; set; }
        public int? NumberOfPackages { get; set; }
        public string PackageTypeCode { get; set; }
        public string PackageDetailComments { get; set; }
        public string ProductId { get; set; }
        public string ItemTypeIdCode { get; set; }
        public double? GrossVolume { get; set; }
        public string GVUnit { get; set; }
        public double? GW { get; set; }
        public string GWUnit { get; set; }
        public string SMarks { get; set; }
        public string ContainerNo { get; set; }
        public int? SplitGoodsNumberOfPackages { get; set; }
        public int? ItemNum { get; set; }

        public virtual Transactions JobNoNavigation { get; set; }
    }
}
