using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class TASK
    {
        public decimal TASKID { get; set; }
        public decimal? TASKREGISTERID { get; set; }
        public string TRANSACTIONID { get; set; }
        public string STAFFID { get; set; }
        public string DEPARTMENTID { get; set; }
        public int? STATUS { get; set; }
        public DateTime? FINISHDATE { get; set; }
        public string DESCRIPTION { get; set; }
        public decimal IDKEYSHIPMENT { get; set; }
        public string FileContentBase64 { get; set; }
        public string FileName { get; set; }
        public string FileExt { get; set; }
        public string NOTES { get; set; }
        public string TASKNAME { get; set; }
        public int? TASKORDER { get; set; }
        public DateTime? ACCEPTEDON { get; set; }
        public DateTime? CREATEDON { get; set; }
        public string TASKADDRESS { get; set; }
        public string TASKGROUPADDRESS { get; set; }
        public bool CREATETRUCK { get; set; }
        public bool ISOPERATED { get; set; }
        public bool ASSIGNMOBILE { get; set; }
        public string DEADLINE { get; set; }
        public string HBLNo { get; set; }
        public DateTime? DeadlineOn { get; set; }
        public DateTime? RETURNEDON { get; set; }
        public DateTime? ASSIGNEDON { get; set; }
        public bool ASSIGNOPIC { get; set; }
        public string CREATEDBY { get; set; }
        public bool GETDEFAULTFEE { get; set; }
        public bool? ISDOC { get; set; }
    }
}
