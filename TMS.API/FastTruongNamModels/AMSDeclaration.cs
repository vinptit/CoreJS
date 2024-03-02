using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class AMSDeclaration
    {
        public AMSDeclaration()
        {
            AMSDeclarationDetails = new HashSet<AMSDeclarationDetails>();
        }

        public int IDKey { get; set; }
        public string RefNo { get; set; }
        public string AMSSMLRefNo { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ShipmentType { get; set; }
        public string OriginStation { get; set; }
        public string DestinationHandlingStation { get; set; }
        public string ForwardingAgent { get; set; }
        public string BillingAccount { get; set; }
        public string FDAInterested { get; set; }
        public string VesselName { get; set; }
        public string VesselFlag { get; set; }
        public string VoyageNumber { get; set; }
        public string IMO { get; set; }
        public string CarrierCode { get; set; }
        public DateTime? ETA { get; set; }
        public string HouseBillNumber { get; set; }
        public string OceanBillNumber { get; set; }
        public string MasterBillNumber { get; set; }
        public string CustomsEntryType { get; set; }
        public string ACIEntryType { get; set; }
        public string ReportNumber { get; set; }
        public string SCAC_Carrier { get; set; }
        public string SCAC_Secondary { get; set; }
        public string BillOfLadingType { get; set; }
        public string SendersUniqueReference { get; set; }
        public string AmendmentFlag { get; set; }
        public double? TotalPieces { get; set; }
        public string UnitOfMeasure { get; set; }
        public double? Totalkilos { get; set; }
        public string ReceiptPortCode { get; set; }
        public string ReceiptQualifier { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string POLPortCode { get; set; }
        public string POLQualifier { get; set; }
        public DateTime? POLDate { get; set; }
        public string LFPPortCode { get; set; }
        public string LFPQualifier { get; set; }
        public DateTime? LFPDate { get; set; }
        public string FUSDPPortCode { get; set; }
        public string FUSDPQualifier { get; set; }
        public DateTime? FUSDPDate { get; set; }
        public string PODPortCode { get; set; }
        public string PODQualifier { get; set; }
        public DateTime? PODDate { get; set; }
        public string LODPortCode { get; set; }
        public string LODQualifier { get; set; }
        public DateTime? LODDate { get; set; }
        public string SPAccountCode { get; set; }
        public string SPName { get; set; }
        public string SPStreetAddress1 { get; set; }
        public string SPStreetAddress2 { get; set; }
        public string SPCityStateZip { get; set; }
        public string SPCountry { get; set; }
        public string SPContact { get; set; }
        public string SPPhone { get; set; }
        public string CNAccountCode { get; set; }
        public string CNName { get; set; }
        public string CNStreetAddress1 { get; set; }
        public string CNStreetAddress2 { get; set; }
        public string CNCityStateZip { get; set; }
        public string CNCountry { get; set; }
        public string CNContact { get; set; }
        public string CNPhone { get; set; }
        public string NPAccountCode { get; set; }
        public string NPName { get; set; }
        public string NPStreetAddress1 { get; set; }
        public string NPStreetAddress2 { get; set; }
        public string NPCityStateZip { get; set; }
        public string NPCountry { get; set; }
        public string NPContact { get; set; }
        public string NPPhone { get; set; }
        public string UserEdit { get; set; }
        public bool? FTPUploaded { get; set; }
        public string VesselCode { get; set; }
        public bool? Requested { get; set; }
        public string MESSAGE_ID { get; set; }
        public string BLMESSAGE_ID { get; set; }
        public bool? BLRequested { get; set; }
        public DateTime? RequestedDate { get; set; }
        public DateTime? BLRequestedDate { get; set; }
        public bool? EditRequested { get; set; }
        public DateTime? EditRequestedDate { get; set; }
        public bool? BLEditRequested { get; set; }
        public DateTime? BLEditRequestedDate { get; set; }
        public bool? Submitted { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public bool? BLSubmitted { get; set; }
        public DateTime? BLSubmittedDate { get; set; }
        public string STATUS_TYPE { get; set; }
        public string CODE { get; set; }
        public string CODE_DESCRIPTION { get; set; }
        public string ADDITIONAL_REMARK { get; set; }
        public string BLSTATUS_TYPE { get; set; }
        public string BLCODE { get; set; }
        public string BLCODE_DESCRIPTION { get; set; }
        public string BLADDITIONAL_REMARK { get; set; }
        public string ISFMESSAGE_ID { get; set; }
        public bool? ISFRequested { get; set; }
        public DateTime? ISFRequestedDate { get; set; }
        public bool? ISFEditRequested { get; set; }
        public DateTime? ISFEditRequestedDate { get; set; }
        public bool? ISFSubmitted { get; set; }
        public DateTime? ISFSubmittedDate { get; set; }
        public string ISFSTATUS_TYPE { get; set; }
        public string ISFCODE_DESCRIPTION { get; set; }
        public string SPState { get; set; }
        public string SPZip { get; set; }
        public string CNState { get; set; }
        public string CNZip { get; set; }
        public string NPState { get; set; }
        public string NPZip { get; set; }
        public string ANPAccountCode { get; set; }
        public string ANPName { get; set; }
        public string ANPStreetAddress1 { get; set; }
        public string ANPStreetAddress2 { get; set; }
        public string ANPCityStateZip { get; set; }
        public string ANPState { get; set; }
        public string ANPZip { get; set; }
        public string ANPCountry { get; set; }
        public string ANPContact { get; set; }
        public string ANPPhone { get; set; }
        public string ACIDischargePort { get; set; }
        public string ACIDischargePortCode { get; set; }
        public string ACIDestinationPort { get; set; }
        public string ACIDestinationPortCode { get; set; }
        public string BondParticipant { get; set; }
        public string Action { get; set; }
        public string AMSFileBy { get; set; }
        public string ACIFileBy { get; set; }
        public string ISFFileBy { get; set; }

        public virtual HAWB HouseBillNumberNavigation { get; set; }
        public virtual ICollection<AMSDeclarationDetails> AMSDeclarationDetails { get; set; }
    }
}
