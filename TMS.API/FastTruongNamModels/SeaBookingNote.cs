using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class SeaBookingNote
    {
        public SeaBookingNote()
        {
            TransactionDetails = new HashSet<TransactionDetails>();
        }

        public string BookingID { get; set; }
        public DateTime? DateMaking { get; set; }
        public DateTime? Revision { get; set; }
        public string ReleaseNo { get; set; }
        public bool? CancelBooking { get; set; }
        public string CancelMsg { get; set; }
        public string ShipperID { get; set; }
        public string Attn { get; set; }
        public string ConsigneeCode { get; set; }
        /// <summary>
        /// avc
        /// </summary>
        public string ConsigneeName { get; set; }
        public string ConsigneeAddress { get; set; }
        public string ForwardingAgent { get; set; }
        public string ReceiptAt { get; set; }
        public string Deliveryat { get; set; }
        public string ServiceMode { get; set; }
        public string SC { get; set; }
        public string PortofLading { get; set; }
        public string PortofUnlading { get; set; }
        public string ModeSea { get; set; }
        public string EstimatedVessel { get; set; }
        public DateTime? LoadingDate { get; set; }
        public DateTime? DestinationDate { get; set; }
        public string Quantity { get; set; }
        public string ContainerSize { get; set; }
        public string Commidity { get; set; }
        public double? GrosWeight { get; set; }
        public double? CBMSea { get; set; }
        public string SpecialRequest { get; set; }
        public string CloseTime20 { get; set; }
        public string CloseTime40 { get; set; }
        public string CloseTimeLCL { get; set; }
        public string ContainerNo { get; set; }
        public string HBLData { get; set; }
        public string SCIACI { get; set; }
        public string BlCorrection { get; set; }
        public string PickupAt { get; set; }
        public DateTime? PickupDate { get; set; }
        public string DropoffAt { get; set; }
        public DateTime? DropoffDate { get; set; }
        public string OperationCode { get; set; }
        public string TransID { get; set; }
        public string LotNo { get; set; }
        public string WhoisMaking { get; set; }
        public DateTime? EmptyReturnDate { get; set; }
        public DateTime? ClosingTimeDate { get; set; }
        public DateTime? FullLadenDate { get; set; }
        public string Remark { get; set; }
        public bool? Preview { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? FreeDem { get; set; }
        public int? FreeDet { get; set; }
        public string ReferenceNo { get; set; }
        public string FormName { get; set; }
        public string NominatedContainer { get; set; }
        public string HBLNoASGN { get; set; }
        public string SalesmantID { get; set; }
        public string ShipmentType { get; set; }
        public string NMPartyID { get; set; }
        public string ShipperCode { get; set; }
        public string ShipperName { get; set; }
        public string ShipperAddress { get; set; }
        public string TransitPort { get; set; }
        public bool? BKApp { get; set; }
        public DateTime? BKAppDate { get; set; }
        public string BKAppBy { get; set; }
        public string BKAppComment { get; set; }
        public string FeederVessel { get; set; }
        public string VGMCutofftime { get; set; }
        public string FDAgentID { get; set; }
        public string CarrierID { get; set; }
        public string StuffingTime { get; set; }
        public DateTime? ETDTransit { get; set; }
        public DateTime? ETADest { get; set; }
        public string WHNo { get; set; }

        public virtual ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
