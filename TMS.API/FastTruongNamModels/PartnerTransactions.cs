using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class PartnerTransactions
    {
        public string TransID { get; set; }
        public DateTime? DateInput { get; set; }
        public DateTime? TransDate { get; set; }
        public string Description { get; set; }
        public string CompanyContact { get; set; }
        public string GuestPersonals { get; set; }
        public string Category { get; set; }
        public string FieldInterested { get; set; }
        public string Competitor { get; set; }
        public string TransStatus { get; set; }
        public DateTime? NextDateContact { get; set; }
        public string Notes { get; set; }
        public string UserName { get; set; }
        public string PartnerID { get; set; }
        public string Attached { get; set; }
        public bool? UserRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? NumdayAlertBefore { get; set; }
        public DateTime? DateModify { get; set; }

        public virtual Partners Partner { get; set; }
    }
}
