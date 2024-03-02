using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class FormList
    {
        public FormList()
        {
            FormControlList = new HashSet<FormControlList>();
        }

        public string FormID { get; set; }
        public string frmCaption { get; set; }
        public string frmCaptionSND { get; set; }
        public string URLAddress { get; set; }

        public virtual ICollection<FormControlList> FormControlList { get; set; }
    }
}
