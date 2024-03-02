using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class AcsAccountsConvertConfig
    {
        public AcsAccountsConvertConfig()
        {
            AcsAccountsConvertHis = new HashSet<AcsAccountsConvertHis>();
        }

        public int IDKey { get; set; }
        public string SoTKKet { get; set; }
        public bool? TKNoKet { get; set; }
        public bool? TKCoKet { get; set; }
        public string SoTKChuyen { get; set; }
        public bool? TKNoChuyen { get; set; }
        public bool? TKCoChuyen { get; set; }
        public int? Priority { get; set; }
        public string CompanyID { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string UserEdit { get; set; }
        public string DeptCode { get; set; }
        public bool? GroupOnPartner { get; set; }
        public bool? GroupOnJob { get; set; }
        public bool? JobAppOnly { get; set; }
        public string ACLock { get; set; }
        public string AMTFormular { get; set; }

        public virtual ICollection<AcsAccountsConvertHis> AcsAccountsConvertHis { get; set; }
    }
}
