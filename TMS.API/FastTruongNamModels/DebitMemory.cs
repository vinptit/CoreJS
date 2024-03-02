using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class DebitMemory
    {
        public string DebitID { get; set; }
        public string SqlStatement { get; set; }
        public string Descriptions { get; set; }
        public double? FormerlyBalance { get; set; }
        public string VatPer { get; set; }
        public double? VAT { get; set; }
        public double? GrandTotal { get; set; }
        public string GrandTotalStr { get; set; }
        public string USDSayWord { get; set; }
        public string CurrencyRate { get; set; }
        public DateTime? DateUpto { get; set; }
        public string Notes { get; set; }
        public string TotalDebit { get; set; }
        public string TotalCredit { get; set; }
        public string TotalCreditDue { get; set; }
    }
}
