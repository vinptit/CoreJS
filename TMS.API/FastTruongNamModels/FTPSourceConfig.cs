﻿using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class FTPSourceConfig
    {
        public Guid ID { get; set; }
        public string FTPSource { get; set; }
        public string Method { get; set; }
    }
}