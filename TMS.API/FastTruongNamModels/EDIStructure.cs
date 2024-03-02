using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class EDIStructure
    {
        public EDIStructure()
        {
            EDIStructureDT = new HashSet<EDIStructureDT>();
        }

        public string EDIID { get; set; }
        public string EDIName { get; set; }
        public string sVersion { get; set; }
        public string SqlStatement { get; set; }
        public string FormName { get; set; }
        public string FileExt { get; set; }
        public bool? Deactive { get; set; }
        public bool? AMS { get; set; }
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public bool? Sendftp { get; set; }
        public string FtpType { get; set; }
        public string URLWS { get; set; }
        public string SOAActionURLWS { get; set; }
        public string UsernameWS { get; set; }
        public string PwdWS { get; set; }
        public string sqlARG { get; set; }
        public bool? NoAddIfFieldsEmpty { get; set; }
        public string AgentID { get; set; }

        public virtual ICollection<EDIStructureDT> EDIStructureDT { get; set; }
    }
}
