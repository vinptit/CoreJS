using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class VehicleAlerterHistory
    {
        public decimal ID { get; set; }
        public string maxFkey { get; set; }
        public string VehicleNo { get; set; }
        public string AlerterTypeId { get; set; }
        public DateTime? DeadLine { get; set; }
        public int? AlertedDay { get; set; }
        public string ContactID { get; set; }
        public DateTime? CREATEDON { get; set; }
        public string CREATEDBY { get; set; }
        public bool ISFINISHED { get; set; }
        public DateTime? MODIFIEDON { get; set; }
        public string MODIFIEDBY { get; set; }
        public DateTime? FINISHEDON { get; set; }
    }
}
