using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class AdvancePaymentRequestDetails
    {
        public int IDKey { get; set; }
        public string AdvID { get; set; }
        public string Description { get; set; }
        public string JobNo { get; set; }
        public string HBLNo { get; set; }
        public double? Amount { get; set; }
        public string Currency { get; set; }
        public double? ExchangeRate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string InvoiceNo { get; set; }
        public string Notes { get; set; }
        public bool? Norm { get; set; }
        public bool? Validfee { get; set; }
        public bool? Others { get; set; }
        public bool? CSApp { get; set; }
        public bool? CSDecline { get; set; }
        public string CSUser { get; set; }
        public DateTime? CSAppDate { get; set; }
        public int? iIndex { get; set; }
        public string FeeCode { get; set; }
        public string NormSource { get; set; }

        public virtual AdvancePaymentRequest Adv { get; set; }
    }
}
