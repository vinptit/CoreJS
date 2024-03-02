using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class EDOSetting
    {
        public int IDKey { get; set; }
        public string CompID { get; set; }
        public string CDSOffice { get; set; }
        public string APIURL { get; set; }
        public string APIHeader { get; set; }
        public bool? APIManagerApproved { get; set; }
        public int? TypeDocument { get; set; }
        public string Taxcode { get; set; }
        public string LCPassword { get; set; }
    }
}
