using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
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
        public string RETURNEDREASON { get; set; }
        public bool? ISRETURN { get; set; }
        public bool HM_ISGETBILLTASK { get; set; }
        public bool HM_ISGETOTHERTASK { get; set; }
        public string HM_REQUESTEREMAIL { get; set; }
        public string HM_REQUESTERNAME { get; set; }
        public int? HM_NUMBERATTACHEDPAGES { get; set; }
        public double? HM_PAYMENTAMOUNT { get; set; }
        public string HM_CARRIERNAME { get; set; }
        public string HM_GETBILLADDRESS { get; set; }
        public string HM_GETBILLDISTRICT { get; set; }
        public string HM_GETBILLCONTACT { get; set; }
        public DateTime? HM_ONBOARDDATE { get; set; }
        public string HM_INVOICENO { get; set; }
        public string HM_BILLTYPE { get; set; }
        public string HM_PACKAGE { get; set; }
        public int? HM_20QTY { get; set; }
        public int? HM_40QTY { get; set; }
        public double? HM_GW { get; set; }
        public double? HM_CBM { get; set; }
        public double? HM_PAYMENTAMOUNTUSD { get; set; }
        public string HM_GETBILLCELLNO { get; set; }
        public bool HM_ISGETBILL { get; set; }
        public string PROBLEMNAME { get; set; }
        public string RESOLUTION { get; set; }
        public string GROUPMANAGER { get; set; }
        public string GROUPID { get; set; }
        public string FILENAMEFIREBASE { get; set; }
        public int ATTITUDE { get; set; }
        public int ISSUPPORT { get; set; }
        public int ISCORRECTION { get; set; }
        public string ASSIGNEDBY { get; set; }
        public bool HM_ISGETDO { get; set; }
        public string FileContentBase64_1 { get; set; }
        public string FileName_1 { get; set; }
        public string FileExt_1 { get; set; }
        public string FileContentBase64_2 { get; set; }
        public string FileName_2 { get; set; }
        public string FileExt_2 { get; set; }
        public string FileContentBase64_3 { get; set; }
        public string FileName_3 { get; set; }
        public string FileExt_3 { get; set; }
        public string FileContentBase64_4 { get; set; }
        public string FileName_4 { get; set; }
        public string FileExt_4 { get; set; }
        public string FILENAMEFIREBASE_1 { get; set; }
        public string FILENAMEFIREBASE_2 { get; set; }
        public string FILENAMEFIREBASE_3 { get; set; }
        public string FILENAMEFIREBASE_4 { get; set; }
        public bool ChangeDeadline { get; set; }
        public string REPONSEMESSAGE { get; set; }
        public bool ISPROBLEM { get; set; }
        public bool ISREPLACETASK { get; set; }
        public decimal? ORIGINTASKID { get; set; }
        public int STATUSPROBLEM { get; set; }
    }
}
