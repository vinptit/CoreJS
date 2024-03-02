using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ExchangeRate
    {
        public int ID { get; set; }
        public string Unit { get; set; }
        public string UnitName { get; set; }
        public string LocalName { get; set; }
        public double? ExchangeRate1 { get; set; }
        public double? KBExchangeRate { get; set; }
        public double? ExtVNDSales { get; set; }
        public double? ExtVNDSalesKB { get; set; }
        public double? ExtVND { get; set; }
        public double? DeptExUSD { get; set; }
        public string Notes { get; set; }
        public bool CrActive { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}
