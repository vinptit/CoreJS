using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class AdvanceSettlementPayment
    {
        public decimal IDKeyField { get; set; }
        public string AvNo { get; set; }
        public int No { get; set; }
        public string CustomsID { get; set; }
        public string PartnerID { get; set; }
        public string JobID { get; set; }
        public string HBL { get; set; }
        public string Description { get; set; }
        public string TableName { get; set; }
        public string InvoiceNo { get; set; }
        public string Series { get; set; }
        public string InvoiceID { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public double? Quantity { get; set; }
        public string UnitQty { get; set; }
        public double? BFVATAmount { get; set; }
        public double? Amount { get; set; }
        public double? VAT { get; set; }
        public bool Debt { get; set; }
        public double? DFAmount { get; set; }
        public string Currency { get; set; }
        public string Note { get; set; }
        public string AccountNo { get; set; }
        public bool? CSApp { get; set; }
        public bool? CSDecline { get; set; }
        public string CSUser { get; set; }
        public DateTime? CSAppDate { get; set; }
        public string CLLPartnerID { get; set; }
        public string RowsIndexLinked { get; set; }
        public bool? FixCode { get; set; }
        public bool? ExcludePM { get; set; }
        public string FieldKey { get; set; }
        public string INVLink { get; set; }
        public double? BUDGET { get; set; }

        public virtual AcsSetlementPayment AvNoNavigation { get; set; }
        public virtual HAWB HBLNavigation { get; set; }
        public virtual Transactions Job { get; set; }
    }
}
