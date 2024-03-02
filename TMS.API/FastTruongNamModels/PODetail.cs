using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class PODetail
    {
        public decimal IDKey { get; set; }
        public string PONumber { get; set; }
        public string ItemCode { get; set; }
        public string HSCode { get; set; }
        public string Description { get; set; }
        public double? Quantity { get; set; }
        public string QTYUnit { get; set; }
        public double? UnitPrice { get; set; }
        public string Curr { get; set; }
        public DateTime? ProductionDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string PlaceOfDelivery { get; set; }
        public string VendorCode { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? IIndex { get; set; }

        public virtual POList PONumberNavigation { get; set; }
        public virtual Partners VendorCodeNavigation { get; set; }
    }
}
