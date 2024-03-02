using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class INNER_ISIPTOFASTPRO
    {
        public string IPIDKey { get; set; }
        public bool? IsIPtoFASTPRO { get; set; }
        public DateTime? DateImported { get; set; }
        public string UserUpdate { get; set; }
        public string PCUpdate { get; set; }
        public string VoidIDIDKey { get; set; }
    }
}
