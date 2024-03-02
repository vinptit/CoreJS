using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class DataSourceSetupFieldDefine
    {
        public decimal IDKey { get; set; }
        public string FieldName { get; set; }
        public int? ColIndex { get; set; }
        public int? ColSource { get; set; }
        public string ColSourceFieldName { get; set; }
        public string SourceTableName { get; set; }
        public bool? ColSourceIDIsnumber { get; set; }
        public string ColComboItem { get; set; }
        public bool? ColComboIsSQL { get; set; }
        public bool? PickItemfromDialog { get; set; }
        public bool? IsContactList { get; set; }
        public bool? IsAllpartners { get; set; }
        public string PickCondition { get; set; }
        public bool? IsDatePicker { get; set; }
        public string FuncID { get; set; }
        public bool? Editable { get; set; }
        public bool? IsCurrentUsername { get; set; }
        public bool? IsDateCreate { get; set; }
        public bool? IsDateModify { get; set; }
        public bool? IsAutorunID { get; set; }
    }
}
