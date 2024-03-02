using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class InttraCheckStatusHistory
    {
        public decimal IDKey { get; set; }
        public string RefNo { get; set; }
        public string ServiceName { get; set; }
        public string FileName { get; set; }
        public string PCName { get; set; }
        public string UserChecked { get; set; }
        public DateTime? DateChecked { get; set; }
        public byte[] FileContent { get; set; }
    }
}
