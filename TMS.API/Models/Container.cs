using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class Container
    {
        public int ID { get; set; }
        public string ContNo { get; set; }
        public string ContSize { get; set; }
        public string ContMode { get; set; }
        public string ContDescription { get; set; }
        public double? Weight { get; set; }
        public string VenderName { get; set; }
        public string Origin { get; set; }
        public string OwnerID { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string WhoIsUnput { get; set; }
        public double? CAPKG { get; set; }
        public double? MAXKG { get; set; }
        public string YearMade { get; set; }
        public double? BuyingRate { get; set; }
        public string BCurr { get; set; }
        public double? SellingRate { get; set; }
        public string SCurr { get; set; }
        public double? HireRate { get; set; }
        public string HCurr { get; set; }
        public DateTime? HireDateFrom { get; set; }
        public DateTime? HireDateTo { get; set; }
        public string ContNote { get; set; }
        public string SellerId { get; set; }
        public int? GlobalId { get; set; }
        public bool IsSync { get; set; }
        public bool? InUse { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
