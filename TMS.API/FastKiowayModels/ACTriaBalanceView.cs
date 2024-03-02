﻿using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ACTriaBalanceView
    {
        public int ID { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Description { get; set; }
        public string Whois { get; set; }
        public string CompID { get; set; }
        public string FormName { get; set; }
        public string SelACNo { get; set; }
        public string PCName { get; set; }
        public bool? ENView { get; set; }
    }
}