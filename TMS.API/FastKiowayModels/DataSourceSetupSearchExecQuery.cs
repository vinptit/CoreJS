using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class DataSourceSetupSearchExecQuery
    {
        public decimal IDKey { get; set; }
        public string FuncID { get; set; }
        public string ExecQuery { get; set; }
        public int? IIndex { get; set; }
    }
}
