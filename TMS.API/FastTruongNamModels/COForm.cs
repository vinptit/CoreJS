using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class COForm
    {
        public COForm()
        {
            COFormDetails = new HashSet<COFormDetails>();
        }

        public string RefNo { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public string Username { get; set; }
        public string CONo { get; set; }
        public DateTime? CODate { get; set; }
        public string CDSNo { get; set; }
        public DateTime? CDSDate { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string BLNO { get; set; }
        public DateTime? BLDate { get; set; }
        public string Country { get; set; }
        public string COForm1 { get; set; }
        public string COType { get; set; }
        public int? COTime { get; set; }
        public string COPlace { get; set; }
        public string ShipperID1 { get; set; }
        public string ShipperID2 { get; set; }
        public string ConsigneeID { get; set; }
        public string ContractNo { get; set; }
        public DateTime? ContactDate { get; set; }
        public bool? Finished { get; set; }
        public string Notes { get; set; }
        public string POL { get; set; }
        public string POD { get; set; }
        public string VesselName { get; set; }
        public string Voyage { get; set; }
        public int? COQty { get; set; }

        public virtual ICollection<COFormDetails> COFormDetails { get; set; }
    }
}
