using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class NOTIFICATIONS
    {
        public decimal ID { get; set; }
        public decimal TASKID { get; set; }
        public decimal IDKEYSHIPMENT { get; set; }
        public string CREATEDBY { get; set; }
        public DateTime? CREATEDON { get; set; }
        public string SENDTO { get; set; }
        public string TYPE { get; set; }
        public int STATUS { get; set; }
        public string DESCRIPTIONS { get; set; }
        public DateTime? READON { get; set; }
        public DateTime? REJECTEDON { get; set; }
        public DateTime? ACCEPTEDON { get; set; }
    }
}
