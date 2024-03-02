using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class PriceCenters
    {
        public PriceCenters()
        {
            PriceCenterDetails = new HashSet<PriceCenterDetails>();
        }

        public string PriceID { get; set; }
        public string ColoaderID { get; set; }
        public string ServiceMode { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? ValidDate { get; set; }
        public string AdditionalNote { get; set; }
        public string Currency { get; set; }
        public bool Ativate { get; set; }
        public bool Publics { get; set; }
        public bool SEA { get; set; }
        public bool Air { get; set; }
        public double? SCAddon { get; set; }
        public double? VATAdd { get; set; }
        public bool Express { get; set; }
        public DateTime? DateCreate { get; set; }
        public string IssueBy { get; set; }

        public virtual Partners Coloader { get; set; }
        public virtual ICollection<PriceCenterDetails> PriceCenterDetails { get; set; }
    }
}
