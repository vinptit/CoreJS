using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class DataSourceSetupSearch
    {
        public decimal IDKey { get; set; }
        public string FieldName { get; set; }
        public string NameDisplay { get; set; }
        public string Datatype { get; set; }
        public string ItemSource { get; set; }
        public bool? ItemSourceIsSQL { get; set; }
        public bool? IsContactList { get; set; }
        public bool? IsAllpartners { get; set; }
        public string PickCondition { get; set; }
        public int? iIndex { get; set; }
        public string DefaultValue { get; set; }
        public string OperatorValue { get; set; }
        public string FuncID { get; set; }
    }
}
