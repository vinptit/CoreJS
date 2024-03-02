using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class OtherSurcharge
    {
        public int Id { get; set; }
        public int? HBLId { get; set; }
        public int? TransId { get; set; }
        public int? Payer { get; set; }
        public int? ChargeName { get; set; }
        public int? Quantity { get; set; }
        public int? Unit { get; set; }
        public int? UnitPrice { get; set; }
        public int? Currency { get; set; }
        public int? Vat { get; set; }
        public int? Base { get; set; }
        public int? Total { get; set; }
        public bool? NoINV { get; set; }
        public bool? KB { get; set; }
        public int? OBH { get; set; }
        public int? ChargeCode { get; set; }
        public string Notes { get; set; }
        public bool? Debit { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Transaction Trans { get; set; }
    }
}
