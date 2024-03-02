using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class PartnerTransactionsAttachedFiles
    {
        public string FieldKey { get; set; }
        public string FieldKeyLinked { get; set; }
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
