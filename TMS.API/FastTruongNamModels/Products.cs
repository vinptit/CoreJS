using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class Products
    {
        public Products()
        {
            ProductMaintenance = new HashSet<ProductMaintenance>();
        }

        public string ProductID { get; set; }
        public string ProductDescription { get; set; }
        public string Original { get; set; }
        public DateTime? BuyingDate { get; set; }
        public double? ProValue { get; set; }
        public string Currency { get; set; }
        public string ProBelong { get; set; }
        public string Managed { get; set; }
        public string Notes { get; set; }

        public virtual ContactsList ManagedNavigation { get; set; }
        public virtual ICollection<ProductMaintenance> ProductMaintenance { get; set; }
    }
}
