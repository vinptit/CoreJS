using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class SalesIncentive
    {
        public string IDKeyField { get; set; }
        public string CompID { get; set; }
        public int? YearRP { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string UserCreated { get; set; }
        public string Currency { get; set; }
        public bool? Approved { get; set; }
        public DateTime? DateApp { get; set; }
        public string ApprovedBy { get; set; }
    }
}
