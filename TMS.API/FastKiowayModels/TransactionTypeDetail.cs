using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class TransactionTypeDetail
    {
        public int IDKey { get; set; }
        public string IDTransType { get; set; }
        public bool? Request { get; set; }
        public bool? RateRequired { get; set; }
        public string UserName { get; set; }
        public string Sign { get; set; }
        public string sMonth { get; set; }
        public string No { get; set; }
        public string Ys { get; set; }
        public string sYear { get; set; }
        public string Increment { get; set; }
        public int? IDResetOn { get; set; }
        public int? NoDaysLock { get; set; }
        public int? DayofLogisticsLock { get; set; }
        public int? LockAgainAfterUnlock { get; set; }
        public string ApproveManager { get; set; }
        public bool? MngAPP { get; set; }
        public string CompID { get; set; }
        public string DeptID { get; set; }
        public int? DayofJobFinish { get; set; }
        public bool? IsSystem { get; set; }
    }
}
