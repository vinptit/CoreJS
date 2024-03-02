using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ACTriaBalanceViewDetails
    {
        public int IDKey { get; set; }
        public int? IDLinked { get; set; }
        public string ACNo { get; set; }
        public string ACName { get; set; }
        public double? PDN { get; set; }
        public double? PCN { get; set; }
        public double? CDN { get; set; }
        public double? CCN { get; set; }
        public double? LDN { get; set; }
        public double? LCN { get; set; }
        public bool? Bold { get; set; }
        public int? LIndex { get; set; }
        public double? PDNNT { get; set; }
        public double? PCNNT { get; set; }
        public double? CDNNT { get; set; }
        public double? CCNNT { get; set; }
        public double? LDNNT { get; set; }
        public double? LCNNT { get; set; }
    }
}
