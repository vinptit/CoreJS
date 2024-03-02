using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class InfoNote
    {
        public string CmpID { get; set; }
        public short? OnlineNo { get; set; }
        public string InfoNotes { get; set; }

        public virtual YourCompany Cmp { get; set; }
    }
}
