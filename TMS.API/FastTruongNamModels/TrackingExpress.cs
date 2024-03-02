using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class TrackingExpress
    {
        public decimal KeyIDTC { get; set; }
        public string HAWB { get; set; }
        public string TransactionID { get; set; }
        public DateTime? Date { get; set; }
        public string Time { get; set; }
        public string Carrier { get; set; }
        public string FlightNo { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string Departure { get; set; }
        public string ArrivalDate { get; set; }
        public string ArrivalTime { get; set; }
        public string Pieces { get; set; }
        public string Weight { get; set; }
        public string TM { get; set; }
        public bool Delivered { get; set; }
        public int? IIndex { get; set; }
    }
}
