using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class AcsAccountsConvertHis
    {
        public int IDKey { get; set; }
        public DateTime? DateApply { get; set; }
        public int? IDLinked { get; set; }
        public string UserUpdate { get; set; }
        public string PCUpdate { get; set; }
        public DateTime? ServerDate { get; set; }

        public virtual AcsAccountsConvertConfig IDLinkedNavigation { get; set; }
    }
}
