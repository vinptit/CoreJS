using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ACExchangeRate
    {
        public ACExchangeRate()
        {
            ACCurrencyExchangeRate = new HashSet<ACCurrencyExchangeRate>();
        }

        public string ID { get; set; }
        public string Description { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Notes { get; set; }
        public string Username { get; set; }
        public string CompIDList { get; set; }
        public string CompID { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual ICollection<ACCurrencyExchangeRate> ACCurrencyExchangeRate { get; set; }
    }
}
