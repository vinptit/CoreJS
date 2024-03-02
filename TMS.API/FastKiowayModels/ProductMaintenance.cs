using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ProductMaintenance
    {
        public int MID { get; set; }
        public string ProductID { get; set; }
        public DateTime? MDate { get; set; }
        public string Description { get; set; }
        public string Solution { get; set; }
        public double? outlay { get; set; }
        public bool Paid { get; set; }
        public string DocNo { get; set; }
        public string Transactions { get; set; }
        public string Notes { get; set; }

        public virtual Products Product { get; set; }
    }
}
