using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class StartUpMasseagesView
    {
        public int IDKey { get; set; }
        public string MsgID { get; set; }
        public string WhoisView { get; set; }
        public DateTime? ViewDate { get; set; }
        public string PCName { get; set; }

        public virtual StartUpMasseages Msg { get; set; }
    }
}
