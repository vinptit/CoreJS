using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class PackingListDetails
    {
        /// <summary>
        /// HAWB NO
        /// </summary>
        public string PackingNo { get; set; }
        /// <summary>
        /// DETAIL
        /// </summary>
        public int No { get; set; }
        public string CtnsNo { get; set; }
        public string ProCode { get; set; }
        /// <summary>
        /// Description of Goods
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// pcs,set
        /// </summary>
        public double? Quantity { get; set; }
        public string Unit { get; set; }
        public double? QtyPkg { get; set; }
        public string UnitPkg { get; set; }
        public double? PerKgs { get; set; }
        /// <summary>
        /// kg
        /// </summary>
        public double? NetWeight { get; set; }
        /// <summary>
        /// kg
        /// </summary>
        public double? GrossWeight { get; set; }
        public double? SumWeight { get; set; }
        /// <summary>
        /// m
        /// </summary>
        public double? CBM { get; set; }
        /// <summary>
        /// usd
        /// </summary>
        public double? UnitPrice { get; set; }
        public string Currency { get; set; }

        public virtual HAWB PackingNoNavigation { get; set; }
    }
}
