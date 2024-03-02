using System.ComponentModel;

namespace TMS.API.Enums
{
    public enum ImportFeeStatusEnum
    {
        [Description("Insert")]
        Insert = 1,
        [Description("Update")]
        Update,
        [Description("Error")]
        Error
    }
}
