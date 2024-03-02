using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class UpdateProcess
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public bool CloseApp { get; set; }
        public string ComputerLog { get; set; }
        public string CHINHANH { get; set; }
    }
}
