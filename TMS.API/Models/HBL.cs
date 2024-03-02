using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class HBL
    {
        public HBL()
        {
            AttachedFile = new HashSet<AttachedFile>();
            ContainerListOnHBL = new HashSet<ContainerListOnHBL>();
            OtherSurcharge = new HashSet<OtherSurcharge>();
            RouteOnHBL = new HashSet<RouteOnHBL>();
            Surcharge = new HashSet<Surcharge>();
            TaskList = new HashSet<TaskList>();
        }

        public int Id { get; set; }
        public int? TransId { get; set; }
        public string HBLNo { get; set; }
        public int? CommodityId { get; set; }
        public bool Active { get; set; }
        public DateTime InsertedDate { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string BookingNo { get; set; }
        public int? HBLType { get; set; }
        public int? ShipperId { get; set; }
        public string ShipperInfo { get; set; }
        public int? ConsigneeId { get; set; }
        public string ConsigneeInfo { get; set; }
        public int? NotifyPartyId { get; set; }
        public string NotifyPartyInfo { get; set; }
        public int? AlsoNotifyPartyId { get; set; }
        public string AlsoNotifyPartyInfo { get; set; }
        public string Description { get; set; }
        public string RevenueTons { get; set; }
        public string Rate { get; set; }
        public string Currency { get; set; }
        public string Per { get; set; }
        public int? PaymentTermId { get; set; }
        public bool? OF { get; set; }
        public string ForwardingArgent { get; set; }
        public string FreightAmount { get; set; }
        public string ExRef { get; set; }
        public int? PlaceOfReceipt { get; set; }
        public int? PlaceOfDelivery { get; set; }
        public int? FinalDestination { get; set; }
        public DateTime? SailingDate { get; set; }
        public DateTime? ClosingDate { get; set; }
        public int? PointCountryOfOrigin { get; set; }
        public int? PlaceOfIssued { get; set; }
        public DateTime? DateOfIssued { get; set; }
        public int? FreightPayableId { get; set; }
        public int? NoOriginalB { get; set; }
        public int? TypeMove { get; set; }
        public string PONo { get; set; }
        public string HSCode { get; set; }
        public string Inwords { get; set; }
        public string ShippingMark { get; set; }
        public string DescriptionGood { get; set; }
        public string DeliveryGood { get; set; }
        public string Remark { get; set; }
        public string OnBoardStatus { get; set; }
        public DateTime? Receipt { get; set; }
        public string BillPickup { get; set; }
        public DateTime? Deadline { get; set; }
        public int? Dem { get; set; }
        public int? Det { get; set; }
        public int? Storage { get; set; }
        public int? CustomerId { get; set; }
        public int? Source { get; set; }
        public decimal? GWTotal { get; set; }
        public decimal? CBMTotal { get; set; }
        public decimal? QuantityTotal { get; set; }
        public string FirstNotice { get; set; }
        public string SecondNotice { get; set; }
        public string ArrivalNo { get; set; }
        public string DocumentNo { get; set; }
        public string DONo { get; set; }
        public string PlaceReciept { get; set; }
        public string PlaceIssued { get; set; }
        public string Owner { get; set; }
        public DateTime? DateIssued { get; set; }
        public string DGInfo { get; set; }
        public string ReferenceNo { get; set; }
        public string ArrivalVessel { get; set; }
        public string NoOfOriginalBL { get; set; }
        public string PMTerm { get; set; }
        public DateTime? DOPrintedDate { get; set; }
        public string Warehouse { get; set; }
        public string ShippingLines { get; set; }
        public string SubmitMNF { get; set; }
        public string BillType { get; set; }
        public string ContainerContent { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Type { get; set; }

        public virtual Commodity Commodity { get; set; }
        public virtual Transaction Trans { get; set; }
        public virtual ICollection<AttachedFile> AttachedFile { get; set; }
        public virtual ICollection<ContainerListOnHBL> ContainerListOnHBL { get; set; }
        public virtual ICollection<OtherSurcharge> OtherSurcharge { get; set; }
        public virtual ICollection<RouteOnHBL> RouteOnHBL { get; set; }
        public virtual ICollection<Surcharge> Surcharge { get; set; }
        public virtual ICollection<TaskList> TaskList { get; set; }
    }
}
