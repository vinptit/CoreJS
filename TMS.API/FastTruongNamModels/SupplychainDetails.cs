using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class SupplychainDetails
    {
        public int IDKey { get; set; }
        public DateTime? SCDate { get; set; }
        public string Service { get; set; }
        public string Description { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string UserInput { get; set; }
        public string PartnerID { get; set; }
        public string Attached { get; set; }
        public string Incoterm { get; set; }
        public bool? Trucking { get; set; }
        public bool? Customs { get; set; }
        public bool? Insurance { get; set; }
        public string InsuranceDes { get; set; }
        public string Others { get; set; }
        public bool? Activate { get; set; }
    }
}
