using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ActiveUsers
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public DateTime? Onlinedate { get; set; }
        public DateTime? Offlinedate { get; set; }
        public bool Active { get; set; }
        public string ComputerName { get; set; }
        public string IPAddress { get; set; }
        public string Notes { get; set; }
        public DateTime? AppRevision { get; set; }
        public string AppPath { get; set; }
        public string ProcessID { get; set; }
        public string TOKEN { get; set; }
        public string CONTACTID { get; set; }
        public string PARTNERID { get; set; }
        public string VEHICLENO { get; set; }
        public bool? EXPIRATION { get; set; }
        public DateTime? EXPIRATEDDATE { get; set; }
    }
}
