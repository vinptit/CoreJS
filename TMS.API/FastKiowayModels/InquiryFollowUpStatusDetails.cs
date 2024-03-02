using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class InquiryFollowUpStatusDetails
    {
        public int IDKey { get; set; }
        public int? LinkedIDKey { get; set; }
        public string KeyName { get; set; }
        public string sqlStatement { get; set; }
    }
}
