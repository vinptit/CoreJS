using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class PersonalData
    {
        public int Id { get; set; }
        public string ContactID { get; set; }
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
        public int? DeptID { get; set; }
        public bool stopworking { get; set; }
        public DateTime? stopworkingDate { get; set; }
        public int? GroupID { get; set; }
        public int? PartnerID { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string DepartmentName { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
