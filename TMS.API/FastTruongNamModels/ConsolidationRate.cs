using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ConsolidationRate
    {
        public string TransID { get; set; }
        public string HBL { get; set; }
        public string PartnerID { get; set; }
        public double? FirstDest { get; set; }
        public double? Inland { get; set; }
        public double? SOF { get; set; }
        public double? SAMS { get; set; }
        public double? SHandling { get; set; }
        public double? STHC { get; set; }
        public double? SExamfee { get; set; }
        public double? SPierPass { get; set; }
        public double? DDC { get; set; }
        public double? Devanning { get; set; }
        public double? CHandle { get; set; }
        public double? CCom { get; set; }

        public virtual Transactions Trans { get; set; }
    }
}
