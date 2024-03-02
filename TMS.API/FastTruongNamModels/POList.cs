using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class POList
    {
        public POList()
        {
            PODetail = new HashSet<PODetail>();
            POListAttachedFiles = new HashSet<POListAttachedFiles>();
        }

        public string PONumber { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? PODate { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public bool? ShipmentDelivery { get; set; }
        public DateTime? ShipmentDeliveryDate { get; set; }
        public string ShipmentTerm { get; set; }
        public string PaymentTerm { get; set; }
        public DateTime? ETD { get; set; }
        public DateTime? ETA { get; set; }
        public string POL { get; set; }
        public string POD { get; set; }
        public string Notes { get; set; }
        public string CreateUser { get; set; }
        public string PCName { get; set; }
        public string Attached { get; set; }

        public virtual ICollection<PODetail> PODetail { get; set; }
        public virtual ICollection<POListAttachedFiles> POListAttachedFiles { get; set; }
    }
}
