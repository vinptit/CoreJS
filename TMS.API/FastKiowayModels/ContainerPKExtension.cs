using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ContainerPKExtension
    {
        public int IDKey { get; set; }
        public string HBLNo { get; set; }
        public string ContainerNo { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ExttoDate { get; set; }
        public string Description { get; set; }
        public string ContactName { get; set; }
        public int? OverdueDays { get; set; }
        public double? UnitPrice { get; set; }
        public string Curr { get; set; }
        public string ExtType { get; set; }
        public string UserInput { get; set; }
        public bool? ActiveCD { get; set; }
        public int? IIndex { get; set; }
        public string RefNo { get; set; }

        public virtual HAWB HBLNoNavigation { get; set; }
    }
}
