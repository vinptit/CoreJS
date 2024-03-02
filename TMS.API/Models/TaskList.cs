using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class TaskList
    {
        public int Id { get; set; }
        public int? HBLId { get; set; }
        public string JobName { get; set; }
        public DateTime? KickOff { get; set; }
        public DateTime? ESTFinish { get; set; }
        public string Notes { get; set; }
        public string Object { get; set; }
        public bool? Done { get; set; }
        public DateTime? ACTFinish { get; set; }
        public string Evaluation { get; set; }
        public DateTime? EVLDate { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string Attach { get; set; }
        public int? TransId { get; set; }

        public virtual Transaction Trans { get; set; }
    }
}
