using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class AirfreightPrcing
    {
        public AirfreightPrcing()
        {
            AirfreightPrcingDetail = new HashSet<AirfreightPrcingDetail>();
        }

        public decimal IDKey { get; set; }
        public string PricingCode { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string AirlineID { get; set; }
        public string DeptID { get; set; }
        public double? MinQty { get; set; }
        /// <summary>
        /// 01/10/2010
        /// </summary>
        public double? Min { get; set; }
        /// <summary>
        /// -45
        /// </summary>
        public double? Normal { get; set; }
        /// <summary>
        /// 45
        /// </summary>
        public double? Level3 { get; set; }
        /// <summary>
        /// 100
        /// </summary>
        public double? Level4 { get; set; }
        /// <summary>
        /// 300
        /// </summary>
        public double? Level5 { get; set; }
        /// <summary>
        /// 500
        /// </summary>
        public double? Level6 { get; set; }
        /// <summary>
        /// 1000
        /// </summary>
        public double? Level7 { get; set; }
        /// <summary>
        /// Phu phi xang dau
        /// </summary>
        public double? FSC { get; set; }
        /// <summary>
        /// Phu phi chuien tranh
        /// </summary>
        public double? SSC { get; set; }
        public bool? GWC { get; set; }
        public string Curr { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? ValidDate { get; set; }
        public string TT { get; set; }
        public string Freq { get; set; }
        public string Cutoff { get; set; }
        public string Notes { get; set; }
        public bool Public { get; set; }
        public string UserInput { get; set; }
        public bool? LockedRCD { get; set; }
        public string CarrierID { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Partners Airline { get; set; }
        public virtual Departments Dept { get; set; }
        public virtual ICollection<AirfreightPrcingDetail> AirfreightPrcingDetail { get; set; }
    }
}
