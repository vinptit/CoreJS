using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class EDIStructureCharReplace
    {
        public decimal IDKey { get; set; }
        public string EDIID { get; set; }
        public string OriginalChar { get; set; }
        public string ReplaceChar { get; set; }
        public bool? Deactive { get; set; }
    }
}
