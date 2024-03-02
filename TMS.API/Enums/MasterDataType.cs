using System.ComponentModel;

namespace TMS.API.Enums
{
    public enum WareHouseTypeEnum
    {
        Import = 7563,
        Check = 7564,
    }

    public enum VendorTypeEnum
    {
        Partner = 7552,
        Boss = 7551,

    }

    public enum VendorService
    {
        Packing = 7572,
        Return = 7573,
    }
    
    public enum RatingPartnersTypeEnum
    {
        OneStar = 11044,
        TwoStar = 11045,
        ThreeStar = 11046,
        FourStar = 11047,
        FiveStar = 11048
    }

    public enum IndustryTypeEnum
    {

        False = 11051,
        Garments = 11060,
        MACHINE = 11061,
        WEB = 11062
    }

    public enum CustomerStateEnum
    {
        [Description("Chưa liên hệ")]
        Leads = 1,
        [Description("Đã liên hệ")]
        Potential = 2,
        [Description("Chính thức")]
        Offical = 3,
    }

    public enum CurrencyTypeEnum
    {
        USD = 11063,
        VND = 11066,
        GBP = 11067,
        EUR = 11068,
        SGD = 11072,
        JPY = 11071
    }

    public enum SateTypeEnum
    {
        AK = 11073,
        US = 11074,
        VN = 11075,

    }

    public enum PartnerGroupEnum
    {
        SHIPPER = 58,
        CUSTOMERS,
        CONSIGNEE,
        COLOADERS,
        AGENTS,
        OTHER_CONTACT
    }
    public enum CategoryEnum
    {
        BUYER = 68,
        CONSIGNEE,
        CONSOLIDATOR,
        DIRECT_SHIPPER,
        FORWARDER,
        FORWARDER_IMPORTER,
        IMPORTER,
        MANUFACTURER,
        SELLER,
        SHIPPER_OVERSEAS,
        SHIPPER_OVERSEAS_CONSOLIDATOR,
        SHIPPER_OVERSEAS_IMPORTER_STUFFINGLOC,
        SHIPPER_OVERSEAS_MANUFACTURER,
        SHIPPER_OVERSEAS_SELLER,
        SHIPPER_OVERSEAS_SHIPTO,
        SHIPTO,
        STUFFINGLOC
    }

    public enum FileAttachTypeEnum
    {

        Contract = 11092,
        Quote = 11097

    }
}
