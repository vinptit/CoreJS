using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class SurchargeType
    {
        public int Id { get; set; }
        public int? CurrencyId { get; set; }
        public string Name { get; set; }
        public decimal Vat { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? PriceTypeId { get; set; }
        public bool CollectOnBehalf { get; set; }
        public bool CountToPrice { get; set; }
        public bool IsPayable { get; set; }
        public bool? IsPin { get; set; }
        public int? GroupId { get; set; }
        public int? PinId { get; set; }
    }
}
