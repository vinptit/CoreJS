using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class StartUpMasseages
    {
        public StartUpMasseages()
        {
            StartUpMasseagesView = new HashSet<StartUpMasseagesView>();
        }

        public string MsgID { get; set; }
        public string WhoisMaking { get; set; }
        public string ContactID { get; set; }
        public string ListContact { get; set; }
        public string Subject { get; set; }
        public string Masseges { get; set; }
        public DateTime? MsgDate { get; set; }
        public int? DateStop { get; set; }
        public bool Public { get; set; }
        public int? DayStartup { get; set; }
        public bool UserRead { get; set; }
        public bool Sentitems { get; set; }
        public bool Drafts { get; set; }
        public bool Delete { get; set; }
        public bool MsgWarning { get; set; }
        public string Attached { get; set; }
        public string PCName { get; set; }

        public virtual ICollection<StartUpMasseagesView> StartUpMasseagesView { get; set; }
    }
}
