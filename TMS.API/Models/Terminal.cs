using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class Terminal
    {
        public Terminal()
        {
            TerminalType = new HashSet<TerminalType>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string EnterAddress1 { get; set; }
        public string EnterAddress2 { get; set; }
        public string ExitAddress1 { get; set; }
        public string ExitAddress2 { get; set; }
        public int NationalityId { get; set; }
        public double Long { get; set; }
        public double Lat { get; set; }
        public string ContactNumber { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactZalo { get; set; }
        public string ContactSkype { get; set; }
        public string ContactOther { get; set; }
        public string StartEnter { get; set; }
        public string EndEnter { get; set; }
        public string StartExit { get; set; }
        public string EndExit { get; set; }
        public int? UnloadingMinute { get; set; }
        public string Note { get; set; }
        public int? RegionId { get; set; }
        public int? TerminalGroupId { get; set; }
        public string LocalAddress { get; set; }
        public string LocalAddress2 { get; set; }
        public string InterAddress1 { get; set; }
        public string InterAddress2 { get; set; }
        public bool Reported { get; set; }
        public int Radius { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public decimal? Rating { get; set; }
        public decimal? Time { get; set; }
        public string TruckType { get; set; }
        public int? SeqKey { get; set; }
        public string InterShortName { get; set; }
        public string InterFullName { get; set; }
        public string GlobalId { get; set; }
        public string Path { get; set; }
        public string TypeString { get; set; }

        public virtual ICollection<TerminalType> TerminalType { get; set; }
    }
}
