using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class OPSManagement
    {
        public int IDKey { get; set; }
        public string JobNo { get; set; }
        public string RequestNo { get; set; }
        public string OPStaffID { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public string Deadline { get; set; }
        public string Comment { get; set; }
        public string UserEdit { get; set; }
        public DateTime? Modify { get; set; }
        public string UserApproved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ForwardUser { get; set; }
        public int? IDLinked { get; set; }
        public int? IIndex { get; set; }
        public string RefNo { get; set; }
        public string RequestType { get; set; }
        public string MethodEx { get; set; }
        public string SenderNotes { get; set; }
        public bool? Sended { get; set; }
        public DateTime? DeclineDate { get; set; }
        public string Attached { get; set; }
        public string ApproveNotes { get; set; }
        public bool? DoneJob { get; set; }
        public DateTime? DoneDate { get; set; }
        public DateTime? DoneInputDate { get; set; }
        public bool? DoneApp { get; set; }
        public string WhoisDoneApp { get; set; }
        public DateTime? DoneAppDate { get; set; }
        public DateTime? DateSenderReadAPPDECL { get; set; }

        public virtual Transactions JobNoNavigation { get; set; }
        public virtual ContactsList OPStaff { get; set; }
        public virtual CargoOperationRequest RequestNoNavigation { get; set; }
    }
}
