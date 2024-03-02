using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class HAWB
    {
        public HAWB()
        {
            AMSDeclaration = new HashSet<AMSDeclaration>();
            AcsInstallPayment = new HashSet<AcsInstallPayment>();
            AdvanceSettlementPayment = new HashSet<AdvanceSettlementPayment>();
            AirFreightTracking = new HashSet<AirFreightTracking>();
            BookingLocal = new HashSet<BookingLocal>();
            BuyingRateWithHBL = new HashSet<BuyingRateWithHBL>();
            CargoOperationRequest = new HashSet<CargoOperationRequest>();
            ContainerListOnHBL = new HashSet<ContainerListOnHBL>();
            ContainerLoadedHBL = new HashSet<ContainerLoadedHBL>();
            ContainerPKExtension = new HashSet<ContainerPKExtension>();
            HAWBRATE = new HashSet<HAWBRATE>();
            HAWBSEPDetails = new HashSet<HAWBSEPDetails>();
            HAWBTranshipment = new HashSet<HAWBTranshipment>();
            PackingListDetails = new HashSet<PackingListDetails>();
            ProfitShares = new HashSet<ProfitShares>();
            ProfitSharesCost = new HashSet<ProfitSharesCost>();
            SellingRate = new HashSet<SellingRate>();
            TransactionDetails = new HashSet<TransactionDetails>();
            TransactionDetailsRelatedPartners = new HashSet<TransactionDetailsRelatedPartners>();
            TransactionInfo = new HashSet<TransactionInfo>();
            TransactionInfoDetail = new HashSet<TransactionInfoDetail>();
        }

        public string HWBNO { get; set; }
        public string AWBNO { get; set; }
        public string TRANSID { get; set; }
        public string ArrivalNo { get; set; }
        public string DONo { get; set; }
        public string ShipperDf { get; set; }
        public string ATTN { get; set; }
        public string ISSUED { get; set; }
        public string Consignee { get; set; }
        public string ConsigneeID { get; set; }
        public string HBShipperID { get; set; }
        public string HBNotifyID { get; set; }
        public string HBAlsoNotifyID { get; set; }
        public string HBAgentID { get; set; }
        /// <summary>
        /// Issuing Carrier&apos;s Agent and City
        /// </summary>
        public string ICASNC { get; set; }
        public string AccountingInfo { get; set; }
        public string AgentIATACode { get; set; }
        public string AccountNo { get; set; }
        public string DepartureAirportCode { get; set; }
        public string DepartureAirport { get; set; }
        public string ReferrenceNo { get; set; }
        /// <summary>
        /// Optional Shipping Information
        /// </summary>
        public string OSI { get; set; }
        public string FirstDestination { get; set; }
        public string FirstCarrier { get; set; }
        public string SecondDestination { get; set; }
        public string SecondCarrier { get; set; }
        public string ThirdDestination { get; set; }
        public string ThirdCarrier { get; set; }
        public string Currency { get; set; }
        public string CHGSCode { get; set; }
        public bool WTVALPP { get; set; }
        public bool WTVALCC { get; set; }
        public bool OtherPP { get; set; }
        public bool OtherCC { get; set; }
        public string DlvCarriage { get; set; }
        public string DlvCustoms { get; set; }
        public string LastDestination { get; set; }
        public string FlightNo { get; set; }
        public DateTime? FlightDate { get; set; }
        public string insurAmount { get; set; }
        public string HandlingInfo { get; set; }
        public string Notify { get; set; }
        public string SCI { get; set; }
        public string WChargePP { get; set; }
        public string WChargeCC { get; set; }
        public string ValChargePP { get; set; }
        public string ValChargeCC { get; set; }
        public string TaxPP { get; set; }
        public string TaxCC { get; set; }
        public string OrChrW { get; set; }
        public string OrChrVal { get; set; }
        public string TTChgAgentPP { get; set; }
        public string TTChgAgentCC { get; set; }
        public string TTChgCarrPP { get; set; }
        public string TTChgCarrCC { get; set; }
        public string TotalPP { get; set; }
        public string TotalCC { get; set; }
        public string CurConvRate { get; set; }
        public string CCChgDes { get; set; }
        public string DestCharge { get; set; }
        public string ShipperCertf { get; set; }
        public string ExecutedOn { get; set; }
        public string ExecutedAt { get; set; }
        public string Signature { get; set; }
        /// <summary>
        /// Booking Confirm
        /// </summary>
        public DateTime? DateConfirm { get; set; }
        public DateTime? LoadingDate { get; set; }
        public DateTime? FlightSchedule { get; set; }
        public string Description { get; set; }
        public double? Pieces { get; set; }
        public double? GrossWeight { get; set; }
        public double? Dimension { get; set; }
        public string RateConfirm { get; set; }
        public string QuoID { get; set; }
        /// <summary>
        /// Express
        /// </summary>
        public DateTime? ExHDate { get; set; }
        public string OriginCode { get; set; }
        public string SenderName { get; set; }
        public string SenderAddress { get; set; }
        public string SenderCity { get; set; }
        public string SenderZipCode { get; set; }
        public string SenderProvince { get; set; }
        public string SenderCountry { get; set; }
        public string SenderContactName { get; set; }
        public string SenderTelNo { get; set; }
        public string ShipperSigned { get; set; }
        public string BillSender { get; set; }
        public string BillRecipient { get; set; }
        public string BillSenderTax { get; set; }
        public string BillRecipientTax { get; set; }
        public string DestinationCode { get; set; }
        public string ReceivedName { get; set; }
        public string ReceivedAddress { get; set; }
        public string ReceivedCity { get; set; }
        public string ReceivedZipCode { get; set; }
        public string ReceivedProvince { get; set; }
        public string ReceivedCountry { get; set; }
        public string ReceivedContactName { get; set; }
        public string ReceivedTelNo { get; set; }
        public bool Document { get; set; }
        public bool Parcel { get; set; }
        public double? Packages { get; set; }
        public double? Weight { get; set; }
        public double? ChargeableWeight { get; set; }
        public string SpecialInstruction { get; set; }
        public string TimeAm { get; set; }
        public string TimePm { get; set; }
        public DateTime? SignDate { get; set; }
        public DateTime? CussignedDate { get; set; }
        public string Sign { get; set; }
        public string PlaceAtReceiptCode { get; set; }
        public string PlaceAtReceipt { get; set; }
        public string PlaceDeliveryCode { get; set; }
        public string PlaceDelivery { get; set; }
        public string ReferenceNo { get; set; }
        public string LocalVessel { get; set; }
        public string FromSea { get; set; }
        public string FromSeaCode { get; set; }
        public string OceanVessel { get; set; }
        public string PortofDischargeCode { get; set; }
        public string PortofDischarge { get; set; }
        public string TranShipmentToCode { get; set; }
        public string TranShipmentTo { get; set; }
        public string GoodsDelivery { get; set; }
        public string TotalPackages { get; set; }
        public string Movement { get; set; }
        public bool OriginLandPP { get; set; }
        public bool OriginTHCPP { get; set; }
        public bool SeafreightPP { get; set; }
        public bool DesTHCPP { get; set; }
        public bool DesLandPP { get; set; }
        public bool OriginLandCC { get; set; }
        public bool OriginTHCCC { get; set; }
        public bool SeafreightCC { get; set; }
        public bool DesTHCCC { get; set; }
        public bool DesLandCC { get; set; }
        public string FreightPayAt { get; set; }
        public string NoofOriginBL { get; set; }
        public string ForCarrier { get; set; }
        public string SpecialNote { get; set; }
        public string SayWord { get; set; }
        public string SayWordPkg { get; set; }
        public string ContSealNo { get; set; }
        public string ShippingMarkImport { get; set; }
        public string Commodity { get; set; }
        public string Commodities { get; set; }
        public DateTime? DatePackage { get; set; }
        public string ArrivalFooterNotice { get; set; }
        public string DeliveryOrderNote { get; set; }
        public bool AirWayBill { get; set; }
        public bool SeaLCL { get; set; }
        public bool SeaFCL { get; set; }
        public bool Express { get; set; }
        public string CleanOnBoard { get; set; }
        public DateTime? ClosingDate { get; set; }
        public byte[] ShipPicture { get; set; }
        public string EmpPhotoSize { get; set; }
        public string Owner { get; set; }
        public string SerialNo { get; set; }
        public bool? DocumentRelease { get; set; }
        public DateTime? DocumentReleaseDate { get; set; }
        public DateTime? DocPrinted { get; set; }
        public string PONo { get; set; }
        public DateTime? PODate { get; set; }
        public DateTime? ATA { get; set; }
        public string BKStatus { get; set; }
        public string BKReason { get; set; }
        public string KBEvidence { get; set; }
        public string EsVessel { get; set; }
        public string EsVoyage { get; set; }
        public string PaidInvoiceNo { get; set; }
        public bool? OriginalBLPrintedLock { get; set; }
        public DateTime? OriginalBLPrintedDate { get; set; }
        public DateTime? InsurRegDate { get; set; }
        public string InsurOurRef { get; set; }
        public string InsurYourRef { get; set; }
        public string InsurTerm { get; set; }
        public string Insurance { get; set; }
        public string InsurCarrier { get; set; }
        public string InsurInvoice { get; set; }
        public string Insured { get; set; }
        public string InsurSumInsured { get; set; }
        public string InsurCover { get; set; }
        public string InsurPremium { get; set; }
        public string InsurOREF { get; set; }
        public string InsurRemark { get; set; }
        public string AltHBLNo { get; set; }
        public string DGCond { get; set; }
        public string StyleNo { get; set; }
        public string SContractNo { get; set; }
        public double? SPrice { get; set; }
        public string IssuingBank { get; set; }
        public string FreightNotes { get; set; }
        public string Seller { get; set; }
        public string ShipTo { get; set; }
        public string Consolidator { get; set; }
        public string ContainerStuffingLocation { get; set; }
        public string DocumentReleaseBy { get; set; }
        public DateTime? DocumentReleaseUpdate { get; set; }
        public string Drawee { get; set; }
        public bool? ShipmentTransit { get; set; }
        public string HSCode { get; set; }
        public bool? ANChargesSyn { get; set; }
        public string WarehouseName { get; set; }
        public DateTime? MNFSubmitDeadline { get; set; }
        public bool? CargoReceipt { get; set; }
        public string CargoReceiptRefNo { get; set; }
        public string CustomerID { get; set; }
        public DateTime? ETDAtReceiptPlace { get; set; }
        public DateTime? ETAAtReceiptPlace { get; set; }
        public DateTime? ATDAtReceiptPlace { get; set; }
        public DateTime? ATAAtReceiptPlace { get; set; }
        public string ReceiptTransportTypeNo { get; set; }
        public string ReceiptStatus { get; set; }
        public DateTime? ETDAtDeliveryPlace { get; set; }
        public DateTime? ETAAtDeliveryPlace { get; set; }
        public DateTime? ATDAtDeliveryPlace { get; set; }
        public DateTime? ATAAtDeliveryPlace { get; set; }
        public string DeliveryTransportTypeNo { get; set; }
        public string DeliveryStatus { get; set; }
        public DateTime? ETDAtDestinationPlace { get; set; }
        public DateTime? ETAAtDestinationPlace { get; set; }
        public DateTime? ATDAtDestinationPlace { get; set; }
        public DateTime? ATAAtDestinationPlace { get; set; }
        public string DestinationTransportTypeNo { get; set; }
        public string DestinationStatus { get; set; }
        public string ModeReceipt { get; set; }
        public string ModeMain { get; set; }
        public string ModeOnCarriage { get; set; }
        public string InvoicePKNo { get; set; }
        public string ManufacturerID { get; set; }
        public string Manufacturer { get; set; }
        public string BuyerID { get; set; }
        public string Buyer { get; set; }
        public string ImporterID { get; set; }
        public string Importer { get; set; }
        public string MSG_FUNC { get; set; }
        public string RELEASE_NO { get; set; }
        public DateTime? EXPIRY_TS { get; set; }
        public string SECURE_CODE { get; set; }
        public string MOD_TRANS_CALLSIGN { get; set; }
        public string PLACE_OF_MT_RETURN { get; set; }
        public string HTSCode { get; set; }
        public string CountryOfOriginCommodity { get; set; }
        public bool? EDOReady { get; set; }
        public string EDOApprovedBy { get; set; }
        public DateTime? EDOApprovedDate { get; set; }
        public DateTime? EDODeclineDate { get; set; }
        public string EDOUserSent { get; set; }
        public DateTime? EDODateSent { get; set; }
        public DateTime? EDODateRead { get; set; }
        public string EDOID { get; set; }
        public string EDOStatus { get; set; }
        public string EDORecallReason { get; set; }
        public string EDOErrorMessage { get; set; }
        public bool? LCBILL { get; set; }
        public string RECALLREASON { get; set; }

        public virtual HAWBDETAILS HAWBDETAILS { get; set; }
        public virtual ICollection<AMSDeclaration> AMSDeclaration { get; set; }
        public virtual ICollection<AcsInstallPayment> AcsInstallPayment { get; set; }
        public virtual ICollection<AdvanceSettlementPayment> AdvanceSettlementPayment { get; set; }
        public virtual ICollection<AirFreightTracking> AirFreightTracking { get; set; }
        public virtual ICollection<BookingLocal> BookingLocal { get; set; }
        public virtual ICollection<BuyingRateWithHBL> BuyingRateWithHBL { get; set; }
        public virtual ICollection<CargoOperationRequest> CargoOperationRequest { get; set; }
        public virtual ICollection<ContainerListOnHBL> ContainerListOnHBL { get; set; }
        public virtual ICollection<ContainerLoadedHBL> ContainerLoadedHBL { get; set; }
        public virtual ICollection<ContainerPKExtension> ContainerPKExtension { get; set; }
        public virtual ICollection<HAWBRATE> HAWBRATE { get; set; }
        public virtual ICollection<HAWBSEPDetails> HAWBSEPDetails { get; set; }
        public virtual ICollection<HAWBTranshipment> HAWBTranshipment { get; set; }
        public virtual ICollection<PackingListDetails> PackingListDetails { get; set; }
        public virtual ICollection<ProfitShares> ProfitShares { get; set; }
        public virtual ICollection<ProfitSharesCost> ProfitSharesCost { get; set; }
        public virtual ICollection<SellingRate> SellingRate { get; set; }
        public virtual ICollection<TransactionDetails> TransactionDetails { get; set; }
        public virtual ICollection<TransactionDetailsRelatedPartners> TransactionDetailsRelatedPartners { get; set; }
        public virtual ICollection<TransactionInfo> TransactionInfo { get; set; }
        public virtual ICollection<TransactionInfoDetail> TransactionInfoDetail { get; set; }
    }
}
