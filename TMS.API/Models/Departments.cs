using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class Departments
    {
        public int Id { get; set; }
        public string DeptID { get; set; }
        public string Department { get; set; }
        public int? ManagerContactId { get; set; }
        public string Description { get; set; }
        public int? CmpID { get; set; }
        public int? MngCode { get; set; }
        public string UserInput { get; set; }
        public string pushNotificationURL { get; set; }
        public string pushNotificationCType { get; set; }
        public string pushNotificationCTApp { get; set; }
        public string pushNotificationSCTAU { get; set; }
        public string pushNotificationKey { get; set; }
        public int? AuthorizedBy { get; set; }
        public string DeputyUsers { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual YourCompany Cmp { get; set; }
    }
}
