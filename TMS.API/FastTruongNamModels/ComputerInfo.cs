using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ComputerInfo
    {
        public string ComputerName { get; set; }
        public string UName { get; set; }
        public string Networked { get; set; }
        public string DomainName { get; set; }
        public string LogonServer { get; set; }
        public string TimeSinceReboot { get; set; }
        public string LastBootState { get; set; }
        public string WinVer { get; set; }
        public string WinDir { get; set; }
        public string SysDir { get; set; }
        public string MemoryInfo { get; set; }
        public string DriveInfo { get; set; }
        public string Note { get; set; }
        public string SystemInfo { get; set; }
    }
}
