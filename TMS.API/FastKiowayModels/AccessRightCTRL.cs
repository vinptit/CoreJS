using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class AccessRightCTRL
    {
        public int IDKey { get; set; }
        public string RightName { get; set; }
        public bool? NotVisible { get; set; }
        public string CompID { get; set; }
        public string RightNameDisplay { get; set; }
    }
}
