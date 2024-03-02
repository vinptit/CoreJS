using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class CustomerShippingInstructionDetail
    {
        public decimal CustomerShippingInstructionDetailId { get; set; }
        public decimal CustomerShippingInstructionID { get; set; }
        public double? Quantity { get; set; }
        public string ContainerType { get; set; }
        public string ContainerNo { get; set; }
        public string SealNo { get; set; }
        public string DescriptionOfGoods { get; set; }
        public double? Grossweight { get; set; }
        public double? CBM { get; set; }
        public string PO { get; set; }

        public virtual CustomerShippingInstruction CustomerShippingInstruction { get; set; }
    }
}
