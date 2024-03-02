using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class QUOTATIONS
    {
        public QUOTATIONS()
        {
            QUOTATIONDETAILSOTS = new HashSet<QUOTATIONDETAILSOTS>();
        }

        public string QuotaionNo { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? QuotationDate { get; set; }
        public DateTime? Modify { get; set; }
        public string ShipperID { get; set; }
        public string CustomerName { get; set; }
        public string Attn { get; set; }
        public string Refno { get; set; }
        public string Consignee { get; set; }
        public bool Import { get; set; }
        public string Routine { get; set; }
        public string Destination { get; set; }
        public string ImportFrom { get; set; }
        public string ImportTo { get; set; }
        public string GrossCharges { get; set; }
        public string AWB { get; set; }
        public string Service { get; set; }
        public string ServiceMode { get; set; }
        /// <summary>
        /// Less than container load
        /// </summary>
        public string LCL { get; set; }
        public string LCLUnit { get; set; }
        public string LCLCOOL { get; set; }
        public string FLC20 { get; set; }
        public string FLC20COOL { get; set; }
        public string FLC40DC { get; set; }
        public string FLC40DCCOLL { get; set; }
        public string FLC40HC { get; set; }
        /// <summary>
        /// MIN 1-10
        /// </summary>
        public string LEVEL1 { get; set; }
        /// <summary>
        /// &lt;45
        /// </summary>
        public string LEVEL2 { get; set; }
        /// <summary>
        /// 45-&lt;100
        /// </summary>
        public string LEVEL3 { get; set; }
        /// <summary>
        /// 100-&lt;299
        /// </summary>
        public string LEVEL4 { get; set; }
        /// <summary>
        /// 300-&lt;499
        /// </summary>
        public string LEVEL5 { get; set; }
        /// <summary>
        /// 500-&lt;999
        /// </summary>
        public string LEVEL6 { get; set; }
        /// <summary>
        /// 1000
        /// </summary>
        public string LEVEL7 { get; set; }
        public DateTime? ValidDate { get; set; }
        public string PickupCargoLCL { get; set; }
        public string PickupCargoFCL { get; set; }
        public string PickupAir { get; set; }
        /// <summary>
        /// Express
        /// </summary>
        public string TopNotes { get; set; }
        public string MiddleNotes { get; set; }
        public string BottomNotes { get; set; }
        public string ZoneA { get; set; }
        public string ZoneB { get; set; }
        public string ZoneC { get; set; }
        public string ZoneD { get; set; }
        public string ZoneE { get; set; }
        public string ZoneF { get; set; }
        public string ZoneG { get; set; }
        public string ZoneH { get; set; }
        public string ZoneI { get; set; }
        public string ZoneJ { get; set; }
        public double? Discount { get; set; }
        /// <summary>
        /// userid
        /// </summary>
        public string Whois { get; set; }
        public string QuoUnit { get; set; }
        public double? ExVND { get; set; }
        public string WR { get; set; }
        public string FSC { get; set; }
        public string TT { get; set; }
        public double? GW { get; set; }
        public double? CW { get; set; }
        public string SVInqID { get; set; }
        public int? SubInqID { get; set; }
        public bool Printed { get; set; }
        public bool? MngApproved { get; set; }
        public DateTime? DateApproved { get; set; }
        public string QuoHistory { get; set; }
        public bool? NominatedCargo { get; set; }
        public string SupplierID { get; set; }
        public bool? ComPerRate { get; set; }
        public double? ComPerAMT { get; set; }
        public string ComPartnerID { get; set; }
        public bool? UseAllin { get; set; }
        public string ComChargeType { get; set; }
        public bool? SendApproval { get; set; }

        public virtual Partners Shipper { get; set; }
        public virtual ICollection<QUOTATIONDETAILSOTS> QUOTATIONDETAILSOTS { get; set; }
    }
}
