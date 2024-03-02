using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class SendMails
    {
        public decimal IDKey { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string emailPassword { get; set; }
        public string sendusing { get; set; }
        public string smtpserver { get; set; }
        public string smtpserverport { get; set; }
        public bool? smtpusessl { get; set; }
        public string smtpauthenticate { get; set; }
        public string ReceiverTo { get; set; }
        public string ReceiverCC { get; set; }
        public string Subject { get; set; }
        public string HTMLBody { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool? MailSent { get; set; }
        public DateTime? MailSentDate { get; set; }
        public string JobNo { get; set; }
        public string IDKeyShipment { get; set; }
        public string Type { get; set; }
    }
}
