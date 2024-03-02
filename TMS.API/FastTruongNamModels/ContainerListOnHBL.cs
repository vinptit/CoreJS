using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ContainerListOnHBL
    {
        public ContainerListOnHBL()
        {
            ContainerTransactions = new HashSet<ContainerTransactions>();
        }

        public int IDKey { get; set; }
        public string HBLNo { get; set; }
        public int? Qty { get; set; }
        public string ContainerType { get; set; }
        public string ContainerNo { get; set; }
        public string OwnerID { get; set; }
        public string OffhireDepot { get; set; }
        public string OffhireRefNo { get; set; }
        public string SealNo { get; set; }
        public int? Quantity { get; set; }
        public string CTNUnitOfMeasure { get; set; }
        public string Description { get; set; }
        public double? GW { get; set; }
        public double? NW { get; set; }
        public double? CBM { get; set; }
        public bool? Partof { get; set; }
        public decimal? ShipmentIDKey { get; set; }
        public string Remark { get; set; }
        public string BAGSNO { get; set; }
        public string PALLET { get; set; }
        public double? TareWeight { get; set; }
        public string StuffingPlace { get; set; }
        public string StuffingLocation { get; set; }
        public string StuffingPhoto { get; set; }
        public string ETRTPlace { get; set; }
        public DateTime? SfuffingDate { get; set; }
        public string TruckingCo { get; set; }
        public string FumiCo { get; set; }
        public string InsurCo { get; set; }
        public string QCStaff { get; set; }
        public string VGMCutofftime { get; set; }
        public string DropofPlace { get; set; }
        public string CustomsInspection { get; set; }
        public double? MassGross { get; set; }
        public double? VGMW { get; set; }
        public DateTime? SubmitDate { get; set; }
        public int? Dem { get; set; }
        public int? Det { get; set; }
        public int? STO { get; set; }
        public double? AW { get; set; }
        public double? PW { get; set; }
        public string SfuffingTime { get; set; }
        public string MARK { get; set; }
        public string ContNotes { get; set; }
        public string DocsStaff { get; set; }
        public bool? AutoSave { get; set; }
        public string ContID { get; set; }

        public virtual HAWB HBLNoNavigation { get; set; }
        public virtual ICollection<ContainerTransactions> ContainerTransactions { get; set; }
    }
}
