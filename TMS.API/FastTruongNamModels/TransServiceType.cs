using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class TransServiceType
    {
        public string ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string TransTypeID { get; set; }
        public bool? ExportShmt { get; set; }
        public int? TIndex { get; set; }
    }
}
