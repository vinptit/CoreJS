using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class Partners
    {
        public Partners()
        {
            AcsPartnerPayment = new HashSet<AcsPartnerPayment>();
            AdvanceRequest = new HashSet<AdvanceRequest>();
            AirFreightQuotations = new HashSet<AirFreightQuotations>();
            AirfreightPrcing = new HashSet<AirfreightPrcing>();
            BookingConfirmList = new HashSet<BookingConfirmList>();
            BookingReQuestList = new HashSet<BookingReQuestList>();
            DODishList = new HashSet<DODishList>();
            HandleServiceRate = new HashSet<HandleServiceRate>();
            InvoiceReference = new HashSet<InvoiceReference>();
            PODetail = new HashSet<PODetail>();
            PartnerContact = new HashSet<PartnerContact>();
            PartnerTransactions = new HashSet<PartnerTransactions>();
            PartnersCargo = new HashSet<PartnersCargo>();
            PhieuThuChi = new HashSet<PhieuThuChi>();
            PhieuThuChiMULTIDT = new HashSet<PhieuThuChiMULTIDT>();
            PriceCenters = new HashSet<PriceCenters>();
            ProfitShareCalc = new HashSet<ProfitShareCalc>();
            ProfitShares = new HashSet<ProfitShares>();
            QUOTATIONS = new HashSet<QUOTATIONS>();
            SeaQuotations = new HashSet<SeaQuotations>();
            TransactionDetails = new HashSet<TransactionDetails>();
            TransactionDetailsRelatedPartners = new HashSet<TransactionDetailsRelatedPartners>();
            VATInvoice = new HashSet<VATInvoice>();
            ZoneCountry = new HashSet<ZoneCountry>();
        }

        public string PartnerID { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
        /// <summary>
        /// Company name
        /// </summary>
        public string PartnerName { get; set; }
        /// <summary>
        /// Company name
        /// </summary>
        public string PartnerName2 { get; set; }
        public string PartnerName3 { get; set; }
        public string PersonalContact { get; set; }
        public bool Public { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Homephone { get; set; }
        public string Workphone { get; set; }
        public string Fax { get; set; }
        public string Cell { get; set; }
        public string Taxcode { get; set; }
        public string NotesLess { get; set; }
        public string Notes { get; set; }
        public string Country { get; set; }
        public string Website { get; set; }
        public string Group { get; set; }
        public string GroupType { get; set; }
        public string ContactID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Lastname { get; set; }
        public string NickName { get; set; }
        public string JobTitle { get; set; }
        public string OnlineChat { get; set; }
        public string PhonePager { get; set; }
        public string OtherPhone { get; set; }
        public string AlternateMail1 { get; set; }
        public string AlternateMail2 { get; set; }
        public string FieldInterested { get; set; }
        public string VIP { get; set; }
        public string WorkAddress { get; set; }
        public string WorkCity { get; set; }
        public string WorkState { get; set; }
        public string WorkZipcode { get; set; }
        public string Spouse { get; set; }
        public string Childrent1 { get; set; }
        public string Childrent2 { get; set; }
        public DateTime? SpouseBirthday { get; set; }
        public DateTime? ChildrentBirthday1 { get; set; }
        public DateTime? ChildrentBirthday2 { get; set; }
        public string HomeAddress { get; set; }
        public string HomeCity { get; set; }
        public string HomeState { get; set; }
        public string HomeZipCode { get; set; }
        public string HomeCountry { get; set; }
        public string Birthday_day { get; set; }
        public string Birthday_Month { get; set; }
        public string Birthday_Year { get; set; }
        public string Anni_day { get; set; }
        public string Anni_Month { get; set; }
        public string Anni_Year { get; set; }
        public string BankAccsNo { get; set; }
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public string SwiftCode { get; set; }
        public bool? Denied { get; set; }
        public bool? Warning { get; set; }
        public string WarningMasg { get; set; }
        public int? PaymentTerm { get; set; }
        public double? PaymentAmount { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string CusTypeService { get; set; }
        public string GroupID { get; set; }
        public string AccRef { get; set; }
        public string InputPeople { get; set; }
        public string CompIDLinked { get; set; }
        public string PartnerRating { get; set; }
        public double? PartnerRevenuePerMonth { get; set; }
        public double? RoundupKGSMountFrom { get; set; }
        public int? KGSRoundUpNumber { get; set; }
        public double? RoundupCBMMountFrom { get; set; }
        public int? CBMRoundUpNumber { get; set; }
        public double? RounddownKGSMountFrom { get; set; }
        public double? KGSRounddownNumber { get; set; }
        public double? RounddownCBMMountFrom { get; set; }
        public double? CBMRounddownNumber { get; set; }
        public bool? PotentialCS { get; set; }
        public string Industry { get; set; }
        public bool? NoDebt { get; set; }
        public DateTime? DateConvert { get; set; }
        public bool? Status { get; set; }
        public DateTime? SalesmanDateAssigned { get; set; }
        public string Competitor { get; set; }
        public int? FrequentlyShipment { get; set; }
        public string InvestStyle { get; set; }
        public string Facility { get; set; }
        public double? LegalCapital { get; set; }
        public string LegalCapitalCurr { get; set; }
        public int? Amountheadcount { get; set; }
        public double? LossRatioAccept { get; set; }
        public string Attached { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? CurrDecimalNo { get; set; }
        public string BondHolderID { get; set; }
        public string BondActivityCode { get; set; }
        public string BondType { get; set; }
        public string HighlightBestMonths { get; set; }
        public int? REGISTERCODE { get; set; }
        public bool? ACCESSAPI { get; set; }
        public bool? CONFIRMREGISTER { get; set; }
        public string MAPFEECODE { get; set; }

        public virtual ICollection<AcsPartnerPayment> AcsPartnerPayment { get; set; }
        public virtual ICollection<AdvanceRequest> AdvanceRequest { get; set; }
        public virtual ICollection<AirFreightQuotations> AirFreightQuotations { get; set; }
        public virtual ICollection<AirfreightPrcing> AirfreightPrcing { get; set; }
        public virtual ICollection<BookingConfirmList> BookingConfirmList { get; set; }
        public virtual ICollection<BookingReQuestList> BookingReQuestList { get; set; }
        public virtual ICollection<DODishList> DODishList { get; set; }
        public virtual ICollection<HandleServiceRate> HandleServiceRate { get; set; }
        public virtual ICollection<InvoiceReference> InvoiceReference { get; set; }
        public virtual ICollection<PODetail> PODetail { get; set; }
        public virtual ICollection<PartnerContact> PartnerContact { get; set; }
        public virtual ICollection<PartnerTransactions> PartnerTransactions { get; set; }
        public virtual ICollection<PartnersCargo> PartnersCargo { get; set; }
        public virtual ICollection<PhieuThuChi> PhieuThuChi { get; set; }
        public virtual ICollection<PhieuThuChiMULTIDT> PhieuThuChiMULTIDT { get; set; }
        public virtual ICollection<PriceCenters> PriceCenters { get; set; }
        public virtual ICollection<ProfitShareCalc> ProfitShareCalc { get; set; }
        public virtual ICollection<ProfitShares> ProfitShares { get; set; }
        public virtual ICollection<QUOTATIONS> QUOTATIONS { get; set; }
        public virtual ICollection<SeaQuotations> SeaQuotations { get; set; }
        public virtual ICollection<TransactionDetails> TransactionDetails { get; set; }
        public virtual ICollection<TransactionDetailsRelatedPartners> TransactionDetailsRelatedPartners { get; set; }
        public virtual ICollection<VATInvoice> VATInvoice { get; set; }
        public virtual ICollection<ZoneCountry> ZoneCountry { get; set; }
    }
}
