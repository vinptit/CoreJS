using System.Collections.Generic;

namespace TMS.API.ViewModels
{
    public class ImportChargeVM
    {
        public string Job { get; set; }
        public string PartnerID { get; set; }
        public string HBL { get; set; }
        public string Description { get; set; }
        public string Quantity { get; set; }
        public string Unit { get; set; }
        public string UnitPrice { get; set; }
        public string Currency { get; set; }
        public string ExtRate { get; set; }
        public string VAT { get; set; }
        public string Total { get; set; }
        public string Docs { get; set; }
        public string FeeCode { get; set; }
        public string OBHPartnerID { get; set; }
        public string TYPE { get; set; }
        public int Status { get; set; }
        public string StatusFeeText { get; set; }

    }
}
