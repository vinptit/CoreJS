using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class CustomerBookingRequest
    {
        public CustomerBookingRequest()
        {
            CustomerBookingRequestDetail = new HashSet<CustomerBookingRequestDetail>();
        }

        public decimal BookingRequestId { get; set; }
        public string CustomerId { get; set; }
        public string Email { get; set; }
        public string PIC { get; set; }
        public DateTime? CargoReadyDate { get; set; }
        public string Shipper { get; set; }
        public string Consignee { get; set; }
        public string POL { get; set; }
        public string POD { get; set; }
        public string PlaceOfDelivery { get; set; }
        public string FreightTerm { get; set; }
        public string Commodity { get; set; }
        public string Type { get; set; }
        public double? Grossweight { get; set; }
        public double? Chargesweight { get; set; }
        public double? CBM { get; set; }
        public string PickupAt { get; set; }
        public string EmtpyReturnAt { get; set; }

        public virtual ICollection<CustomerBookingRequestDetail> CustomerBookingRequestDetail { get; set; }
    }
}
