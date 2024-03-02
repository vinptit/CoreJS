using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class AccsIncomeStatement
    {
        public AccsIncomeStatement()
        {
            AcsIncomeStatementDetail = new HashSet<AcsIncomeStatementDetail>();
        }

        public string PMID { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModify { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Notes { get; set; }
        public string WhoisIssued { get; set; }

        public virtual ContactsList WhoisIssuedNavigation { get; set; }
        public virtual ICollection<AcsIncomeStatementDetail> AcsIncomeStatementDetail { get; set; }
    }
}
