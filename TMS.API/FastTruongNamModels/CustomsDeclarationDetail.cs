using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class CustomsDeclarationDetail
    {
        public string MasoTK { get; set; }
        public int SoTT { get; set; }
        public string TenHang { get; set; }
        public string MasoHH { get; set; }
        public string Xuatxu { get; set; }
        public int? Ctns { get; set; }
        public string DVT { get; set; }
        public double? LuongHang { get; set; }
        public double? DonGiaNguyenTe { get; set; }
        public double? TriGiaNguyenTe { get; set; }
        public double? TriGiaTinhThue { get; set; }
        public double? ThuesuatNK { get; set; }
        public double? ThuesuatGTGT { get; set; }
        public double? ThuesuatTTDB { get; set; }
        public double? ThuesuatBVMT { get; set; }
        public double? ThukhacTyle { get; set; }
        public double? ThukhacSotien { get; set; }
        public double? GrossWeight { get; set; }
        public double? CBM { get; set; }
        public string CheDoUuDai { get; set; }

        public virtual CustomsDeclaration MasoTKNavigation { get; set; }
    }
}
