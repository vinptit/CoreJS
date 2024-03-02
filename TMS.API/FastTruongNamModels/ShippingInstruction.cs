using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ShippingInstruction
    {
        public ShippingInstruction()
        {
            ContainerFreightCharges = new HashSet<ContainerFreightCharges>();
        }

        public int IDKey { get; set; }
        public string TransID { get; set; }
        public int? Qty { get; set; }
        public string Container { get; set; }
        public string ContainerNo { get; set; }
        public string SealNo { get; set; }
        public double? TotalPackages { get; set; }
        public string UnitPack { get; set; }
        public string DescriptionofGoods { get; set; }
        public double? GrossWeight { get; set; }
        public double? NW { get; set; }
        public double? CBM { get; set; }
        public string ShippingMarks { get; set; }
        public string HBLNo { get; set; }
        public string Depot { get; set; }
        public string Slot { get; set; }
        public double? DemFreeDays { get; set; }
        public double? DemDaysCharge { get; set; }
        public double? DemUnitPrice { get; set; }
        public string DemCurr { get; set; }
        public bool? DemApp { get; set; }
        public DateTime? DemDate { get; set; }
        public string DemUser { get; set; }
        public double? DepFreeDays { get; set; }
        public double? DepDaysCharge { get; set; }
        public double? DepUnitPrice { get; set; }
        public string DepCurr { get; set; }
        public bool? DepApp { get; set; }
        public DateTime? DepDate { get; set; }
        public string DepUser { get; set; }
        public string Term { get; set; }
        public string EmptyPickup { get; set; }
        public DateTime? EmptyPickupDate { get; set; }
        public string FullToport { get; set; }
        public DateTime? FullToportDate { get; set; }
        public string FullPickup { get; set; }
        public DateTime? FullPickupDate { get; set; }
        public string EmptyDestDepot { get; set; }
        public DateTime? EmptyDestDepotDate { get; set; }
        public string DestDepot { get; set; }
        public DateTime? MovedForRepair { get; set; }
        public DateTime? RepairCompleted { get; set; }
        public string ContStatus { get; set; }
        public bool? Finished { get; set; }
        public string StuffingPlace { get; set; }
        public string DeliveryPlace { get; set; }
        public bool? Insurance { get; set; }
        public string TermIC { get; set; }
        public string OrderNo { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderSubject { get; set; }
        public string Notes { get; set; }
        public string BAGSNO { get; set; }
        public string PALLET { get; set; }
        public double? TareWeight { get; set; }
        public string StuffingLocation { get; set; }
        public string StuffingPhoto { get; set; }
        public DateTime? SfuffingDate { get; set; }
        public string TruckingCo { get; set; }
        public string FumiCo { get; set; }
        public string VGMCutofftime { get; set; }
        public double? AW { get; set; }
        public double? PW { get; set; }
        public string HSCode { get; set; }

        public virtual Transactions Trans { get; set; }
        public virtual ICollection<ContainerFreightCharges> ContainerFreightCharges { get; set; }
    }
}
