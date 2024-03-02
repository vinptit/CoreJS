using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class Departments
    {
        public Departments()
        {
            AirfreightPrcing = new HashSet<AirfreightPrcing>();
            ContactsList = new HashSet<ContactsList>();
        }

        public string DeptID { get; set; }
        public string Department { get; set; }
        public string ManagerContact { get; set; }
        public string Description { get; set; }
        public string ExtNo { get; set; }
        public double? DptSalesTarget { get; set; }
        public double? DptBonus { get; set; }
        public string CmpID { get; set; }
        public int? MngCode { get; set; }
        public string UserInput { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string pushNotificationURL { get; set; }
        public string pushNotificationCType { get; set; }
        public string pushNotificationCTApp { get; set; }
        public string pushNotificationSCTAU { get; set; }
        public string pushNotificationKey { get; set; }
        public string AuthorizedBy { get; set; }
        public string DeputyUsers { get; set; }

        public virtual YourCompany Cmp { get; set; }
        public virtual ICollection<AirfreightPrcing> AirfreightPrcing { get; set; }
        public virtual ICollection<ContactsList> ContactsList { get; set; }
    }
}
