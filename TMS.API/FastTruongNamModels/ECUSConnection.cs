using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ECUSConnection
    {
        public int IDKey { get; set; }
        public string Username { get; set; }
        public string ServerName { get; set; }
        public string DBUsername { get; set; }
        public string DBPassword { get; set; }
        public string DBName { get; set; }
        public bool? ActivateDB { get; set; }
        public DateTime? DateApply { get; set; }
        public string CategoryID { get; set; }

        public virtual EcusCategory Category { get; set; }
        public virtual ContactsList UsernameNavigation { get; set; }
    }
}
