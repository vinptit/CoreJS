using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class BankCustomize
    {
        public Guid ID { get; set; }
        public string AccountLocalNo { get; set; }
        public string AccountUSDNo { get; set; }
        public string AccountName { get; set; }
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public string SwiftCode { get; set; }
        public string IBankCode { get; set; }
        public bool? isDefault { get; set; }
        public decimal IDKey { get; set; }
    }
}
