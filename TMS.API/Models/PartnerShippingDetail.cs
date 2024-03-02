using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class PartnerShippingDetail
    {
        public int Id { get; set; }
        public int? PartnerID { get; set; }
        public DateTime? Date { get; set; }
        public string Origin { get; set; }
        public string POL { get; set; }
        public string Destination { get; set; }
        public string POD { get; set; }
        public string Mode { get; set; }
        public string Terms { get; set; }
        public string Volume { get; set; }
        public string Description { get; set; }
        public string Commodity { get; set; }
        public string Category { get; set; }
        public string GrossProfit { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Partners Partner { get; set; }
    }
}
