using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ContactPartnerObligation
    {
        public int IDKeyIndex { get; set; }
        public string PartnerID { get; set; }
        public string ContactID { get; set; }
        public bool SalesHandle { get; set; }
        public string UserInput { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
