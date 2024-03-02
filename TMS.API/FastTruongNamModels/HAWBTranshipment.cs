using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class HAWBTranshipment
    {
        public decimal IDKey { get; set; }
        public string HAWBNo { get; set; }
        public string InvoiceNo { get; set; }
        public string TruckNo { get; set; }
        public string ContainerNo { get; set; }
        public string SealNo { get; set; }
        public DateTime? DepartureDate { get; set; }
        public string DepartureFrom { get; set; }
        public string OnCarriageTo { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string ReceivedBy { get; set; }
        public int? iIndex { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public double? InvoiceAMT { get; set; }
        public string InvoiceCurr { get; set; }
        public string PONumber { get; set; }
        public string LONumber { get; set; }
        public decimal? Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public double? GW { get; set; }
        public double? CBM { get; set; }
        public string StyleNumber { get; set; }
        public string Campaign { get; set; }
        public string ContainerStuffing { get; set; }
        public string Units { get; set; }
        public string ChargeMode { get; set; }

        public virtual HAWB HAWBNoNavigation { get; set; }
    }
}
