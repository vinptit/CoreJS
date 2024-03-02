using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ContTariffDemDepCharges
    {
        public int IDKey { get; set; }
        public string Kindof { get; set; }
        public int? DayFrom { get; set; }
        public int? DayTo { get; set; }
        public double? Cont20 { get; set; }
        public double? Cont40 { get; set; }
        public double? Cont20RF { get; set; }
        public double? Cont40RF { get; set; }
        public double? OtherCont { get; set; }
        public string OtherContType { get; set; }
        public string Curr { get; set; }
        public string ContMode { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public DateTime? Validity { get; set; }
        public string UserInput { get; set; }
        public string CompanyID { get; set; }
        public int? IIndex { get; set; }

        public virtual ContainerTransType ContModeNavigation { get; set; }
    }
}
