﻿using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class AcsSetlementPaymentAttachedFiles
    {
        public string FieldKey { get; set; }
        public string SettledNo { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string FileExt { get; set; }
        public byte[] FileContent { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModify { get; set; }
        public string UserEdit { get; set; }
        public string UpdateHistory { get; set; }
        public string FILENAMEFIREBASE { get; set; }

        public virtual AcsSetlementPayment SettledNoNavigation { get; set; }
    }
}