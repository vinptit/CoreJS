using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class TransactionLog
    {
        public string TransLogID { get; set; }
        public string TransID { get; set; }
        public DateTime? DateKey { get; set; }
        public string ChangeValue { get; set; }
        public string Whois { get; set; }
        public string LogFile { get; set; }
    }
}
