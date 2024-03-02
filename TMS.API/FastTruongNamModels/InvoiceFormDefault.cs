using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class InvoiceFormDefault
    {
        public decimal ID { get; set; }
        public bool? isDefault { get; set; }
        public bool? isShowJobNo { get; set; }
        public bool? isShowHBLNo { get; set; }
        public string FirstJobID { get; set; }
        public string FirstHBLNo { get; set; }
        public bool? isShowVesselVoy { get; set; }
        public bool? UseWebsiteForEmail { get; set; }
        public string DefaultEmailToSend { get; set; }
        public bool? isVATDateSameWithEInvoiceDate { get; set; }
        public bool? isSignedFromServer { get; set; }
        public bool? isNotesOnTheTop { get; set; }
        public string DefaultNotes { get; set; }
        public bool? isNotifyEmailWhenReleased { get; set; }
        public bool? isShowHBLNoUseDefine { get; set; }
    }
}
