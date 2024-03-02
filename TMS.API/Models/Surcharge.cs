using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class Surcharge
    {
        public int Id { get; set; }
        public int? TransactionId { get; set; }
        public int? HouseBillId { get; set; }
        public int? TypeId { get; set; }
        public int? SurchargeTypeId { get; set; }
        public int? Quantity { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? Vat { get; set; }
        public decimal? TotalPrice { get; set; }
        public string InvoiceNo { get; set; }
        public bool CLL { get; set; }
        public bool COB { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int? VendorId { get; set; }
        public int? CustomerId { get; set; }
    }
}
