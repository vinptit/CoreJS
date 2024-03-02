using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class FunctionListFieldConditions
    {
        public decimal IDKey { get; set; }
        public string FunctId { get; set; }
        public string TableName { get; set; }
        public string ConditionField { get; set; }
        public bool? DebtField { get; set; }
        public string FilterConditionName { get; set; }
    }
}
