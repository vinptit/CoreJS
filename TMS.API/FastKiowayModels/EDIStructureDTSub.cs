using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class EDIStructureDTSub
    {
        public int IDKey { get; set; }
        public string EDIID { get; set; }
        public string FieldName { get; set; }
        public string Fieldssql { get; set; }
        public string FieldCond { get; set; }
        public string FieldValue { get; set; }
        public string AFieldName { get; set; }
        public string HaveSubsql { get; set; }
        public string SubFieldCond { get; set; }
        public string SubFieldValue { get; set; }
        public int? LIndex { get; set; }
        public bool? RCDLoop { get; set; }
        public bool? IsSequence { get; set; }
        public string SequenceCharEachLine { get; set; }
        public string SequenceFieldNumberName { get; set; }
        public string SequenceFieldDescriptionName { get; set; }
    }
}
