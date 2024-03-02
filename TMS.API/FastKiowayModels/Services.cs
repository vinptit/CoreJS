using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class Services
    {
        public string ID { get; set; }
        public string ServiceName { get; set; }
        public string VName { get; set; }
        public string Type { get; set; }
        public string CategoryID { get; set; }
        public string Commodity { get; set; }
        public string CarrierID { get; set; }
        public string AgentID { get; set; }
        public string CustomerID { get; set; }
        public string POLC { get; set; }
        public string PODC { get; set; }
        public string RouteAssigned { get; set; }
        public string ServiceMode { get; set; }
        public string Unit { get; set; }
        public bool? GW { get; set; }
        public double? QtyStart { get; set; }
        public double? QtyEnd { get; set; }
        public double? Amount { get; set; }
        public double? VAT { get; set; }
        public string Curr { get; set; }
        public string PartnerID { get; set; }
        public string FUnit { get; set; }
        public bool srActive { get; set; }
        public string Whois { get; set; }
        public int? Priority { get; set; }
        public string Mode { get; set; }
        public bool Syscronize { get; set; }
        public string FeeCode { get; set; }
        public string CompID { get; set; }
        public bool? BDPM { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public string SVType { get; set; }
        public string ERPC { get; set; }
        public string ListACRef { get; set; }
        public double? KMS { get; set; }
        public string CDSType { get; set; }
        public string TruckStatusLinked { get; set; }
        public string TruckStatus { get; set; }
        public string TruckSubServiceLinked { get; set; }
        public int? CDSModify { get; set; }
        public string COForm { get; set; }
        public string SHPTType { get; set; }
        public double? QtyLimit { get; set; }
        public string LitmitUnit { get; set; }
        public string ACFormular { get; set; }
        public double? MinAmount { get; set; }
        public double? MaxAmount { get; set; }
        public decimal? TASKREGISTERID { get; set; }
        public string GroupID { get; set; }
        public bool? PHYTO { get; set; }
        public string PMTerm { get; set; }
        public string QuoNo { get; set; }
        public bool? OBH { get; set; }
        public DateTime? EffectDate { get; set; }
        public DateTime? ValidityDate { get; set; }
        public double? FuelQty { get; set; }

        public virtual EcusCategory Category { get; set; }
    }
}
