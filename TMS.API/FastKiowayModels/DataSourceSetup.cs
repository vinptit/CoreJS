using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class DataSourceSetup
    {
        public string FuncID { get; set; }
        public string FieldsStatement { get; set; }
        public string JoinStatement { get; set; }
        public string CondStatement { get; set; }
        public string OrderStatement { get; set; }
        public string FormID { get; set; }
        public int? iIndex { get; set; }
        public string FuncDescription { get; set; }
        public string Colswdth { get; set; }
        public string SubofFuncID { get; set; }
        public int? FrozenCols { get; set; }
        public int? LeftCols { get; set; }
        public int? PrimaryKeyCol { get; set; }
        public bool? PrimaryKeyColIsIdentify { get; set; }
        public bool? PrimaryKeyColIsNumber { get; set; }
        public string PrimaryKeyName { get; set; }
        public string ForeignKeyName { get; set; }
        public int? ForeignKeyCol { get; set; }
        public bool? ForeignKeyColIsNumber { get; set; }
        public string SearchCondition { get; set; }
        public string FilterCaption { get; set; }
        public bool? Newable { get; set; }
        public string LongDateFormat { get; set; }
        public string ShortDateFormatCOLS { get; set; }
        public string ServiceList { get; set; }
        public string CompIDList { get; set; }
        public string TotalCaption { get; set; }
        public int? TotalCaptionCol { get; set; }
        public string TotalCOLS { get; set; }
        public int? InwordValueCol { get; set; }
        public string InwordTitle { get; set; }
        public string TotalValueUnit { get; set; }
        public string Sign1 { get; set; }
        public string Sign2 { get; set; }
        public string Sign3 { get; set; }
        public int? AddedCol { get; set; }
        public string AddedColFormular { get; set; }
        public bool? AddedColFontBold { get; set; }
        public bool? NoOrderStatement { get; set; }
        public string FieldsDefaultLoad { get; set; }
        public string FuncDescriptionReport { get; set; }
        public string SheetsCombined { get; set; }
        public string ExportTemplateFile { get; set; }
        public int? SubtitileRow { get; set; }
        public int? RowDataExport { get; set; }
        public string GroupOnCols { get; set; }
        public string CountOnCols { get; set; }
        public string SumOnCols { get; set; }
        public string ConcatCols { get; set; }
    }
}
