using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class AccountingSys
    {
        public string AccountID { get; set; }
        public string Description { get; set; }
        public bool Credit { get; set; }
        public bool Debit { get; set; }
        public double? MinCredit { get; set; }
        public double? MaxCredit { get; set; }
        public string Notes { get; set; }
        public string Curr { get; set; }
        public string OrignalCurr { get; set; }
        public bool Asigned { get; set; }
        public string IcmID { get; set; }
        public bool? TaxAC { get; set; }
        public bool? DisableAC { get; set; }
        public string Code { get; set; }
        public string CompID { get; set; }
        public string MAPAC { get; set; }
        public string PartnerLocation { get; set; }
        public bool? NoDisplayTrialBL { get; set; }
        public string BKAccNo { get; set; }
        public bool? SynToTax { get; set; }
        public decimal? ExchangeRate { get; set; }

        public virtual AcsIncomeStatementAccount Icm { get; set; }
    }
}
