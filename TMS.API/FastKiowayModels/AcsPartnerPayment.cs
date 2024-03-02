using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class AcsPartnerPayment
    {
        public decimal IDKey { get; set; }
        public string PartnerID { get; set; }
        public string Description { get; set; }
        public DateTime? DateInput { get; set; }
        public DateTime? DateModify { get; set; }
        public DateTime? DatePaid { get; set; }
        public double? PaidAmount { get; set; }
        public string Curr { get; set; }
        public double? ExRate { get; set; }
        public string RefNo { get; set; }
        public string WhoisPaid { get; set; }
        public bool? Finish { get; set; }
        public bool? Receivable { get; set; }

        public virtual Partners Partner { get; set; }
    }
}
