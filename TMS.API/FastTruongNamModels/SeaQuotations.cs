using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class SeaQuotations
    {
        public string QuoNo { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? QuoDate { get; set; }
        public DateTime? ValidDate { get; set; }
        public string Commodity { get; set; }
        public string Currency { get; set; }
        public string QuoTitle { get; set; }
        public string QuoSubject { get; set; }
        public DateTime? Modify { get; set; }
        public string ShipperID { get; set; }
        public string CustomerName { get; set; }
        public string Attn { get; set; }
        public string TelNo { get; set; }
        public string HeaderOb { get; set; }
        public string OceanFreight { get; set; }
        public string POL { get; set; }
        public string POD { get; set; }
        public string Volume { get; set; }
        public string LCL { get; set; }
        public string Cont20 { get; set; }
        public string Cont40 { get; set; }
        public string Cont40HQ { get; set; }
        public string Lines { get; set; }
        public string Customs { get; set; }
        public string CusDescription { get; set; }
        public string CusUnit { get; set; }
        public string CusFee { get; set; }
        public string CusCurrency { get; set; }
        public string CusNotes { get; set; }
        public string OtherCharges { get; set; }
        public string OtDescription { get; set; }
        public string OtUnit { get; set; }
        public string OtFee { get; set; }
        public string OtCurrency { get; set; }
        public string OtNotes { get; set; }
        public string FooterNotes { get; set; }
        public string InlandOrder { get; set; }
        public string Managed { get; set; }
        public string Service { get; set; }
        public bool? MngApproved { get; set; }
        public DateTime? DateApproved { get; set; }
        public string FHistory { get; set; }
        public int? SubSVInqID { get; set; }
        public bool? NominatedCargo { get; set; }
        public bool? UseAllin { get; set; }
        public string QuoAgentID { get; set; }
        public bool? SendApproval { get; set; }

        public virtual ContactsList ManagedNavigation { get; set; }
        public virtual Partners Shipper { get; set; }
    }
}
