using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class CurrencyExchangeRate
    {
        public string ID { get; set; }
        public string Unit { get; set; }
        public double? Price { get; set; }
        public double? KBExchangeRate { get; set; }
        public double? ExtVNDSales { get; set; }
        public double? ExtVNDSalesKB { get; set; }
        public string Note { get; set; }

        public virtual SalesCurrencyExchange IDNavigation { get; set; }
    }
}
