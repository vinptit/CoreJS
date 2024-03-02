using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class VendorPersonalContact
    {
        public int Id { get; set; }
        public int? VendorId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public bool? Sexual { get; set; }
        public DateTime? Birthday { get; set; }
        public string JobTitle { get; set; }
        public string CellNo { get; set; }
        public string Email { get; set; }
        public string FieldInterested { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Gender { get; set; }
    }
}
