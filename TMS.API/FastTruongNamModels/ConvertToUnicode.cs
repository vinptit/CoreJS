using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ConvertToUnicode
    {
        public decimal ID { get; set; }
        public bool? isUseDefaultConvert { get; set; }
        public string FromCode { get; set; }
        public string ToCode { get; set; }
        public string HostName { get; set; }
        public string IPAddress { get; set; }
        public string WhoSync { get; set; }
        public DateTime? DateSync { get; set; }
    }
}
