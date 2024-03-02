using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class VehicleList
    {
        public int Id { get; set; }
        public string VHUnitNo { get; set; }
        public string VHMake { get; set; }
        public string VHModel { get; set; }
        public string VHYear { get; set; }
        public string VHColor { get; set; }
        public string VHVIN { get; set; }
        public int? VHType { get; set; }
        public int? VHFuelType { get; set; }
        public double? VHFuelConsumption { get; set; }
        public string VHUnitFC { get; set; }
        public string VHUnitDT { get; set; }
        public int? VHOdometer { get; set; }
        public int? VHGroup { get; set; }
        public int? VHDeptID { get; set; }
        public string VHDeptName { get; set; }
        public string VHNote { get; set; }
        public string VHDriver { get; set; }
        public string VHDriverPhone { get; set; }
        public string VHEmployeeNumber { get; set; }
        public string PlateNo { get; set; }
        public int? PlateRewal { get; set; }
        public DateTime? VHBuyingDate { get; set; }
        public double? VHCost { get; set; }
        public int? VHCurrency { get; set; }
        public byte[] VHImage { get; set; }
        public string EmpPhotoSize { get; set; }
        public bool? Inuse { get; set; }
        public string UserInput { get; set; }
        public DateTime? DateInput { get; set; }
        public DateTime? DateModify { get; set; }
        public int? VendorID { get; set; }
        public bool? Remooc { get; set; }
        public int? MaximumCapacity { get; set; }
        public double? MaximumCBM { get; set; }
        public string BLTruckNo { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
