using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class ContainerListOnHBL
    {
        public int Id { get; set; }
        public int? TransId { get; set; }
        public int? Quantity { get; set; }
        public string ContainerType { get; set; }
        public string ContainerNo { get; set; }
        public string SealNo { get; set; }
        public string PackingStyle { get; set; }
        public string Unit { get; set; }
        public decimal? ActualWeight { get; set; }
        public decimal? DeclaredWeight { get; set; }
        public decimal? PackingWeight { get; set; }
        public decimal? GW { get; set; }
        public decimal? WeightDiscrepancy { get; set; }
        public decimal? TareWeight { get; set; }
        public decimal? VGMW { get; set; }
        public decimal? CBM { get; set; }
        public string Description { get; set; }
        public string HSCode { get; set; }
        public string StuffingPlace { get; set; }
        public string StuffingLocation { get; set; }
        public string StuffingPhoto { get; set; }
        public int? OwnerID { get; set; }
        public int? Depot { get; set; }
        public string ReferenceNo { get; set; }
        public DateTime? StuffingDate { get; set; }
        public string StuffingTime { get; set; }
        public string TruckingCo { get; set; }
        public string DropofPlace { get; set; }
        public string VGMCutofftime { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public decimal? PKGS { get; set; }
        public decimal? CW { get; set; }
        public decimal? Volume { get; set; }
        public int? HBLId { get; set; }
        public int? Size { get; set; }

        public virtual HBL HBL { get; set; }
        public virtual Transaction Trans { get; set; }
    }
}
