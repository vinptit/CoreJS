using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ContainersList
    {
        public ContainersList()
        {
            ContainerTransactions = new HashSet<ContainerTransactions>();
        }

        public int IDKey { get; set; }
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

        public virtual ICollection<ContainerTransactions> ContainerTransactions { get; set; }
    }
}
