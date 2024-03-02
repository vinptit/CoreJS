using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class OnlineSupports
    {
        public decimal IDKey { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string UserName { get; set; }
        public string Contents { get; set; }
        public string Category { get; set; }
        public bool? SendHelp { get; set; }
        public bool? CancelHelp { get; set; }
        public string UserReceived { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? AnswerTime { get; set; }
        public string AnswerContent { get; set; }
        public bool? DoneJob { get; set; }
        public string Attached { get; set; }
        public string CompID { get; set; }
        public decimal? IDLinked { get; set; }
        public bool? NewUpate { get; set; }
    }
}
