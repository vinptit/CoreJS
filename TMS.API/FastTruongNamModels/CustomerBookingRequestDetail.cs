using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class CustomerBookingRequestDetail
    {
        public decimal BookingRequestDetailId { get; set; }
        public decimal BookingRequestId { get; set; }
        public double? Quantity { get; set; }
        public string ContainerType { get; set; }
        public string DescriptionOfGoods { get; set; }
        public double? Grossweight { get; set; }
        public double? CBM { get; set; }
        public string PO { get; set; }

        public virtual CustomerBookingRequest BookingRequest { get; set; }
    }
}
