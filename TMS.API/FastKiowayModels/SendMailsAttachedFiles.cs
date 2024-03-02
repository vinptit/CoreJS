using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class SendMailsAttachedFiles
    {
        public decimal IDKey { get; set; }
        public decimal? IDKeyLinked { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string FileExt { get; set; }
        public byte[] FileContent { get; set; }
    }
}
