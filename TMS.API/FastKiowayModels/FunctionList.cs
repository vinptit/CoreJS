using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class FunctionList
    {
        public string FunctId { get; set; }
        public string Display { get; set; }
        public bool Visible { get; set; }
        public string FormID { get; set; }
        public bool Default { get; set; }
        public int? iIndex { get; set; }
        public string DisableUserList { get; set; }
        public string GroupName { get; set; }
        public string ReportName { get; set; }
        public string CondF { get; set; }
        public string FieldsOrder { get; set; }
        public string DisplayVN { get; set; }
        public string Description { get; set; }
        public string DescriptionEN { get; set; }
        public string FieldsListID { get; set; }
        public DateTime? Modified { get; set; }
        public string UserUpdate { get; set; }
        public decimal? LoggedID { get; set; }
        public string Sign1 { get; set; }
        public string Sign2 { get; set; }
        public string Sign3 { get; set; }
        public int? PartnerValueRowat { get; set; }
        public int? PartnerValueColat { get; set; }
        public int? DateValueRowAt { get; set; }
        public int? DateValueColAt { get; set; }
        public int? RefNoRowat { get; set; }
        public int? RefNoColat { get; set; }
        public string ChildFuncID { get; set; }
        public bool? OriginalCurr { get; set; }
        public string HeaderCaptionVN { get; set; }
        public string HeaderCaptionEN { get; set; }
        public string PartnerSQL { get; set; }
        public int? RowCollumns { get; set; }
        public int? RowFormulars { get; set; }
        public int? RowTemp { get; set; }
        public string ColsWidth { get; set; }
        public int? KeyColumn { get; set; }
    }
}
