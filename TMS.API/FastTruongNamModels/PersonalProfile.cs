using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class PersonalProfile
    {
        public string CmpID { get; set; }
        public string Group { get; set; }
        public string CompanyLocal { get; set; }
        public string Companyname { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Taxcode { get; set; }
        public string VNAccountNo { get; set; }
        public string FNAccountNo { get; set; }
        public bool Active { get; set; }
        public string Location { get; set; }
        public string AccountNote { get; set; }
        public string Notes { get; set; }
        public string YearInstall { get; set; }
        public string YearInstallTrue { get; set; }
        public string IbanCode { get; set; }
        public string AccountName { get; set; }
        public string SwiftCode { get; set; }
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public string Paymentterms { get; set; }
        public short? ExportLockDays { get; set; }
        public short? ImportLockDays { get; set; }
        public short? DaysofReLock { get; set; }
        public string ContactInfo { get; set; }
        public byte[] Logo { get; set; }
        public string EmpPhotoSize { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string AddressLocal { get; set; }
    }
}
