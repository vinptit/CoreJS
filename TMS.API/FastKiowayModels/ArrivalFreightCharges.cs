using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ArrivalFreightCharges
    {
        public string HawbNo { get; set; }
        public string Description { get; set; }
        public double? Qty { get; set; }
        public string Unit { get; set; }
        public double? TotalValue { get; set; }
        public string Curr { get; set; }
        public double? VAT { get; set; }
        public double? ExVND { get; set; }
        public string Notes { get; set; }
        public string AccsRefNo { get; set; }
        public bool? OBH { get; set; }
        public string OBHPartnerID { get; set; }
        public bool blnStick { get; set; }
        public bool blnShow { get; set; }
        public bool blnRoot { get; set; }
        public int? intIndex { get; set; }
        public int IDKey { get; set; }
        public bool? SynToRev { get; set; }

        public virtual HAWB HawbNoNavigation { get; set; }
    }
}
