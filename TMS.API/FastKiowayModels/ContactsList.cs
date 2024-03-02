using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class ContactsList
    {
        public ContactsList()
        {
            ACSalaryConfig = new HashSet<ACSalaryConfig>();
            AccsIncomeStatement = new HashSet<AccsIncomeStatement>();
            AcsSetlementPayment = new HashSet<AcsSetlementPayment>();
            DOManaged = new HashSet<DOManaged>();
            ECUSConnection = new HashSet<ECUSConnection>();
            OPSManagement = new HashSet<OPSManagement>();
            Products = new HashSet<Products>();
            SeaQuotations = new HashSet<SeaQuotations>();
        }

        public string ContactID { get; set; }
        public string PCode { get; set; }
        public string ContactName { get; set; }
        public string EnglishName { get; set; }
        public string PositionContact { get; set; }
        public DateTime? Birthday { get; set; }
        public string FieldInterested { get; set; }
        public bool marriageStatus { get; set; }
        public string PouseName { get; set; }
        public DateTime? PouseBirthday { get; set; }
        public string Signature { get; set; }
        public string ExtNo { get; set; }
        public string Mobile { get; set; }
        public string HomePhone { get; set; }
        public string HomeAddress { get; set; }
        public string Email { get; set; }
        public string emailPassword { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string DeptID { get; set; }
        public int? AccessRight { get; set; }
        public string AccessDescription { get; set; }
        public DateTime? RegDate { get; set; }
        public byte[] Photo { get; set; }
        public string EmpPhotoSize { get; set; }
        public bool Disable { get; set; }
        public bool stopworking { get; set; }
        public DateTime? stopworkingDate { get; set; }
        public string Identitycard { get; set; }
        public string KeyLog { get; set; }
        public double? SalesTarget { get; set; }
        public double? LocalSalesTarget { get; set; }
        public double? PercentBenifit { get; set; }
        public double? Bonus { get; set; }
        public string cAlias { get; set; }
        public string DAlias { get; set; }
        public string AirBookingAuthorised { get; set; }
        public string GroupID { get; set; }
        public string PartnerID { get; set; }
        public double? QuoAdApproval { get; set; }
        public string ForwardtoID { get; set; }
        public double? QuoStApproval { get; set; }
        public string ForwardtoSTID { get; set; }
        public string TaxCode { get; set; }
        public string BankAC { get; set; }
        public string BankName { get; set; }
        public string BankAdd { get; set; }
        public string LinkedTruckNo { get; set; }
        public string DeptCodeSales { get; set; }
        public bool? DisableOutsideLogin { get; set; }
        public double? AirVLTarget { get; set; }
        public int? TUESTarget { get; set; }
        public double? CBMTarget { get; set; }
        public string NotifySQLStatement { get; set; }
        public string NotifyStatement { get; set; }
        public string sendusing { get; set; }
        public string smtpserver { get; set; }
        public string smtpserverport { get; set; }
        public bool? smtpusessl { get; set; }
        public string smtpauthenticate { get; set; }
        public int? KeyCol { get; set; }
        public bool? IsKeyNumber { get; set; }
        public string TableName { get; set; }
        public string ValidChargesCode { get; set; }
        public bool? DeniedMutiLogin { get; set; }
        public bool? emailPasswordEnscript { get; set; }
        public string URL_API { get; set; }

        public virtual Departments Dept { get; set; }
        public virtual GroupList Group { get; set; }
        public virtual AccessRight AccessRightNavigation { get; set; }
        public virtual ICollection<ACSalaryConfig> ACSalaryConfig { get; set; }
        public virtual ICollection<AccsIncomeStatement> AccsIncomeStatement { get; set; }
        public virtual ICollection<AcsSetlementPayment> AcsSetlementPayment { get; set; }
        public virtual ICollection<DOManaged> DOManaged { get; set; }
        public virtual ICollection<ECUSConnection> ECUSConnection { get; set; }
        public virtual ICollection<OPSManagement> OPSManagement { get; set; }
        public virtual ICollection<Products> Products { get; set; }
        public virtual ICollection<SeaQuotations> SeaQuotations { get; set; }
    }
}
