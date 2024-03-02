using System;
using System.Collections.Generic;

namespace TMS.API.Models
{
    public partial class National
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string NameVN { get; set; }
        public string Zip { get; set; }
        public string FullNameVN { get; set; }
        public string NameEN { get; set; }
        public string FullNameEN { get; set; }
        public string Language { get; set; }
        public bool Active { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
