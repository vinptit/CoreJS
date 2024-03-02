﻿using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class AcsCashFlowView
    {
        public AcsCashFlowView()
        {
            AcsCashFlowViewDetail = new HashSet<AcsCashFlowViewDetail>();
        }

        public int ID { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Description { get; set; }
        public string Whois { get; set; }
        public string CompID { get; set; }
        public string FormName { get; set; }

        public virtual ICollection<AcsCashFlowViewDetail> AcsCashFlowViewDetail { get; set; }
    }
}