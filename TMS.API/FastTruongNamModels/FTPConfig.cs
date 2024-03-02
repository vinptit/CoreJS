using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class FTPConfig
    {
        public Guid ID { get; set; }
        public string FTPSource { get; set; }
        public string FTPURL { get; set; }
        public string FTPPort { get; set; }
        public string FTPUserName { get; set; }
        public string FTPPassword { get; set; }
        public string FolderUpload { get; set; }
        public bool? isAutoUpload { get; set; }
        public string FolderResult { get; set; }
        public bool? isAutoDownload { get; set; }
        public string PrivateKeyContent { get; set; }
        public bool? isHavePrivateKey { get; set; }
        public bool? isActive { get; set; }
        public string FtpUploadOthersDir { get; set; }
        public string BundleCode { get; set; }
    }
}
