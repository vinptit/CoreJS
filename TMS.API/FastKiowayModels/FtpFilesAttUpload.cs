using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class FtpFilesAttUpload
    {
        public int IDKey { get; set; }
        public decimal? IDLinked { get; set; }
        public string FileType { get; set; }
        public string FileDescription { get; set; }
        public string FileName { get; set; }
        public string FileExt { get; set; }
        public string FileSource { get; set; }
        public string UploadDir { get; set; }
        public string XMLFileName { get; set; }
    }
}
