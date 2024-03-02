using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class PartnersCargo
    {
        public decimal IDKey { get; set; }
        public string PartnerID { get; set; }
        public string GoodsDescription { get; set; }
        public string HSCode { get; set; }
        public string GoodsType { get; set; }
        public string ContainerType { get; set; }
        public double? GW { get; set; }
        public double? CBM { get; set; }
        public string Temperature { get; set; }
        public string Ventilation { get; set; }
        public string Attached { get; set; }
        public string FreetimeRequest { get; set; }
        public string Notes { get; set; }
        public string NotesCRBy { get; set; }
        public DateTime? NotesCRDate { get; set; }
        public string NotesPre { get; set; }
        public DateTime? NotesPreDate { get; set; }
        public string NotesPreBy { get; set; }
        public string EmailAddr { get; set; }
        public bool? SEA { get; set; }
        public bool? TRUCK { get; set; }
        public bool? CUSTOMS { get; set; }
        public string ServiceType { get; set; }
        public string POD { get; set; }
        public string POL { get; set; }
        public string PODTerminal { get; set; }
        public string POLTerminal { get; set; }
        public string Liner { get; set; }
        public string Agent { get; set; }
        public string SEANotes { get; set; }
        public string PickupAddr { get; set; }
        public string DeliveryAddr { get; set; }
        public string TRUCKNotes { get; set; }
        public bool? Clearance { get; set; }
        public bool? Phyto { get; set; }
        public bool? CO { get; set; }
        public bool? Fumi { get; set; }
        public bool? QualityCheck { get; set; }
        public bool? PriceRequest { get; set; }
        public bool? CustomsOthers { get; set; }
        public string IMPEXType { get; set; }
        public string Thread { get; set; }
        public string CustomsOffice { get; set; }
        public string CDSTransfer { get; set; }
        public bool? LiffONOFFInvoiceCustomer { get; set; }
        public bool? HTCBInvoiceCustomer { get; set; }
        public string CUSTOMSNotes { get; set; }
        public string CUSTOMSNotesCustomer { get; set; }
        public string VATInvName { get; set; }
        public string VATAddress { get; set; }
        public string VATTaxcode { get; set; }
        public string VATEmailAddr { get; set; }
        public string ContractNo { get; set; }
        public bool? Debt { get; set; }
        public string DebtDuration { get; set; }
        public string CreditTerm { get; set; }
        public string ACOthers { get; set; }
        public string ACNotes { get; set; }
        public string ACNotesCRBy { get; set; }
        public DateTime? ACNotesCRDate { get; set; }
        public string ACNotesPre { get; set; }
        public DateTime? ACNotesPreDate { get; set; }
        public string ACNotesPreBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string UserCreated { get; set; }
        public string UserEdited { get; set; }
        public DateTime? DateCreatedCS { get; set; }
        public DateTime? DateModifiedCS { get; set; }
        public string UserCreatedCS { get; set; }
        public DateTime? DateCreatedTT { get; set; }
        public DateTime? DateModifiedTT { get; set; }
        public string UserCreatedTT { get; set; }
        public DateTime? DateCreatedOPS { get; set; }
        public DateTime? DateModifiedOPS { get; set; }
        public string UserCreatedOPS { get; set; }
        public DateTime? DateCreatedFN { get; set; }
        public DateTime? DateModifiedFN { get; set; }
        public string UserCreatedFN { get; set; }
        public string UpdateType { get; set; }

        public virtual Partners Partner { get; set; }
    }
}
