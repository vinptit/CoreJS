using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class Transactions
    {
        public Transactions()
        {
            AdvanceSettlementPayment = new HashSet<AdvanceSettlementPayment>();
            BookingLocal = new HashSet<BookingLocal>();
            BuyingRate = new HashSet<BuyingRate>();
            BuyingRateFixCost = new HashSet<BuyingRateFixCost>();
            BuyingRateOthers = new HashSet<BuyingRateOthers>();
            ConsolidationRate = new HashSet<ConsolidationRate>();
            ContainerLoaded = new HashSet<ContainerLoaded>();
            EcusJobApply = new HashSet<EcusJobApply>();
            InvoiceReference = new HashSet<InvoiceReference>();
            NACCS_MBL = new HashSet<NACCS_MBL>();
            OPSManagement = new HashSet<OPSManagement>();
            ProfitShareCalc = new HashSet<ProfitShareCalc>();
            ShippingInstruction = new HashSet<ShippingInstruction>();
            ShippingInstructionGoodsDetail = new HashSet<ShippingInstructionGoodsDetail>();
            TransactionDetails = new HashSet<TransactionDetails>();
        }

        public string TransID { get; set; }
        public string ManifestNo { get; set; }
        public DateTime? TransDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? LoadingDate { get; set; }
        public DateTime? FlightScheduleRequest { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public string ColoaderID { get; set; }
        public string ContactID { get; set; }
        public string RouteDelivery { get; set; }
        public string Destination { get; set; }
        public string Attn { get; set; }
        public string AirPortID { get; set; }
        public string Description { get; set; }
        public double? Noofpieces { get; set; }
        public string UnitPieaces { get; set; }
        public double? GrossWeight { get; set; }
        public double? ChargeableWeight { get; set; }
        public string AirDimension { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? Dimension { get; set; }
        public string RateRequest { get; set; }
        public string PaymentTerm { get; set; }
        public string TransactionNotes { get; set; }
        public string TpyeofService { get; set; }
        public string MAWB { get; set; }
        public string FlghtNo { get; set; }
        public DateTime? FlightDateConfirm { get; set; }
        public string AgentID { get; set; }
        public string PayableAgentID { get; set; }
        public string ExpressNotes { get; set; }
        public double? TotalBuyingRate { get; set; }
        public double? TotalSellingRate { get; set; }
        public double? TotalProfitshared { get; set; }
        public int? Profit { get; set; }
        public string BookingRequestNotes { get; set; }
        public string WhoisMaking { get; set; }
        public string Consign { get; set; }
        public bool TransactionDone { get; set; }
        public string DeliverDateText { get; set; }
        public DateTime? DestinationDate { get; set; }
        public bool Delivered { get; set; }
        public bool Reported { get; set; }
        public string ReportInfor { get; set; }
        public string OMB { get; set; }
        public string AirLine { get; set; }
        public string MarksRegistration { get; set; }
        public string PortofLading { get; set; }
        public string PortofUnlading { get; set; }
        public string ModeSea { get; set; }
        public string Consolidatater { get; set; }
        public string DeConsolidatater { get; set; }
        public string Forwarder { get; set; }
        public string Notes { get; set; }
        public string NatureofGoods { get; set; }
        public string ColoaderRouting { get; set; }
        public bool? PSAC { get; set; }
        public bool? CargoOnly { get; set; }
        public bool? NonRadioactive { get; set; }
        public bool? Radioactive { get; set; }
        public string HandlingInformation { get; set; }
        public string ShipperRef { get; set; }
        public string IssuedPlace { get; set; }
        public DateTime? IssuedDate { get; set; }
        public bool LCL { get; set; }
        public bool FCL { get; set; }
        public double? SeaCBM { get; set; }
        public string SeaUnit { get; set; }
        public DateTime? Revision { get; set; }
        public string EstimatedVessel { get; set; }
        public string ContSealNo { get; set; }
        public string Starus { get; set; }
        public string Remark { get; set; }
        public string Ref { get; set; }
        public string Amount { get; set; }
        public DateTime? ETA { get; set; }
        public string RoleShipper { get; set; }
        public string RoleATTN { get; set; }
        public string RoleFrom { get; set; }
        public DateTime? DateofPrealert { get; set; }
        public decimal? NoofPages { get; set; }
        public string ATTNofPrealert { get; set; }
        public int? NoofMAWB { get; set; }
        public int? NoofHAWB { get; set; }
        public int? NoInvoice { get; set; }
        public int? NoofDebitNote { get; set; }
        public string OtherInfo { get; set; }
        public bool transLock { get; set; }
        public bool TransUnlock { get; set; }
        public bool TransLockLog { get; set; }
        public bool TransUnlockLog { get; set; }
        public string SeaRevised { get; set; }
        public string RefNoSea { get; set; }
        public string ContainerSize { get; set; }
        public bool assigned { get; set; }
        public bool customs { get; set; }
        public bool Accs { get; set; }
        public bool AccsUnlock { get; set; }
        public string ConsoleNoteCarrier { get; set; }
        public string ConsoleNoteAgent { get; set; }
        public string ConsoleNoteShipper { get; set; }
        public string ConsoleNoteOthers { get; set; }
        public bool? Approved { get; set; }
        public string Approvedby { get; set; }
        public DateTime? ApproveDate { get; set; }
        public bool? Cancelled { get; set; }
        public string RefSellingRate { get; set; }
        public double? ExpressCW { get; set; }
        public double? ExpressRate { get; set; }
        public string ExpressUnit { get; set; }
        public string LogSV { get; set; }
        public DateTime? ETATransit { get; set; }
        public string TransitPortDes { get; set; }
        public DateTime? ETDTransit { get; set; }
        public string OceanVesselName { get; set; }
        public string OceanVoy { get; set; }
        public bool? ShowMark { get; set; }
        public bool? ErrorAttr { get; set; }
        public string ShipmentCommentGen { get; set; }
        public string ShipmentCommentBLClause { get; set; }
        public string SIMoveType { get; set; }
        public string SIServiceType { get; set; }
        public int? DocumentVersion { get; set; }
        public string SIShipperID { get; set; }
        public string SIConsigneeID { get; set; }
        public string SINotifyID { get; set; }
        public string SIStatus { get; set; }
        public int? FullJob { get; set; }
        public DateTime? FullJobDate { get; set; }
        public DateTime? ETDConnect { get; set; }
        public DateTime? ETAConnect { get; set; }
        public string StatusRoutine1 { get; set; }
        public string StatusRoutine2 { get; set; }
        public string POLC3 { get; set; }
        public string PODC3 { get; set; }
        public string FlightNo3 { get; set; }
        public DateTime? ETD3 { get; set; }
        public DateTime? ETA3 { get; set; }
        public DateTime? ATD3 { get; set; }
        public DateTime? ATA3 { get; set; }
        public string StatusRoutine3 { get; set; }
        public string POLC4 { get; set; }
        public string PODC4 { get; set; }
        public string FlightNo4 { get; set; }
        public DateTime? ETD4 { get; set; }
        public DateTime? ETA4 { get; set; }
        public DateTime? ATD4 { get; set; }
        public DateTime? ATA4 { get; set; }
        public string StatusRoutine4 { get; set; }
        public DateTime? ClearedDate { get; set; }
        public bool? TransitCBMRoundable { get; set; }
        public DateTime? TransitCBMRndUpdateDate { get; set; }
        public int? INVReady { get; set; }
        public DateTime? INVReadyDate { get; set; }
        public DateTime? AcsCTRLDate { get; set; }
        public DateTime? AcsCTRLDateRun { get; set; }
        public string AcsCTRLDateRunUser { get; set; }
        public bool? ChildShipment { get; set; }
        public DateTime? MTDeadline { get; set; }

        public virtual TransactionType TpyeofServiceNavigation { get; set; }
        public virtual ICollection<AdvanceSettlementPayment> AdvanceSettlementPayment { get; set; }
        public virtual ICollection<BookingLocal> BookingLocal { get; set; }
        public virtual ICollection<BuyingRate> BuyingRate { get; set; }
        public virtual ICollection<BuyingRateFixCost> BuyingRateFixCost { get; set; }
        public virtual ICollection<BuyingRateOthers> BuyingRateOthers { get; set; }
        public virtual ICollection<ConsolidationRate> ConsolidationRate { get; set; }
        public virtual ICollection<ContainerLoaded> ContainerLoaded { get; set; }
        public virtual ICollection<EcusJobApply> EcusJobApply { get; set; }
        public virtual ICollection<InvoiceReference> InvoiceReference { get; set; }
        public virtual ICollection<NACCS_MBL> NACCS_MBL { get; set; }
        public virtual ICollection<OPSManagement> OPSManagement { get; set; }
        public virtual ICollection<ProfitShareCalc> ProfitShareCalc { get; set; }
        public virtual ICollection<ShippingInstruction> ShippingInstruction { get; set; }
        public virtual ICollection<ShippingInstructionGoodsDetail> ShippingInstructionGoodsDetail { get; set; }
        public virtual ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
