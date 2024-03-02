using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class PartnerContact
    {
        public string ContactID { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string Onomatology { get; set; }
        public string FristName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EnglishName { get; set; }
        public string Sexual { get; set; }
        public DateTime? Birthday { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string TelNo { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string FieldInterested { get; set; }
        public string Notes { get; set; }
        public string LeadSource { get; set; }
        public string Industry { get; set; }
        public string LeadStatus { get; set; }
        public string Rating { get; set; }
        public double? RevenuePerMonth { get; set; }
        public string Street { get; set; }
        public string POBox { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string UserName { get; set; }
        public string PartnerID { get; set; }
        public bool? AsignedtoUser { get; set; }
        public bool? AsignedtoGroup { get; set; }
        public string AsignedtoUserID { get; set; }
        public string AsignedtoGroupID { get; set; }
        public bool? Inlist { get; set; }
        public string Attached { get; set; }
        public string Taxcode { get; set; }
        public string ContactType { get; set; }

        public virtual Partners Partner { get; set; }
    }
}
