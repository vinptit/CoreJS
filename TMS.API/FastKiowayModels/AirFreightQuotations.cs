using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class AirFreightQuotations
    {
        public AirFreightQuotations()
        {
            AirFreightQuotationDetails = new HashSet<AirFreightQuotationDetails>();
        }

        public string QuoID { get; set; }
        public string ContactID { get; set; }
        public DateTime? QuoDate { get; set; }
        public string Routine { get; set; }
        public string LCLRate { get; set; }
        public string AMS { get; set; }
        public string Notes { get; set; }
        public bool Validation { get; set; }
        public string ValidationText { get; set; }

        public virtual Partners Contact { get; set; }
        public virtual ICollection<AirFreightQuotationDetails> AirFreightQuotationDetails { get; set; }
    }
}
