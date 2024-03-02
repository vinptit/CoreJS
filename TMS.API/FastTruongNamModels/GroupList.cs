using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class GroupList
    {
        public GroupList()
        {
            ContactsList = new HashSet<ContactsList>();
        }

        public string GroupID { get; set; }
        public string GroupName { get; set; }
        public string CompID { get; set; }
        public string ContactMngID { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public string Creator { get; set; }
        public string LeaderUser { get; set; }

        public virtual ICollection<ContactsList> ContactsList { get; set; }
    }
}
