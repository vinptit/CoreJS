using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class FTPProcess
    {
        public decimal IDKey { get; set; }
        public string RefNo { get; set; }
        public string FileName { get; set; }
        public byte[] FileContent { get; set; }
        public DateTime? DateCreated { get; set; }
        public string FTPSource { get; set; }
        public string UserSent { get; set; }
        public string PCName { get; set; }
        public bool? FTPSent { get; set; }
        public DateTime? FTPSentDate { get; set; }
        public string FTPURL { get; set; }
        public string FTPUserName { get; set; }
        public string FTPPwd { get; set; }
        public string FTPDir { get; set; }
        public string FTPStatus { get; set; }
        public string FTPCheckStatusDir { get; set; }
        public string FtpUploadOthersDir { get; set; }
        public string BundleCode { get; set; }
    }
}
