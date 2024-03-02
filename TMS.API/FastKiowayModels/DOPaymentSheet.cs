using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class DOPaymentSheet
    {
        public string PmID { get; set; }
        public DateTime? PmDate { get; set; }
        public string ContactID { get; set; }
        public int? PmValue { get; set; }
        public string ManagedID { get; set; }
        public string Notes { get; set; }
    }
}
