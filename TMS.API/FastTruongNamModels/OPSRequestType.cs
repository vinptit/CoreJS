using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class OPSRequestType
    {
        public string RequestTypeID { get; set; }
        public string RequestDes { get; set; }
        public string TableRef { get; set; }
        public string FieldName { get; set; }
        public string FieldDisplay { get; set; }
        public bool? IsFieldNumber { get; set; }
        public bool? IsSettlement { get; set; }
        public string Conditions { get; set; }
        public string CaptionForm { get; set; }
        public string FormObjectName { get; set; }
        public string FormOJCaption { get; set; }
        public string SqlStatement { get; set; }
        public string FieldCondition { get; set; }
        public bool? CostInput { get; set; }
        public bool? RevenueInput { get; set; }
        public bool? Payment { get; set; }
        public bool? ShipmentDocs { get; set; }
    }
}
