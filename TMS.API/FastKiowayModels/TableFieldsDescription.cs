using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class TableFieldsDescription
    {
        public decimal IDKey { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string FieldDisplay { get; set; }
        public string ColComboItem { get; set; }
        public string FieldDescription { get; set; }
        public bool? Activate { get; set; }
        public int? Lindex { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModify { get; set; }
        public string UserName { get; set; }
    }
}
