﻿using System;
using System.Collections.Generic;

namespace TMS.API.FastKiowayModels
{
    public partial class YourCompany
    {
        public YourCompany()
        {
            Departments = new HashSet<Departments>();
        }

        public string CmpID { get; set; }
        public string CompanyLocal { get; set; }
        public string Companyname { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string AddressLocal { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Taxcode { get; set; }
        public string VNAccountNo { get; set; }
        public string FNAccountNo { get; set; }
        public bool Active { get; set; }
        public string Location { get; set; }
        public string AccountNote { get; set; }
        public string Notes { get; set; }
        public string YearInstall { get; set; }
        public string YearInstallTrue { get; set; }
        public string IbanCode { get; set; }
        public string AccountName { get; set; }
        public string SwiftCode { get; set; }
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public string Paymentterms { get; set; }
        public short? ExportLockDays { get; set; }
        public short? ImportLockDays { get; set; }
        public short? DaysofReLock { get; set; }
        public short? DayofLockafterOpen { get; set; }
        public short? VCLock { get; set; }
        public short? DayofVCLockafterOpen { get; set; }
        public short? QuoApproveMode { get; set; }
        public double? AmountNeedSigned { get; set; }
        public string CurrAmount { get; set; }
        public bool? SettleInclude { get; set; }
        public bool? UserInvoice { get; set; }
        public bool? DisableCancelInvoice { get; set; }
        public bool? PaymentCurrUpdate { get; set; }
        public bool? LCLCBMRoundable { get; set; }
        public bool? ObligeAccount { get; set; }
        public bool? ObligeAccountCost { get; set; }
        public bool? RestrictEmptPartner { get; set; }
        public bool? InternalPartnerUseOnly { get; set; }
        public bool? MAWBF { get; set; }
        public bool? BillPartnerCodeSyn { get; set; }
        public bool? ViewLocalCurrency { get; set; }
        public bool? ShipmentNeedtoApprove { get; set; }
        public bool? CSApprovedPayment { get; set; }
        public bool? UseSynOBHPartner { get; set; }
        public bool? NeedAssignOPSPayment { get; set; }
        public int? SettlePaymentDay { get; set; }
        public bool? PublicNewPartner { get; set; }
        public bool? LockNewPartner { get; set; }
        public string ReportFolder { get; set; }
        public byte[] Logo { get; set; }
        public string EmpPhotoSize { get; set; }
        public int? ApproveMode { get; set; }
        public double? Tax { get; set; }
        public string TaxAccount { get; set; }
        public string TaxDescription { get; set; }
        public bool? FillUSDAmount { get; set; }
        public bool? ContManagement { get; set; }
        public bool? NewIDGenerateAfter { get; set; }
        public string BravoCostAcNo { get; set; }
        public string BravoRevAcNo { get; set; }
        public string BravoOBHAcNo { get; set; }
        public bool? VNmeseDesc { get; set; }
        public string NACCS_ID { get; set; }
        public string NACCS_PWD { get; set; }
        public string APP_AREA_IND { get; set; }
        public string CUST_ID { get; set; }
        public string FtpURL { get; set; }
        public string FtpUsername { get; set; }
        public string FtpPwd { get; set; }
        public string FtpDir { get; set; }
        public int? VATInvExportMode { get; set; }
        public int? DecimalNo { get; set; }
        public int? CurrDecimalNo { get; set; }
        public string SENDER_ID { get; set; }
        public bool? ChangeDefaultIllegal { get; set; }
        public bool? HBLQtySyn { get; set; }
        public string ManageOfficeID { get; set; }
        public bool? SynShipmentETD { get; set; }
        public bool? ForeignCurrRoundable { get; set; }
        public bool? LockedInvInpayment { get; set; }
        public string AMSSenderID { get; set; }
        public string AMSReceiverID { get; set; }
        public string AMSCUST_ID { get; set; }
        public int? LocalCurrencyDecimal { get; set; }
        public string SGLUnitList { get; set; }
        public bool? TransferLogCharges { get; set; }
        public bool? CDSManualInput { get; set; }
        public bool? ShowLotNo { get; set; }
        public string FHPrefix { get; set; }
        public string NomiPrefix { get; set; }
        public bool? VCLockAfterPrinted { get; set; }
        public bool? NolockDocument { get; set; }
        public int? DevicePFMode { get; set; }
        public bool? ExtoLocalCurrInVATInv { get; set; }
        public bool? LockChargesAfterInput { get; set; }
        public int? TotalShmtDefaultDisplay { get; set; }
        public bool? LeadsToPotential { get; set; }
        public bool? UseSystemJobNoDefine { get; set; }
        public bool? SeparateOfficeIDCharges { get; set; }
        public bool? DNVCBaseonVATInv { get; set; }
        public bool? NoIncludeCountry { get; set; }
        public string DFRPCurr { get; set; }
        public int? UnitCurrDecimalNo { get; set; }
        public bool? UpdateNewExchangeRate { get; set; }
        public bool? OwnerRestricted { get; set; }
        public bool? ACStaffDeleteEntire { get; set; }
        public string InttraBookerID { get; set; }
        public string InttraSenderID { get; set; }
        public string InttraFtpURL { get; set; }
        public string InttraFtpUsername { get; set; }
        public string InttraFtpPwd { get; set; }
        public string InttraFtpDir { get; set; }
        public bool? NoVATInRemoteCharges { get; set; }
        public string InttraFtpBKCDir { get; set; }
        public string InttraFtpSIDir { get; set; }
        public string InttraFtpTNTDir { get; set; }
        public bool? DirectACSettleCharges { get; set; }
        public string FtpRCDir { get; set; }
        public bool? AllowOPUpdatePartners { get; set; }
        public bool? DeniedChangeShipmentAfterSettled { get; set; }
        public int? FinishDaysLock { get; set; }
        public string LCDateFormat { get; set; }
        public string PLDateFormat { get; set; }
        public bool? LockShipmentAfterPrintPL { get; set; }
        public bool? BaseOnTotalAmount { get; set; }
        public bool? AgentUseInternal { get; set; }
        public bool? SupplierUseInternal { get; set; }
        public bool? OtherPartnerUseInternal { get; set; }
        public bool? ShipmentChangedNotify { get; set; }
        public bool? SynSellingRateToAN { get; set; }
        public bool? InvoiceNeedACCApp { get; set; }
        public bool? InvoiceNeedMNGApp { get; set; }
        public bool? StopSuggestExportBK { get; set; }
        public bool? SynNumberofBLtoBLType { get; set; }
        public bool? DeleteTempFilesAfterSubmit { get; set; }
        public int? QuarterHappySadFace { get; set; }
        public string InttraSIID { get; set; }
        public int? LocalCurrencyDecimalUnit { get; set; }
        public bool? NoRestrictOverDue { get; set; }
        public bool? OwnerRestrictedWithTotal { get; set; }
        public bool? HidePasswordCharAdmin { get; set; }
        public bool? AverageQarterOT { get; set; }
        public bool? SynVoucherPMForOBH { get; set; }
        public bool? IgnoreInvNoWhenCheckSettlementDuplicate { get; set; }
        public bool? LCSalesProfitBaseonUSDProfit { get; set; }
        public DateTime? VSDateNeedUpdateToRUN { get; set; }
        public bool? UseSubLockRange { get; set; }
        public bool? ExchangeUpdateWhenINVIssued { get; set; }
        public bool? TurnoffWrightLog { get; set; }
        public bool? TurnoffWrightLogEffectQuery { get; set; }
        public bool? AMSACISubmit { get; set; }
        public string ShipmentTypeList { get; set; }
        public double? MaxCompercentPF { get; set; }
        public bool? ACApproveAfterMNg { get; set; }
        public bool? AuthorizedStopAPP { get; set; }
        public bool? BILL_DO_RequireDOCSRelease { get; set; }
        public bool? UseKBSalesExForPaymentExchange { get; set; }
        public int? DeleteNonUsePotentialAfter { get; set; }
        public bool? EnforcePasswordPolicy { get; set; }
        public bool? OpenFileAfterExport { get; set; }
        public bool? EnableDuplicatedPartners { get; set; }
        public bool? EnableCustomerAdvanceTab { get; set; }
        public string ADVSTLCurrency { get; set; }
        public bool? ACAsignGroupByVATInvOnly { get; set; }

        public virtual InfoNote InfoNote { get; set; }
        public virtual ICollection<Departments> Departments { get; set; }
    }
}
