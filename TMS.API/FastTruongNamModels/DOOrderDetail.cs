using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class DOOrderDetail
    {
        public string OrderID { get; set; }
        public string DishNo { get; set; }
        public int? Quantity { get; set; }
        public double? UnitPrice { get; set; }
        public string Note { get; set; }

        public virtual DODishList DishNoNavigation { get; set; }
        public virtual DOOrderList Order { get; set; }
    }
}
