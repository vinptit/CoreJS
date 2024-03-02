using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class VehicleList
    {
        public string VHUnitNo { get; set; }
        public string VHMake { get; set; }
        public string VHModel { get; set; }
        public string VHYear { get; set; }
        public string VHColor { get; set; }
        public string VHVIN { get; set; }
        public string VHType { get; set; }
        public string VHFuelType { get; set; }
        public double? VHFuelConsumption { get; set; }
        public string VHUnitFC { get; set; }
        public string VHUnitDT { get; set; }
        public string VHOdometer { get; set; }
        public string VHGroup { get; set; }
        public string VHDeptID { get; set; }
        public string VHNote { get; set; }
        public string VHDriver { get; set; }
        public string VHDriverPhone { get; set; }
        public string VHEmployeeNumber { get; set; }
        public string PlateNo { get; set; }
        public string PlateRewal { get; set; }
        public DateTime? VHBuyingDate { get; set; }
        public double? VHCost { get; set; }
        public string VHCurrency { get; set; }
        public byte[] VHImage { get; set; }
        public string EmpPhotoSize { get; set; }
        public bool? Inuse { get; set; }
        public string UserInput { get; set; }
        public DateTime? DateInput { get; set; }
        public DateTime? DateModify { get; set; }
        public string VendorID { get; set; }
        public bool? Remooc { get; set; }
        public double? MaximumCapacity { get; set; }
        public double? MaximumCBM { get; set; }
        public string BLTruckNo { get; set; }
    }
}
