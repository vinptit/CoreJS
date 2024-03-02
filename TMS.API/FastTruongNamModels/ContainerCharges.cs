using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ContainerCharges
    {
        public int IDKey { get; set; }
        public int? IDLinked { get; set; }
        public string ContainerNo { get; set; }
        public string ChargeCode { get; set; }
        public string Description { get; set; }
        public double? AmountCost { get; set; }
        public double? VATCost { get; set; }
        public string InvoiceNo { get; set; }
        public string ContactIDRequest { get; set; }
        public DateTime? DateRequest { get; set; }
        public string ContactIDApp { get; set; }
        public DateTime? DateApp { get; set; }
        public string PartnerPayeeID { get; set; }
        public double? AmountRev { get; set; }
        public double? VATRev { get; set; }
        public string PayerID { get; set; }
        public string Curr { get; set; }
        public double? VNDExRate { get; set; }
        public string RevInvoiceNo { get; set; }
        public string Notes { get; set; }
        public string UserEdit { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? IIndex { get; set; }
    }
}
