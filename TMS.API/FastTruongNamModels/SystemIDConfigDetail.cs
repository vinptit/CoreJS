using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class SystemIDConfigDetail
    {
        public string ID { get; set; }
        public string FieldName { get; set; }
        public string CompID { get; set; }
        public string Contents { get; set; }
        public string UserName { get; set; }
        public string Notes { get; set; }

        public virtual SystemIDConfig IDNavigation { get; set; }
    }
}
