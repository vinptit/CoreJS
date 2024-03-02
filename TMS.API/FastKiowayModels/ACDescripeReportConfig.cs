using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ACDescripeReportConfig
    {
        public ACDescripeReportConfig()
        {
            ACDescripeReportDetailConfig = new HashSet<ACDescripeReportDetailConfig>();
        }

        public string ACReportID { get; set; }
        public string ACReport { get; set; }
        public string TemplateFile { get; set; }
        public string CompID { get; set; }

        public virtual ICollection<ACDescripeReportDetailConfig> ACDescripeReportDetailConfig { get; set; }
    }
}
