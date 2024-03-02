using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class MailSendingMsg
    {
        public decimal IDKey { get; set; }
        public string Username { get; set; }
        public string MailMode { get; set; }
        public string MailSubject { get; set; }
        public string MailBody { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
