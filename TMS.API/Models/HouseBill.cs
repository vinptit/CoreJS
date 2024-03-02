using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class HouseBill
    {
        public HouseBill()
        {
            ContainerHouseBill = new HashSet<ContainerHouseBill>();
            ContainerList = new HashSet<ContainerList>();
            Route = new HashSet<Route>();
        }

        public int Id { get; set; }
        public int? TransactionId { get; set; }
        public DateTime? TransactionDetailDate { get; set; }
        public string ArrivalNo { get; set; }
        public string DocumentNo { get; set; }
        public int? AlsoNotitfyPartyId { get; set; }
        public string AlsoNotitfyPartyAddress { get; set; }
        public string DONo { get; set; }
        public DateTime? PrintedDate { get; set; }
        public int? ShipperId { get; set; }
        public string ShipperAddress { get; set; }
        public int? ConsigneeId { get; set; }
        public string ConsigneeAddress { get; set; }
        public int? NotitfyPartyId { get; set; }
        public string NotitfyPartyAddress { get; set; }
        public int? PlaceReceiptId { get; set; }
        public int? PolId { get; set; }
        public int? TransitPortId { get; set; }
        public int? PodId { get; set; }
        public int? FinalDetinationId { get; set; }
        public int? ShippingLinesId { get; set; }
        public string FeederVesselVoyage { get; set; }
        public DateTime? EtdDate { get; set; }
        public string ArrivalVessel { get; set; }
        public string Voyage { get; set; }
        public DateTime? EtaDate { get; set; }
        public string HblNo { get; set; }
        public int? BillTypeId { get; set; }
        public int? OginalId { get; set; }
        public int? WareHouseId { get; set; }
        public DateTime? EtaAtDate { get; set; }
        public decimal? Dem { get; set; }
        public decimal? Det { get; set; }
        public decimal? Storage { get; set; }
        public string ReferenceNo { get; set; }
        public int? PlaceIssuedId { get; set; }
        public DateTime? IssuedDate { get; set; }
        public string MblNo { get; set; }
        public string DescriptionGoods { get; set; }
        public string ContainerText { get; set; }
        public decimal? Packages { get; set; }
        public decimal? GrossWeight { get; set; }
        public decimal? Cbm { get; set; }
        public int? OwnerId { get; set; }
        public string DgInfo { get; set; }
        public string InWords { get; set; }
        public string ShippingMark { get; set; }
        public int? CommodityId { get; set; }
        public int? TermId { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string Remark { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int? PaymentTermId { get; set; }
        public int? CustomerId { get; set; }

        public virtual Transaction Transaction { get; set; }
        public virtual ICollection<ContainerHouseBill> ContainerHouseBill { get; set; }
        public virtual ICollection<ContainerList> ContainerList { get; set; }
        public virtual ICollection<Route> Route { get; set; }
    }
}
