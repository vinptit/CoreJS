using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ContainerFreightCharges
    {
        public int IDSelf { get; set; }
        public int? IDKey { get; set; }
        public string FreightCharges { get; set; }
        public double? Amount { get; set; }
        public string HBLNo { get; set; }
        public string Source { get; set; }
        public string SCharges { get; set; }
        public string WhoisInput { get; set; }
        public bool? LockFreight { get; set; }
        public DateTime? DateKey { get; set; }
        public DateTime? DateModify { get; set; }
        public int? lIndex { get; set; }

        public virtual ShippingInstruction IDKeyNavigation { get; set; }
    }
}
