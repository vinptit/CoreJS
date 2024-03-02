using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class EcusCategory
    {
        public EcusCategory()
        {
            ECUSConnection = new HashSet<ECUSConnection>();
            Services = new HashSet<Services>();
        }

        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<ECUSConnection> ECUSConnection { get; set; }
        public virtual ICollection<Services> Services { get; set; }
    }
}
