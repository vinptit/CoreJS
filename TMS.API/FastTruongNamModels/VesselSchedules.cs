using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class VesselSchedules
    {
        public int IDKey { get; set; }
        public string PartnerID { get; set; }
        public string POLC { get; set; }
        public string ETD { get; set; }
        public string PODC { get; set; }
        public string ETAPOP { get; set; }
        public string ETDDest { get; set; }
        public string DestC { get; set; }
        public string ETADest { get; set; }
        public string VesselName { get; set; }
        public string VoyageNo { get; set; }
        public string Notes { get; set; }
        public bool? Activate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ServiceType { get; set; }
        public string UserInput { get; set; }
        public string ServiceID { get; set; }
        public string CargoCutoff { get; set; }
        public string DOCCutoff { get; set; }
        public string StuffingPlace { get; set; }
        public string TransitTime { get; set; }
    }
}
