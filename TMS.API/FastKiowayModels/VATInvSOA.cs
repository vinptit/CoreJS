using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class VATInvSOA
    {
        public VATInvSOA()
        {
            VATInvoice = new HashSet<VATInvoice>();
        }

        public string SOANO { get; set; }
        public DateTime? SOADate { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string PartnerID { get; set; }
        public string PartnerName { get; set; }
        public bool Revised { get; set; }
        public DateTime? RevisedDate { get; set; }
        public string WhoisRevised { get; set; }
        public bool PaidSOA { get; set; }
        public DateTime? PaidDate { get; set; }
        public string WhoisPaid { get; set; }
        public bool SOAVoid { get; set; }
        public DateTime? VoidDate { get; set; }
        public string WhoisVoid { get; set; }
        public string IssuedBy { get; set; }
        public DateTime? DateOfIssued { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<VATInvoice> VATInvoice { get; set; }
    }
}
