using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class CargoOperationRequest
    {
        public CargoOperationRequest()
        {
            CargoOperationRequestDetail = new HashSet<CargoOperationRequestDetail>();
            HandleServiceRate = new HashSet<HandleServiceRate>();
            OPSManagement = new HashSet<OPSManagement>();
        }

        public string RequestNo { get; set; }
        public string RqTimes { get; set; }
        public DateTime? RequestDate { get; set; }
        public string HBLNo { get; set; }
        public string RequestService { get; set; }
        public string CustomerID { get; set; }
        public string ShipperID { get; set; }
        public string Shipper { get; set; }
        public string ConsigneeID { get; set; }
        public string Consignee { get; set; }
        public string PortofLoading { get; set; }
        public string PortofDischarge { get; set; }
        public bool PersonalCustomsNonTrd { get; set; }
        public bool CompanyCustomsNonTrd { get; set; }
        public bool CustomsTrading { get; set; }
        public string GoodsDescription { get; set; }
        public string ContQty { get; set; }
        public double? Quantity { get; set; }
        public string Unit { get; set; }
        public string Packages { get; set; }
        public double? Measurement { get; set; }
        public string GoodsNotes { get; set; }
        public string DocsRequest { get; set; }
        public string ClosingTime { get; set; }
        public string CargoContactAddress { get; set; }
        public string CargoContact { get; set; }
        public string CargoContactTel { get; set; }
        public string CargoContactTime { get; set; }
        public string CargoContactOthers { get; set; }
        public DateTime? Etd { get; set; }
        public string Notes { get; set; }
        public bool Finished { get; set; }
        public string Whoismaking { get; set; }
        public string OperationContact { get; set; }
        public string OPExecutive { get; set; }
        public bool Approved { get; set; }
        public bool Previewed { get; set; }
        public bool Decline { get; set; }
        public bool? Inland { get; set; }
        public string EmptyReturnPickup { get; set; }
        public decimal? IDKeyShipmentDT { get; set; }
        public string VesselVoy { get; set; }
        public string CDSNo { get; set; }
        public string CDSType { get; set; }
        public bool? WaitH { get; set; }
        public DateTime? AppDate { get; set; }
        public string AppMode { get; set; }
        public string JobApp { get; set; }
        public bool? ForceNew { get; set; }
        public string APPType { get; set; }
        public string NMPartyID { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string InternalBKRequestNo { get; set; }
        public string Attached { get; set; }
        public bool? EntireShipment { get; set; }
        public DateTime? DOExpired { get; set; }

        public virtual HAWB HBLNoNavigation { get; set; }
        public virtual ICollection<CargoOperationRequestDetail> CargoOperationRequestDetail { get; set; }
        public virtual ICollection<HandleServiceRate> HandleServiceRate { get; set; }
        public virtual ICollection<OPSManagement> OPSManagement { get; set; }
    }
}
