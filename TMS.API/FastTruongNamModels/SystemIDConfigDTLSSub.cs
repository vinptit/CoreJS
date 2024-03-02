using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class SystemIDConfigDTLSSub
    {
        public string ID { get; set; }
        public string Description { get; set; }
        public string ParentMode { get; set; }
        public string ContactList { get; set; }
        public bool Activate { get; set; }
    }
}
