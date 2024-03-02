using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class TransactionInfoDetail
    {
        public string FieldKey { get; set; }
        public string HAWBNO { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string FileExt { get; set; }
        public byte[] FileContent { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModify { get; set; }
        public string UserEdit { get; set; }
        public string UpdateHistory { get; set; }
        public string PartnerNo { get; set; }
        public string JobNo { get; set; }
        public string FileContentBase64 { get; set; }
        public string KeyDes { get; set; }

        public virtual HAWB HAWBNONavigation { get; set; }
    }
}
