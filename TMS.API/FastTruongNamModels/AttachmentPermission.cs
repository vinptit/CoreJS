using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class AttachmentPermission
    {
        public decimal IDKey { get; set; }
        public string IDRestrict { get; set; }
        public string InputedUser { get; set; }
        public string ContactIDVisible { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string TableSource { get; set; }
        public string KeyFieldValue { get; set; }
        public int? LIndex { get; set; }
    }
}
