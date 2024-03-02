using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class BookingContainer
    {
        public string TransID { get; set; }
        public int? Qty { get; set; }
        public string Container { get; set; }
        public string Notes { get; set; }

        public virtual BookingLocal Trans { get; set; }
    }
}
