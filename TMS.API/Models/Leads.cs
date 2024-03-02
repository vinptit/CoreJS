using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class Leads
    {
        public int Id { get; set; }
        public string ContactID { get; set; }
        public int? GenderId { get; set; }
        public string FristName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EnglishName { get; set; }
        public string Sexual { get; set; }
        public DateTime? Birthday { get; set; }
        public string JobTitle { get; set; }
        public int? CompanyId { get; set; }
        public string TelNo { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string FieldInterested { get; set; }
        public string Notes { get; set; }
        public string LeadSource { get; set; }
        public string Industry { get; set; }
        public int? LeadStatus { get; set; }
        public int? Rating { get; set; }
        public double? RevenuePerMonth { get; set; }
        public string Street { get; set; }
        public string POBox { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string UserName { get; set; }
        public int? PartnerID { get; set; }
        public bool? AsignedtoUser { get; set; }
        public bool? AsignedtoGroup { get; set; }
        public int? AsignedtoUserID { get; set; }
        public int? AsignedtoGroupID { get; set; }
        public bool? Inlist { get; set; }
        public string Taxcode { get; set; }
        public string ContactType { get; set; }
        public string Address { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
