using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class SeaBookingRequestContainers
    {
        public string BKRefNo { get; set; }
        public decimal IDKey { get; set; }
        public int? CQty { get; set; }
        public string CType { get; set; }
        public string FullIndicator { get; set; }
        public string ContainerComment { get; set; }
        public bool? ShipperOwner { get; set; }
        public string CargoMovement { get; set; }
        public string HaulageArrangements { get; set; }
        public double? EquipmentGrossWeight { get; set; }
        public string WUnit { get; set; }
        public double? EquipmentGrossVolume { get; set; }
        public string VLUnit { get; set; }
        public string EquipmentRole { get; set; }
        public string EquipmentPartyID { get; set; }
        public DateTime? PickupDeliveryDate { get; set; }
        public string RequestType { get; set; }
        public int? LIndex { get; set; }
        public bool? NonActiveReefer { get; set; }
        public double? Temperature { get; set; }
        public string TemperatureUOM { get; set; }
        public string ContainerNo { get; set; }
        public string EquipmentType { get; set; }
        public DateTime? PickupDeliveryDate2 { get; set; }
        public string RequestType2 { get; set; }
        public bool? Subof { get; set; }
        public decimal? RootID { get; set; }

        public virtual SeaBookingRequest BKRefNoNavigation { get; set; }
    }
}
