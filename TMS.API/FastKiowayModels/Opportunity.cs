using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class Opportunity
    {
        public int IDKey { get; set; }
        public DateTime? OPDate { get; set; }
        public string OPName { get; set; }
        public string Company { get; set; }
        public string Pic { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public double? ExpREV { get; set; }
        public double? ExpGP { get; set; }
        public string AsignedtoGroup { get; set; }
        public string AsignedtoUser { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string UserInput { get; set; }
        public string PartnerID { get; set; }
        public string Attached { get; set; }
    }
}
