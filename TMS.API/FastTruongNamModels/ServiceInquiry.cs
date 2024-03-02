using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ServiceInquiry
    {
        public ServiceInquiry()
        {
            ContainerLoadedInquiry = new HashSet<ContainerLoadedInquiry>();
            ServiceInquiryDetails = new HashSet<ServiceInquiryDetails>();
        }

        public string ServiceID { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public bool? ImportShipment { get; set; }
        public DateTime? ETD { get; set; }
        public DateTime? ETA { get; set; }
        public string CreateUser { get; set; }
        public string PartnerID { get; set; }
        public string ServiceInquiry1 { get; set; }
        public string POL { get; set; }
        public string POD { get; set; }
        public string FinalDestination { get; set; }
        public string PickupCargo { get; set; }
        public string EmptyContReturn { get; set; }
        public double? TotalGW { get; set; }
        public double? TotalCW { get; set; }
        public double? TotalCBM { get; set; }
        public string ConQty { get; set; }
        public double? Quantity { get; set; }
        public string UnitQuantity { get; set; }
        public string VesselName { get; set; }
        public string VoyNo { get; set; }
        public string Commodity { get; set; }
        public string Dimention { get; set; }
        public string Notes { get; set; }
        public string SalesmanID { get; set; }
        public bool? SVLocked { get; set; }
        public DateTime? DateLocked { get; set; }
        public string PCName { get; set; }
        public bool? ApprovedCmd { get; set; }
        public bool? HVComment { get; set; }
        public string UserComment { get; set; }
        public string DeliveryTerm { get; set; }

        public virtual ICollection<ContainerLoadedInquiry> ContainerLoadedInquiry { get; set; }
        public virtual ICollection<ServiceInquiryDetails> ServiceInquiryDetails { get; set; }
    }
}
