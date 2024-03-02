using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class DODishList
    {
        public DODishList()
        {
            DOOrderDetail = new HashSet<DOOrderDetail>();
        }

        public string SupplierID { get; set; }
        public string DiskNo { get; set; }
        public string Name { get; set; }
        public string Portion { get; set; }
        public bool bActive { get; set; }
        public byte[] Image { get; set; }
        public int? UnitPrice { get; set; }

        public virtual Partners Supplier { get; set; }
        public virtual ICollection<DOOrderDetail> DOOrderDetail { get; set; }
    }
}
