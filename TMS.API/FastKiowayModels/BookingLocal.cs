using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class BookingLocal
    {
        public string BkgID { get; set; }
        public string ContactID { get; set; }
        public string WhoisMakingID { get; set; }
        public string ServiceType { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateConfirm { get; set; }
        public string RealShipperID { get; set; }
        public string ShipperInBill { get; set; }
        public string Consignee { get; set; }
        public string RQRoutine { get; set; }
        public string POL { get; set; }
        public string POD { get; set; }
        public string Delivery { get; set; }
        public DateTime? RQLoadingDate { get; set; }
        public string RQFlight { get; set; }
        public DateTime? RQFlightDate { get; set; }
        public string RQCommodity { get; set; }
        public string DetailofGoods { get; set; }
        public string RQWeight { get; set; }
        public int? RQNoCarton { get; set; }
        public string Unit { get; set; }
        public double? CBM { get; set; }
        public string CBMDescription { get; set; }
        public double? GrossW { get; set; }
        public double? Chargeable { get; set; }
        public string MaskSeal { get; set; }
        public string ColoaderID { get; set; }
        public string AgentID { get; set; }
        public string PaymentMethod { get; set; }
        public string RQRate { get; set; }
        public string RQCustoms { get; set; }
        public string RQPickup { get; set; }
        public string CFFlight { get; set; }
        public string CFClosingTime { get; set; }
        public string CFMAWB { get; set; }
        public string CFHAWB { get; set; }
        public string CFRate { get; set; }
        public bool CFConfirm { get; set; }
        public bool RQRead { get; set; }
        public bool CFRead { get; set; }
        public bool BKWait { get; set; }
        public string ConformJobNo { get; set; }
        public string ConfirmHBL { get; set; }
        public string BookingConfirmID { get; set; }
        public string Note { get; set; }
        public string Attached { get; set; }
        public string ForwarderForm { get; set; }
        public DateTime? FowarderDate { get; set; }
        public string QuoNo { get; set; }
        public string QuoMode { get; set; }
        public string AgentSalesID { get; set; }
        public string CarrierBookingNo { get; set; }
        public bool? CancelBK { get; set; }
        public string CancelNote { get; set; }
        public DateTime? CancelDate { get; set; }
        public string PCNameRequester { get; set; }
        public bool? CancelAPP { get; set; }
        public string WhoisCancel { get; set; }
        public DateTime? CancelAPPDate { get; set; }
        public string PCName { get; set; }
        public string HistoryCLAPP { get; set; }
        public bool? ExportShipment { get; set; }
        public string LogisticsType { get; set; }
        public string CargoPickup { get; set; }
        public string CargoDelivery { get; set; }
        public string TransService { get; set; }
        public string ContQtyAP { get; set; }
        public string RQReturn { get; set; }
        public string SalesmanID { get; set; }
        public string ShipperID { get; set; }
        public string ConsigneeID { get; set; }
        public DateTime? ETD { get; set; }
        public DateTime? ETA { get; set; }
        public DateTime? DateSenttoForAPP { get; set; }
        public string TransitPOL { get; set; }
        public string TransitPOD { get; set; }
        public string ConnectFlightNo { get; set; }
        public DateTime? ConnectFlightDate { get; set; }
        public bool? SalesmanagerAPP { get; set; }
        public bool? SalesmanagerDenied { get; set; }
        public DateTime? SalesmanagerDateProcess { get; set; }
        public string Salesmanager { get; set; }
        public string Comments { get; set; }
        public string PONo { get; set; }
        public string DeliveryTerm { get; set; }

        public virtual HAWB ConfirmHBLNavigation { get; set; }
        public virtual Transactions ConformJobNoNavigation { get; set; }
    }
}
