using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class CargoOperationRequestDetail
    {
        public string RequestNo { get; set; }
        public decimal IDKey { get; set; }
        public int? CQty { get; set; }
        public string CType { get; set; }
        public string ContainerNo { get; set; }
        public int? PKGS { get; set; }
        public string PKGSUnit { get; set; }
        public double? KGS { get; set; }
        public double? CBM { get; set; }
        public string ReceiptPlace { get; set; }
        public string DeliveryPlace { get; set; }
        public string EmptyReturnORPickup { get; set; }
        public string Deadline { get; set; }
        public string PIC { get; set; }
        public string BKNo { get; set; }
        public string Notes { get; set; }
        public string UserKey { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? LIndex { get; set; }

        public virtual CargoOperationRequest RequestNoNavigation { get; set; }
    }
}
