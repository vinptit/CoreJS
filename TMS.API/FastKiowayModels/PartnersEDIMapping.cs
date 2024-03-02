using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class PartnersEDIMapping
    {
        public decimal IDKey { get; set; }
        public string EDIPartnerName { get; set; }
        public string EDIPartnerID { get; set; }
        public string PartnerIDMapped { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
