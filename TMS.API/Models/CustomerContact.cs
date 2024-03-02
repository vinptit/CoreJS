using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class CustomerContact
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? UserId { get; set; }
        public int? TerminalId { get; set; }
        public int Order { get; set; }
        public int? VendorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public int? GenderId { get; set; }
        public DateTime? DoB { get; set; }
        public string Ssn { get; set; }
        public string Passport { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumber1 { get; set; }
        public string Skype { get; set; }
        public string Zalo { get; set; }
        public string Viber { get; set; }
        public string OtherContact { get; set; }
        public string TaxCode { get; set; }
        public int? NationalityId { get; set; }
        public string Email { get; set; }
        public bool IsPrioritize { get; set; }
        public string Position { get; set; }
        public bool Active { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public int? Customer2Id { get; set; }
    }
}
