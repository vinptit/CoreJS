using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class Commodity
    {
        public int Id { get; set; }
        public string CommodityID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
