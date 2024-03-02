using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ACPayrollDeploy
    {
        public decimal IDKey { get; set; }
        public int? IDLinked { get; set; }
        public string ContactID { get; set; }
        public string Description { get; set; }
        public double? UnitPrice { get; set; }
        public string Curr { get; set; }
        public double? Quantity { get; set; }
        public bool? Dbt { get; set; }
        public double? Amount { get; set; }
        public string Notes { get; set; }
    }
}
