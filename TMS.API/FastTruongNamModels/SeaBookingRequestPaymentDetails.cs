using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class SeaBookingRequestPaymentDetails
    {
        public string BKRefNo { get; set; }
        public decimal IDKey { get; set; }
        public string ChargeType { get; set; }
        public string FreightTerm { get; set; }
        public string PayerID { get; set; }
        public string PaymentLocation { get; set; }
        public int? LIndex { get; set; }

        public virtual SeaBookingRequest BKRefNoNavigation { get; set; }
    }
}
