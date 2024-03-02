using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class SMTPServerConfig
    {
        public decimal ID { get; set; }
        public string SMTPServer { get; set; }
        public int? SMTPPort { get; set; }
        public string SMTPUserName { get; set; }
        public string SMTPPassword { get; set; }
        public string EmailSendTest { get; set; }
        public bool? isUseSSL { get; set; }
    }
}
