using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ServiceInquiryDetails
    {
        public int IDKey { get; set; }
        public string ServiceID { get; set; }
        public string ServiceType { get; set; }
        public string ServiceInquiry { get; set; }
        public string TargetRate { get; set; }
        public string POLOrigin { get; set; }
        public string Destination { get; set; }
        public double? TotalGW { get; set; }
        public double? TotalCW { get; set; }
        public double? TotalCBM { get; set; }
        public string ConQty { get; set; }
        public double? Quantity { get; set; }
        public string UnitQuantity { get; set; }
        public string AsignedtoUser { get; set; }
        public string AsigntoGroup { get; set; }
        public string Deadline { get; set; }
        public bool? Approved { get; set; }
        public string PriceID { get; set; }
        public string ModeDB { get; set; }
        public string PriceINLID { get; set; }
        public string JobID { get; set; }
        public string HBLNo { get; set; }
        public bool? Decline { get; set; }
        public string Comment { get; set; }
        public DateTime? DateProcess { get; set; }
        public string WhoisProcess { get; set; }
        public DateTime? Modified { get; set; }
        public bool? SentRequest { get; set; }
        public bool? ReadRQ { get; set; }
        public DateTime? ReadRQDate { get; set; }
        public string UserCommentDT { get; set; }
        public string PriceIDList { get; set; }
        public string Attached { get; set; }

        public virtual ServiceInquiry Service { get; set; }
    }
}
