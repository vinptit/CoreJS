using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class TransactionsChangeHis
    {
        public decimal IDKey { get; set; }
        public decimal? IDKeyLinked { get; set; }
        public string UserChecked { get; set; }
        public DateTime? DateCheck { get; set; }
        public string SourceType { get; set; }
        public string RefNo { get; set; }
    }
}
