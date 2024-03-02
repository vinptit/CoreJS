using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class RouteOnHBL
    {
        public int Id { get; set; }
        public int? HBLId { get; set; }
        public int? POL { get; set; }
        public DateTime? ETD { get; set; }
        public string Vessel { get; set; }
        public string Voy { get; set; }
        public int? POD { get; set; }
        public DateTime? ETA { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int? TransId { get; set; }

        public virtual HBL HBL { get; set; }
        public virtual Transaction Trans { get; set; }
    }
}
