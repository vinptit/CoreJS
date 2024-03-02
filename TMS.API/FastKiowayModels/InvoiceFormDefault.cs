using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class InvoiceFormDefault
    {
        public string ID { get; set; }
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
        public bool? isNullTaxCode { get; set; }
        public bool? isAddSTTToNoteDetail { get; set; }
        public bool? isExtraUsingForBank { get; set; }
        public bool? isExtraUsingForHBL { get; set; }
        public bool? isExtraUsingForFkey { get; set; }
        public bool? isKindOfServiceUsingForFkey { get; set; }
        public bool? isKindOfServiceUsingForHBL { get; set; }
        public bool? isKindOfServiceUsingForBank { get; set; }
        public bool? isUseGroupByCustomNo { get; set; }
        public bool? isPushCustomer { get; set; }
        public bool? isINVLockedAfterPush { get; set; }
        public bool? isHSM { get; set; }
        public bool? isNotifyEmailWhenReleased { get; set; }
        public bool? isShowHBLNoUseDefine { get; set; }
    }
}
