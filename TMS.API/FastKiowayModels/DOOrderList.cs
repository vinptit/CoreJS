using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class DOOrderList
    {
        public DOOrderList()
        {
            DOOrderDetail = new HashSet<DOOrderDetail>();
        }

        public string OrderID { get; set; }
        public string ContactID { get; set; }
        public string Managed { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Payment { get; set; }
        public string Notes { get; set; }
        public bool Lock { get; set; }

        public virtual ICollection<DOOrderDetail> DOOrderDetail { get; set; }
    }
}
