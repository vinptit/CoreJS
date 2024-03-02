using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ExpressZonePrice
    {
        public string Code { get; set; }
        public string Weight { get; set; }
        public bool Public { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string AirlineID { get; set; }
        public string DeptID { get; set; }
        public double? ZoneA { get; set; }
        public double? ZoneB { get; set; }
        public double? ZoneC { get; set; }
        public double? ZoneD { get; set; }
        public double? ZoneE { get; set; }
        public double? ZoneF { get; set; }
        public double? ZoneG { get; set; }
        public double? ZoneH { get; set; }
        public string Notes { get; set; }
    }
}
