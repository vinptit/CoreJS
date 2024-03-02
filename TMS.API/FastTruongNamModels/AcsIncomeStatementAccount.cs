using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class AcsIncomeStatementAccount
    {
        public AcsIncomeStatementAccount()
        {
            AccountingSys = new HashSet<AccountingSys>();
            AcsIncomeStatementDetail = new HashSet<AcsIncomeStatementDetail>();
        }

        public string IncmstID { get; set; }
        public string ItemDes { get; set; }

        public virtual ICollection<AccountingSys> AccountingSys { get; set; }
        public virtual ICollection<AcsIncomeStatementDetail> AcsIncomeStatementDetail { get; set; }
    }
}
