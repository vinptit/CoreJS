using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class AcsIncomeStatementDetail
    {
        public string PMID { get; set; }
        public int ID { get; set; }
        public string ItemDes { get; set; }
        public double? TTAmount { get; set; }
        public double? Including { get; set; }
        public string FormularDes { get; set; }
        public string RefNo { get; set; }
        public string CodeDes { get; set; }
        public string Notes { get; set; }
        public int? TagID { get; set; }

        public virtual AccsIncomeStatement PM { get; set; }
        public virtual AcsIncomeStatementAccount RefNoNavigation { get; set; }
    }
}
