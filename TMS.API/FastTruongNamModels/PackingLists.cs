using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class PackingLists
    {
        public string PackingNo { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? ShipmentDate { get; set; }
        /// <summary>
        /// Packing List (Name &amp; Address)
        /// </summary>
        public string SellerName { get; set; }
        public string SellerAddress { get; set; }
        /// <summary>
        /// Packing List (Name &amp; Address)
        /// </summary>
        public string BuyerName { get; set; }
        public string BuylerAddress { get; set; }
        public string Commodity { get; set; }
        public string OrderNo { get; set; }
        public string ContainerNo { get; set; }
        /// <summary>
        /// Bill of Lading (House)
        /// </summary>
        public string HWBNO { get; set; }
        public string ShippingMark { get; set; }
        public string Notes { get; set; }
        public double? GrossWeight { get; set; }
        public double? CBM { get; set; }
        public string SayGroup { get; set; }
        public string FlightDateConfirm { get; set; }
    }
}
