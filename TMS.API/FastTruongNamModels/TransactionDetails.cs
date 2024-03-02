using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class TransactionDetails
    {
        public TransactionDetails()
        {
            ContainerRoutine = new HashSet<ContainerRoutine>();
        }

        public decimal IDKeyShipment { get; set; }
        public string TransID { get; set; }
        public string LotNo { get; set; }
        public string BookingID { get; set; }
        public string ShipperID { get; set; }
        /// <summary>
        /// Booking Confirm
        /// </summary>
        public string Attn { get; set; }
        public string NominationParty { get; set; }
        public string ShipmentType { get; set; }
        public string ContactID { get; set; }
        public string SalesManID { get; set; }
        public string Description { get; set; }
        public string HWBNO { get; set; }
        public string MAWB { get; set; }
        public string MAWBSE { get; set; }
        public string CustomsID { get; set; }
        public DateTime? DateMaking { get; set; }
        public DateTime? ETD { get; set; }
        public DateTime? ETDConnecting { get; set; }
        /// <summary>
        /// Connecting
        /// </summary>
        public DateTime? ETA { get; set; }
        /// <summary>
        /// Number of pieces
        /// </summary>
        public double? Quantity { get; set; }
        public string UnitDetail { get; set; }
        public double? GrosWeight { get; set; }
        public double? WeightChargeable { get; set; }
        public double? CBMSea { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? Dimension { get; set; }
        public string RateConfirm { get; set; }
        public double? SellTotalValue { get; set; }
        public double? ProfitShared { get; set; }
        public string Notes { get; set; }
        public string ExConsigneeSign { get; set; }
        public string DeliveryDate { get; set; }
        public string ReceiptAt { get; set; }
        public string Deliveryat { get; set; }
        public string ServiceMode { get; set; }
        public string SC { get; set; }
        public string ContainerSize { get; set; }
        public string Commidity { get; set; }
        public string CloseTime20 { get; set; }
        public string CloseTime40 { get; set; }
        public string CloseTimeLCL { get; set; }
        public string PickupAt { get; set; }
        public DateTime? PickupDate { get; set; }
        public string DropoffAt { get; set; }
        public DateTime? DropoffDate { get; set; }
        public string ContainerNo { get; set; }
        public string HBLData { get; set; }
        public string BlCorrection { get; set; }
        public string SCIACI { get; set; }
        public string ConsigneeCode { get; set; }
        public string ConsigneeName { get; set; }
        public string ConsigneeAddress { get; set; }
        public string SpecialRequest { get; set; }
        /// <summary>
        /// Connecting Vessel (Mother vessel)
        /// </summary>
        public string ContSealNo { get; set; }
        public string LoadingConfirmShipper { get; set; }
        public string AttnLoadingConfig { get; set; }
        public double? SellingRateVAT { get; set; }
        public double? SellingRate { get; set; }
        public double? BuyingRate { get; set; }
        public double? CommissionCarrier { get; set; }
        public double? CoverCharges { get; set; }
        public string ChargesDesc { get; set; }
        public string PayableAC { get; set; }
        public int? VATCharges { get; set; }
        public string CSCurr { get; set; }
        public string ProcessNotes { get; set; }
        public int? SIQID { get; set; }
        public double? ExchangeRate { get; set; }
        public bool? ConfirmReceived { get; set; }
        public string UserConfirm { get; set; }
        public DateTime? DateReceivedConfirm { get; set; }
        public string QuoNo { get; set; }
        public bool? CDSExtra { get; set; }
        public double? ExpressDTCW { get; set; }
        public double? ExpressDTRate { get; set; }
        public string ExpressDTUnit { get; set; }
        public double? CommissionCustomer { get; set; }
        public string DocsReceiver { get; set; }
        public DateTime? DocsReceivedDate { get; set; }
        public string NMDeliverName { get; set; }
        public DateTime? NMDeliveryDate { get; set; }
        public string DeliveryStatus { get; set; }
        public DateTime? EsDeliveryDate { get; set; }
        public DateTime? AcDeliveryDate { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool? TKSent { get; set; }
        public string TKContactID { get; set; }
        public int? TKStatus { get; set; }
        public DateTime? TKStatusReadDate { get; set; }
        public string TKStatusReadUser { get; set; }
        public string TruckJob { get; set; }
        public string MaymentAPPName { get; set; }
        public int? IBKUseExist { get; set; }
        public string BLType { get; set; }
        public string PaymentMethod { get; set; }
        public bool? PaidChecked { get; set; }
        public bool? BLReady { get; set; }
        public string DOStatus { get; set; }
        public string RemoocNo { get; set; }
        public DateTime? TruckStorageDate { get; set; }
        public DateTime? MoocStorageDate { get; set; }
        public DateTime? MoocPKDate { get; set; }
        public double? MoocStorage { get; set; }
        public string ComChargeType { get; set; }
        public string ServiceRQNo { get; set; }
        public DateTime? DOExpired { get; set; }
        public double? TotalPastRevenue { get; set; }
        public double? TotalPastCost { get; set; }
        public double? TotalPastRevenueVND { get; set; }
        public double? TotalPastCostVND { get; set; }
        public string TKRomoocNo { get; set; }
        public bool? TKRomoocStatus { get; set; }
        public DateTime? TKSentOn { get; set; }
        public bool? TKType { get; set; }
        public string TKStartPosition { get; set; }
        public DateTime? TKArrivedOn { get; set; }
        public DateTime? TKStartedOn { get; set; }
        public DateTime? TKDeliveryOn { get; set; }
        public DateTime? TkRomoocReturnedOn { get; set; }
        public bool? TKFinish { get; set; }
        public bool? TKSTATUSCANCEL { get; set; }
        public bool? ISCREATEDMOBILETASK { get; set; }
        public bool? ISCREATEDHANDLINGTASK { get; set; }
        public string SHMTPriority { get; set; }
        public string VesselVoyFlight { get; set; }
        public string STUFFINGEIR { get; set; }
        public string UNSTUFFINGEIR { get; set; }
        public bool? ISCANTPICKUP { get; set; }
        public bool? ISCANTDELIVER { get; set; }
        public decimal? OwnerShipmentID { get; set; }
        public DateTime? DEADLINEON { get; set; }
        public int? CUSTOMERSATISFACTION { get; set; }
        public string CUSTOMERSATISFACTIONNOTES { get; set; }
        public string ENCRYPTSEADO { get; set; }
        public string Incoterm { get; set; }
        public DateTime? DTDeadline { get; set; }
        public string TKDeployID { get; set; }
        public int? EQCFreeDays { get; set; }
        public string TROUBLEMESSAGE { get; set; }
        public bool? ISTROUBLE { get; set; }
        public bool? ISWARNING { get; set; }
        public string WARNINGMESSAGE { get; set; }
        public string WARNINGTYPE { get; set; }
        public bool? ISTROUBLE2 { get; set; }
        public bool? ISTROUBLE3 { get; set; }
        public bool? ISASSIGNED { get; set; }
        public bool? ISFINISHED { get; set; }
        public bool? ISRETURNED { get; set; }
        public int? REMOCSTATUS { get; set; }
        public string PARKINGREMOCREASON { get; set; }
        public DateTime? PARKINGREMOCON { get; set; }
        public DateTime? RELEASEREMOCON { get; set; }
        public DateTime? PICKUPEMPTYON { get; set; }
        public DateTime? ARRIVEPICKUPEMPTYON { get; set; }
        public bool ChangeDeadline { get; set; }
        public bool GETDEFAULTFEE { get; set; }
        public DateTime? TKFinishedOn { get; set; }
        public DateTime? TKCANTPICKUPDON { get; set; }
        public string REASONCANTPICKUP { get; set; }
        public string REASONCANTDELIVER { get; set; }
        public string TKCANTDELIVERDON { get; set; }

        public virtual SeaBookingNote Booking { get; set; }
        public virtual CustomsDeclaration Customs { get; set; }
        public virtual HAWB HWBNONavigation { get; set; }
        public virtual Partners Shipper { get; set; }
        public virtual Transactions Trans { get; set; }
        public virtual ICollection<ContainerRoutine> ContainerRoutine { get; set; }
    }
}
