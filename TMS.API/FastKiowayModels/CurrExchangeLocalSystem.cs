using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class CurrExchangeLocalSystem
    {
        public int IDKey { get; set; }
        public string CurrUnit { get; set; }
        public string CurrDesc { get; set; }
        public double? ExUSD { get; set; }
        public double? ExLocal { get; set; }
        public string CompID { get; set; }
        public string Username { get; set; }
        public string MCurr { get; set; }
    }
}
