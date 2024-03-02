using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class EcusJobApply
    {
        public decimal IDKey { get; set; }
        public decimal DToKhaiMDID { get; set; }
        public DateTime? NgayApply { get; set; }
        public string UserApply { get; set; }
        public string PCApply { get; set; }
        public string TransID { get; set; }
        public string DBName { get; set; }
        public string ServerName { get; set; }
        public string BookingNo { get; set; }
        public string VoidTransID { get; set; }

        public virtual Transactions Trans { get; set; }
    }
}
