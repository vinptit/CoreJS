using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class YourCompany
    {
        public YourCompany()
        {
            Departments = new HashSet<Departments>();
        }

        public int Id { get; set; }
        public string CmpID { get; set; }
        public string CompanyLocal { get; set; }
        public string Companyname { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Taxcode { get; set; }
        public string VNAccountNo { get; set; }
        public string AccountName { get; set; }
        public string SwiftCode { get; set; }
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<Departments> Departments { get; set; }
    }
}
