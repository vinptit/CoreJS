using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class DOManaged
    {
        public int ID { get; set; }
        public string ContactID { get; set; }
        public bool bActive { get; set; }
        public int? DeathLine { get; set; }
        public string Timestart { get; set; }
        public string TimeFinish { get; set; }
        public string Msg { get; set; }
        public string Authorise { get; set; }

        public virtual ContactsList Contact { get; set; }
    }
}
