using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class RateHistory
    {
        public string RefID { get; set; }
        public string HBLNo { get; set; }
        public string TableName { get; set; }
        public string DescKey { get; set; }
        public string PartnerKey { get; set; }
        public bool DptKey { get; set; }
        public string Description { get; set; }
        public string PartnerID { get; set; }
        public bool Dpt { get; set; }
        public double? Quantity { get; set; }
        public string Unit { get; set; }
        public double? UnitPrice { get; set; }
        public string Curr { get; set; }
        public double? VAT { get; set; }
        public double? Amount { get; set; }
        public string Notes { get; set; }
        public string Reason { get; set; }
        public bool Sent { get; set; }
        public DateTime? DateSent { get; set; }
        public bool Approved { get; set; }
        public string OBHPartnerID { get; set; }
        public bool Deny { get; set; }
        public DateTime? DateProcess { get; set; }
        public string ExeptionInfo { get; set; }
        public string UserInfo { get; set; }
        public string Admin { get; set; }
        public bool? GWHeavyW { get; set; }
        public string KeyfieldData { get; set; }
        public double? ACExRate { get; set; }
        public string DataSource { get; set; }
    }
}
