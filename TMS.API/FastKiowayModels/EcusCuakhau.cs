using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class EcusCuakhau
    {
        public EcusCuakhau()
        {
            Airports = new HashSet<Airports>();
        }

        public string Ma_CK { get; set; }
        public string Ten_CK { get; set; }
        public string Ma_Cuc { get; set; }
        public int? HienThi { get; set; }

        public virtual ECusCucHQ Ma_CucNavigation { get; set; }
        public virtual ICollection<Airports> Airports { get; set; }
    }
}
