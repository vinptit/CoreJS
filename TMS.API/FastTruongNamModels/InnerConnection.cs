using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class InnerConnection
    {
        public int IDKey { get; set; }
        public string Username { get; set; }
        public string ServerDBInstance { get; set; }
        public string DBUser { get; set; }
        public string DBUserPwd { get; set; }
        public string DBName { get; set; }
        public DateTime? ApplyDate { get; set; }
        public bool? Activate { get; set; }
        public string ConType { get; set; }
        public string FieldCondition { get; set; }
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string P3 { get; set; }
        public string P4 { get; set; }
        public string P5 { get; set; }
        public string ExceptionFieldsChangeCheck { get; set; }
        public string SubFieldCondition { get; set; }
    }
}
