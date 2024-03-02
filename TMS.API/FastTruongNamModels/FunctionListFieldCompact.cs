using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class FunctionListFieldCompact
    {
        public decimal IDKey { get; set; }
        public string FormID { get; set; }
        public string FunctId { get; set; }
        public string FieldStatement { get; set; }
        public string FieldReplace { get; set; }
        public string sqlStatement { get; set; }
        public string CompID { get; set; }
        public int? LIndex { get; set; }
    }
}
