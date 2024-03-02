using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ContainerBorrowExtend
    {
        public int IDKey { get; set; }
        public string ExtendMode { get; set; }
        public string ContainerNo { get; set; }
        public string RefNo { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? OverdueDays { get; set; }
        public double? UnitPrice { get; set; }
        public string Curr { get; set; }
        public string Notes { get; set; }
        public DateTime? IssuedDate { get; set; }
        public string UserInput { get; set; }

        public virtual ContainerBorrowReport RefNoNavigation { get; set; }
    }
}
