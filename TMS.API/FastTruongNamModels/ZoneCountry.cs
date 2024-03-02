using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ZoneCountry
    {
        public string CountryID { get; set; }
        public string ColoaderID { get; set; }
        public string Country { get; set; }
        public string CountryZone { get; set; }
        public string TTDx { get; set; }
        public string TTXs { get; set; }
        public string TransServiceID { get; set; }

        public virtual Partners Coloader { get; set; }
    }
}
