using System.ComponentModel;
namespace TMS.API.Enums
{
    public enum HAWBTypeEnum
    {
        [Description("FCL Import")]
        FCLImport = 1,
        [Description("FCL Export")]
        FCLExport = 2,
        [Description("LCL Import")]
        LCLImport = 3,
        [Description("LCL Export")]
        LCLExport = 4,
        [Description("Air Import")]
        AirImport = 5,
        [Description("Air Export")]
        AirExport = 6,
        [Description("Trucking")]
        Trucking = 7,
        [Description("Logistics")]
        Logistics = 8,
        [Description("Express")]
        Express = 9,
    }
    public enum ConfigIDTypeEnum
    {
        [Description("Số chuyến")]
        Job = 28,
        [Description("Số house bill")]
        Bill,
        [Description("Số chứng từ")]
        Document
    }
}
