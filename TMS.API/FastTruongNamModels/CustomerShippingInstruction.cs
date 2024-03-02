using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class CustomerShippingInstruction
    {
        public CustomerShippingInstruction()
        {
            CustomerShippingInstructionDetail = new HashSet<CustomerShippingInstructionDetail>();
        }

        public decimal CustomerShippingInstructionID { get; set; }
        public decimal BookingRequestId { get; set; }
        public string HBLNo { get; set; }
        public string CustomerId { get; set; }
        public string Shipper { get; set; }
        public string Consignee { get; set; }
        public string NotifyParty { get; set; }
        public string POL { get; set; }
        public string POD { get; set; }
        public string FinalDestination { get; set; }
        public double? NoOfPackage { get; set; }
        public string Unit { get; set; }
        public string FreightTerm { get; set; }
        public string Commodity { get; set; }
        public string Dimension { get; set; }
        public string ShippingMark { get; set; }
        public string TypeOfBill { get; set; }
        public double? Grossweight { get; set; }
        public double? Chargesweight { get; set; }
        public double? CBM { get; set; }

        public virtual ICollection<CustomerShippingInstructionDetail> CustomerShippingInstructionDetail { get; set; }
    }
}
