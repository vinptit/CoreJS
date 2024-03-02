using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class QuoSentHistory
    {
        public int IDKey { get; set; }
        public string QuoID { get; set; }
        public string QuoMode { get; set; }
        public string BookingID { get; set; }
        public string InqID { get; set; }
        public DateTime? DateSent { get; set; }
        public string SentBy { get; set; }
        public string PCSent { get; set; }
        public DateTime? SVDate { get; set; }
        public int? InqIDSub { get; set; }
    }
}
