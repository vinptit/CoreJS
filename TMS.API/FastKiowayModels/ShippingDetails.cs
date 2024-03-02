using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ShippingDetails
    {
        public int IDKey { get; set; }
        public DateTime? SDDate { get; set; }
        public string Origin { get; set; }
        public string POL { get; set; }
        public string Destination { get; set; }
        public string POD { get; set; }
        public string Mode { get; set; }
        public string Terms { get; set; }
        public string Volume { get; set; }
        public string Desription { get; set; }
        public string Notes { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string UserInput { get; set; }
        public string PartnerID { get; set; }
        public string Attached { get; set; }
        public string Commodity { get; set; }
        public string Category { get; set; }
        public string EstimateGP { get; set; }
        public bool? Activate { get; set; }
    }
}
