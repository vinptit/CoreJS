using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class BookingReQuestList
    {
        public string TransID { get; set; }
        public DateTime? TransDate { get; set; }
        /// <summary>
        /// ETD
        /// </summary>
        public DateTime? LoadingDate { get; set; }
        public DateTime? FlightScheduleRequest { get; set; }
        /// <summary>
        /// Service provider
        /// </summary>
        public string ColoaderID { get; set; }
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
        /// <summary>
        /// Volume if it is Express
        /// </summary>
        public double? Dimension { get; set; }
        public string RateRequest { get; set; }
        public string PaymentTerm { get; set; }
        public string BookingRequestNotes { get; set; }
        public string WhoisMaking { get; set; }
        public string PortofLading { get; set; }
        public string PortofUnlading { get; set; }
        public string NatureofGoods { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public string OfficerContact { get; set; }
        public string JobNo { get; set; }

        public virtual Partners Coloader { get; set; }
    }
}
