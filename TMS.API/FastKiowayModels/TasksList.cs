using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class TasksList
    {
        public int ID { get; set; }
        public string Whois { get; set; }
        public string UserName { get; set; }
        public string IDPost { get; set; }
        public DateTime? DatePost { get; set; }
        public string SqlStatement { get; set; }
        public bool CheckRead { get; set; }
        public bool Previewed { get; set; }
        public bool Decline { get; set; }
        public DateTime? DateRead { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
    }
}
