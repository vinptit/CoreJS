using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ToKhaiThue
    {
        public decimal ID { get; set; }
        public string IDInvoice { get; set; }
        public string ToKhai { get; set; }
        public string LoaiThue { get; set; }
        public string Ky { get; set; }
        public string Thang { get; set; }
        public string Nam { get; set; }
        public bool? isToKhaiQuy { get; set; }
        public string HostName { get; set; }
        public string IPAddress { get; set; }
        public string WhoCreate { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
