using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class AcsIncomstatementConfig
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string AcsCode { get; set; }
        public string Expression { get; set; }
        public string AccountRef { get; set; }
        public string ExAccountRef { get; set; }
        public string AcsFormular { get; set; }
        public bool? Debt { get; set; }
        public bool? CreditBL { get; set; }
        public bool? DebitBL { get; set; }
        public bool? MinusAC { get; set; }
        public int? SubID { get; set; }
        public bool? Activate { get; set; }
        public bool? Bold { get; set; }
        public bool? Root { get; set; }
        public string UserInput { get; set; }
        public string CompID { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public int? iIndex { get; set; }
        public int? TotalIndex { get; set; }
        public string DescriptionEN { get; set; }
        public string Cond1 { get; set; }
        public string Cond2 { get; set; }
        public string Cond3 { get; set; }
        public string FormName { get; set; }
        public bool? HideR { get; set; }
    }
}
