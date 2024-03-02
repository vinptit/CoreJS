using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class AdvancePaymentRequestAttachedFiles
    {
        public string FieldKey { get; set; }
        public string AdvNo { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string FileExt { get; set; }
        public byte[] FileContent { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModify { get; set; }
        public string UserEdit { get; set; }
        public string UpdateHistory { get; set; }
    }
}
