using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class TransactionInfo
    {
        public string HAWBNO { get; set; }
        public string Description { get; set; }
        public string DescriptionDisplay { get; set; }
        public string DateModified { get; set; }
        public DateTime? InfoDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public string Notes { get; set; }
        public bool JobDone { get; set; }
        public string Evaluation { get; set; }
        public string AttachedChecked { get; set; }
        public string Attached { get; set; }
        public string WhoisMaking { get; set; }
        public string OPStaffID { get; set; }
        public DateTime? JSSentDate { get; set; }
        public DateTime? DateModifiedDT { get; set; }
        public DateTime? ACTFinishDate { get; set; }
        public DateTime? EvaluationDate { get; set; }
        public string Object { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual HAWB HAWBNONavigation { get; set; }
    }
}
