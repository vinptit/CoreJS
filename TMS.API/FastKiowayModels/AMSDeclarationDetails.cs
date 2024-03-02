using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class AMSDeclarationDetails
    {
        public int IDKey { get; set; }
        public int? IDLinked { get; set; }
        public string EquipmentInitial { get; set; }
        public string EquipmentNum { get; set; }
        public string EquipmentSuffix { get; set; }
        public string EquipmentTypeCode { get; set; }
        public string Seal { get; set; }
        public string Seal2 { get; set; }
        public double? Quantity { get; set; }
        public string CTNUnitOfMeasure { get; set; }
        public string FreeFormDescription { get; set; }
        public string MarksAndNumbers { get; set; }
        public string HazmatCode { get; set; }
        public double? Kilos { get; set; }
        public double? CBM { get; set; }
        public string HAZARDOUS_CLASS { get; set; }
        public string HAZARDOUS_CODE_QUALIFIER { get; set; }
        public string HAZARDOUS_DESC { get; set; }
        public string EMERGENCY_CONTACT_NAME { get; set; }
        public string ServiceCode { get; set; }
        public string ContainerCode { get; set; }
        public string ContainerStatus { get; set; }
        public string CountryOrigin { get; set; }
        public string HSCode { get; set; }
        public double? FlashpointTemperature { get; set; }
        public string UOM { get; set; }
        public string EMERGENCY_CONTACT_PHONE { get; set; }
        public string OwnerID { get; set; }

        public virtual AMSDeclaration IDLinkedNavigation { get; set; }
    }
}
