using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ContainerTrans
    {
        public int IDKey { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string ContainerNo { get; set; }
        public string ContentStatus { get; set; }
        public string JobNo { get; set; }
        public string MBLNo { get; set; }
        public DateTime? EmptyOutDate { get; set; }
        public string BookingNo { get; set; }
        public string SealNo { get; set; }
        public string ContStatus { get; set; }
        public string EmptyOutRemark { get; set; }
        public int? DemFreeDaysCus { get; set; }
        public int? DepFreeDaysCus { get; set; }
        public int? StorageEmptyOwner { get; set; }
        public int? StorageFullOwner { get; set; }
        public string StorageOwnerRemark { get; set; }
        public int? StorageEmptySelf { get; set; }
        public int? StorageFullSelf { get; set; }
        public string StorageDepot { get; set; }
        public string StorageSelfRemark { get; set; }
        public string Remark { get; set; }
        public DateTime? LadenOutDate { get; set; }
        public string LadenOutTerminal { get; set; }
        public string LadenOutStatus { get; set; }
        public string LadenOutRemark { get; set; }
        public DateTime? LadenInDate { get; set; }
        public string LadenInTerminal { get; set; }
        public string LadenInStatus { get; set; }
        public string LadenInRemark { get; set; }
        public string LadenOnboardStatus { get; set; }
        public DateTime? EmptyInDate { get; set; }
        public string EmptyInTerminal { get; set; }
        public string EmptyInStatus { get; set; }
        public string EmptyInGrade { get; set; }
        public string EmptyMovetoDepot { get; set; }
        public DateTime? EmptyMovetoDate { get; set; }
        public string EmptyInRemark { get; set; }
        public DateTime? MovetoRepairDate { get; set; }
        public string AfterRepaid { get; set; }
        public string RepaidRemark { get; set; }
        public string TransMode { get; set; }
        public string UserEdit { get; set; }
    }
}
