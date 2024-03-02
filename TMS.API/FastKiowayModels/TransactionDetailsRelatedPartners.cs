using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class TransactionDetailsRelatedPartners
    {
        public decimal TransIDKey { get; set; }
        public string PartnerID { get; set; }
        public DateTime? DateInput { get; set; }
        public DateTime? DateModify { get; set; }
        public DateTime? DateTrans { get; set; }
        public string Category { get; set; }
        public string Notes { get; set; }
        public string UserInput { get; set; }
        public string HAWBNO { get; set; }
        public int? lIndex { get; set; }

        public virtual HAWB HAWBNONavigation { get; set; }
        public virtual Partners Partner { get; set; }
    }
}
