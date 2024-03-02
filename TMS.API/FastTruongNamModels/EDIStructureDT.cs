using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class EDIStructureDT
    {
        public int IDKey { get; set; }
        public string EDIID { get; set; }
        public string NodeName { get; set; }
        public bool? PRNode { get; set; }
        public string PRNodeSelName { get; set; }
        public string NodeKey { get; set; }
        public int? NodeIndex { get; set; }
        public string TableFieldName { get; set; }
        public string SubSqlStatement { get; set; }
        public string SubFieldCond { get; set; }
        public string FieldNameCond { get; set; }
        public bool? InitialNode { get; set; }
        public bool? MTLoop { get; set; }
        public string PNodeName { get; set; }
        public string PNodeSel { get; set; }
        public string ExtraNodeName { get; set; }
        public string ExtraSubSqlStatement { get; set; }
        public string ExtraSubFieldCond { get; set; }
        public string ExtraFieldNameCond { get; set; }
        public string ExtraPRNodeSelName { get; set; }
        public bool? DeactiveRCD { get; set; }
        public string OrderSubSqlStatement { get; set; }
        public string OrderExtraSubSqlStatement { get; set; }

        public virtual EDIStructure EDI { get; set; }
    }
}
