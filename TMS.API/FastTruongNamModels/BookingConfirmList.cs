using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class BookingConfirmList
    {
        public string TransID { get; set; }
        public DateTime? TransDate { get; set; }
        /// <summary>
        /// ETD
        /// </summary>
        public DateTime? LoadingDate { get; set; }
        public string PortofLading { get; set; }
        public string PortofUnlading { get; set; }
        public string FlightNoCfrm { get; set; }
        public DateTime? FlightScheduleConfirm { get; set; }
        public DateTime? ETA { get; set; }
        public string AOL2 { get; set; }
        public string AOD2 { get; set; }
        public string FlightNoCfrm2 { get; set; }
        public DateTime? FlightScheduleConfirm2 { get; set; }
        public DateTime? ETA2 { get; set; }
        public string AOL3 { get; set; }
        public string AOD3 { get; set; }
        public string FlightNoCfrm3 { get; set; }
        public DateTime? FlightScheduleConfirm3 { get; set; }
        public DateTime? ETA3 { get; set; }
        public string AOL4 { get; set; }
        public string AOD4 { get; set; }
        public string FlightNoCfrm4 { get; set; }
        public DateTime? FlightScheduleConfirm4 { get; set; }
        public DateTime? ETA4 { get; set; }
        public string AOL5 { get; set; }
        public string AOD5 { get; set; }
        public string FlightNoCfrm5 { get; set; }
        public DateTime? FlightScheduleConfirm5 { get; set; }
        public DateTime? ETA5 { get; set; }
        public string FinalDestination { get; set; }
        public string ClosingTime { get; set; }
        /// <summary>
        /// Service provider
        /// </summary>
        public string ShipperID { get; set; }
        public string Attn { get; set; }
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
        public string RateConfirm { get; set; }
        public string PaymentTerm { get; set; }
        public string BookingConfirmNotes { get; set; }
        public string WhoisMaking { get; set; }
        public string NatureofGoods { get; set; }
        public string HAWBNo { get; set; }
        public string MAWBNo { get; set; }
        public string ContactID { get; set; }
        public DateTime? DateSend { get; set; }
        public string RefID { get; set; }
        public bool Decline { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public string OfficerContact { get; set; }
        public string StuffingPlace { get; set; }
        public bool? PickupRequired { get; set; }
        public string ServiceRequired { get; set; }

        public virtual Partners Shipper { get; set; }
    }
}
