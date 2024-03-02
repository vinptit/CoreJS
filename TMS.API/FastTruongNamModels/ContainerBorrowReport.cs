using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ContainerBorrowReport
    {
        public ContainerBorrowReport()
        {
            ContainerBorrowDetail = new HashSet<ContainerBorrowDetail>();
            ContainerBorrowExtend = new HashSet<ContainerBorrowExtend>();
        }

        public string RefNo { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CreateModify { get; set; }
        public DateTime? BRDate { get; set; }
        public string WareHouse { get; set; }
        public string CargoDroffAt { get; set; }
        public string PartnerID { get; set; }
        public string WareHouseAddress { get; set; }
        public string TelNo { get; set; }
        public string ContactName { get; set; }
        public string CellPhoneNo { get; set; }
        public string IdentityID { get; set; }
        public DateTime? DateBR { get; set; }
        public string HBLNO { get; set; }
        public DateTime? HBLDate { get; set; }
        public string ContainerNoList { get; set; }
        public string BorrowPort { get; set; }
        public int? FreeDay { get; set; }
        public string FreeDayNotes { get; set; }
        public DateTime? DateReturn { get; set; }
        public string ReturnContAt { get; set; }
        public string ReturnPortAddress { get; set; }
        public double? AmountBR { get; set; }
        public string CurrencyBR { get; set; }
        public bool? Received { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string VoucherID { get; set; }
        public string AcsUser { get; set; }
        public bool? Accomplish { get; set; }
        public DateTime? AccomplishDate { get; set; }
        public string ConditionBR { get; set; }
        public string UserInput { get; set; }
        public string ReportName { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<ContainerBorrowDetail> ContainerBorrowDetail { get; set; }
        public virtual ICollection<ContainerBorrowExtend> ContainerBorrowExtend { get; set; }
    }
}
