using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class FormBillList
    {
        public int IDKey { get; set; }
        public string FormName { get; set; }
        public string DisplayName { get; set; }
        public string ContainerName { get; set; }
        public int? tIndex { get; set; }
        public string CompID { get; set; }
        public bool? OriginalForm { get; set; }
        public string CurrDF { get; set; }
        public string SQLStatement { get; set; }
        public string Charset { get; set; }
        public string HeaderCaption { get; set; }
        public string HeaderCOLW { get; set; }
        public int? HeaderStartRow { get; set; }
        public int? DataStartRow { get; set; }
        public string TemplateFile { get; set; }
        public string APIURL { get; set; }
        public string APIHeader { get; set; }
        public bool? APIManagerApproved { get; set; }
        public int? TypeDocument { get; set; }
        public bool? KeepTemplateFooter { get; set; }
        public int? PartnerInfoRow { get; set; }
        public int? PartnerInfoCol { get; set; }
        public double? PartnerInfoRowHeight { get; set; }
        public string PartnerSQL { get; set; }
        public bool? DrawLine { get; set; }
        public string EmailSubject { get; set; }
        public string EmailHeader { get; set; }
        public string EmailBody { get; set; }
        public string EmailFooter { get; set; }
        public string AttachedFilesFilterFieldPartnerID { get; set; }
        public string AttachedFilesFilterFieldHBLID { get; set; }
        public bool? UsingMSOutlook { get; set; }
        public string ReportTitle { get; set; }
        public int? ReportTitleRow { get; set; }
        public int? ReportTitleCol { get; set; }
        public string ReportSubTitle { get; set; }
        public int? ReportSubTitleRow { get; set; }
        public int? ReportSubTitleCol { get; set; }
    }
}
