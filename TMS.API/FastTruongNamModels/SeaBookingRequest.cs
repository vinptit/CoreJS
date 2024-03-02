using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class SeaBookingRequest
    {
        public SeaBookingRequest()
        {
            SeaBookingRequestCargo = new HashSet<SeaBookingRequestCargo>();
            SeaBookingRequestCarriage = new HashSet<SeaBookingRequestCarriage>();
            SeaBookingRequestContainers = new HashSet<SeaBookingRequestContainers>();
            SeaBookingRequestPaymentDetails = new HashSet<SeaBookingRequestPaymentDetails>();
        }

        public string KBRefNo { get; set; }
        public string CarrierID { get; set; }
        public string ContractNo { get; set; }
        public string CarrierBKNo { get; set; }
        public string InttraBKNo { get; set; }
        public string BKOffice { get; set; }
        public bool? CarrierNotFile { get; set; }
        public string CarrierFile { get; set; }
        public string CarrierNotFileRef { get; set; }
        public bool? PerContainerReleaseNbrReqst { get; set; }
        public bool? EmptyContainer { get; set; }
        public string ShipperID { get; set; }
        public string ShipperRefNo { get; set; }
        public string ForwarderID { get; set; }
        public string ForwarderRefNo { get; set; }
        public string ConsigneeID { get; set; }
        public string ConsigneeRefNo { get; set; }
        public string ContractParty { get; set; }
        public string ContractPartyRefNo { get; set; }
        public string PurchaseOrderNo { get; set; }
        public string NotifyPartyID { get; set; }
        public string AddNotifyPartyID { get; set; }
        public string AddNotifyParty2ID { get; set; }
        public string TariffNo { get; set; }
        public string BLNo { get; set; }
        public string MoveType { get; set; }
        public string PlaceOfReceipt { get; set; }
        public DateTime? DepartureDate { get; set; }
        public string PlaceOfDelivery { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public bool? CargoAllocate { get; set; }
        public bool? NotifyCargoStatus { get; set; }
        public string CustomerComment { get; set; }
        public string AmendmentJustification { get; set; }
        public string EmailNotify { get; set; }
        public string VesselNameCF { get; set; }
        public string VoyageNumberCF { get; set; }
        public DateTime? DepartureDateCF { get; set; }
        public DateTime? ArrivalDateCF { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateMotify { get; set; }
        public string Creator { get; set; }
        public bool? LockedRecord { get; set; }
        public string BKStatus { get; set; }
        public string BKType { get; set; }

        public virtual ICollection<SeaBookingRequestCargo> SeaBookingRequestCargo { get; set; }
        public virtual ICollection<SeaBookingRequestCarriage> SeaBookingRequestCarriage { get; set; }
        public virtual ICollection<SeaBookingRequestContainers> SeaBookingRequestContainers { get; set; }
        public virtual ICollection<SeaBookingRequestPaymentDetails> SeaBookingRequestPaymentDetails { get; set; }
    }
}
