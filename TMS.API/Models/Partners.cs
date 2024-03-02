using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class Partners
    {
        public Partners()
        {
            PartnerCategory = new HashSet<PartnerCategory>();
        }

        public int Id { get; set; }
        public string PartnerID { get; set; }
        public string PartnerName { get; set; }
        public string PartnerName2 { get; set; }
        public string PartnerName3 { get; set; }
        public bool Public { get; set; }
        public string Email { get; set; }
        public string AddressEN { get; set; }
        public string Homephone { get; set; }
        public string Workphone { get; set; }
        public string Fax { get; set; }
        public string Cell { get; set; }
        public string Taxcode { get; set; }
        public int? Country { get; set; }
        public string GroupType { get; set; }
        public int? GroupID { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool PotentialCS { get; set; }
        public int? LocationId { get; set; }
        public string PartnerRating { get; set; }
        public string HomeCity { get; set; }
        public string WorkCity { get; set; }
        public string Source { get; set; }
        public string Industry { get; set; }
        public string Group { get; set; }
        public string HomeState { get; set; }
        public string WorkState { get; set; }
        public string WorkZipcode { get; set; }
        public string HomeZipCode { get; set; }
        public string Website { get; set; }
        public string SwiftCode { get; set; }
        public string BankAddress { get; set; }
        public string Notes { get; set; }
        public string BankAccsNo { get; set; }
        public string BankName { get; set; }
        public decimal? PaymentAmount { get; set; }
        public int? PaymentTerm { get; set; }
        public bool Denied { get; set; }
        public bool Warning { get; set; }
        public bool NoDebt { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Lastname { get; set; }
        public string NickName { get; set; }
        public string JobTitle { get; set; }
        public string OnlineChat { get; set; }
        public string Competitor { get; set; }
        public string AlternateMail1 { get; set; }
        public string AlternateMail2 { get; set; }
        public decimal? PartnerRevenuePerMonth { get; set; }
        public decimal? RoundupKGSMountFrom { get; set; }
        public int? KGSRoundUpNumber { get; set; }
        public decimal? RoundupCBMMountFrom { get; set; }
        public int? CBMRoundUpNumber { get; set; }
        public decimal? RounddownKGSMountFrom { get; set; }
        public decimal? KGSRounddownNumber { get; set; }
        public decimal? RounddownCBMMountFrom { get; set; }
        public decimal? CBMRounddownNumber { get; set; }
        public int? FrequentlyShipment { get; set; }
        public string InvestStyle { get; set; }
        public string Facility { get; set; }
        public decimal? LegalCapital { get; set; }
        public string LegalCapitalCurr { get; set; }
        public int? Amountheadcount { get; set; }
        public decimal? LossRatioAccept { get; set; }
        public string Attached { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? CurrDecimalNo { get; set; }
        public int? REGISTERCODE { get; set; }
        public bool ACCESSAPI { get; set; }
        public bool CONFIRMREGISTER { get; set; }
        public int? GlobalId { get; set; }
        public string PhonePager { get; set; }
        public string OtherPhone { get; set; }
        public string FieldInterested { get; set; }
        public string VIP { get; set; }
        public string Spouse { get; set; }
        public DateTime? SpouseBirthday { get; set; }
        public string Childrent1 { get; set; }
        public string Childrent2 { get; set; }
        public DateTime? ChildrentBirthday1 { get; set; }
        public DateTime? ChildrentBirthday2 { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }
        public string HighlightBestMonths { get; set; }
        public string BondHolderID { get; set; }
        public string BondActivityCode { get; set; }
        public string BondType { get; set; }
        public string Birthday_day { get; set; }
        public string Birthday_Month { get; set; }
        public string Birthday_Year { get; set; }
        public string Anni_day { get; set; }
        public string Anni_Month { get; set; }
        public string Anni_Year { get; set; }
        public int? CompIDLinked { get; set; }
        public int? AccRef { get; set; }
        public string WarningMsg { get; set; }
        public DateTime? SalesmanDateAssigned { get; set; }
        public string AddressVN { get; set; }
        public string GeneralNotes { get; set; }
        public string CallingCode { get; set; }

        public virtual ICollection<PartnerCategory> PartnerCategory { get; set; }
    }
}
