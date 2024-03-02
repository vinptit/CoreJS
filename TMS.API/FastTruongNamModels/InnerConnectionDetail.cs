using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class InnerConnectionDetail
    {
        public int IDKey { get; set; }
        public int? IDKeyLinked { get; set; }
        public string LinkedTable { get; set; }
        public string AcRefListLLinked { get; set; }
    }
}
