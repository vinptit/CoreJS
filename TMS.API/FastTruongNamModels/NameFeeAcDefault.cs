using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class NameFeeAcDefault
    {
        public int IDKey { get; set; }
        public string FeeCodeRef { get; set; }
        public string VCMode { get; set; }
        public string AcNo { get; set; }
        public string AcCo { get; set; }
        public string VATAcNo { get; set; }
        public string VATAcCo { get; set; }
        public string OBHAcNo { get; set; }
        public string OBHAcCo { get; set; }
        public string VATOBHAcNo { get; set; }
        public string VATOBHAcCo { get; set; }
        public string UserEdit { get; set; }
        public DateTime? DateModify { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
