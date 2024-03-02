using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ProfitShareCalc
    {
        public ProfitShareCalc()
        {
            ProfitShareCalcDetail = new HashSet<ProfitShareCalcDetail>();
        }

        public string RefNo { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string TransID { get; set; }
        public string HBLList { get; set; }
        public string PartnerID { get; set; }
        public string ProfitShareDesc { get; set; }
        public double? PercentMode { get; set; }
        public double? ShareAmountOnly { get; set; }
        public string Curr { get; set; }
        public string AccountRef { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? Modify { get; set; }
        public string Creator { get; set; }
        public decimal IDKeyIndex { get; set; }

        public virtual Partners Partner { get; set; }
        public virtual Transactions Trans { get; set; }
        public virtual ICollection<ProfitShareCalcDetail> ProfitShareCalcDetail { get; set; }
    }
}
