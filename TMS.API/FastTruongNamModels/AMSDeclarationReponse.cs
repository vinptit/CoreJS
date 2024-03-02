using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class AMSDeclarationReponse
    {
        public int IDKey { get; set; }
        public string ResponseID { get; set; }
        public string CBPRemarks { get; set; }
        public string DispositionCode { get; set; }
        public DateTime? ActionDate { get; set; }
        public DateTime? CBPProcessingTime { get; set; }
        public int IDKeyLinked { get; set; }
    }
}
