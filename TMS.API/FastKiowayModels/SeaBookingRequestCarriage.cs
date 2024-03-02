using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class SeaBookingRequestCarriage
    {
        public string BKRefNo { get; set; }
        public decimal IDKey { get; set; }
        public string LoadingPort { get; set; }
        public DateTime? ETD { get; set; }
        public string Mode { get; set; }
        public string DischargePort { get; set; }
        public DateTime? ETA { get; set; }
        public string ConveyanceType { get; set; }
        public string VesselName { get; set; }
        public string Voyage { get; set; }
        public string CarriageMode { get; set; }
        public int? LIndex { get; set; }
        public bool? ConfirmCR { get; set; }
        public string LloydsCode { get; set; }
        public string RegistrationCountryCode { get; set; }
        public string OperatorIdentifierType { get; set; }
        public string OperatorIdentifierCode { get; set; }

        public virtual SeaBookingRequest BKRefNoNavigation { get; set; }
    }
}
