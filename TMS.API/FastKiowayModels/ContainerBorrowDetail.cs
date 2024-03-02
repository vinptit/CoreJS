using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ContainerBorrowDetail
    {
        public int IDKey { get; set; }
        public string RefNo { get; set; }
        public string ContainerNo { get; set; }
        public string ContainerType { get; set; }
        public double? Qty { get; set; }
        public string OPSCode { get; set; }
        public bool? OffHire { get; set; }
        public string ReferenceNo { get; set; }
        public string ContactName { get; set; }
        public string TelNo { get; set; }
        public string Notes { get; set; }

        public virtual ContainerBorrowReport RefNoNavigation { get; set; }
    }
}
