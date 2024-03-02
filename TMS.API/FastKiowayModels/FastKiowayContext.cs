using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TMS.API.FastKiowayModels
{
    public partial class FastKiowayContext : DbContext
    {
        public FastKiowayContext()
        {
        }

        public FastKiowayContext(DbContextOptions<FastKiowayContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ACCurrencyExchangeRate> ACCurrencyExchangeRate { get; set; }
        public virtual DbSet<ACDescripeReportConfig> ACDescripeReportConfig { get; set; }
        public virtual DbSet<ACDescripeReportDetailConfig> ACDescripeReportDetailConfig { get; set; }
        public virtual DbSet<ACExchangeRate> ACExchangeRate { get; set; }
        public virtual DbSet<ACFinanceForms> ACFinanceForms { get; set; }
        public virtual DbSet<ACPayRoll> ACPayRoll { get; set; }
        public virtual DbSet<ACPayrollDeploy> ACPayrollDeploy { get; set; }
        public virtual DbSet<ACSalaryConfig> ACSalaryConfig { get; set; }
        public virtual DbSet<ACTriaBalanceView> ACTriaBalanceView { get; set; }
        public virtual DbSet<ACTriaBalanceViewDetails> ACTriaBalanceViewDetails { get; set; }
        public virtual DbSet<ACVATCode> ACVATCode { get; set; }
        public virtual DbSet<AMSContainerCode> AMSContainerCode { get; set; }
        public virtual DbSet<AMSDeclaration> AMSDeclaration { get; set; }
        public virtual DbSet<AMSDeclarationDetails> AMSDeclarationDetails { get; set; }
        public virtual DbSet<AMSDeclarationReponse> AMSDeclarationReponse { get; set; }
        public virtual DbSet<AMSEQCTypeCode> AMSEQCTypeCode { get; set; }
        public virtual DbSet<AccessRight> AccessRight { get; set; }
        public virtual DbSet<AccessRightCTRL> AccessRightCTRL { get; set; }
        public virtual DbSet<AccessRightLevel> AccessRightLevel { get; set; }
        public virtual DbSet<AccountingSys> AccountingSys { get; set; }
        public virtual DbSet<AccsIncomeStatement> AccsIncomeStatement { get; set; }
        public virtual DbSet<AcsAccountsConvertConfig> AcsAccountsConvertConfig { get; set; }
        public virtual DbSet<AcsAccountsConvertHis> AcsAccountsConvertHis { get; set; }
        public virtual DbSet<AcsAssetDepreciation> AcsAssetDepreciation { get; set; }
        public virtual DbSet<AcsBalanceSheetConfig> AcsBalanceSheetConfig { get; set; }
        public virtual DbSet<AcsBalanceSheetView> AcsBalanceSheetView { get; set; }
        public virtual DbSet<AcsBalanceSheetViewDetail> AcsBalanceSheetViewDetail { get; set; }
        public virtual DbSet<AcsCashFlowView> AcsCashFlowView { get; set; }
        public virtual DbSet<AcsCashFlowViewDetail> AcsCashFlowViewDetail { get; set; }
        public virtual DbSet<AcsCashflowConfig> AcsCashflowConfig { get; set; }
        public virtual DbSet<AcsFixAssetManagement> AcsFixAssetManagement { get; set; }
        public virtual DbSet<AcsIncomeStatementAccount> AcsIncomeStatementAccount { get; set; }
        public virtual DbSet<AcsIncomeStatementDetail> AcsIncomeStatementDetail { get; set; }
        public virtual DbSet<AcsIncomstatementConfig> AcsIncomstatementConfig { get; set; }
        public virtual DbSet<AcsIncomstatementView> AcsIncomstatementView { get; set; }
        public virtual DbSet<AcsIncomstatementViewDetail> AcsIncomstatementViewDetail { get; set; }
        public virtual DbSet<AcsInstallPayment> AcsInstallPayment { get; set; }
        public virtual DbSet<AcsInstallPaymentDetails> AcsInstallPaymentDetails { get; set; }
        public virtual DbSet<AcsPartnerPayment> AcsPartnerPayment { get; set; }
        public virtual DbSet<AcsSetlementPayment> AcsSetlementPayment { get; set; }
        public virtual DbSet<AcsSetlementPaymentAttachedFiles> AcsSetlementPaymentAttachedFiles { get; set; }
        public virtual DbSet<AcsVoucherLockConfig> AcsVoucherLockConfig { get; set; }
        public virtual DbSet<AcsVoucherLockConfigHis> AcsVoucherLockConfigHis { get; set; }
        public virtual DbSet<ActiveUsers> ActiveUsers { get; set; }
        public virtual DbSet<AdvancePaymentRequest> AdvancePaymentRequest { get; set; }
        public virtual DbSet<AdvancePaymentRequestAttachedFiles> AdvancePaymentRequestAttachedFiles { get; set; }
        public virtual DbSet<AdvancePaymentRequestDetails> AdvancePaymentRequestDetails { get; set; }
        public virtual DbSet<AdvanceRequest> AdvanceRequest { get; set; }
        public virtual DbSet<AdvanceRequestAttachedFiles> AdvanceRequestAttachedFiles { get; set; }
        public virtual DbSet<AdvanceSettlementPayment> AdvanceSettlementPayment { get; set; }
        public virtual DbSet<AirFreightAdjust> AirFreightAdjust { get; set; }
        public virtual DbSet<AirFreightQuotationDetails> AirFreightQuotationDetails { get; set; }
        public virtual DbSet<AirFreightQuotations> AirFreightQuotations { get; set; }
        public virtual DbSet<AirFreightTracking> AirFreightTracking { get; set; }
        public virtual DbSet<AirPortPerKGSChargeable> AirPortPerKGSChargeable { get; set; }
        public virtual DbSet<AirfreightPrcing> AirfreightPrcing { get; set; }
        public virtual DbSet<AirfreightPrcingDetail> AirfreightPrcingDetail { get; set; }
        public virtual DbSet<Airports> Airports { get; set; }
        public virtual DbSet<Airports_SE> Airports_SE { get; set; }
        public virtual DbSet<ArrivalFreightCharges> ArrivalFreightCharges { get; set; }
        public virtual DbSet<ArrivalFreightChargesDefault> ArrivalFreightChargesDefault { get; set; }
        public virtual DbSet<AttachmentPermission> AttachmentPermission { get; set; }
        public virtual DbSet<AuthorizedApproval> AuthorizedApproval { get; set; }
        public virtual DbSet<BankCustomize> BankCustomize { get; set; }
        public virtual DbSet<BookingConfirmList> BookingConfirmList { get; set; }
        public virtual DbSet<BookingContainer> BookingContainer { get; set; }
        public virtual DbSet<BookingLocal> BookingLocal { get; set; }
        public virtual DbSet<BookingLocalAttachedFiles> BookingLocalAttachedFiles { get; set; }
        public virtual DbSet<BookingLocalRoutine> BookingLocalRoutine { get; set; }
        public virtual DbSet<BookingRateRequest> BookingRateRequest { get; set; }
        public virtual DbSet<BookingReQuestList> BookingReQuestList { get; set; }
        public virtual DbSet<BuyingRate> BuyingRate { get; set; }
        public virtual DbSet<BuyingRateFixCost> BuyingRateFixCost { get; set; }
        public virtual DbSet<BuyingRateInland> BuyingRateInland { get; set; }
        public virtual DbSet<BuyingRateOthers> BuyingRateOthers { get; set; }
        public virtual DbSet<BuyingRateTrucking> BuyingRateTrucking { get; set; }
        public virtual DbSet<BuyingRateWithHBL> BuyingRateWithHBL { get; set; }
        public virtual DbSet<COForm> COForm { get; set; }
        public virtual DbSet<COFormAttachedFiles> COFormAttachedFiles { get; set; }
        public virtual DbSet<COFormDetails> COFormDetails { get; set; }
        public virtual DbSet<COFormIssuedPlace> COFormIssuedPlace { get; set; }
        public virtual DbSet<COFormMaterialList> COFormMaterialList { get; set; }
        public virtual DbSet<COFormType> COFormType { get; set; }
        public virtual DbSet<COForms> COForms { get; set; }
        public virtual DbSet<COMaterialNorm> COMaterialNorm { get; set; }
        public virtual DbSet<CargoOperationRequest> CargoOperationRequest { get; set; }
        public virtual DbSet<CargoOperationRequestAttachedFiles> CargoOperationRequestAttachedFiles { get; set; }
        public virtual DbSet<CargoOperationRequestDetail> CargoOperationRequestDetail { get; set; }
        public virtual DbSet<Commodity> Commodity { get; set; }
        public virtual DbSet<ComputerInfo> ComputerInfo { get; set; }
        public virtual DbSet<ConsolidationRate> ConsolidationRate { get; set; }
        public virtual DbSet<ContTariffDemDepCharges> ContTariffDemDepCharges { get; set; }
        public virtual DbSet<ContactPartnerObligation> ContactPartnerObligation { get; set; }
        public virtual DbSet<ContactsList> ContactsList { get; set; }
        public virtual DbSet<ContainerBorrowDetail> ContainerBorrowDetail { get; set; }
        public virtual DbSet<ContainerBorrowExtend> ContainerBorrowExtend { get; set; }
        public virtual DbSet<ContainerBorrowReport> ContainerBorrowReport { get; set; }
        public virtual DbSet<ContainerCharges> ContainerCharges { get; set; }
        public virtual DbSet<ContainerFreightCharges> ContainerFreightCharges { get; set; }
        public virtual DbSet<ContainerListOnHBL> ContainerListOnHBL { get; set; }
        public virtual DbSet<ContainerLoaded> ContainerLoaded { get; set; }
        public virtual DbSet<ContainerLoadedHBL> ContainerLoadedHBL { get; set; }
        public virtual DbSet<ContainerLoadedInquiry> ContainerLoadedInquiry { get; set; }
        public virtual DbSet<ContainerLoadedSVR> ContainerLoadedSVR { get; set; }
        public virtual DbSet<ContainerPKExtension> ContainerPKExtension { get; set; }
        public virtual DbSet<ContainerRoutine> ContainerRoutine { get; set; }
        public virtual DbSet<ContainerTrans> ContainerTrans { get; set; }
        public virtual DbSet<ContainerTransType> ContainerTransType { get; set; }
        public virtual DbSet<ContainerTransactionDetails> ContainerTransactionDetails { get; set; }
        public virtual DbSet<ContainerTransactions> ContainerTransactions { get; set; }
        public virtual DbSet<ContainersList> ContainersList { get; set; }
        public virtual DbSet<ConvertToUnicode> ConvertToUnicode { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<CrossTabTable> CrossTabTable { get; set; }
        public virtual DbSet<CrosstabTableCaption> CrosstabTableCaption { get; set; }
        public virtual DbSet<CrosstabTableCaptionTemplate> CrosstabTableCaptionTemplate { get; set; }
        public virtual DbSet<CurrExchangeLocalSystem> CurrExchangeLocalSystem { get; set; }
        public virtual DbSet<CurrencyExchangeRate> CurrencyExchangeRate { get; set; }
        public virtual DbSet<CustomsDeclaration> CustomsDeclaration { get; set; }
        public virtual DbSet<CustomsDeclarationDetail> CustomsDeclarationDetail { get; set; }
        public virtual DbSet<DODishList> DODishList { get; set; }
        public virtual DbSet<DOManaged> DOManaged { get; set; }
        public virtual DbSet<DOOrderDetail> DOOrderDetail { get; set; }
        public virtual DbSet<DOOrderList> DOOrderList { get; set; }
        public virtual DbSet<DOPaymentSheet> DOPaymentSheet { get; set; }
        public virtual DbSet<DOSupplierList> DOSupplierList { get; set; }
        public virtual DbSet<DataSourceSetup> DataSourceSetup { get; set; }
        public virtual DbSet<DataSourceSetupFieldDefine> DataSourceSetupFieldDefine { get; set; }
        public virtual DbSet<DataSourceSetupSearch> DataSourceSetupSearch { get; set; }
        public virtual DbSet<DataSourceSetupSearchExecQuery> DataSourceSetupSearchExecQuery { get; set; }
        public virtual DbSet<DataSourceSetupSubtotalSetting> DataSourceSetupSubtotalSetting { get; set; }
        public virtual DbSet<DebitMemory> DebitMemory { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<DisplayConfigInformation> DisplayConfigInformation { get; set; }
        public virtual DbSet<ECUSConnection> ECUSConnection { get; set; }
        public virtual DbSet<ECusCucHQ> ECusCucHQ { get; set; }
        public virtual DbSet<EDIStructure> EDIStructure { get; set; }
        public virtual DbSet<EDIStructureCharReplace> EDIStructureCharReplace { get; set; }
        public virtual DbSet<EDIStructureDT> EDIStructureDT { get; set; }
        public virtual DbSet<EDIStructureDTSub> EDIStructureDTSub { get; set; }
        public virtual DbSet<EDOSetting> EDOSetting { get; set; }
        public virtual DbSet<EDOSettingStatus> EDOSettingStatus { get; set; }
        public virtual DbSet<EcusCategory> EcusCategory { get; set; }
        public virtual DbSet<EcusCuakhau> EcusCuakhau { get; set; }
        public virtual DbSet<EcusJobApply> EcusJobApply { get; set; }
        public virtual DbSet<ExcelReportConfig> ExcelReportConfig { get; set; }
        public virtual DbSet<ExcelReportConfigDetails> ExcelReportConfigDetails { get; set; }
        public virtual DbSet<ExchangeRate> ExchangeRate { get; set; }
        public virtual DbSet<ExpressZonePrice> ExpressZonePrice { get; set; }
        public virtual DbSet<ExpressZonePriceColoaders> ExpressZonePriceColoaders { get; set; }
        public virtual DbSet<FTPConfig> FTPConfig { get; set; }
        public virtual DbSet<FTPProcess> FTPProcess { get; set; }
        public virtual DbSet<FTPSourceConfig> FTPSourceConfig { get; set; }
        public virtual DbSet<FormBillList> FormBillList { get; set; }
        public virtual DbSet<FormControlList> FormControlList { get; set; }
        public virtual DbSet<FormControlListDT> FormControlListDT { get; set; }
        public virtual DbSet<FormList> FormList { get; set; }
        public virtual DbSet<FtpAttFileType> FtpAttFileType { get; set; }
        public virtual DbSet<FtpFilesAttUpload> FtpFilesAttUpload { get; set; }
        public virtual DbSet<FunctionList> FunctionList { get; set; }
        public virtual DbSet<FunctionListCompactToGrid> FunctionListCompactToGrid { get; set; }
        public virtual DbSet<FunctionListFieldCompact> FunctionListFieldCompact { get; set; }
        public virtual DbSet<FunctionListFieldConditions> FunctionListFieldConditions { get; set; }
        public virtual DbSet<GAGENT> GAGENT { get; set; }
        public virtual DbSet<GroupList> GroupList { get; set; }
        public virtual DbSet<HAWB> HAWB { get; set; }
        public virtual DbSet<HAWBDETAILS> HAWBDETAILS { get; set; }
        public virtual DbSet<HAWBRATE> HAWBRATE { get; set; }
        public virtual DbSet<HAWBSEPDetails> HAWBSEPDetails { get; set; }
        public virtual DbSet<HAWBTranshipment> HAWBTranshipment { get; set; }
        public virtual DbSet<HandleServiceRate> HandleServiceRate { get; set; }
        public virtual DbSet<INNER_ISIPTOFASTPRO> INNER_ISIPTOFASTPRO { get; set; }
        public virtual DbSet<InfoNote> InfoNote { get; set; }
        public virtual DbSet<InnerConnection> InnerConnection { get; set; }
        public virtual DbSet<InnerConnectionDetail> InnerConnectionDetail { get; set; }
        public virtual DbSet<InquiryFollowUpStatus> InquiryFollowUpStatus { get; set; }
        public virtual DbSet<InquiryFollowUpStatusDetails> InquiryFollowUpStatusDetails { get; set; }
        public virtual DbSet<InttraCheckStatusHistory> InttraCheckStatusHistory { get; set; }
        public virtual DbSet<InvoiceForm> InvoiceForm { get; set; }
        public virtual DbSet<InvoiceFormDTS> InvoiceFormDTS { get; set; }
        public virtual DbSet<InvoiceFormDefault> InvoiceFormDefault { get; set; }
        public virtual DbSet<InvoiceRefGrouping> InvoiceRefGrouping { get; set; }
        public virtual DbSet<InvoiceReference> InvoiceReference { get; set; }
        public virtual DbSet<InvoiceReferenceDetail> InvoiceReferenceDetail { get; set; }
        public virtual DbSet<InvoiceReferenceMode> InvoiceReferenceMode { get; set; }
        public virtual DbSet<InvoiceSOA> InvoiceSOA { get; set; }
        public virtual DbSet<JobApplyExchangeRate> JobApplyExchangeRate { get; set; }
        public virtual DbSet<MailSendingMsg> MailSendingMsg { get; set; }
        public virtual DbSet<MainMenu> MainMenu { get; set; }
        public virtual DbSet<MainTool> MainTool { get; set; }
        public virtual DbSet<MenuSubList> MenuSubList { get; set; }
        public virtual DbSet<NACCS_CNTR> NACCS_CNTR { get; set; }
        public virtual DbSet<NACCS_HBL> NACCS_HBL { get; set; }
        public virtual DbSet<NACCS_MBL> NACCS_MBL { get; set; }
        public virtual DbSet<NACCS_PARTY> NACCS_PARTY { get; set; }
        public virtual DbSet<NameFeeAcDefault> NameFeeAcDefault { get; set; }
        public virtual DbSet<NameFeeDescription> NameFeeDescription { get; set; }
        public virtual DbSet<OPSManagement> OPSManagement { get; set; }
        public virtual DbSet<OPSManagementAttachedFiles> OPSManagementAttachedFiles { get; set; }
        public virtual DbSet<OPSManagementDefaultList> OPSManagementDefaultList { get; set; }
        public virtual DbSet<OPSRequestType> OPSRequestType { get; set; }
        public virtual DbSet<OnlineSupportConnect> OnlineSupportConnect { get; set; }
        public virtual DbSet<OnlineSupports> OnlineSupports { get; set; }
        public virtual DbSet<OnlineSupportsAttachedFiles> OnlineSupportsAttachedFiles { get; set; }
        public virtual DbSet<Opportunity> Opportunity { get; set; }
        public virtual DbSet<OpportunityAttachedFiles> OpportunityAttachedFiles { get; set; }
        public virtual DbSet<PODetail> PODetail { get; set; }
        public virtual DbSet<POList> POList { get; set; }
        public virtual DbSet<POListAttachedFiles> POListAttachedFiles { get; set; }
        public virtual DbSet<PackageType> PackageType { get; set; }
        public virtual DbSet<PackingListDetails> PackingListDetails { get; set; }
        public virtual DbSet<PackingLists> PackingLists { get; set; }
        public virtual DbSet<PartnerContact> PartnerContact { get; set; }
        public virtual DbSet<PartnerContactAttachedFiles> PartnerContactAttachedFiles { get; set; }
        public virtual DbSet<PartnerIDMaker> PartnerIDMaker { get; set; }
        public virtual DbSet<PartnerTransactions> PartnerTransactions { get; set; }
        public virtual DbSet<PartnerTransactionsAttachedFiles> PartnerTransactionsAttachedFiles { get; set; }
        public virtual DbSet<Partners> Partners { get; set; }
        public virtual DbSet<PartnersAttachedFiles> PartnersAttachedFiles { get; set; }
        public virtual DbSet<PartnersCARRIER> PartnersCARRIER { get; set; }
        public virtual DbSet<PartnersCargo> PartnersCargo { get; set; }
        public virtual DbSet<PartnersCargoAttachedFiles> PartnersCargoAttachedFiles { get; set; }
        public virtual DbSet<PartnersEDIMapping> PartnersEDIMapping { get; set; }
        public virtual DbSet<PersonalProfile> PersonalProfile { get; set; }
        public virtual DbSet<PhieuThuChi> PhieuThuChi { get; set; }
        public virtual DbSet<PhieuThuChiDetail> PhieuThuChiDetail { get; set; }
        public virtual DbSet<PhieuThuChiDetails> PhieuThuChiDetails { get; set; }
        public virtual DbSet<PhieuThuChiMULTI> PhieuThuChiMULTI { get; set; }
        public virtual DbSet<PhieuThuChiMULTIDT> PhieuThuChiMULTIDT { get; set; }
        public virtual DbSet<PhieuThuChiPL> PhieuThuChiPL { get; set; }
        public virtual DbSet<PhieuThuChiPLDetail> PhieuThuChiPLDetail { get; set; }
        public virtual DbSet<PhieuThuChiTaxReport> PhieuThuChiTaxReport { get; set; }
        public virtual DbSet<PriceCenterDetails> PriceCenterDetails { get; set; }
        public virtual DbSet<PriceCenters> PriceCenters { get; set; }
        public virtual DbSet<ProductMaintenance> ProductMaintenance { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProfitShareCalc> ProfitShareCalc { get; set; }
        public virtual DbSet<ProfitShareCalcDetail> ProfitShareCalcDetail { get; set; }
        public virtual DbSet<ProfitShares> ProfitShares { get; set; }
        public virtual DbSet<ProfitSharesCost> ProfitSharesCost { get; set; }
        public virtual DbSet<QUOTATIONDETAILS> QUOTATIONDETAILS { get; set; }
        public virtual DbSet<QUOTATIONDETAILSOTS> QUOTATIONDETAILSOTS { get; set; }
        public virtual DbSet<QUOTATIONS> QUOTATIONS { get; set; }
        public virtual DbSet<QuoSentHistory> QuoSentHistory { get; set; }
        public virtual DbSet<QuotationFreightDetail> QuotationFreightDetail { get; set; }
        public virtual DbSet<RateHistory> RateHistory { get; set; }
        public virtual DbSet<RateTemp> RateTemp { get; set; }
        public virtual DbSet<SMTPServerConfig> SMTPServerConfig { get; set; }
        public virtual DbSet<SOFTEKVIEW> SOFTEKVIEW { get; set; }
        public virtual DbSet<STAFFLOCATION> STAFFLOCATION { get; set; }
        public virtual DbSet<SalesCurrencyExchange> SalesCurrencyExchange { get; set; }
        public virtual DbSet<SalesIncentive> SalesIncentive { get; set; }
        public virtual DbSet<SalesIncentiveDetails> SalesIncentiveDetails { get; set; }
        public virtual DbSet<SeaBookingContainer> SeaBookingContainer { get; set; }
        public virtual DbSet<SeaBookingNote> SeaBookingNote { get; set; }
        public virtual DbSet<SeaBookingRequest> SeaBookingRequest { get; set; }
        public virtual DbSet<SeaBookingRequestCargo> SeaBookingRequestCargo { get; set; }
        public virtual DbSet<SeaBookingRequestCarriage> SeaBookingRequestCarriage { get; set; }
        public virtual DbSet<SeaBookingRequestContainers> SeaBookingRequestContainers { get; set; }
        public virtual DbSet<SeaBookingRequestPaymentDetails> SeaBookingRequestPaymentDetails { get; set; }
        public virtual DbSet<SeaFreightPricing> SeaFreightPricing { get; set; }
        public virtual DbSet<SeaFreightPricingDetail> SeaFreightPricingDetail { get; set; }
        public virtual DbSet<SeaQuotationCtnrs> SeaQuotationCtnrs { get; set; }
        public virtual DbSet<SeaQuotationDetails> SeaQuotationDetails { get; set; }
        public virtual DbSet<SeaQuotationOthers> SeaQuotationOthers { get; set; }
        public virtual DbSet<SeaQuotations> SeaQuotations { get; set; }
        public virtual DbSet<SellingRate> SellingRate { get; set; }
        public virtual DbSet<SendMails> SendMails { get; set; }
        public virtual DbSet<SendMailsAttachedFiles> SendMailsAttachedFiles { get; set; }
        public virtual DbSet<ServiceInquiry> ServiceInquiry { get; set; }
        public virtual DbSet<ServiceInquiryDetails> ServiceInquiryDetails { get; set; }
        public virtual DbSet<ServiceInquiryDetailsAttachedFiles> ServiceInquiryDetailsAttachedFiles { get; set; }
        public virtual DbSet<ServiceInquiryRate> ServiceInquiryRate { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<ShipmentChargesActivities> ShipmentChargesActivities { get; set; }
        public virtual DbSet<ShippingDetails> ShippingDetails { get; set; }
        public virtual DbSet<ShippingDetailsAttachedFiles> ShippingDetailsAttachedFiles { get; set; }
        public virtual DbSet<ShippingInstruction> ShippingInstruction { get; set; }
        public virtual DbSet<ShippingInstructionGoodsDetail> ShippingInstructionGoodsDetail { get; set; }
        public virtual DbSet<StartUpMasseages> StartUpMasseages { get; set; }
        public virtual DbSet<StartUpMasseagesAttached> StartUpMasseagesAttached { get; set; }
        public virtual DbSet<StartUpMasseagesView> StartUpMasseagesView { get; set; }
        public virtual DbSet<SupplychainDetails> SupplychainDetails { get; set; }
        public virtual DbSet<SupplychainDetailsAttachedFiles> SupplychainDetailsAttachedFiles { get; set; }
        public virtual DbSet<SystemIDConfig> SystemIDConfig { get; set; }
        public virtual DbSet<SystemIDConfigDTLS> SystemIDConfigDTLS { get; set; }
        public virtual DbSet<SystemIDConfigDTLSSub> SystemIDConfigDTLSSub { get; set; }
        public virtual DbSet<SystemIDConfigDetail> SystemIDConfigDetail { get; set; }
        public virtual DbSet<TASK> TASK { get; set; }
        public virtual DbSet<TASKREGISTERS> TASKREGISTERS { get; set; }
        public virtual DbSet<TableFieldsDescription> TableFieldsDescription { get; set; }
        public virtual DbSet<TasksList> TasksList { get; set; }
        public virtual DbSet<TempMsg> TempMsg { get; set; }
        public virtual DbSet<ToKhaiThue> ToKhaiThue { get; set; }
        public virtual DbSet<TrackAndTraceMT> TrackAndTraceMT { get; set; }
        public virtual DbSet<TrackingExpress> TrackingExpress { get; set; }
        public virtual DbSet<TransServiceType> TransServiceType { get; set; }
        public virtual DbSet<TransTracking> TransTracking { get; set; }
        public virtual DbSet<TransactionDetails> TransactionDetails { get; set; }
        public virtual DbSet<TransactionDetailsRelatedPartners> TransactionDetailsRelatedPartners { get; set; }
        public virtual DbSet<TransactionInfo> TransactionInfo { get; set; }
        public virtual DbSet<TransactionInfoDetail> TransactionInfoDetail { get; set; }
        public virtual DbSet<TransactionLog> TransactionLog { get; set; }
        public virtual DbSet<TransactionType> TransactionType { get; set; }
        public virtual DbSet<TransactionTypeDetail> TransactionTypeDetail { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<TransactionsChange> TransactionsChange { get; set; }
        public virtual DbSet<TransactionsChangeHis> TransactionsChangeHis { get; set; }
        public virtual DbSet<UN_LOC_Code> UN_LOC_Code { get; set; }
        public virtual DbSet<UnitContents> UnitContents { get; set; }
        public virtual DbSet<UpdateProcess> UpdateProcess { get; set; }
        public virtual DbSet<VATInvSOA> VATInvSOA { get; set; }
        public virtual DbSet<VATInvoice> VATInvoice { get; set; }
        public virtual DbSet<VATInvoiceDetail> VATInvoiceDetail { get; set; }
        public virtual DbSet<VATInvoiceDetailAT> VATInvoiceDetailAT { get; set; }
        public virtual DbSet<VATInvoiceDetailSource> VATInvoiceDetailSource { get; set; }
        public virtual DbSet<VATInvoiceLog> VATInvoiceLog { get; set; }
        public virtual DbSet<VATInvoiceSyncLog> VATInvoiceSyncLog { get; set; }
        public virtual DbSet<VehicleAlerterConfig> VehicleAlerterConfig { get; set; }
        public virtual DbSet<VehicleAlerterHistory> VehicleAlerterHistory { get; set; }
        public virtual DbSet<VehicleFuelConsumption> VehicleFuelConsumption { get; set; }
        public virtual DbSet<VehicleList> VehicleList { get; set; }
        public virtual DbSet<VehicleServiceFeeDefined> VehicleServiceFeeDefined { get; set; }
        public virtual DbSet<VehicleServiceFeeDefinedHis> VehicleServiceFeeDefinedHis { get; set; }
        public virtual DbSet<Vessel> Vessel { get; set; }
        public virtual DbSet<VesselSchedules> VesselSchedules { get; set; }
        public virtual DbSet<YourCompany> YourCompany { get; set; }
        public virtual DbSet<ZoneCountry> ZoneCountry { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCurrencyExchangeRate>(entity =>
            {
                entity.HasKey(e => new { e.ID, e.Unit });

                entity.Property(e => e.ID).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.ExtVNDSales).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtVNDSalesKB).HasDefaultValueSql("((0))");

                entity.Property(e => e.Note).HasMaxLength(150);

                entity.Property(e => e.Price).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IDNavigation)
                    .WithMany(p => p.ACCurrencyExchangeRate)
                    .HasForeignKey(d => d.ID)
                    .HasConstraintName("FK_ACCurrencyExchangeRate_ACExchangeRate");
            });

            modelBuilder.Entity<ACDescripeReportConfig>(entity =>
            {
                entity.HasKey(e => e.ACReportID)
                    .HasName("PK_ACDescripeReport");

                entity.Property(e => e.ACReportID).HasMaxLength(50);

                entity.Property(e => e.ACReport).HasMaxLength(50);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.TemplateFile).HasMaxLength(255);
            });

            modelBuilder.Entity<ACDescripeReportDetailConfig>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ACReportID).HasMaxLength(50);

                entity.Property(e => e.AccountRef).HasMaxLength(255);

                entity.Property(e => e.Activate).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreditBL).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DebitBL).HasDefaultValueSql("((0))");

                entity.Property(e => e.Debt).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExAccountRef).HasMaxLength(255);

                entity.Property(e => e.FormName).HasMaxLength(50);

                entity.Property(e => e.Formular).HasMaxLength(50);

                entity.Property(e => e.Item).HasMaxLength(50);

                entity.Property(e => e.ItemID).HasMaxLength(50);

                entity.Property(e => e.MinusAC).HasDefaultValueSql("((0))");

                entity.Property(e => e.RPSource).HasMaxLength(50);

                entity.Property(e => e.UseOpenAMT).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.HasOne(d => d.ACReport)
                    .WithMany(p => p.ACDescripeReportDetailConfig)
                    .HasForeignKey(d => d.ACReportID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ACDescripeReportDetailConfig_ACDescripeReportConfig");
            });

            modelBuilder.Entity<ACExchangeRate>(entity =>
            {
                entity.Property(e => e.ID).HasMaxLength(50);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.CompIDList).HasMaxLength(255);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<ACFinanceForms>(entity =>
            {
                entity.HasKey(e => e.FormID);

                entity.Property(e => e.FormID).HasMaxLength(50);

                entity.Property(e => e.FormName).HasMaxLength(50);
            });

            modelBuilder.Entity<ACPayRoll>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AllowanceCOtherNotes).HasMaxLength(255);

                entity.Property(e => e.AllowanceOthersDescription).HasMaxLength(255);

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.DateApply).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IDLinked).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PRDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.PRDeletedHistory).HasMaxLength(255);

                entity.Property(e => e.UserInput).HasMaxLength(50);
            });

            modelBuilder.Entity<ACPayrollDeploy>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Notes).HasMaxLength(255);
            });

            modelBuilder.Entity<ACSalaryConfig>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccountCo).HasMaxLength(50);

                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.AllowanceCOtherNotes).HasMaxLength(255);

                entity.Property(e => e.AllowanceOthersDescription).HasMaxLength(255);

                entity.Property(e => e.ByCash).HasDefaultValueSql("((0))");

                entity.Property(e => e.ComObiligationHealthyPerAC).HasMaxLength(50);

                entity.Property(e => e.ComObiligationSocialPerAC).HasMaxLength(50);

                entity.Property(e => e.ComObiligationUnemployPerAC).HasMaxLength(50);

                entity.Property(e => e.ComObiligationUnionPerAC).HasMaxLength(50);

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DeductionFamilyAC).HasMaxLength(50);

                entity.Property(e => e.DeductionPersonelAC).HasMaxLength(50);

                entity.Property(e => e.HealthyPerAC).HasMaxLength(50);

                entity.Property(e => e.PMACNo).HasMaxLength(50);

                entity.Property(e => e.PRDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.PRDeletedHistory).HasMaxLength(255);

                entity.Property(e => e.SocialPerAC).HasMaxLength(50);

                entity.Property(e => e.TaxableAC).HasMaxLength(50);

                entity.Property(e => e.UnemplPerAC).HasMaxLength(50);

                entity.Property(e => e.UnionPerAC).HasMaxLength(50);

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ACSalaryConfig)
                    .HasForeignKey(d => d.ContactID)
                    .HasConstraintName("FK_ACSalaryConfig_ContactsList");
            });

            modelBuilder.Entity<ACTriaBalanceView>(entity =>
            {
                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ENView).HasDefaultValueSql("((0))");

                entity.Property(e => e.FormName).HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.PCName).HasMaxLength(50);

                entity.Property(e => e.SelACNo).HasMaxLength(150);

                entity.Property(e => e.Whois).HasMaxLength(50);
            });

            modelBuilder.Entity<ACTriaBalanceViewDetails>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.ACName).HasMaxLength(150);

                entity.Property(e => e.ACNo).HasMaxLength(50);

                entity.Property(e => e.Bold).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ACVATCode>(entity =>
            {
                entity.HasKey(e => e.VATCode);

                entity.Property(e => e.VATCode).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.VNDescription).HasMaxLength(150);
            });

            modelBuilder.Entity<AMSContainerCode>(entity =>
            {
                entity.HasKey(e => e.ContainerCode);

                entity.Property(e => e.ContainerCode)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.ContainerDesc).HasMaxLength(50);
            });

            modelBuilder.Entity<AMSDeclaration>(entity =>
            {
                entity.HasKey(e => e.IDKey)
                    .HasName("PK_AMSDelcaration");

                entity.Property(e => e.ACIDestinationPort).HasMaxLength(255);

                entity.Property(e => e.ACIDestinationPortCode).HasMaxLength(50);

                entity.Property(e => e.ACIDischargePort).HasMaxLength(255);

                entity.Property(e => e.ACIDischargePortCode).HasMaxLength(50);

                entity.Property(e => e.ACIEntryType)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.ADDITIONAL_REMARK).HasMaxLength(255);

                entity.Property(e => e.AMSSMLRefNo).HasMaxLength(50);

                entity.Property(e => e.ANPAccountCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ANPCityStateZip)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.ANPContact)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.ANPCountry)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.ANPName)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.ANPPhone)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.ANPState)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.ANPStreetAddress1)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.ANPStreetAddress2)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.ANPZip)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Action)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.AmendmentFlag)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.BLADDITIONAL_REMARK).HasMaxLength(255);

                entity.Property(e => e.BLCODE).HasMaxLength(255);

                entity.Property(e => e.BLCODE_DESCRIPTION).HasMaxLength(255);

                entity.Property(e => e.BLEditRequested).HasDefaultValueSql("((0))");

                entity.Property(e => e.BLEditRequestedDate).HasColumnType("datetime");

                entity.Property(e => e.BLMESSAGE_ID).HasMaxLength(50);

                entity.Property(e => e.BLRequested).HasDefaultValueSql("((0))");

                entity.Property(e => e.BLRequestedDate).HasColumnType("datetime");

                entity.Property(e => e.BLSTATUS_TYPE).HasMaxLength(255);

                entity.Property(e => e.BLSubmitted).HasDefaultValueSql("((0))");

                entity.Property(e => e.BLSubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.BillOfLadingType)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.BillingAccount).HasMaxLength(50);

                entity.Property(e => e.BondParticipant)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.CNAccountCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CNCityStateZip)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.CNContact)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CNCountry)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.CNName)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.CNPhone)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CNState)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CNStreetAddress1)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.CNStreetAddress2)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.CNZip)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.CODE).HasMaxLength(255);

                entity.Property(e => e.CODE_DESCRIPTION).HasMaxLength(255);

                entity.Property(e => e.CarrierCode)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomsEntryType)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.DestinationHandlingStation).HasMaxLength(255);

                entity.Property(e => e.ETA).HasColumnType("datetime");

                entity.Property(e => e.EditRequested).HasDefaultValueSql("((0))");

                entity.Property(e => e.EditRequestedDate).HasColumnType("datetime");

                entity.Property(e => e.FDAInterested)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.FTPUploaded).HasDefaultValueSql("((0))");

                entity.Property(e => e.FUSDPDate).HasColumnType("datetime");

                entity.Property(e => e.FUSDPPortCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FUSDPQualifier)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ForwardingAgent).HasMaxLength(255);

                entity.Property(e => e.HouseBillNumber).HasMaxLength(50);

                entity.Property(e => e.IMO)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.ISFCODE_DESCRIPTION).HasMaxLength(255);

                entity.Property(e => e.ISFEditRequested).HasDefaultValueSql("((0))");

                entity.Property(e => e.ISFEditRequestedDate).HasColumnType("datetime");

                entity.Property(e => e.ISFMESSAGE_ID).HasMaxLength(50);

                entity.Property(e => e.ISFRequested).HasDefaultValueSql("((0))");

                entity.Property(e => e.ISFRequestedDate).HasColumnType("datetime");

                entity.Property(e => e.ISFSTATUS_TYPE).HasMaxLength(255);

                entity.Property(e => e.ISFSubmitted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ISFSubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.LFPDate).HasColumnType("datetime");

                entity.Property(e => e.LFPPortCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LFPQualifier)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LODDate).HasColumnType("datetime");

                entity.Property(e => e.LODPortCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LODQualifier)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MESSAGE_ID).HasMaxLength(50);

                entity.Property(e => e.MasterBillNumber)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NPAccountCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NPCityStateZip)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NPContact)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.NPCountry)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.NPName)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NPPhone)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.NPState)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.NPStreetAddress1)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NPStreetAddress2)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NPZip)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.OceanBillNumber)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.OriginStation).HasMaxLength(50);

                entity.Property(e => e.PODDate).HasColumnType("datetime");

                entity.Property(e => e.PODPortCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PODQualifier)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.POLDate).HasColumnType("datetime");

                entity.Property(e => e.POLPortCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.POLQualifier)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiptPortCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ReceiptQualifier)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.ReportNumber)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.Requested).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequestedDate).HasColumnType("datetime");

                entity.Property(e => e.SCAC_Carrier)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.SCAC_Secondary)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.SPAccountCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SPCityStateZip)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.SPContact)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.SPCountry)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.SPName)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.SPPhone)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.SPState)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.SPStreetAddress1)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.SPStreetAddress2)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.SPZip)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.STATUS_TYPE).HasMaxLength(255);

                entity.Property(e => e.SendersUniqueReference)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ShipmentType)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Submitted).HasDefaultValueSql("((0))");

                entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.UnitOfMeasure)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.UserEdit).HasMaxLength(50);

                entity.Property(e => e.VesselCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.VesselFlag)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.VesselName).HasMaxLength(50);

                entity.Property(e => e.VoyageNumber)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.HasOne(d => d.HouseBillNumberNavigation)
                    .WithMany(p => p.AMSDeclaration)
                    .HasForeignKey(d => d.HouseBillNumber)
                    .HasConstraintName("FK_AMSDeclaration_HAWB");
            });

            modelBuilder.Entity<AMSDeclarationDetails>(entity =>
            {
                entity.HasKey(e => e.IDKey)
                    .HasName("PK_AMSCleclarationDetails");

                entity.Property(e => e.CTNUnitOfMeasure)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ContainerCode).HasMaxLength(50);

                entity.Property(e => e.ContainerStatus).HasMaxLength(50);

                entity.Property(e => e.CountryOrigin).HasMaxLength(50);

                entity.Property(e => e.EMERGENCY_CONTACT_NAME)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.EMERGENCY_CONTACT_PHONE).HasMaxLength(50);

                entity.Property(e => e.EquipmentInitial)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.EquipmentNum)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.EquipmentSuffix)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.EquipmentTypeCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FreeFormDescription)
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.HAZARDOUS_CLASS)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.HAZARDOUS_CODE_QUALIFIER)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.HAZARDOUS_DESC)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.HSCode).HasMaxLength(50);

                entity.Property(e => e.HazmatCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MarksAndNumbers)
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.OwnerID).HasMaxLength(10);

                entity.Property(e => e.Seal)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Seal2)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.UOM).HasMaxLength(50);

                entity.HasOne(d => d.IDLinkedNavigation)
                    .WithMany(p => p.AMSDeclarationDetails)
                    .HasForeignKey(d => d.IDLinked)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AMSDeclarationDetails_AMSDeclaration");
            });

            modelBuilder.Entity<AMSDeclarationReponse>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey).ValueGeneratedNever();

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.CBPProcessingTime).HasColumnType("datetime");

                entity.Property(e => e.CBPRemarks).HasMaxLength(1000);

                entity.Property(e => e.DispositionCode).HasMaxLength(50);

                entity.Property(e => e.ResponseID).HasMaxLength(50);
            });

            modelBuilder.Entity<AMSEQCTypeCode>(entity =>
            {
                entity.HasKey(e => e.EQCCode);

                entity.Property(e => e.EQCCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.EQCDesc).HasMaxLength(50);
            });

            modelBuilder.Entity<AccessRight>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("aaaaaAccessRight_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.UserName, "ContactsListAccessRight")
                    .IsUnique();

                entity.HasIndex(e => e.KeyLog, "KeyLog");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.ALLUSERSDefaultCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.AcSOADelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.AcSOAPayment).HasDefaultValueSql("((0))");

                entity.Property(e => e.AcSOARead).HasDefaultValueSql("((0))");

                entity.Property(e => e.AcSOASave).HasDefaultValueSql("((0))");

                entity.Property(e => e.AcsCTRLUnUpdate).HasDefaultValueSql("((0))");

                entity.Property(e => e.AcsCTRLUpdate).HasDefaultValueSql("((0))");

                entity.Property(e => e.AdvancePaymentDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.AdvanceSettlementCTRLRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.AdvanceSettlementCTRLUpdate).HasDefaultValueSql("((0))");

                entity.Property(e => e.AirExpfixedCostDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.AirExpfixedCostRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.AirExpfixedCostSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.AirImpfixedCostDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.AirImpfixedCostRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.AirImpfixedCostSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.AssetManagement).HasDefaultValueSql("((0))");

                entity.Property(e => e.AssetManagementDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.BKCreatorProfitRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.BKRequestDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.BKRequestRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.BKRequestSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.CSDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.CSRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.CSSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.CargoReceiptDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.CargoReceiptRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.CargoReceiptSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.ChargesAC).HasDefaultValueSql("((0))");

                entity.Property(e => e.ChargesRequestApproval).HasDefaultValueSql("((0))");

                entity.Property(e => e.ConsigneeCtrl).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContainerManagement).HasDefaultValueSql("((0))");

                entity.Property(e => e.DELETEHANDLINGTASK).HasDefaultValueSql("((0))");

                entity.Property(e => e.DebtRecordRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeniedCreateNewPN).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeniedExportMNReport).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeniedIssueInv).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeniedViewAirVendor).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeniedViewComm).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeniedViewSeaVendor).HasDefaultValueSql("((0))");

                entity.Property(e => e.DocsRelease).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpressfixedCostDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpressfixedCostRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpressfixedCostSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.FNDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.FNRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.FNSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupListUpdate).HasDefaultValueSql("((0))");

                entity.Property(e => e.InlandfixedCostDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.InlandfixedCostRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.InlandfixedCostSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.KeyLog).HasMaxLength(255);

                entity.Property(e => e.Leads).HasDefaultValueSql("((0))");

                entity.Property(e => e.LockShipment).HasDefaultValueSql("((0))");

                entity.Property(e => e.LogfixedCostDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.LogfixedCostRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.LogfixedCostSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.NameFeeControl).HasDefaultValueSql("((0))");

                entity.Property(e => e.OPSDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.OPSRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.OPSSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.PODelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.PORead).HasDefaultValueSql("((0))");

                entity.Property(e => e.POSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartnerAuth).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartnerCreditTermFieldsEditable).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartnerENFieldsEditable).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartnerLCFieldsEditable).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartnerMNGFieldsEditable).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartnersReadExport).HasDefaultValueSql("((0))");

                entity.Property(e => e.PersonalPartnerEditNonOwner).HasDefaultValueSql("((0))");

                entity.Property(e => e.PortIndexEdit).HasDefaultValueSql("((0))");

                entity.Property(e => e.Potential).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProfitExchange).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProfitRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectfixedCostDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectfixedCostRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectfixedCostSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.RestrictAP).HasDefaultValueSql("((0))");

                entity.Property(e => e.RestrictAR).HasDefaultValueSql("((0))");

                entity.Property(e => e.RestrictDefaultCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.RestrictInfo).HasMaxLength(255);

                entity.Property(e => e.RestrictSELVCRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.RestrictUNSELVCRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.SALESDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.SALESRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.SALESSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesIncentive).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesmanChange).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaCSLExpfixedCostDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaCSLExpfixedCostRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaCSLExpfixedCostSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaCSLImpfixedCostDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaCSLImpfixedCostRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaCSLImpfixedCostSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaFCLImpfixedCostDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaFCLImpfixedCostRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaFCLImpfixedCostSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaFCLfixedCostDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaFCLfixedCostRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaFCLfixedCostSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaLCLExpfixedCostDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaLCLExpfixedCostRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaLCLExpfixedCostSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaLCLImpfixedCostDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaLCLImpfixedCostRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaLCLImpfixedCostSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShipmentPaymentCTRLUpdate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShipperCtrl).HasDefaultValueSql("((0))");

                entity.Property(e => e.TTDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.TTRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.TTSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateGainLoss).HasDefaultValueSql("((0))");

                entity.Property(e => e.VCLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.VCUnlock).HasDefaultValueSql("((0))");

                entity.Property(e => e.VehicleManagement).HasDefaultValueSql("((0))");

                entity.Property(e => e.VehicleNorm).HasDefaultValueSql("((0))");

                entity.Property(e => e.ViewBKCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.VoucherManagement).HasDefaultValueSql("((0))");

                entity.Property(e => e.VoucherManagementDelete).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithOne(p => p.AccessRightNavigation)
                    .HasPrincipalKey<ContactsList>(p => p.Username)
                    .HasForeignKey<AccessRight>(d => d.UserName)
                    .HasConstraintName("AccessRight_FK00");
            });

            modelBuilder.Entity<AccessRightCTRL>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.NotVisible).HasDefaultValueSql("((0))");

                entity.Property(e => e.RightName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RightNameDisplay).HasMaxLength(50);
            });

            modelBuilder.Entity<AccessRightLevel>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccessDescription).HasMaxLength(50);

                entity.Property(e => e.AccessRight).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<AccountingSys>(entity =>
            {
                entity.HasKey(e => e.AccountID)
                    .HasName("aaaaaAccountingSys_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.AccountID, "AccountID");

                entity.HasIndex(e => e.Code, "Code");

                entity.HasIndex(e => e.AccountID, "IX_AccountingSys");

                entity.Property(e => e.AccountID).HasMaxLength(50);

                entity.Property(e => e.BKAccNo).HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.IcmID).HasMaxLength(50);

                entity.Property(e => e.MAPAC).HasMaxLength(50);

                entity.Property(e => e.MaxCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoDisplayTrialBL).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OrignalCurr).HasMaxLength(50);

                entity.Property(e => e.PartnerLocation).HasMaxLength(50);

                entity.Property(e => e.SynToTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxAC).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Icm)
                    .WithMany(p => p.AccountingSys)
                    .HasForeignKey(d => d.IcmID)
                    .HasConstraintName("FK_AccountingSys_AcsIncomeStatementAccount");
            });

            modelBuilder.Entity<AccsIncomeStatement>(entity =>
            {
                entity.HasKey(e => e.PMID)
                    .HasName("aaaaaAccsIncomeStatement_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.WhoisIssued, "ContactsListAccsIncomeStatement");

                entity.HasIndex(e => e.PMID, "PMID");

                entity.Property(e => e.PMID).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.WhoisIssued).HasMaxLength(50);

                entity.HasOne(d => d.WhoisIssuedNavigation)
                    .WithMany(p => p.AccsIncomeStatement)
                    .HasPrincipalKey(p => p.Username)
                    .HasForeignKey(d => d.WhoisIssued)
                    .HasConstraintName("AccsIncomeStatement_FK00");
            });

            modelBuilder.Entity<AcsAccountsConvertConfig>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.AMTFormular).HasMaxLength(255);

                entity.Property(e => e.CompanyID).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DeptCode).HasMaxLength(50);

                entity.Property(e => e.GroupOnJob).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupOnPartner).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobAppOnly).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoTKChuyen).HasMaxLength(50);

                entity.Property(e => e.SoTKKet).HasMaxLength(50);

                entity.Property(e => e.TKCoChuyen).HasDefaultValueSql("((0))");

                entity.Property(e => e.TKCoKet).HasDefaultValueSql("((0))");

                entity.Property(e => e.TKNoChuyen).HasDefaultValueSql("((0))");

                entity.Property(e => e.TKNoKet).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<AcsAccountsConvertHis>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.DateApply).HasColumnType("datetime");

                entity.Property(e => e.PCUpdate).HasMaxLength(50);

                entity.Property(e => e.ServerDate).HasColumnType("datetime");

                entity.Property(e => e.UserUpdate).HasMaxLength(50);

                entity.HasOne(d => d.IDLinkedNavigation)
                    .WithMany(p => p.AcsAccountsConvertHis)
                    .HasForeignKey(d => d.IDLinked)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AcsAccountsConvertHis_AcsAccountsConvertConfig");
            });

            modelBuilder.Entity<AcsAssetDepreciation>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.AssetID).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.Property(e => e.VoucherID).HasMaxLength(50);

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AcsAssetDepreciation)
                    .HasForeignKey(d => d.AssetID)
                    .HasConstraintName("FK_AcsAssetDepreciation_AcsFixAssetManagement");
            });

            modelBuilder.Entity<AcsBalanceSheetConfig>(entity =>
            {
                entity.Property(e => e.AccountRef).HasMaxLength(255);

                entity.Property(e => e.AcsCode).HasMaxLength(50);

                entity.Property(e => e.AcsFormular).HasMaxLength(255);

                entity.Property(e => e.Activate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bold).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.CreditBL).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DebitBL).HasDefaultValueSql("((0))");

                entity.Property(e => e.Debt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DescriptionEN).HasMaxLength(255);

                entity.Property(e => e.ExAccountRef).HasMaxLength(255);

                entity.Property(e => e.Expression).HasMaxLength(50);

                entity.Property(e => e.FormName).HasMaxLength(50);

                entity.Property(e => e.HideR).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinusAC).HasDefaultValueSql("((0))");

                entity.Property(e => e.Root).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserInput).HasMaxLength(50);
            });

            modelBuilder.Entity<AcsBalanceSheetView>(entity =>
            {
                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.FormName).HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Whois).HasMaxLength(50);
            });

            modelBuilder.Entity<AcsBalanceSheetViewDetail>(entity =>
            {
                entity.HasKey(e => e.KeyID);

                entity.Property(e => e.AccountRef).HasMaxLength(255);

                entity.Property(e => e.AcsCode).HasMaxLength(50);

                entity.Property(e => e.AcsFormular).HasMaxLength(255);

                entity.Property(e => e.Activate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bold).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.CreditBL).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DebitBL).HasDefaultValueSql("((0))");

                entity.Property(e => e.Debt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DescriptionEN).HasMaxLength(255);

                entity.Property(e => e.ExAccountRef).HasMaxLength(255);

                entity.Property(e => e.Expression).HasMaxLength(50);

                entity.Property(e => e.FormName).HasMaxLength(50);

                entity.Property(e => e.HideR).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinusAC).HasDefaultValueSql("((0))");

                entity.Property(e => e.Root).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.HasOne(d => d.IDLinkNavigation)
                    .WithMany(p => p.AcsBalanceSheetViewDetail)
                    .HasForeignKey(d => d.IDLink)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AcsBalanceSheetViewDetail_AcsBalanceSheetView");
            });

            modelBuilder.Entity<AcsCashFlowView>(entity =>
            {
                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.FormName).HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Whois).HasMaxLength(50);
            });

            modelBuilder.Entity<AcsCashFlowViewDetail>(entity =>
            {
                entity.HasKey(e => e.KeyID);

                entity.Property(e => e.AccountRef).HasMaxLength(255);

                entity.Property(e => e.AcsCode).HasMaxLength(50);

                entity.Property(e => e.AcsFormular).HasMaxLength(255);

                entity.Property(e => e.Activate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bold).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.CreditBL).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DebitBL).HasDefaultValueSql("((0))");

                entity.Property(e => e.Debt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DescriptionEN).HasMaxLength(255);

                entity.Property(e => e.ExAccountRef).HasMaxLength(255);

                entity.Property(e => e.Expression).HasMaxLength(50);

                entity.Property(e => e.FormName).HasMaxLength(50);

                entity.Property(e => e.HideR).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinusAC).HasDefaultValueSql("((0))");

                entity.Property(e => e.Root).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.HasOne(d => d.IDLinkNavigation)
                    .WithMany(p => p.AcsCashFlowViewDetail)
                    .HasForeignKey(d => d.IDLink)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AcsCashFlowViewDetail_AcsCashFlowView");
            });

            modelBuilder.Entity<AcsCashflowConfig>(entity =>
            {
                entity.Property(e => e.AccountRef).HasMaxLength(255);

                entity.Property(e => e.AcsCode).HasMaxLength(50);

                entity.Property(e => e.AcsFormular).HasMaxLength(255);

                entity.Property(e => e.Activate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bold).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.CreditBL).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DebitBL).HasDefaultValueSql("((0))");

                entity.Property(e => e.Debt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DescriptionEN).HasMaxLength(255);

                entity.Property(e => e.ExAccountRef).HasMaxLength(255);

                entity.Property(e => e.Expression).HasMaxLength(50);

                entity.Property(e => e.FormName).HasMaxLength(50);

                entity.Property(e => e.HideR).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinusAC).HasDefaultValueSql("((0))");

                entity.Property(e => e.Root).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserInput).HasMaxLength(50);
            });

            modelBuilder.Entity<AcsFixAssetManagement>(entity =>
            {
                entity.HasKey(e => e.FixAssetID);

                entity.Property(e => e.FixAssetID).HasMaxLength(50);

                entity.Property(e => e.AssetLockEdit).HasDefaultValueSql("(0)");

                entity.Property(e => e.BuyingDate).HasColumnType("datetime");

                entity.Property(e => e.ChargeCode).HasMaxLength(50);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Depreciation).HasDefaultValueSql("(0)");

                entity.Property(e => e.DepreciationStart).HasColumnType("datetime");

                entity.Property(e => e.DeptID).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FixAssetName).HasMaxLength(255);

                entity.Property(e => e.GTGLDate).HasColumnType("datetime");

                entity.Property(e => e.Liquidation).HasDefaultValueSql("((0))");

                entity.Property(e => e.LiquidationDate).HasColumnType("datetime");

                entity.Property(e => e.LiquidationDesc).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OriginCountry).HasMaxLength(50);

                entity.Property(e => e.TKCP).HasMaxLength(50);

                entity.Property(e => e.TKKH).HasMaxLength(50);

                entity.Property(e => e.TKTSCD).HasMaxLength(50);

                entity.Property(e => e.TS1).HasMaxLength(50);

                entity.Property(e => e.TS2).HasMaxLength(50);

                entity.Property(e => e.TS3).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UserInput).HasMaxLength(50);
            });

            modelBuilder.Entity<AcsIncomeStatementAccount>(entity =>
            {
                entity.HasKey(e => e.IncmstID)
                    .HasName("aaaaaAcsIncomeStatementAccount_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.IncmstID, "IncmstID");

                entity.Property(e => e.IncmstID).HasMaxLength(50);

                entity.Property(e => e.ItemDes).HasMaxLength(255);
            });

            modelBuilder.Entity<AcsIncomeStatementDetail>(entity =>
            {
                entity.HasKey(e => new { e.PMID, e.ID })
                    .HasName("aaaaaAcsIncomeStatementDetail_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.PMID, "AccsIncomeStatementAcsIncomeStatementDetail");

                entity.HasIndex(e => e.RefNo, "AcsIncomeStatementAccountAcsIncomeStatementDetail");

                entity.HasIndex(e => e.CodeDes, "CodeDes");

                entity.HasIndex(e => e.ID, "ID");

                entity.HasIndex(e => e.PMID, "PMID");

                entity.HasIndex(e => e.TagID, "TagID");

                entity.Property(e => e.PMID).HasMaxLength(50);

                entity.Property(e => e.CodeDes).HasMaxLength(50);

                entity.Property(e => e.FormularDes).HasMaxLength(255);

                entity.Property(e => e.Including).HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemDes).HasMaxLength(255);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.TTAmount).HasDefaultValueSql("(0)");

                entity.Property(e => e.TagID).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.PM)
                    .WithMany(p => p.AcsIncomeStatementDetail)
                    .HasForeignKey(d => d.PMID)
                    .HasConstraintName("AcsIncomeStatementDetail_FK00");

                entity.HasOne(d => d.RefNoNavigation)
                    .WithMany(p => p.AcsIncomeStatementDetail)
                    .HasForeignKey(d => d.RefNo)
                    .HasConstraintName("AcsIncomeStatementDetail_FK01");
            });

            modelBuilder.Entity<AcsIncomstatementConfig>(entity =>
            {
                entity.Property(e => e.AccountRef).HasMaxLength(255);

                entity.Property(e => e.AcsCode).HasMaxLength(50);

                entity.Property(e => e.AcsFormular).HasMaxLength(255);

                entity.Property(e => e.Activate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bold).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.Cond1).HasMaxLength(1000);

                entity.Property(e => e.Cond2).HasMaxLength(1000);

                entity.Property(e => e.Cond3).HasMaxLength(1000);

                entity.Property(e => e.CreditBL).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DebitBL).HasDefaultValueSql("((0))");

                entity.Property(e => e.Debt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DescriptionEN).HasMaxLength(255);

                entity.Property(e => e.ExAccountRef).HasMaxLength(255);

                entity.Property(e => e.Expression).HasMaxLength(50);

                entity.Property(e => e.FormName).HasMaxLength(50);

                entity.Property(e => e.HideR).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinusAC).HasDefaultValueSql("((0))");

                entity.Property(e => e.Root).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserInput).HasMaxLength(50);
            });

            modelBuilder.Entity<AcsIncomstatementView>(entity =>
            {
                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.FormName).HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Whois).HasMaxLength(50);
            });

            modelBuilder.Entity<AcsIncomstatementViewDetail>(entity =>
            {
                entity.HasKey(e => e.KeyID);

                entity.Property(e => e.AccountRef).HasMaxLength(255);

                entity.Property(e => e.AcsCode).HasMaxLength(50);

                entity.Property(e => e.AcsFormular).HasMaxLength(255);

                entity.Property(e => e.Activate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bold).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.Cond1).HasMaxLength(1000);

                entity.Property(e => e.Cond2).HasMaxLength(1000);

                entity.Property(e => e.Cond3).HasMaxLength(1000);

                entity.Property(e => e.CreditBL).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DebitBL).HasDefaultValueSql("((0))");

                entity.Property(e => e.Debt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DescriptionEN).HasMaxLength(255);

                entity.Property(e => e.ExAccountRef).HasMaxLength(255);

                entity.Property(e => e.Expression).HasMaxLength(50);

                entity.Property(e => e.FormName).HasMaxLength(50);

                entity.Property(e => e.HideR).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinusAC).HasDefaultValueSql("((0))");

                entity.Property(e => e.Root).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.HasOne(d => d.IDLinkNavigation)
                    .WithMany(p => p.AcsIncomstatementViewDetail)
                    .HasForeignKey(d => d.IDLink)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AcsIncomstatementViewDetail_AcsIncomstatementView");
            });

            modelBuilder.Entity<AcsInstallPayment>(entity =>
            {
                entity.HasKey(e => e.KeyField);

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DateInput).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.DoituongVAT).HasMaxLength(255);

                entity.Property(e => e.Dpt).HasDefaultValueSql("((0))");

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.HBLNo).HasMaxLength(50);

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.JobID).HasMaxLength(50);

                entity.Property(e => e.KeyFieldSource).HasMaxLength(50);

                entity.Property(e => e.MSTVAT).HasMaxLength(50);

                entity.Property(e => e.MathangVAT).HasMaxLength(255);

                entity.Property(e => e.NgayHD).HasColumnType("datetime");

                entity.Property(e => e.PCUser).HasMaxLength(50);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.SoCT).HasMaxLength(50);

                entity.Property(e => e.SoHD).HasMaxLength(50);

                entity.Property(e => e.SoSeriVAT).HasMaxLength(50);

                entity.Property(e => e.SoTKDU).HasMaxLength(50);

                entity.Property(e => e.SoTKVAT).HasMaxLength(50);

                entity.Property(e => e.Source_data).HasMaxLength(50);

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.Property(e => e.VATInvoiceID).HasMaxLength(50);

                entity.HasOne(d => d.HBLNoNavigation)
                    .WithMany(p => p.AcsInstallPayment)
                    .HasForeignKey(d => d.HBLNo)
                    .HasConstraintName("FK_AcsInstallPayment_HAWB");
            });

            modelBuilder.Entity<AcsInstallPaymentDetails>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CurrUnit).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.HBLNo).HasMaxLength(50);

                entity.Property(e => e.IDKeyIndex).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InputBy).HasMaxLength(50);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.Partof).HasDefaultValueSql("((0))");

                entity.Property(e => e.TableSource).HasMaxLength(50);

                entity.Property(e => e.UnitQty).HasMaxLength(50);
            });

            modelBuilder.Entity<AcsPartnerPayment>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DateInput).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DatePaid).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Finish).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.Receivable).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.WhoisPaid).HasMaxLength(50);

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.AcsPartnerPayment)
                    .HasForeignKey(d => d.PartnerID)
                    .HasConstraintName("FK_AcsPartnerPayment_Partners");
            });

            modelBuilder.Entity<AcsSetlementPayment>(entity =>
            {
                entity.HasKey(e => e.SetleID)
                    .HasName("aaaaaAcsSetlementPayment_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.SltBODID, "AdvAcsDpManageID");

                entity.HasIndex(e => e.SltDpManagerID, "AdvDpManageID");

                entity.HasIndex(e => e.SltAcsDpManagerID, "AdvDpManageID1");

                entity.HasIndex(e => e.AdvNo, "AdvNo");

                entity.HasIndex(e => e.AdvNo10, "AdvNo10");

                entity.HasIndex(e => e.AdvNo2, "AdvNo2");

                entity.HasIndex(e => e.AdvNo3, "AdvNo3");

                entity.HasIndex(e => e.AdvNo4, "AdvNo4");

                entity.HasIndex(e => e.AdvNo5, "AdvNo5");

                entity.HasIndex(e => e.AdvNo6, "AdvNo6");

                entity.HasIndex(e => e.AdvNo7, "AdvNo7");

                entity.HasIndex(e => e.AdvNo8, "AdvNo8");

                entity.HasIndex(e => e.AdvNo9, "AdvNo9");

                entity.HasIndex(e => new { e.AdvNo, e.AdvListNo }, "AdvNo_AdvListNo");

                entity.HasIndex(e => e.SltContactID, "AdvanceContactID");

                entity.HasIndex(e => e.SetleID, "AdvanceID");

                entity.HasIndex(e => e.AdvNo, "AdvancePaymentRequestAcsSetlementPayment");

                entity.HasIndex(e => e.AmountSettle, "AmountSettle");

                entity.HasIndex(e => e.ClearStatus, "ClearStatus");

                entity.HasIndex(e => e.SltContactID, "ContactsListAcsSetlementPayment");

                entity.HasIndex(e => e.SetleID, "SetleID");

                entity.HasIndex(e => e.SltAcsDpManagerAu2ID, "SltAcsDpManagerAu2ID_AcsSetlementPayment");

                entity.HasIndex(e => e.SltAcsDpManagerAuID, "SltAcsDpManagerAuID_AcsSetlementPayment");

                entity.HasIndex(e => e.SltBOAuDID, "SltBOAuDID_AcsSetlementPayment");

                entity.HasIndex(e => e.SltContactID, "SltContactID");

                entity.HasIndex(e => e.SltDpManagerAuID, "SltDpManagerAuID_AcsSetlementPayment");

                entity.Property(e => e.SetleID).HasMaxLength(50);

                entity.Property(e => e.AcsApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.AdvListNo).HasMaxLength(255);

                entity.Property(e => e.AdvNo).HasMaxLength(50);

                entity.Property(e => e.AdvNo10).HasMaxLength(50);

                entity.Property(e => e.AdvNo2).HasMaxLength(50);

                entity.Property(e => e.AdvNo3).HasMaxLength(50);

                entity.Property(e => e.AdvNo4).HasMaxLength(50);

                entity.Property(e => e.AdvNo5).HasMaxLength(50);

                entity.Property(e => e.AdvNo6).HasMaxLength(50);

                entity.Property(e => e.AdvNo7).HasMaxLength(50);

                entity.Property(e => e.AdvNo8).HasMaxLength(50);

                entity.Property(e => e.AdvNo9).HasMaxLength(50);

                entity.Property(e => e.AmountSettle).HasDefaultValueSql("((0))");

                entity.Property(e => e.Attached).HasColumnType("ntext");

                entity.Property(e => e.Cancelled).HasDefaultValueSql("((0))");

                entity.Property(e => e.CancelledDate).HasColumnType("datetime");

                entity.Property(e => e.ClearDate).HasColumnType("datetime");

                entity.Property(e => e.GroupVoucherID).HasMaxLength(50);

                entity.Property(e => e.InvoiceNoList).HasMaxLength(150);

                entity.Property(e => e.NoLink).HasDefaultValueSql("((0))");

                entity.Property(e => e.PMRequisitionID).HasMaxLength(50);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.SettleCurrency).HasMaxLength(50);

                entity.Property(e => e.SltAcsCashierName).HasMaxLength(50);

                entity.Property(e => e.SltAcsDpManagerAu2ID).HasMaxLength(50);

                entity.Property(e => e.SltAcsDpManagerAu2Name).HasMaxLength(50);

                entity.Property(e => e.SltAcsDpManagerAuID).HasMaxLength(50);

                entity.Property(e => e.SltAcsDpManagerAuName).HasMaxLength(50);

                entity.Property(e => e.SltAcsDpManagerID).HasMaxLength(50);

                entity.Property(e => e.SltAcsDpManagerName).HasMaxLength(50);

                entity.Property(e => e.SltAcsSignDate).HasColumnType("datetime");

                entity.Property(e => e.SltAddress).HasMaxLength(50);

                entity.Property(e => e.SltBOAuDID).HasMaxLength(50);

                entity.Property(e => e.SltBODAuName).HasMaxLength(50);

                entity.Property(e => e.SltBODID).HasMaxLength(50);

                entity.Property(e => e.SltBODName).HasMaxLength(50);

                entity.Property(e => e.SltBODSignDate).HasColumnType("datetime");

                entity.Property(e => e.SltCSName).HasMaxLength(50);

                entity.Property(e => e.SltCSSignDate).HasColumnType("datetime");

                entity.Property(e => e.SltCSStickApp).HasDefaultValueSql("((0))");

                entity.Property(e => e.SltCSStickDeny).HasDefaultValueSql("((0))");

                entity.Property(e => e.SltCSStickWait).HasDefaultValueSql("((0))");

                entity.Property(e => e.SltCashier).HasMaxLength(50);

                entity.Property(e => e.SltCashierDate).HasColumnType("datetime");

                entity.Property(e => e.SltContact).HasMaxLength(50);

                entity.Property(e => e.SltContactID).HasMaxLength(50);

                entity.Property(e => e.SltDpComment).HasMaxLength(255);

                entity.Property(e => e.SltDpManagerAuID).HasMaxLength(50);

                entity.Property(e => e.SltDpManagerAuName).HasMaxLength(50);

                entity.Property(e => e.SltDpManagerID).HasMaxLength(50);

                entity.Property(e => e.SltDpManagerName).HasMaxLength(50);

                entity.Property(e => e.SltDpSignDate).HasColumnType("datetime");

                entity.Property(e => e.SltNote)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.SltPaymentCheck).HasMaxLength(255);

                entity.Property(e => e.SltPaymentNote).HasMaxLength(150);

                entity.Property(e => e.SltSCID).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.StlCurr).HasMaxLength(50);

                entity.Property(e => e.StlDescription).HasMaxLength(255);

                entity.Property(e => e.StltDate).HasColumnType("datetime");

                entity.Property(e => e.StltModifyDate).HasColumnType("datetime");

                entity.Property(e => e.StltRealDate).HasColumnType("datetime");

                entity.Property(e => e.ViceChecked).HasDefaultValueSql("((0))");

                entity.Property(e => e.ViceCheckedDate).HasColumnType("datetime");

                entity.Property(e => e.ViceCheckedUser).HasMaxLength(50);

                entity.Property(e => e.WhoisClear).HasMaxLength(50);

                entity.HasOne(d => d.SltContactNavigation)
                    .WithMany(p => p.AcsSetlementPayment)
                    .HasForeignKey(d => d.SltContactID)
                    .HasConstraintName("AcsSetlementPayment_FK01");
            });

            modelBuilder.Entity<AcsSetlementPaymentAttachedFiles>(entity =>
            {
                entity.HasKey(e => e.FieldKey);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SettledNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit).HasMaxLength(50);

                entity.HasOne(d => d.SettledNoNavigation)
                    .WithMany(p => p.AcsSetlementPaymentAttachedFiles)
                    .HasForeignKey(d => d.SettledNo)
                    .HasConstraintName("FK_AcsSetlementPaymentAttachedFiles_AcsSetlementPayment");
            });

            modelBuilder.Entity<AcsVoucherLockConfig>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.ACLock).HasMaxLength(255);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Locked).HasDefaultValueSql("((0))");

                entity.Property(e => e.PCName).HasMaxLength(50);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<AcsVoucherLockConfigHis>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.ACLock).HasMaxLength(255);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Locked).HasDefaultValueSql("((0))");

                entity.Property(e => e.PCName).HasMaxLength(50);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.IDLinkedNavigation)
                    .WithMany(p => p.AcsVoucherLockConfigHis)
                    .HasForeignKey(d => d.IDLinked)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AcsVoucherLockConfigHis_AcsVoucherLockConfig");
            });

            modelBuilder.Entity<ActiveUsers>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Username, "User");

                entity.Property(e => e.AppPath).HasMaxLength(255);

                entity.Property(e => e.AppRevision).HasColumnType("datetime");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.IPAddress).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.Offlinedate).HasColumnType("datetime");

                entity.Property(e => e.Onlinedate).HasColumnType("datetime");

                entity.Property(e => e.ProcessID).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<AdvancePaymentRequest>(entity =>
            {
                entity.HasKey(e => e.AdvID)
                    .HasName("aaaaaAdvancePaymentRequest_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.AdvBODID, "AdvAcsDpManageID");

                entity.HasIndex(e => e.AdvAcsDpManagerAu2ID, "AdvAcsDpManagerAu2ID_AdvancePaymentRequest");

                entity.HasIndex(e => e.AdvAcsDpManagerAuID, "AdvAcsDpManagerAuID_AdvancePaymentRequest");

                entity.HasIndex(e => e.AdvBODAuID, "AdvBODAuID_AdvancePaymentRequest");

                entity.HasIndex(e => e.AdvDpManagerID, "AdvDpManageID");

                entity.HasIndex(e => e.AdvAcsDpManagerID, "AdvDpManageID1");

                entity.HasIndex(e => e.AdvDpManagerAuID, "AdvDpManagerAuID_AdvancePaymentRequest");

                entity.HasIndex(e => e.AdvContactID, "AdvanceContactID");

                entity.HasIndex(e => e.AdvID, "AdvanceID");

                entity.HasIndex(e => e.AdvContactID, "ContactsListAdvancePaymentRequest");

                entity.Property(e => e.AdvID).HasMaxLength(50);

                entity.Property(e => e.AcsApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.AdvAcsDpManagerAu2ID).HasMaxLength(50);

                entity.Property(e => e.AdvAcsDpManagerAu2Name).HasMaxLength(50);

                entity.Property(e => e.AdvAcsDpManagerAuID).HasMaxLength(50);

                entity.Property(e => e.AdvAcsDpManagerAuName).HasMaxLength(50);

                entity.Property(e => e.AdvAcsDpManagerID).HasMaxLength(50);

                entity.Property(e => e.AdvAcsDpManagerName).HasMaxLength(50);

                entity.Property(e => e.AdvAcsSignDate).HasColumnType("datetime");

                entity.Property(e => e.AdvAddress).HasMaxLength(50);

                entity.Property(e => e.AdvBODAuID).HasMaxLength(50);

                entity.Property(e => e.AdvBODAuName).HasMaxLength(50);

                entity.Property(e => e.AdvBODID).HasMaxLength(50);

                entity.Property(e => e.AdvBODName).HasMaxLength(50);

                entity.Property(e => e.AdvBODSignDate).HasColumnType("datetime");

                entity.Property(e => e.AdvCSName).HasMaxLength(50);

                entity.Property(e => e.AdvCSSignDate).HasColumnType("datetime");

                entity.Property(e => e.AdvCSStickApp).HasDefaultValueSql("((0))");

                entity.Property(e => e.AdvCSStickDeny).HasDefaultValueSql("((0))");

                entity.Property(e => e.AdvCSStickWait).HasDefaultValueSql("((0))");

                entity.Property(e => e.AdvCashier).HasMaxLength(50);

                entity.Property(e => e.AdvCashierName).HasMaxLength(50);

                entity.Property(e => e.AdvCondition).HasMaxLength(255);

                entity.Property(e => e.AdvContact).HasMaxLength(50);

                entity.Property(e => e.AdvContactID).HasMaxLength(50);

                entity.Property(e => e.AdvCurrency).HasMaxLength(50);

                entity.Property(e => e.AdvDate).HasColumnType("datetime");

                entity.Property(e => e.AdvDpManagerAuID).HasMaxLength(50);

                entity.Property(e => e.AdvDpManagerAuName).HasMaxLength(50);

                entity.Property(e => e.AdvDpManagerID).HasMaxLength(50);

                entity.Property(e => e.AdvDpManagerName).HasMaxLength(50);

                entity.Property(e => e.AdvDpSignDate).HasColumnType("datetime");

                entity.Property(e => e.AdvHBL).HasMaxLength(300);

                entity.Property(e => e.AdvInvoiceNo).HasMaxLength(50);

                entity.Property(e => e.AdvNote)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.AdvPaymentCheck).HasMaxLength(255);

                entity.Property(e => e.AdvPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.AdvPaymentNote).HasMaxLength(150);

                entity.Property(e => e.AdvRealDate).HasColumnType("datetime");

                entity.Property(e => e.AdvRef).HasMaxLength(50);

                entity.Property(e => e.AdvSCID).HasMaxLength(50);

                entity.Property(e => e.AdvTo).HasMaxLength(150);

                entity.Property(e => e.AdvValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.AmountSettle).HasDefaultValueSql("((0))");

                entity.Property(e => e.Attached).HasColumnType("ntext");

                entity.Property(e => e.ClearDate).HasColumnType("datetime");

                entity.Property(e => e.DateDepositForward).HasColumnType("datetime");

                entity.Property(e => e.DateReceivedForard).HasColumnType("datetime");

                entity.Property(e => e.Deposit).HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositDesc).HasMaxLength(150);

                entity.Property(e => e.DepositPIC).HasMaxLength(50);

                entity.Property(e => e.DepositType).HasMaxLength(50);

                entity.Property(e => e.GroupVoucherID).HasMaxLength(50);

                entity.Property(e => e.OTPayment).HasMaxLength(50);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentNo).HasMaxLength(50);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.SettleCurrency).HasMaxLength(50);

                entity.Property(e => e.SettleNo).HasMaxLength(50);

                entity.Property(e => e.SettleVCNo).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.VCEditing).HasDefaultValueSql("((0))");

                entity.Property(e => e.WhoisClear).HasMaxLength(50);
            });

            modelBuilder.Entity<AdvancePaymentRequestAttachedFiles>(entity =>
            {
                entity.HasKey(e => e.FieldKey);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.AdvNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<AdvancePaymentRequestDetails>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.AdvID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CSAppDate).HasColumnType("datetime");

                entity.Property(e => e.CSDecline).HasDefaultValueSql("((0))");

                entity.Property(e => e.CSUser).HasMaxLength(50);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FeeCode).HasMaxLength(50);

                entity.Property(e => e.HBLNo).HasMaxLength(50);

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.JobNo).HasMaxLength(50);

                entity.Property(e => e.Norm).HasDefaultValueSql("((0))");

                entity.Property(e => e.NormSource).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.Others).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.Validfee).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Adv)
                    .WithMany(p => p.AdvancePaymentRequestDetails)
                    .HasForeignKey(d => d.AdvID)
                    .HasConstraintName("FK_AdvancePaymentRequestDetails_AdvancePaymentRequest");
            });

            modelBuilder.Entity<AdvanceRequest>(entity =>
            {
                entity.HasKey(e => e.RefNo);

                entity.HasIndex(e => e.HBLNo, "HBLNo_AdvanceRequest");

                entity.HasIndex(e => e.JobNo, "JobNo_AdvanceRequest");

                entity.HasIndex(e => e.PayeeID, "PayeeID_AdvanceRequest");

                entity.HasIndex(e => e.RequesterID, "RequesterID_AdvanceRequest");

                entity.HasIndex(e => e.UserName, "UserName_AdvanceRequest");

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.AdvanceAR).HasDefaultValueSql("((0))");

                entity.Property(e => e.AdvanceNo).HasMaxLength(50);

                entity.Property(e => e.Advanced).HasDefaultValueSql("((0))");

                entity.Property(e => e.Attached).HasColumnType("ntext");

                entity.Property(e => e.Cancelled).HasDefaultValueSql("((0))");

                entity.Property(e => e.CancelledDate).HasColumnType("datetime");

                entity.Property(e => e.ContactName).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DVHistory).HasMaxLength(4000);

                entity.Property(e => e.Deadline).HasColumnType("datetime");

                entity.Property(e => e.Decline).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeclineDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(3000);

                entity.Property(e => e.DescriptionLC).HasMaxLength(4000);

                entity.Property(e => e.FromShipment).HasDefaultValueSql("((0))");

                entity.Property(e => e.HBLNo).HasMaxLength(1500);

                entity.Property(e => e.JobNo).HasMaxLength(1500);

                entity.Property(e => e.Locked).HasDefaultValueSql("((0))");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.MultiPartner).HasDefaultValueSql("((0))");

                entity.Property(e => e.PayeeID).HasMaxLength(50);

                entity.Property(e => e.PaymentMethod).HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.RequesterID).HasMaxLength(50);

                entity.Property(e => e.RequesterName).HasMaxLength(255);

                entity.Property(e => e.SettleNo).HasMaxLength(50);

                entity.Property(e => e.UserLock).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.VoucherID).HasMaxLength(50);

                entity.Property(e => e.VoucherIDSE).HasMaxLength(50);
            });

            modelBuilder.Entity<AdvanceRequestAttachedFiles>(entity =>
            {
                entity.HasKey(e => e.FieldKey);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SettledNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<AdvanceSettlementPayment>(entity =>
            {
                entity.HasKey(e => e.IDKeyField)
                    .HasName("aaaaaAdvanceSettlementPayment_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.AvNo, "AcsSetlementPaymentAdvanceSettlementPayment");

                entity.HasIndex(e => e.CustomsID, "CustomsID");

                entity.HasIndex(e => e.HBL, "HAWBAdvanceSettlementPayment");

                entity.HasIndex(e => e.TableName, "IDAccs");

                entity.HasIndex(e => e.JobID, "JobID");

                entity.HasIndex(e => e.PartnerID, "PartnerID");

                entity.HasIndex(e => e.JobID, "TransactionsAdvanceSettlementPayment");

                entity.Property(e => e.IDKeyField)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.AvNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CLLPartnerID).HasMaxLength(50);

                entity.Property(e => e.CSAppDate).HasColumnType("datetime");

                entity.Property(e => e.CSDecline).HasDefaultValueSql("((0))");

                entity.Property(e => e.CSUser).HasMaxLength(50);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.CustomsID).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.FixCode).HasDefaultValueSql("((0))");

                entity.Property(e => e.HBL).HasMaxLength(50);

                entity.Property(e => e.INVLink).HasMaxLength(500);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceID).HasMaxLength(50);

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.JobID).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.RowsIndexLinked).HasMaxLength(50);

                entity.Property(e => e.Series).HasMaxLength(50);

                entity.Property(e => e.TableName).HasMaxLength(255);

                entity.Property(e => e.UnitQty).HasMaxLength(50);

                entity.Property(e => e.VAT).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AvNoNavigation)
                    .WithMany(p => p.AdvanceSettlementPayment)
                    .HasForeignKey(d => d.AvNo)
                    .HasConstraintName("AdvanceSettlementPayment_FK00");

                entity.HasOne(d => d.HBLNavigation)
                    .WithMany(p => p.AdvanceSettlementPayment)
                    .HasForeignKey(d => d.HBL)
                    .HasConstraintName("AdvanceSettlementPayment_FK01");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.AdvanceSettlementPayment)
                    .HasForeignKey(d => d.JobID)
                    .HasConstraintName("AdvanceSettlementPayment_FK02");
            });

            modelBuilder.Entity<AirFreightAdjust>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.FormID).HasMaxLength(50);

                entity.Property(e => e.InlQuo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaQuo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<AirFreightQuotationDetails>(entity =>
            {
                entity.HasKey(e => new { e.QuoID, e.Routine, e.WeightLevel })
                    .HasName("aaaaaAirFreightQuotationDetails_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.QuoID, "AirFreightQuotationsAirFreightQuotationDetails");

                entity.HasIndex(e => e.QuoID, "QuoID");

                entity.Property(e => e.QuoID).HasMaxLength(50);

                entity.Property(e => e.Routine).HasMaxLength(50);

                entity.Property(e => e.WeightLevel).HasMaxLength(50);

                entity.Property(e => e.FuelSurcharge).HasMaxLength(50);

                entity.Property(e => e.Price).HasMaxLength(50);

                entity.Property(e => e.WarRistlSurcharge).HasMaxLength(50);

                entity.HasOne(d => d.Quo)
                    .WithMany(p => p.AirFreightQuotationDetails)
                    .HasForeignKey(d => d.QuoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AirFreightQuotationDetail_FK00");
            });

            modelBuilder.Entity<AirFreightQuotations>(entity =>
            {
                entity.HasKey(e => e.QuoID)
                    .HasName("aaaaaAirFreightQuotations_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ContactID, "ContactID");

                entity.HasIndex(e => e.ContactID, "PartnersAirFreightQuotations");

                entity.HasIndex(e => e.QuoID, "QuoID");

                entity.Property(e => e.QuoID).HasMaxLength(50);

                entity.Property(e => e.AMS).HasMaxLength(50);

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.LCLRate).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.QuoDate).HasColumnType("datetime");

                entity.Property(e => e.Routine).HasMaxLength(50);

                entity.Property(e => e.ValidationText).HasMaxLength(150);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.AirFreightQuotations)
                    .HasForeignKey(d => d.ContactID)
                    .HasConstraintName("AirFreightQuotations_FK00");
            });

            modelBuilder.Entity<AirFreightTracking>(entity =>
            {
                entity.HasKey(e => new { e.HWBNO, e.ConnectingFlight })
                    .HasName("aaaaaAirFreightTracking_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.HWBNO, "HAWBAirFreightTracking");

                entity.Property(e => e.HWBNO).HasMaxLength(50);

                entity.Property(e => e.ConnectingFlight).HasMaxLength(150);

                entity.Property(e => e.CTNS).HasDefaultValueSql("(0)");

                entity.Property(e => e.ETA).HasColumnType("datetime");

                entity.Property(e => e.ETATimes).HasMaxLength(50);

                entity.Property(e => e.ETD).HasColumnType("datetime");

                entity.Property(e => e.ETDTimes).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.Weight).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.HWBNONavigation)
                    .WithMany(p => p.AirFreightTracking)
                    .HasForeignKey(d => d.HWBNO)
                    .HasConstraintName("AirFreightTracking_FK00");
            });

            modelBuilder.Entity<AirPortPerKGSChargeable>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Activate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ChargeAC).HasMaxLength(50);

                entity.Property(e => e.ChargeName).HasMaxLength(255);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.PortCode).HasMaxLength(50);

                entity.Property(e => e.PortName).HasMaxLength(50);

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.Property(e => e.VendorID).HasMaxLength(50);

                entity.Property(e => e.ViaPortCode).HasMaxLength(50);
            });

            modelBuilder.Entity<AirfreightPrcing>(entity =>
            {
                entity.HasKey(e => e.PricingCode)
                    .HasName("aaaaaAirfreightPrcing_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.DeptID, "DepartmentsAirfreightPrcing");

                entity.HasIndex(e => e.DeptID, "DeptID");

                entity.HasIndex(e => e.Destination, "Destination_AirfreightPrcing");

                entity.HasIndex(e => e.UserInput, "IX_AirfreightPrcing");

                entity.HasIndex(e => e.Origin, "Origin_AirfreightPrcing");

                entity.HasIndex(e => e.AirlineID, "PartnersAirfreightPrcing");

                entity.HasIndex(e => e.PricingCode, "PricingCode");

                entity.Property(e => e.PricingCode).HasMaxLength(50);

                entity.Property(e => e.AirlineID).HasMaxLength(50);

                entity.Property(e => e.CarrierID).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.Cutoff).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeptID).HasMaxLength(50);

                entity.Property(e => e.Destination).HasMaxLength(150);

                entity.Property(e => e.FSC)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Phu phi xang dau");

                entity.Property(e => e.Freq).HasMaxLength(50);

                entity.Property(e => e.GWC).HasDefaultValueSql("((0))");

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Level3)
                    .HasDefaultValueSql("((0))")
                    .HasComment("45");

                entity.Property(e => e.Level4)
                    .HasDefaultValueSql("((0))")
                    .HasComment("100");

                entity.Property(e => e.Level5)
                    .HasDefaultValueSql("((0))")
                    .HasComment("300");

                entity.Property(e => e.Level6)
                    .HasDefaultValueSql("((0))")
                    .HasComment("500");

                entity.Property(e => e.Level7)
                    .HasDefaultValueSql("((0))")
                    .HasComment("1000");

                entity.Property(e => e.LockedRCD).HasDefaultValueSql("((0))");

                entity.Property(e => e.Min)
                    .HasDefaultValueSql("((0))")
                    .HasComment("01/10/2010");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Normal)
                    .HasDefaultValueSql("((0))")
                    .HasComment("-45");

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.Origin).HasMaxLength(150);

                entity.Property(e => e.SSC)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Phu phi chuien tranh");

                entity.Property(e => e.TT).HasMaxLength(50);

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.Property(e => e.ValidDate).HasColumnType("datetime");

                entity.HasOne(d => d.Airline)
                    .WithMany(p => p.AirfreightPrcing)
                    .HasForeignKey(d => d.AirlineID)
                    .HasConstraintName("AirfreightPrcing_FK01");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.AirfreightPrcing)
                    .HasForeignKey(d => d.DeptID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("AirfreightPrcing_FK00");
            });

            modelBuilder.Entity<AirfreightPrcingDetail>(entity =>
            {
                entity.HasKey(e => new { e.PricingCode, e.Description, e.Unit });

                entity.Property(e => e.PricingCode).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.AccsRef).HasMaxLength(50);

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.ExLavel)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Phu phi xang dau");

                entity.Property(e => e.GW).HasDefaultValueSql("((0))");

                entity.Property(e => e.Level3)
                    .HasDefaultValueSql("((0))")
                    .HasComment("45");

                entity.Property(e => e.Level4)
                    .HasDefaultValueSql("((0))")
                    .HasComment("100");

                entity.Property(e => e.Level5)
                    .HasDefaultValueSql("((0))")
                    .HasComment("300");

                entity.Property(e => e.Level6)
                    .HasDefaultValueSql("((0))")
                    .HasComment("500");

                entity.Property(e => e.Level7)
                    .HasDefaultValueSql("((0))")
                    .HasComment("1000");

                entity.Property(e => e.Min)
                    .HasDefaultValueSql("((0))")
                    .HasComment("01/10/2010");

                entity.Property(e => e.Normal)
                    .HasDefaultValueSql("((0))")
                    .HasComment("-45");

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.OBH).HasDefaultValueSql("((0))");

                entity.Property(e => e.VendorID).HasMaxLength(50);

                entity.HasOne(d => d.PricingCodeNavigation)
                    .WithMany(p => p.AirfreightPrcingDetail)
                    .HasForeignKey(d => d.PricingCode)
                    .HasConstraintName("FK_AirfreightPrcingDetail_AirfreightPrcing");
            });

            modelBuilder.Entity<Airports>(entity =>
            {
                entity.HasKey(e => e.AirPortID)
                    .HasName("aaaaaAirports_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.AirPortID, "AirPortID");

                entity.HasIndex(e => e.AirPortName, "IX_Airports")
                    .IsUnique();

                entity.Property(e => e.AirPortID).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.AirPortName).HasMaxLength(150);

                entity.Property(e => e.CBPCode).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(150);

                entity.Property(e => e.MaCK).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.PersonIncharge).HasMaxLength(50);

                entity.Property(e => e.TelNo).HasMaxLength(50);

                entity.Property(e => e.TypeService).HasMaxLength(50);

                entity.Property(e => e.Zone).HasMaxLength(150);

                entity.HasOne(d => d.MaCKNavigation)
                    .WithMany(p => p.Airports)
                    .HasForeignKey(d => d.MaCK)
                    .HasConstraintName("FK_Airports_EcusCuakhau1");
            });

            modelBuilder.Entity<Airports_SE>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AirPortID).HasMaxLength(50);

                entity.Property(e => e.AirPortName).HasMaxLength(150);

                entity.Property(e => e.Country).HasMaxLength(150);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.TypeService).HasMaxLength(50);

                entity.Property(e => e.Zone).HasMaxLength(150);
            });

            modelBuilder.Entity<ArrivalFreightCharges>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.HawbNo, "HAWBArrivalFreightCharges");

                entity.Property(e => e.AccsRefNo).HasMaxLength(150);

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.HawbNo).HasMaxLength(50);

                entity.Property(e => e.IDKey).ValueGeneratedOnAdd();

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OBHPartnerID).HasMaxLength(50);

                entity.Property(e => e.Qty).HasDefaultValueSql("((0))");

                entity.Property(e => e.SynToRev).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.VAT).HasDefaultValueSql("((0))");

                entity.Property(e => e.intIndex).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.HawbNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.HawbNo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("ArrivalFreightCharges_FK00");
            });

            modelBuilder.Entity<ArrivalFreightChargesDefault>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccsRefNo).HasMaxLength(150);

                entity.Property(e => e.BLNo).HasMaxLength(50);

                entity.Property(e => e.Collect).HasDefaultValueSql("((0))");

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OBHPartnerID).HasMaxLength(50);

                entity.Property(e => e.Routing).HasMaxLength(50);

                entity.Property(e => e.Service).HasMaxLength(50);

                entity.Property(e => e.TotalValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UserDefault).HasMaxLength(50);

                entity.Property(e => e.VAT).HasDefaultValueSql("((0))");

                entity.Property(e => e.intIndex).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AttachmentPermission>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContactIDVisible).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IDRestrict).HasMaxLength(50);

                entity.Property(e => e.InputedUser).HasMaxLength(50);

                entity.Property(e => e.KeyFieldValue).HasMaxLength(50);

                entity.Property(e => e.TableSource).HasMaxLength(50);
            });

            modelBuilder.Entity<AuthorizedApproval>(entity =>
            {
                entity.HasKey(e => e.RefNo);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.AdvAccsFNApp).HasDefaultValueSql("(0)");

                entity.Property(e => e.AdvAccsMngApp).HasDefaultValueSql("(0)");

                entity.Property(e => e.AdvManagerApp).HasDefaultValueSql("(0)");

                entity.Property(e => e.AdvPBOBApp).HasDefaultValueSql("(0)");

                entity.Property(e => e.AirQuoApp).HasDefaultValueSql("(0)");

                entity.Property(e => e.AppActive).HasDefaultValueSql("(0)");

                entity.Property(e => e.AppDatedeleted).HasColumnType("datetime");

                entity.Property(e => e.AppDeleted).HasDefaultValueSql("(0)");

                entity.Property(e => e.AppDeletedNote).HasMaxLength(1000);

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.DateApply).HasColumnType("datetime");

                entity.Property(e => e.Datefrom).HasColumnType("datetime");

                entity.Property(e => e.Dateto).HasColumnType("datetime");

                entity.Property(e => e.JobApproval).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeaQuoApp).HasDefaultValueSql("(0)");

                entity.Property(e => e.SettleAccsFNApp).HasDefaultValueSql("(0)");

                entity.Property(e => e.SettleAccsMngApp).HasDefaultValueSql("(0)");

                entity.Property(e => e.SettleManagerApp).HasDefaultValueSql("(0)");

                entity.Property(e => e.SettlePBOBApp).HasDefaultValueSql("(0)");

                entity.Property(e => e.UnJobApproval).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.Property(e => e.WhoisID).HasMaxLength(50);
            });

            modelBuilder.Entity<BankCustomize>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AccountLocalNo).HasMaxLength(50);

                entity.Property(e => e.AccountName).HasMaxLength(255);

                entity.Property(e => e.AccountUSDNo).HasMaxLength(50);

                entity.Property(e => e.BankAddress).HasMaxLength(255);

                entity.Property(e => e.BankName).HasMaxLength(255);

                entity.Property(e => e.IBankCode).HasMaxLength(50);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SwiftCode).HasMaxLength(50);
            });

            modelBuilder.Entity<BookingConfirmList>(entity =>
            {
                entity.HasKey(e => e.TransID)
                    .HasName("aaaaaBookingConfirmList_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ShipperID, "ColoaderID");

                entity.HasIndex(e => e.ContactID, "ContactID");

                entity.HasIndex(e => e.ShipperID, "PartnersBookingConfirmList");

                entity.HasIndex(e => e.TransID, "TransID");

                entity.HasIndex(e => e.RefID, "TransID1");

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.AOD2).HasMaxLength(50);

                entity.Property(e => e.AOD3).HasMaxLength(50);

                entity.Property(e => e.AOD4).HasMaxLength(50);

                entity.Property(e => e.AOD5).HasMaxLength(50);

                entity.Property(e => e.AOL2).HasMaxLength(50);

                entity.Property(e => e.AOL3).HasMaxLength(50);

                entity.Property(e => e.AOL4).HasMaxLength(50);

                entity.Property(e => e.AOL5).HasMaxLength(50);

                entity.Property(e => e.AirDimension).HasMaxLength(150);

                entity.Property(e => e.Attn).HasMaxLength(150);

                entity.Property(e => e.BookingConfirmNotes).HasMaxLength(150);

                entity.Property(e => e.ChargeableWeight).HasDefaultValueSql("(0)");

                entity.Property(e => e.ClosingTime).HasMaxLength(150);

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.DateSend).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Dimension).HasDefaultValueSql("(0)");

                entity.Property(e => e.ETA).HasColumnType("datetime");

                entity.Property(e => e.ETA2).HasColumnType("datetime");

                entity.Property(e => e.ETA3).HasColumnType("datetime");

                entity.Property(e => e.ETA4).HasColumnType("datetime");

                entity.Property(e => e.ETA5).HasColumnType("datetime");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.FinalDestination).HasMaxLength(50);

                entity.Property(e => e.FlightNoCfrm).HasMaxLength(50);

                entity.Property(e => e.FlightNoCfrm2).HasMaxLength(50);

                entity.Property(e => e.FlightNoCfrm3).HasMaxLength(50);

                entity.Property(e => e.FlightNoCfrm4).HasMaxLength(50);

                entity.Property(e => e.FlightNoCfrm5).HasMaxLength(50);

                entity.Property(e => e.FlightScheduleConfirm).HasColumnType("datetime");

                entity.Property(e => e.FlightScheduleConfirm2).HasColumnType("datetime");

                entity.Property(e => e.FlightScheduleConfirm3).HasColumnType("datetime");

                entity.Property(e => e.FlightScheduleConfirm4).HasColumnType("datetime");

                entity.Property(e => e.FlightScheduleConfirm5).HasColumnType("datetime");

                entity.Property(e => e.GrossWeight).HasDefaultValueSql("(0)");

                entity.Property(e => e.HAWBNo).HasMaxLength(50);

                entity.Property(e => e.Height).HasDefaultValueSql("(0)");

                entity.Property(e => e.Length).HasDefaultValueSql("(0)");

                entity.Property(e => e.LoadingDate)
                    .HasColumnType("datetime")
                    .HasComment("ETD");

                entity.Property(e => e.MAWBNo).HasMaxLength(50);

                entity.Property(e => e.NatureofGoods).HasColumnType("ntext");

                entity.Property(e => e.Noofpieces).HasDefaultValueSql("(0)");

                entity.Property(e => e.OfficerContact).HasMaxLength(255);

                entity.Property(e => e.PaymentTerm).HasMaxLength(50);

                entity.Property(e => e.PickupRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.PortofLading).HasMaxLength(50);

                entity.Property(e => e.PortofUnlading).HasMaxLength(50);

                entity.Property(e => e.RateConfirm).HasMaxLength(50);

                entity.Property(e => e.RefID).HasMaxLength(50);

                entity.Property(e => e.ServiceRequired).HasMaxLength(50);

                entity.Property(e => e.ShipperID)
                    .HasMaxLength(50)
                    .HasComment("Service provider");

                entity.Property(e => e.StuffingPlace).HasMaxLength(150);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.UnitPieaces).HasMaxLength(50);

                entity.Property(e => e.WhoisMaking).HasMaxLength(50);

                entity.Property(e => e.Width).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.Shipper)
                    .WithMany(p => p.BookingConfirmList)
                    .HasForeignKey(d => d.ShipperID)
                    .HasConstraintName("BookingConfirmList_FK00");
            });

            modelBuilder.Entity<BookingContainer>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.TransID, "BookingLocalBookingContainer");

                entity.HasIndex(e => e.TransID, "TransID");

                entity.Property(e => e.Container).HasMaxLength(255);

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.Qty).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransID).HasMaxLength(255);
            });

            modelBuilder.Entity<BookingLocal>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.AgentID, "AgentID");

                entity.HasIndex(e => e.BookingConfirmID, "BookingConfirmID");

                entity.HasIndex(e => e.ColoaderID, "ColoaderID");

                entity.HasIndex(e => e.ConformJobNo, "ConformJobNo");

                entity.HasIndex(e => e.ContactID, "ContactID");

                entity.HasIndex(e => e.ContactID, "ContactsListBookingLocal");

                entity.HasIndex(e => e.WhoisMakingID, "ContactsListBookingLocal1");

                entity.HasIndex(e => e.ConfirmHBL, "HAWBBookingLocal");

                entity.HasIndex(e => e.ColoaderID, "PartnersBookingLocal");

                entity.HasIndex(e => e.AgentID, "PartnersBookingLocal1");

                entity.HasIndex(e => e.RealShipperID, "PartnersBookingLocal2");

                entity.HasIndex(e => e.RealShipperID, "RealShipperID");

                entity.HasIndex(e => e.ConformJobNo, "TransactionsBookingLocal");

                entity.HasIndex(e => e.WhoisMakingID, "WhoisMakingID");

                entity.Property(e => e.AgentID).HasMaxLength(50);

                entity.Property(e => e.AgentSalesID).HasMaxLength(50);

                entity.Property(e => e.Attached).HasColumnType("ntext");

                entity.Property(e => e.BkgID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BookingConfirmID).HasMaxLength(50);

                entity.Property(e => e.CBMDescription).HasMaxLength(50);

                entity.Property(e => e.CFClosingTime).HasMaxLength(50);

                entity.Property(e => e.CFFlight).HasMaxLength(50);

                entity.Property(e => e.CFHAWB).HasMaxLength(50);

                entity.Property(e => e.CFMAWB).HasMaxLength(50);

                entity.Property(e => e.CFRate).HasMaxLength(50);

                entity.Property(e => e.CancelAPPDate).HasColumnType("datetime");

                entity.Property(e => e.CancelDate).HasColumnType("datetime");

                entity.Property(e => e.CancelNote).HasMaxLength(255);

                entity.Property(e => e.CargoDelivery).HasMaxLength(255);

                entity.Property(e => e.CargoPickup).HasMaxLength(255);

                entity.Property(e => e.CarrierBookingNo).HasMaxLength(50);

                entity.Property(e => e.ColoaderID).HasMaxLength(50);

                entity.Property(e => e.Comments).HasMaxLength(4000);

                entity.Property(e => e.ConfirmHBL).HasMaxLength(50);

                entity.Property(e => e.ConformJobNo).HasMaxLength(50);

                entity.Property(e => e.ConnectFlightDate).HasColumnType("datetime");

                entity.Property(e => e.ConnectFlightNo).HasMaxLength(50);

                entity.Property(e => e.Consignee).HasMaxLength(255);

                entity.Property(e => e.ConsigneeID).HasMaxLength(50);

                entity.Property(e => e.ContQtyAP).HasMaxLength(50);

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.DateConfirm).HasColumnType("datetime");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateSenttoForAPP).HasColumnType("datetime");

                entity.Property(e => e.Delivery).HasMaxLength(50);

                entity.Property(e => e.DeliveryTerm).HasMaxLength(50);

                entity.Property(e => e.DetailofGoods).HasColumnType("ntext");

                entity.Property(e => e.ETA).HasColumnType("datetime");

                entity.Property(e => e.ETD).HasColumnType("datetime");

                entity.Property(e => e.ForwarderForm).HasMaxLength(255);

                entity.Property(e => e.FowarderDate).HasColumnType("datetime");

                entity.Property(e => e.HistoryCLAPP).HasMaxLength(1000);

                entity.Property(e => e.LogisticsType).HasMaxLength(50);

                entity.Property(e => e.MaskSeal).HasMaxLength(255);

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.PCName).HasMaxLength(50);

                entity.Property(e => e.PCNameRequester).HasMaxLength(50);

                entity.Property(e => e.POD).HasMaxLength(50);

                entity.Property(e => e.POL).HasMaxLength(50);

                entity.Property(e => e.PONo).HasMaxLength(50);

                entity.Property(e => e.PaymentMethod).HasMaxLength(50);

                entity.Property(e => e.QuoMode).HasMaxLength(50);

                entity.Property(e => e.QuoNo).HasMaxLength(50);

                entity.Property(e => e.RQCommodity).HasMaxLength(255);

                entity.Property(e => e.RQCustoms).HasMaxLength(50);

                entity.Property(e => e.RQFlight).HasMaxLength(50);

                entity.Property(e => e.RQFlightDate).HasColumnType("datetime");

                entity.Property(e => e.RQLoadingDate).HasColumnType("datetime");

                entity.Property(e => e.RQNoCarton).HasDefaultValueSql("((0))");

                entity.Property(e => e.RQPickup).HasMaxLength(50);

                entity.Property(e => e.RQRate).HasMaxLength(50);

                entity.Property(e => e.RQReturn).HasMaxLength(50);

                entity.Property(e => e.RQRoutine).HasMaxLength(150);

                entity.Property(e => e.RQWeight).HasMaxLength(50);

                entity.Property(e => e.RealShipperID).HasMaxLength(50);

                entity.Property(e => e.SalesmanID).HasMaxLength(50);

                entity.Property(e => e.Salesmanager).HasMaxLength(50);

                entity.Property(e => e.SalesmanagerAPP).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesmanagerDateProcess).HasColumnType("datetime");

                entity.Property(e => e.SalesmanagerDenied).HasDefaultValueSql("((0))");

                entity.Property(e => e.ServiceType).HasMaxLength(50);

                entity.Property(e => e.ShipperID).HasMaxLength(50);

                entity.Property(e => e.ShipperInBill).HasMaxLength(255);

                entity.Property(e => e.TransService).HasMaxLength(50);

                entity.Property(e => e.TransitPOD).HasMaxLength(50);

                entity.Property(e => e.TransitPOL).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.WhoisCancel).HasMaxLength(50);

                entity.Property(e => e.WhoisMakingID).HasMaxLength(50);

                entity.HasOne(d => d.ConfirmHBLNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ConfirmHBL)
                    .HasConstraintName("FK_BookingLocal_HAWB");

                entity.HasOne(d => d.ConformJobNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ConformJobNo)
                    .HasConstraintName("FK_BookingLocal_Transactions");
            });

            modelBuilder.Entity<BookingLocalAttachedFiles>(entity =>
            {
                entity.HasKey(e => e.FieldKey);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.BKNO)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<BookingLocalRoutine>(entity =>
            {
                entity.HasKey(e => e.Maso);

                entity.Property(e => e.Maso)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContainerNo).HasMaxLength(50);

                entity.Property(e => e.DiaChiDongHang).HasMaxLength(255);

                entity.Property(e => e.DiaChiGiaHang).HasMaxLength(255);

                entity.Property(e => e.DieuKien).HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasMaxLength(255);

                entity.Property(e => e.NgayCapLenh).HasColumnType("datetime");

                entity.Property(e => e.NgayCapNhat).HasColumnType("datetime");

                entity.Property(e => e.NgayDongHang).HasColumnType("datetime");

                entity.Property(e => e.NgayGiaoHang).HasColumnType("datetime");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.NguoiCap).HasMaxLength(50);

                entity.Property(e => e.NguoiLienHeDongHang).HasMaxLength(50);

                entity.Property(e => e.NguoiLienHeGiaoHang).HasMaxLength(50);

                entity.Property(e => e.NoiHaHang).HasMaxLength(50);

                entity.Property(e => e.NoiHaRong).HasMaxLength(50);

                entity.Property(e => e.NoiLayHang).HasMaxLength(50);

                entity.Property(e => e.NoiLayRong).HasMaxLength(50);

                entity.Property(e => e.RequestNo).HasMaxLength(50);

                entity.Property(e => e.SealNo).HasMaxLength(50);

                entity.Property(e => e.SoLenh).HasMaxLength(50);

                entity.Property(e => e.TyLePhi).HasMaxLength(50);

                entity.Property(e => e.UnitQty).HasMaxLength(50);
            });

            modelBuilder.Entity<BookingRateRequest>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.BkgID, "BookingLocalBookingRateRequest");

                entity.HasIndex(e => e.IDKeyIndexPS, "IDKeyIndexPS_U")
                    .IsUnique();

                entity.HasIndex(e => e.PartnerID, "PartnerID");

                entity.HasIndex(e => e.PartnerID, "PartnersBookingRateRequest");

                entity.Property(e => e.AutoInputPS).HasDefaultValueSql("((0))");

                entity.Property(e => e.BkgID).HasMaxLength(50);

                entity.Property(e => e.CC).HasDefaultValueSql("((0))");

                entity.Property(e => e.ChargeCode).HasMaxLength(50);

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DataIndex).HasDefaultValueSql("(0)");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.ExtRate).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExtVND).HasDefaultValueSql("(0)");

                entity.Property(e => e.Gainloss).HasDefaultValueSql("((0))");

                entity.Property(e => e.IDKeyIndexAU).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IDKeyIndexPS)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NoInv).HasDefaultValueSql("(0)");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OBH).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.Quantity).HasDefaultValueSql("(0)");

                entity.Property(e => e.RateApp).HasDefaultValueSql("((0))");

                entity.Property(e => e.TT).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalValue).HasDefaultValueSql("(0)");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("(0)");

                entity.Property(e => e.VAT).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.Partner)
                    .WithMany()
                    .HasForeignKey(d => d.PartnerID)
                    .HasConstraintName("BookingRateRequest_FK01");
            });

            modelBuilder.Entity<BookingReQuestList>(entity =>
            {
                entity.HasKey(e => e.TransID)
                    .HasName("aaaaaBookingReQuestList_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ColoaderID, "ColoaderID");

                entity.HasIndex(e => e.ColoaderID, "PartnersBookingReQuestList");

                entity.HasIndex(e => e.TransID, "TransID");

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.AirDimension).HasMaxLength(150);

                entity.Property(e => e.Attn).HasMaxLength(150);

                entity.Property(e => e.BookingRequestNotes).HasMaxLength(150);

                entity.Property(e => e.ChargeableWeight).HasDefaultValueSql("(0)");

                entity.Property(e => e.ColoaderID)
                    .HasMaxLength(50)
                    .HasComment("Service provider");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Dimension)
                    .HasDefaultValueSql("(0)")
                    .HasComment("Volume if it is Express");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.FlightScheduleRequest).HasColumnType("datetime");

                entity.Property(e => e.GrossWeight).HasDefaultValueSql("(0)");

                entity.Property(e => e.Height).HasDefaultValueSql("(0)");

                entity.Property(e => e.JobNo).HasMaxLength(50);

                entity.Property(e => e.Length).HasDefaultValueSql("(0)");

                entity.Property(e => e.LoadingDate)
                    .HasColumnType("datetime")
                    .HasComment("ETD");

                entity.Property(e => e.NatureofGoods).HasColumnType("ntext");

                entity.Property(e => e.Noofpieces).HasDefaultValueSql("(0)");

                entity.Property(e => e.OfficerContact).HasMaxLength(255);

                entity.Property(e => e.PaymentTerm).HasMaxLength(50);

                entity.Property(e => e.PortofLading).HasMaxLength(150);

                entity.Property(e => e.PortofUnlading).HasMaxLength(150);

                entity.Property(e => e.RateRequest).HasMaxLength(50);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.UnitPieaces).HasMaxLength(50);

                entity.Property(e => e.WhoisMaking).HasMaxLength(50);

                entity.Property(e => e.Width).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.Coloader)
                    .WithMany(p => p.BookingReQuestList)
                    .HasForeignKey(d => d.ColoaderID)
                    .HasConstraintName("BookingReQuestList_FK00");
            });

            modelBuilder.Entity<BuyingRate>(entity =>
            {
                entity.HasKey(e => new { e.TransID, e.Description, e.Unit, e.Collect })
                    .HasName("aaaaaBuyingRate_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.DatePaid, "DatePaid");

                entity.HasIndex(e => e.Docs, "Docs_BuyingRateWithHBL");

                entity.HasIndex(e => e.FieldKey, "FieldKey_BuyingRateWithHBL");

                entity.HasIndex(e => e.IDKeyIndex, "IDKeyIndex_BuyingRateWithHBL");

                entity.HasIndex(e => e.InoiceNo, "InoiceNo_BuyingRate");

                entity.HasIndex(e => e.InputData, "InputData_BuyingRateWithHBL");

                entity.HasIndex(e => e.RequisitionID, "RequisitionID_BuyingRateWithHBL");

                entity.HasIndex(e => e.SortDes, "SortDes_BuyingRateWithHBL");

                entity.HasIndex(e => e.TransID, "TransID");

                entity.HasIndex(e => e.TransID, "TransactionsBuyingRate");

                entity.HasIndex(e => e.VoucherID, "VoucherID");

                entity.HasIndex(e => e.VoucherIDSE, "VoucherIDSE_BuyingRateWithHBL_1");

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.AccsDateKey).HasColumnType("datetime");

                entity.Property(e => e.AccsUserKey).HasMaxLength(50);

                entity.Property(e => e.AdvVoucherID).HasMaxLength(50);

                entity.Property(e => e.Advanced).HasDefaultValueSql("((0))");

                entity.Property(e => e.AutoInput).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyConvertRate).HasMaxLength(50);

                entity.Property(e => e.DatePaid).HasColumnType("datetime");

                entity.Property(e => e.Docs).HasMaxLength(50);

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.ExtRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtRateVND).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtVND).HasDefaultValueSql("((0))");

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.GWHeavyW).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gainloss).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.IDKeyIndex)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InoiceNo).HasMaxLength(50);

                entity.Property(e => e.InputData).HasMaxLength(50);

                entity.Property(e => e.InvDate).HasColumnType("datetime");

                entity.Property(e => e.NoInv).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.OBH).HasDefaultValueSql("((0))");

                entity.Property(e => e.OBHPartnerID).HasMaxLength(50);

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequisitionID).HasMaxLength(50);

                entity.Property(e => e.SeriNo).HasMaxLength(50);

                entity.Property(e => e.SettlementRefNo).HasMaxLength(50);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.SortDes).HasMaxLength(255);

                entity.Property(e => e.TotalValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.VAT).HasDefaultValueSql("((0))");

                entity.Property(e => e.VATDate).HasColumnType("datetime");

                entity.Property(e => e.VATInvID).HasMaxLength(50);

                entity.Property(e => e.VATName).HasMaxLength(255);

                entity.Property(e => e.VATTaxCode).HasMaxLength(50);

                entity.Property(e => e.VoucherID).HasMaxLength(50);

                entity.Property(e => e.VoucherIDSE).HasMaxLength(50);

                entity.HasOne(d => d.Trans)
                    .WithMany(p => p.BuyingRate)
                    .HasForeignKey(d => d.TransID)
                    .HasConstraintName("BuyingRate_FK00");
            });

            modelBuilder.Entity<BuyingRateFixCost>(entity =>
            {
                entity.HasKey(e => new { e.TransID, e.PartnerID, e.QUnit, e.Notes, e.Dpt });

                entity.HasIndex(e => e.IDKeyIndex, "IDKeyIndex");

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.QUnit).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.AccsDateKey).HasColumnType("datetime");

                entity.Property(e => e.AccsLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccsLog).HasMaxLength(4000);

                entity.Property(e => e.AccsUserKey).HasMaxLength(50);

                entity.Property(e => e.AutoInput).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyConvertRate).HasMaxLength(50);

                entity.Property(e => e.DataInput).HasMaxLength(50);

                entity.Property(e => e.Docs).HasMaxLength(50);

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.ExtRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtRateVND).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtVND).HasDefaultValueSql("((0))");

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.GWHeavyW).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.IDKeyIndex)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InoiceNo).HasMaxLength(50);

                entity.Property(e => e.NoInv).HasDefaultValueSql("((0))");

                entity.Property(e => e.OBHPartnerID).HasMaxLength(50);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeriNo).HasMaxLength(50);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.SortDes).HasMaxLength(255);

                entity.Property(e => e.TotalValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.VAT).HasDefaultValueSql("((0))");

                entity.Property(e => e.VoucherID).HasMaxLength(50);

                entity.Property(e => e.VoucherIDSE).HasMaxLength(50);

                entity.HasOne(d => d.Trans)
                    .WithMany(p => p.BuyingRateFixCost)
                    .HasForeignKey(d => d.TransID)
                    .HasConstraintName("FK_BuyingRateFixCost_Transactions");
            });

            modelBuilder.Entity<BuyingRateInland>(entity =>
            {
                entity.HasKey(e => new { e.TransID, e.PartnerID, e.QUnit, e.Notes, e.Dpt })
                    .HasName("aaaaaBuyingRateInland_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.PartnerID, "PartnerID");

                entity.HasIndex(e => e.TransID, "TransID");

                entity.HasIndex(e => e.VoucherID, "VoucherID");

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.QUnit).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.AccsDateKey).HasColumnType("datetime");

                entity.Property(e => e.AccsLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccsLog).HasMaxLength(4000);

                entity.Property(e => e.AccsUserKey).HasMaxLength(50);

                entity.Property(e => e.Advanced).HasDefaultValueSql("((0))");

                entity.Property(e => e.AutoInput).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyConvertRate).HasMaxLength(50);

                entity.Property(e => e.DataInput).HasMaxLength(50);

                entity.Property(e => e.Docs).HasMaxLength(50);

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.ExtRate).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExtRateVND).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExtVND).HasDefaultValueSql("(0)");

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.GWHeavyW).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gainloss).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.IDKeyIndex)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InoiceNo).HasMaxLength(50);

                entity.Property(e => e.NoInv).HasDefaultValueSql("(0)");

                entity.Property(e => e.OBHPartnerID).HasMaxLength(50);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasDefaultValueSql("(0)");

                entity.Property(e => e.SeriNo).HasMaxLength(50);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.SortDes).HasMaxLength(255);

                entity.Property(e => e.TotalValue).HasDefaultValueSql("(0)");

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("(0)");

                entity.Property(e => e.VAT).HasDefaultValueSql("(0)");

                entity.Property(e => e.VoucherID).HasMaxLength(50);

                entity.Property(e => e.VoucherIDSE).HasMaxLength(50);
            });

            modelBuilder.Entity<BuyingRateOthers>(entity =>
            {
                entity.HasKey(e => new { e.TransID, e.PartnerID, e.QUnit, e.Notes, e.Dpt })
                    .HasName("aaaaaBuyingRateOthers_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.DataInput, "DataInput_BuyingRateOthers");

                entity.HasIndex(e => e.Docs, "Docs_BuyingRateOthers");

                entity.HasIndex(e => e.FieldKey, "FieldKey_BuyingRateOthers");

                entity.HasIndex(e => e.IDKeyIndex, "IDKeyIndex_BuyingRateOthers");

                entity.HasIndex(e => e.InoiceNo, "InoiceNo_BuyingRateOthers");

                entity.HasIndex(e => e.PartnerID, "PartnerID");

                entity.HasIndex(e => e.RequisitionID, "RequisitionID_BuyingRateOthers");

                entity.HasIndex(e => e.SortDes, "SortDes");

                entity.HasIndex(e => e.TransID, "TransID");

                entity.HasIndex(e => e.TransID, "TransactionsBuyingRateOthers");

                entity.HasIndex(e => e.VoucherID, "VoucherID");

                entity.HasIndex(e => e.VoucherIDSE, "VoucherIDSE_BuyingRateOthers");

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.QUnit).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.AccsDateKey).HasColumnType("datetime");

                entity.Property(e => e.AccsLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccsLog).HasMaxLength(4000);

                entity.Property(e => e.AccsUserKey).HasMaxLength(50);

                entity.Property(e => e.AdvVoucherID).HasMaxLength(50);

                entity.Property(e => e.Advanced).HasDefaultValueSql("((0))");

                entity.Property(e => e.AutoInput).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyConvertRate).HasMaxLength(50);

                entity.Property(e => e.DataInput).HasMaxLength(50);

                entity.Property(e => e.Docs).HasMaxLength(50);

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.ExtRate).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExtRateVND).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExtVND).HasDefaultValueSql("(0)");

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.GWHeavyW).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gainloss).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.IDKeyIndex)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.INVSOANo).HasMaxLength(50);

                entity.Property(e => e.InoiceNo).HasMaxLength(50);

                entity.Property(e => e.InvDate).HasColumnType("datetime");

                entity.Property(e => e.NoInv).HasDefaultValueSql("(0)");

                entity.Property(e => e.OBHFieldKey).HasMaxLength(50);

                entity.Property(e => e.OBHLink).HasDefaultValueSql("((0))");

                entity.Property(e => e.OBHPartnerID).HasMaxLength(50);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasDefaultValueSql("(0)");

                entity.Property(e => e.RemoteChargesRef).HasMaxLength(50);

                entity.Property(e => e.RequisitionID).HasMaxLength(50);

                entity.Property(e => e.SeriNo).HasMaxLength(50);

                entity.Property(e => e.SettlementRefNo).HasMaxLength(50);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.SortDes).HasMaxLength(255);

                entity.Property(e => e.SynCharge).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalValue).HasDefaultValueSql("(0)");

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("(0)");

                entity.Property(e => e.VAT).HasDefaultValueSql("(0)");

                entity.Property(e => e.VATDate).HasColumnType("datetime");

                entity.Property(e => e.VATInvID).HasMaxLength(50);

                entity.Property(e => e.VATName).HasMaxLength(255);

                entity.Property(e => e.VATSOANo).HasMaxLength(50);

                entity.Property(e => e.VATTaxCode).HasMaxLength(50);

                entity.Property(e => e.VoucherID).HasMaxLength(50);

                entity.Property(e => e.VoucherIDSE).HasMaxLength(50);

                entity.HasOne(d => d.Trans)
                    .WithMany(p => p.BuyingRateOthers)
                    .HasForeignKey(d => d.TransID)
                    .HasConstraintName("BuyingRateOthers_FK00");
            });

            modelBuilder.Entity<BuyingRateTrucking>(entity =>
            {
                entity.Property(e => e.ID)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CURRENCY).HasMaxLength(10);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DOCS).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MODIFIEDON).HasColumnType("datetime");

                entity.Property(e => e.PartnerId).HasMaxLength(50);

                entity.Property(e => e.SortDesc).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.VehicleNo).HasMaxLength(50);
            });

            modelBuilder.Entity<BuyingRateWithHBL>(entity =>
            {
                entity.HasKey(e => new { e.HAWBNO, e.Description, e.Unit, e.Collect })
                    .HasName("aaaaaBuyingRateWithHBL_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.CostSheetIDLinked, "CostSheetIDLinked");

                entity.HasIndex(e => e.DatePaid, "DatePaid");

                entity.HasIndex(e => e.Docs, "Docs_BuyingRateWithHBL");

                entity.HasIndex(e => e.FieldKey, "FieldKey_BuyingRateWithHBL");

                entity.HasIndex(e => e.HAWBNO, "HAWBBuyingRateWithHBL");

                entity.HasIndex(e => e.IDKeyIndex, "IDKeyIndex_BuyingRateWithHBL");

                entity.HasIndex(e => e.InoiceNo, "INVOICE_BuyingRateWithHBL_2");

                entity.HasIndex(e => e.InputData, "InputData_BuyingRateWithHBL");

                entity.HasIndex(e => e.OBHPartnerID, "OBHPartnerID_BuyingRateWithHBL");

                entity.HasIndex(e => e.RequisitionID, "RequisitionID_BuyingRateWithHBL");

                entity.HasIndex(e => e.SortDes, "SortDes_BuyingRateWithHBL");

                entity.HasIndex(e => e.HAWBNO, "TransID");

                entity.HasIndex(e => e.VoucherID, "VoucherID");

                entity.HasIndex(e => e.VoucherIDSE, "VoucherIDSE_BuyingRateWithHBL_1");

                entity.Property(e => e.HAWBNO).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.AccsDateKey).HasColumnType("datetime");

                entity.Property(e => e.AccsUserKey).HasMaxLength(50);

                entity.Property(e => e.AdvVoucherID).HasMaxLength(50);

                entity.Property(e => e.Advanced).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.AutoInput).HasDefaultValueSql("((0))");

                entity.Property(e => e.CIDIndex).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CostSheetIDLinked).HasMaxLength(50);

                entity.Property(e => e.CurrencyConvertRate).HasMaxLength(50);

                entity.Property(e => e.DatePaid).HasColumnType("datetime");

                entity.Property(e => e.Docs).HasMaxLength(50);

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.ExtRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtRateVND).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtVND).HasDefaultValueSql("((0))");

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.FieldName).HasMaxLength(50);

                entity.Property(e => e.GWHeavyW).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gainloss).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupName).HasMaxLength(150);

                entity.Property(e => e.IDKeyIndex)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IDKeyShipmentDT).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.INVSOANo).HasMaxLength(50);

                entity.Property(e => e.InoiceNo).HasMaxLength(50);

                entity.Property(e => e.InputData).HasMaxLength(50);

                entity.Property(e => e.InvDate).HasColumnType("datetime");

                entity.Property(e => e.IsSyncEqc).HasDefaultValueSql("((0))");

                entity.Property(e => e.MUnit).HasMaxLength(50);

                entity.Property(e => e.NoInv).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.OBH).HasDefaultValueSql("((0))");

                entity.Property(e => e.OBHPartnerID).HasMaxLength(50);

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequisitionID).HasMaxLength(50);

                entity.Property(e => e.SeriNo).HasMaxLength(50);

                entity.Property(e => e.SettlementRefNo).HasMaxLength(50);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.SortDes).HasMaxLength(50);

                entity.Property(e => e.SortInv).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.VAT).HasDefaultValueSql("((0))");

                entity.Property(e => e.VATDate).HasColumnType("datetime");

                entity.Property(e => e.VATInvID).HasMaxLength(50);

                entity.Property(e => e.VATName).HasMaxLength(255);

                entity.Property(e => e.VATSOANo).HasMaxLength(50);

                entity.Property(e => e.VATTaxCode).HasMaxLength(50);

                entity.Property(e => e.VoucherID).HasMaxLength(50);

                entity.Property(e => e.VoucherIDSE).HasMaxLength(50);

                entity.HasOne(d => d.HAWBNONavigation)
                    .WithMany(p => p.BuyingRateWithHBL)
                    .HasForeignKey(d => d.HAWBNO)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BuyingRateWithHBL_HAWB");
            });

            modelBuilder.Entity<COForm>(entity =>
            {
                entity.HasKey(e => e.RefNo);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.BLDate).HasColumnType("datetime");

                entity.Property(e => e.BLNO).HasMaxLength(50);

                entity.Property(e => e.CDSDate).HasColumnType("datetime");

                entity.Property(e => e.CDSNo).HasMaxLength(50);

                entity.Property(e => e.CODate).HasColumnType("datetime");

                entity.Property(e => e.COForm1)
                    .HasMaxLength(50)
                    .HasColumnName("COForm");

                entity.Property(e => e.CONo).HasMaxLength(50);

                entity.Property(e => e.COPlace).HasMaxLength(50);

                entity.Property(e => e.COType).HasMaxLength(50);

                entity.Property(e => e.ConsigneeID).HasMaxLength(50);

                entity.Property(e => e.ContactDate).HasColumnType("datetime");

                entity.Property(e => e.ContractNo).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Finished).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.POD).HasMaxLength(150);

                entity.Property(e => e.POL).HasMaxLength(150);

                entity.Property(e => e.ShipperID1).HasMaxLength(50);

                entity.Property(e => e.ShipperID2).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.VesselName).HasMaxLength(150);

                entity.Property(e => e.Voyage).HasMaxLength(50);
            });

            modelBuilder.Entity<COFormAttachedFiles>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FieldKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<COFormDetails>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ACFTA).HasMaxLength(255);

                entity.Property(e => e.ApplyRule).HasMaxLength(50);

                entity.Property(e => e.CNTSUnit).HasMaxLength(50);

                entity.Property(e => e.CORefNo).HasMaxLength(50);

                entity.Property(e => e.CurrFOB).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.GoodsDesc).HasMaxLength(255);

                entity.Property(e => e.HSCode).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.ShippingMark).HasMaxLength(255);

                entity.HasOne(d => d.CORefNoNavigation)
                    .WithMany(p => p.COFormDetails)
                    .HasForeignKey(d => d.CORefNo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_COFormDetails_COForm");
            });

            modelBuilder.Entity<COFormIssuedPlace>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Attn).HasMaxLength(255);

                entity.Property(e => e.COPlaceID).HasMaxLength(50);

                entity.Property(e => e.IssuedPlace).HasMaxLength(50);
            });

            modelBuilder.Entity<COFormMaterialList>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CDSDate).HasColumnType("datetime");

                entity.Property(e => e.CDSNo).HasMaxLength(50);

                entity.Property(e => e.CountryOrigin).HasMaxLength(50);

                entity.Property(e => e.HSCode).HasMaxLength(50);

                entity.Property(e => e.IDKeyLinked).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MTUnit).HasMaxLength(50);

                entity.Property(e => e.MaterialDesc).HasMaxLength(150);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.RefNo).HasMaxLength(50);
            });

            modelBuilder.Entity<COFormType>(entity =>
            {
                entity.HasKey(e => e.COFormType1);

                entity.Property(e => e.COFormType1)
                    .HasMaxLength(50)
                    .HasColumnName("COFormType");

                entity.Property(e => e.CompID).HasMaxLength(50);
            });

            modelBuilder.Entity<COForms>(entity =>
            {
                entity.HasKey(e => e.COForm);

                entity.Property(e => e.COForm).HasMaxLength(50);

                entity.Property(e => e.CODesc).HasMaxLength(255);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.CountryName).HasMaxLength(50);

                entity.Property(e => e.ReportName).HasMaxLength(50);
            });

            modelBuilder.Entity<COMaterialNorm>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CDSDate).HasColumnType("datetime");

                entity.Property(e => e.CDSNo).HasMaxLength(50);

                entity.Property(e => e.CountryOrigin).HasMaxLength(50);

                entity.Property(e => e.HSCode).HasMaxLength(50);

                entity.Property(e => e.MTUnit).HasMaxLength(50);

                entity.Property(e => e.MaterialDesc).HasMaxLength(150);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.ProductID).HasMaxLength(50);

                entity.Property(e => e.RefNo).HasMaxLength(50);
            });

            modelBuilder.Entity<CargoOperationRequest>(entity =>
            {
                entity.HasKey(e => e.RequestNo)
                    .HasName("aaaaaCargoOperationRequest_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.CustomerID, "CustomerID");

                entity.HasIndex(e => e.HBLNo, "HAWBCargoOperationRequest");

                entity.Property(e => e.RequestNo).HasMaxLength(50);

                entity.Property(e => e.APPType).HasMaxLength(50);

                entity.Property(e => e.AppDate).HasColumnType("datetime");

                entity.Property(e => e.AppMode).HasMaxLength(255);

                entity.Property(e => e.Attached).HasColumnType("ntext");

                entity.Property(e => e.CDSNo).HasMaxLength(255);

                entity.Property(e => e.CDSType).HasMaxLength(50);

                entity.Property(e => e.CargoContact).HasMaxLength(50);

                entity.Property(e => e.CargoContactAddress).HasMaxLength(255);

                entity.Property(e => e.CargoContactOthers).HasMaxLength(150);

                entity.Property(e => e.CargoContactTel).HasMaxLength(50);

                entity.Property(e => e.CargoContactTime).HasMaxLength(50);

                entity.Property(e => e.ClosingTime).HasMaxLength(50);

                entity.Property(e => e.Consignee).HasMaxLength(255);

                entity.Property(e => e.ConsigneeID).HasMaxLength(50);

                entity.Property(e => e.ContQty).HasMaxLength(50);

                entity.Property(e => e.CustomerID).HasMaxLength(50);

                entity.Property(e => e.DOExpired).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DocsRequest).HasColumnType("ntext");

                entity.Property(e => e.EmptyReturnPickup).HasMaxLength(255);

                entity.Property(e => e.EntireShipment).HasDefaultValueSql("((0))");

                entity.Property(e => e.Etd).HasColumnType("datetime");

                entity.Property(e => e.ForceNew).HasDefaultValueSql("((0))");

                entity.Property(e => e.GoodsDescription).HasMaxLength(255);

                entity.Property(e => e.GoodsNotes).HasMaxLength(255);

                entity.Property(e => e.HBLNo).HasMaxLength(50);

                entity.Property(e => e.IDKeyShipmentDT).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Inland).HasDefaultValueSql("((0))");

                entity.Property(e => e.InternalBKRequestNo).HasMaxLength(50);

                entity.Property(e => e.JobApp).HasMaxLength(50);

                entity.Property(e => e.Measurement).HasDefaultValueSql("((0))");

                entity.Property(e => e.NMPartyID).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OPExecutive).HasMaxLength(50);

                entity.Property(e => e.OperationContact).HasMaxLength(50);

                entity.Property(e => e.Packages).HasMaxLength(50);

                entity.Property(e => e.PortofDischarge).HasMaxLength(50);

                entity.Property(e => e.PortofLoading).HasMaxLength(50);

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.RequestService).HasMaxLength(50);

                entity.Property(e => e.RqTimes).HasMaxLength(50);

                entity.Property(e => e.Shipper).HasMaxLength(255);

                entity.Property(e => e.ShipperID).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.VesselVoy).HasMaxLength(150);

                entity.Property(e => e.WaitH).HasDefaultValueSql("((0))");

                entity.Property(e => e.Whoismaking).HasMaxLength(50);

                entity.HasOne(d => d.HBLNoNavigation)
                    .WithMany(p => p.CargoOperationRequest)
                    .HasForeignKey(d => d.HBLNo)
                    .HasConstraintName("CargoOperationRequest_FK00");
            });

            modelBuilder.Entity<CargoOperationRequestAttachedFiles>(entity =>
            {
                entity.HasKey(e => e.FieldKey);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RequestNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<CargoOperationRequestDetail>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BKNo).HasMaxLength(50);

                entity.Property(e => e.CType).HasMaxLength(50);

                entity.Property(e => e.ContainerNo).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Deadline).HasMaxLength(50);

                entity.Property(e => e.DeliveryPlace).HasMaxLength(150);

                entity.Property(e => e.EmptyReturnORPickup).HasMaxLength(150);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.PIC).HasMaxLength(50);

                entity.Property(e => e.PKGSUnit).HasMaxLength(50);

                entity.Property(e => e.ReceiptPlace).HasMaxLength(150);

                entity.Property(e => e.RequestNo).HasMaxLength(50);

                entity.Property(e => e.UserKey).HasMaxLength(50);

                entity.HasOne(d => d.RequestNoNavigation)
                    .WithMany(p => p.CargoOperationRequestDetail)
                    .HasForeignKey(d => d.RequestNo)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_CargoOperationRequestDetail_CargoOperationRequest");
            });

            modelBuilder.Entity<Commodity>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("aaaaaCommodity_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ID, "ID");

                entity.Property(e => e.ID).HasMaxLength(50);

                entity.Property(e => e.Commodity1)
                    .HasMaxLength(255)
                    .HasColumnName("Commodity");
            });

            modelBuilder.Entity<ComputerInfo>(entity =>
            {
                entity.HasKey(e => e.ComputerName)
                    .HasName("aaaaaComputerInfo_PK")
                    .IsClustered(false);

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.DomainName).HasMaxLength(150);

                entity.Property(e => e.DriveInfo).HasMaxLength(255);

                entity.Property(e => e.LastBootState).HasMaxLength(150);

                entity.Property(e => e.LogonServer).HasMaxLength(150);

                entity.Property(e => e.MemoryInfo).HasMaxLength(255);

                entity.Property(e => e.Networked).HasMaxLength(150);

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.SysDir).HasMaxLength(150);

                entity.Property(e => e.SystemInfo).HasColumnType("ntext");

                entity.Property(e => e.TimeSinceReboot).HasMaxLength(150);

                entity.Property(e => e.UName).HasMaxLength(150);

                entity.Property(e => e.WinDir).HasMaxLength(150);

                entity.Property(e => e.WinVer).HasMaxLength(150);
            });

            modelBuilder.Entity<ConsolidationRate>(entity =>
            {
                entity.HasKey(e => new { e.TransID, e.HBL })
                    .HasName("aaaaaConsolidationRate_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.PartnerID, "PartnersConsolidationRate");

                entity.HasIndex(e => e.TransID, "TransID");

                entity.HasIndex(e => e.HBL, "TransactionDetailsConsolidationRate");

                entity.HasIndex(e => e.TransID, "TransactionsConsolidationRate");

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.HBL).HasMaxLength(50);

                entity.Property(e => e.CCom).HasDefaultValueSql("(0)");

                entity.Property(e => e.CHandle).HasDefaultValueSql("(0)");

                entity.Property(e => e.DDC).HasDefaultValueSql("(0)");

                entity.Property(e => e.Devanning).HasDefaultValueSql("(0)");

                entity.Property(e => e.FirstDest).HasDefaultValueSql("(0)");

                entity.Property(e => e.Inland).HasDefaultValueSql("(0)");

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.SAMS).HasDefaultValueSql("(0)");

                entity.Property(e => e.SExamfee).HasDefaultValueSql("(0)");

                entity.Property(e => e.SHandling).HasDefaultValueSql("(0)");

                entity.Property(e => e.SOF).HasDefaultValueSql("(0)");

                entity.Property(e => e.SPierPass).HasDefaultValueSql("(0)");

                entity.Property(e => e.STHC).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.Trans)
                    .WithMany(p => p.ConsolidationRate)
                    .HasForeignKey(d => d.TransID)
                    .HasConstraintName("ConsolidationRate_FK02");
            });

            modelBuilder.Entity<ContTariffDemDepCharges>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.CompanyID).HasMaxLength(50);

                entity.Property(e => e.ContMode).HasMaxLength(50);

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Kindof).HasMaxLength(50);

                entity.Property(e => e.OtherContType).HasMaxLength(50);

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.Property(e => e.Validity).HasColumnType("datetime");

                entity.HasOne(d => d.ContModeNavigation)
                    .WithMany(p => p.ContTariffDemDepCharges)
                    .HasForeignKey(d => d.ContMode)
                    .HasConstraintName("FK_ContTariffDemDepCharges_ContainerTransType");
            });

            modelBuilder.Entity<ContactPartnerObligation>(entity =>
            {
                entity.HasKey(e => e.IDKeyIndex)
                    .HasName("PK_ContactPartnerObligation_1");

                entity.Property(e => e.ContactID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.PartnerID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserInput).HasMaxLength(50);
            });

            modelBuilder.Entity<ContactsList>(entity =>
            {
                entity.HasKey(e => e.ContactID)
                    .HasName("aaaaaContactsList_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.DeptID, "DepartmentsContactsList");

                entity.HasIndex(e => e.DeptID, "DeptID");

                entity.HasIndex(e => new { e.ContactID, e.ContactName, e.EnglishName, e.Username }, "ID_Name_EnglishName_Username");

                entity.HasIndex(e => e.Identitycard, "Identitycard");

                entity.HasIndex(e => e.KeyLog, "KeyLog");

                entity.HasIndex(e => e.ContactID, "SalesContactID");

                entity.HasIndex(e => e.Username, "Username")
                    .IsUnique();

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.AccessDescription).HasMaxLength(50);

                entity.Property(e => e.AccessRight).HasDefaultValueSql("((0))");

                entity.Property(e => e.AirBookingAuthorised).HasMaxLength(50);

                entity.Property(e => e.BankAC).HasMaxLength(50);

                entity.Property(e => e.BankAdd).HasMaxLength(255);

                entity.Property(e => e.BankName).HasMaxLength(150);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Bonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContactName).HasMaxLength(150);

                entity.Property(e => e.DAlias).HasMaxLength(1000);

                entity.Property(e => e.DeniedMutiLogin).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeptCodeSales).HasMaxLength(50);

                entity.Property(e => e.DeptID).HasMaxLength(50);

                entity.Property(e => e.DisableOutsideLogin).HasDefaultValueSql("((0))");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmpPhotoSize).HasMaxLength(255);

                entity.Property(e => e.EnglishName).HasMaxLength(150);

                entity.Property(e => e.ExtNo).HasMaxLength(50);

                entity.Property(e => e.FieldInterested).HasMaxLength(255);

                entity.Property(e => e.ForwardtoID).HasMaxLength(50);

                entity.Property(e => e.ForwardtoSTID).HasMaxLength(50);

                entity.Property(e => e.GroupID).HasMaxLength(50);

                entity.Property(e => e.HomeAddress).HasMaxLength(150);

                entity.Property(e => e.HomePhone).HasMaxLength(50);

                entity.Property(e => e.Identitycard).HasMaxLength(50);

                entity.Property(e => e.IsKeyNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.KeyLog).HasMaxLength(255);

                entity.Property(e => e.LinkedTruckNo).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.NotifySQLStatement).HasMaxLength(4000);

                entity.Property(e => e.NotifyStatement).HasMaxLength(255);

                entity.Property(e => e.PCode).HasMaxLength(50);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('123456')");

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.PositionContact).HasMaxLength(50);

                entity.Property(e => e.PouseBirthday).HasColumnType("datetime");

                entity.Property(e => e.PouseName).HasMaxLength(150);

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.SalesTarget).HasDefaultValueSql("((0))");

                entity.Property(e => e.Signature).HasMaxLength(255);

                entity.Property(e => e.TableName).HasMaxLength(50);

                entity.Property(e => e.TaxCode).HasMaxLength(50);

                entity.Property(e => e.URL_API).HasMaxLength(255);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ValidChargesCode).HasMaxLength(1000);

                entity.Property(e => e.cAlias).HasMaxLength(1000);

                entity.Property(e => e.emailPassword).HasMaxLength(50);

                entity.Property(e => e.emailPasswordEnscript).HasDefaultValueSql("((0))");

                entity.Property(e => e.sendusing).HasMaxLength(50);

                entity.Property(e => e.smtpauthenticate).HasMaxLength(50);

                entity.Property(e => e.smtpserver).HasMaxLength(50);

                entity.Property(e => e.smtpserverport).HasMaxLength(50);

                entity.Property(e => e.smtpusessl).HasDefaultValueSql("((0))");

                entity.Property(e => e.stopworkingDate).HasColumnType("datetime");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.ContactsList)
                    .HasForeignKey(d => d.DeptID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("ContactsList_FK00");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ContactsList)
                    .HasForeignKey(d => d.GroupID)
                    .HasConstraintName("FK_ContactsList_GroupList");
            });

            modelBuilder.Entity<ContainerBorrowDetail>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.ContactName).HasMaxLength(150);

                entity.Property(e => e.ContainerNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContainerType).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OPSCode).HasMaxLength(50);

                entity.Property(e => e.OffHire).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.TelNo).HasMaxLength(50);

                entity.HasOne(d => d.RefNoNavigation)
                    .WithMany(p => p.ContainerBorrowDetail)
                    .HasForeignKey(d => d.RefNo)
                    .HasConstraintName("FK_ContainerBorrowDetail_ContainerBorrowReport");
            });

            modelBuilder.Entity<ContainerBorrowExtend>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.ContainerNo).HasMaxLength(50);

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.ExtendMode).HasMaxLength(50);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.IssuedDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.HasOne(d => d.RefNoNavigation)
                    .WithMany(p => p.ContainerBorrowExtend)
                    .HasForeignKey(d => d.RefNo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ContainerBorrowExtend_ContainerBorrowReport");
            });

            modelBuilder.Entity<ContainerBorrowReport>(entity =>
            {
                entity.HasKey(e => e.RefNo);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.Accomplish).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccomplishDate).HasColumnType("datetime");

                entity.Property(e => e.AcsUser).HasMaxLength(50);

                entity.Property(e => e.BRDate).HasColumnType("datetime");

                entity.Property(e => e.BorrowPort).HasMaxLength(255);

                entity.Property(e => e.CargoDroffAt).HasMaxLength(255);

                entity.Property(e => e.CellPhoneNo).HasMaxLength(50);

                entity.Property(e => e.ConditionBR).HasMaxLength(4000);

                entity.Property(e => e.ContactName).HasMaxLength(150);

                entity.Property(e => e.ContainerNoList).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateModify).HasColumnType("datetime");

                entity.Property(e => e.CurrencyBR).HasMaxLength(50);

                entity.Property(e => e.DateBR).HasColumnType("datetime");

                entity.Property(e => e.DateReturn).HasColumnType("datetime");

                entity.Property(e => e.FreeDayNotes).HasMaxLength(50);

                entity.Property(e => e.HBLDate).HasColumnType("datetime");

                entity.Property(e => e.HBLNO).HasMaxLength(50);

                entity.Property(e => e.IdentityID).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.Received).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportName).HasMaxLength(50);

                entity.Property(e => e.ReturnContAt).HasMaxLength(255);

                entity.Property(e => e.ReturnPortAddress).HasMaxLength(255);

                entity.Property(e => e.TelNo).HasMaxLength(50);

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.Property(e => e.VoucherID).HasMaxLength(50);

                entity.Property(e => e.WareHouse).HasMaxLength(255);

                entity.Property(e => e.WareHouseAddress).HasMaxLength(255);
            });

            modelBuilder.Entity<ContainerCharges>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.ChargeCode).HasMaxLength(50);

                entity.Property(e => e.ContactIDApp).HasMaxLength(50);

                entity.Property(e => e.ContactIDRequest).HasMaxLength(50);

                entity.Property(e => e.ContainerNo).HasMaxLength(50);

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DateApp).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateRequest).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.PartnerPayeeID).HasMaxLength(50);

                entity.Property(e => e.PayerID).HasMaxLength(50);

                entity.Property(e => e.RevInvoiceNo).HasMaxLength(50);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<ContainerFreightCharges>(entity =>
            {
                entity.HasKey(e => e.IDSelf);

                entity.Property(e => e.DateKey).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.FreightCharges).HasMaxLength(255);

                entity.Property(e => e.HBLNo).HasMaxLength(50);

                entity.Property(e => e.LockFreight).HasDefaultValueSql("(0)");

                entity.Property(e => e.SCharges).HasMaxLength(255);

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.WhoisInput).HasMaxLength(50);

                entity.HasOne(d => d.IDKeyNavigation)
                    .WithMany(p => p.ContainerFreightCharges)
                    .HasForeignKey(d => d.IDKey)
                    .HasConstraintName("FK_ContainerFreightCharges_ShippingInstruction");
            });

            modelBuilder.Entity<ContainerListOnHBL>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.HasIndex(e => e.HBLNo, "IX_ContainerListOnHBL");

                entity.Property(e => e.AutoSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.BAGSNO).HasMaxLength(50);

                entity.Property(e => e.CTNUnitOfMeasure).HasMaxLength(50);

                entity.Property(e => e.ContID).HasMaxLength(50);

                entity.Property(e => e.ContNotes).HasMaxLength(255);

                entity.Property(e => e.ContainerNo).HasMaxLength(50);

                entity.Property(e => e.ContainerType).HasMaxLength(50);

                entity.Property(e => e.CustomsInspection).HasMaxLength(50);

                entity.Property(e => e.DocsStaff).HasMaxLength(50);

                entity.Property(e => e.DropofPlace).HasMaxLength(150);

                entity.Property(e => e.ETRTPlace).HasMaxLength(150);

                entity.Property(e => e.FumiCo).HasMaxLength(150);

                entity.Property(e => e.HBLNo).HasMaxLength(50);

                entity.Property(e => e.InsurCo).HasMaxLength(50);

                entity.Property(e => e.MARK).HasMaxLength(50);

                entity.Property(e => e.OffhireDepot).HasMaxLength(50);

                entity.Property(e => e.OffhireRefNo).HasMaxLength(50);

                entity.Property(e => e.OwnerID).HasMaxLength(50);

                entity.Property(e => e.PALLET).HasMaxLength(50);

                entity.Property(e => e.Partof).HasDefaultValueSql("((0))");

                entity.Property(e => e.QCStaff).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.SealNo).HasMaxLength(50);

                entity.Property(e => e.SfuffingDate).HasColumnType("datetime");

                entity.Property(e => e.SfuffingTime).HasMaxLength(50);

                entity.Property(e => e.ShipmentIDKey).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.StuffingLocation).HasMaxLength(150);

                entity.Property(e => e.StuffingPhoto).HasMaxLength(50);

                entity.Property(e => e.StuffingPlace).HasMaxLength(150);

                entity.Property(e => e.SubmitDate).HasColumnType("datetime");

                entity.Property(e => e.TruckingCo).HasMaxLength(150);

                entity.Property(e => e.VGMCutofftime).HasMaxLength(50);

                entity.HasOne(d => d.HBLNoNavigation)
                    .WithMany(p => p.ContainerListOnHBL)
                    .HasForeignKey(d => d.HBLNo)
                    .HasConstraintName("FK_ContainerListOnHBL_HAWB");
            });

            modelBuilder.Entity<ContainerLoaded>(entity =>
            {
                entity.HasKey(e => new { e.TransID, e.Container })
                    .HasName("PK_ContainerLoaded_1");

                entity.HasIndex(e => e.TransID, "TransID");

                entity.HasIndex(e => e.TransID, "TransactionsContainerLoaded");

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.Container).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.Qty).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Trans)
                    .WithMany(p => p.ContainerLoaded)
                    .HasForeignKey(d => d.TransID)
                    .HasConstraintName("ContainerLoaded_FK00");
            });

            modelBuilder.Entity<ContainerLoadedHBL>(entity =>
            {
                entity.HasKey(e => new { e.HBLNo, e.Container });

                entity.HasIndex(e => e.HBLNo, "HAWBContainerLoadedHBL");

                entity.HasIndex(e => e.HBLNo, "TransID");

                entity.Property(e => e.HBLNo).HasMaxLength(50);

                entity.Property(e => e.Container).HasMaxLength(50);

                entity.Property(e => e.ContSealNo).HasMaxLength(4000);

                entity.Property(e => e.Qty).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.HBLNoNavigation)
                    .WithMany(p => p.ContainerLoadedHBL)
                    .HasForeignKey(d => d.HBLNo)
                    .HasConstraintName("ContainerLoadedHBL_FK00");
            });

            modelBuilder.Entity<ContainerLoadedInquiry>(entity =>
            {
                entity.HasKey(e => new { e.TransID, e.Container });

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.Container).HasMaxLength(150);

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.Qty).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.Trans)
                    .WithMany(p => p.ContainerLoadedInquiry)
                    .HasForeignKey(d => d.TransID)
                    .HasConstraintName("FK_ContainerLoadedInquiry_ServiceInquiry");
            });

            modelBuilder.Entity<ContainerLoadedSVR>(entity =>
            {
                entity.HasKey(e => new { e.TransID, e.Qty, e.Container });

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.Container).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(4000);
            });

            modelBuilder.Entity<ContainerPKExtension>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.ContactName).HasMaxLength(150);

                entity.Property(e => e.ContainerNo).HasMaxLength(50);

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ExtType).HasMaxLength(50);

                entity.Property(e => e.ExttoDate).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.HBLNo).HasMaxLength(50);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.HasOne(d => d.HBLNoNavigation)
                    .WithMany(p => p.ContainerPKExtension)
                    .HasForeignKey(d => d.HBLNo)
                    .HasConstraintName("FK_ContainerPKExtension_HAWB");
            });

            modelBuilder.Entity<ContainerRoutine>(entity =>
            {
                entity.HasKey(e => e.Maso);

                entity.Property(e => e.Maso)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContainerNo).HasMaxLength(50);

                entity.Property(e => e.DaTiepNhan).HasDefaultValueSql("((0))");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.DescriptionOfGoods).HasMaxLength(255);

                entity.Property(e => e.DiaChiDongHang).HasMaxLength(255);

                entity.Property(e => e.DiaChiGiaHang).HasMaxLength(255);

                entity.Property(e => e.DieuKien).HasMaxLength(50);

                entity.Property(e => e.Finished).HasDefaultValueSql("((0))");

                entity.Property(e => e.GhiChu).HasMaxLength(255);

                entity.Property(e => e.GhiChuContCombine).HasMaxLength(255);

                entity.Property(e => e.GuiYCVC).HasDefaultValueSql("((0))");

                entity.Property(e => e.Modified).HasDefaultValueSql("((0))");

                entity.Property(e => e.NgayCapLenh).HasColumnType("datetime");

                entity.Property(e => e.NgayCapNhat).HasColumnType("datetime");

                entity.Property(e => e.NgayDongHang).HasColumnType("datetime");

                entity.Property(e => e.NgayGiaoHang).HasColumnType("datetime");

                entity.Property(e => e.NgayGuiYCVC).HasColumnType("datetime");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.NgayTiepNhan).HasColumnType("datetime");

                entity.Property(e => e.NguoiCap).HasMaxLength(50);

                entity.Property(e => e.NguoiLienHeDongHang).HasMaxLength(50);

                entity.Property(e => e.NguoiLienHeGiaoHang).HasMaxLength(50);

                entity.Property(e => e.NoiHaHang).HasMaxLength(50);

                entity.Property(e => e.NoiHaRong).HasMaxLength(50);

                entity.Property(e => e.NoiLayHang).HasMaxLength(50);

                entity.Property(e => e.NoiLayRong).HasMaxLength(50);

                entity.Property(e => e.SealNo).HasMaxLength(50);

                entity.Property(e => e.ShipmentID).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SoLenh).HasMaxLength(50);

                entity.Property(e => e.SoxeVC).HasMaxLength(50);

                entity.Property(e => e.TyLePhi).HasMaxLength(50);

                entity.Property(e => e.UnitQty).HasMaxLength(50);

                entity.Property(e => e.UserHandle).HasMaxLength(50);

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.ContainerRoutine)
                    .HasPrincipalKey(p => p.IDKeyShipment)
                    .HasForeignKey(d => d.ShipmentID)
                    .HasConstraintName("FK_ContainerRoutine_TransactionDetails");
            });

            modelBuilder.Entity<ContainerTrans>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.AfterRepaid).HasMaxLength(50);

                entity.Property(e => e.BookingNo).HasMaxLength(50);

                entity.Property(e => e.ContStatus).HasMaxLength(50);

                entity.Property(e => e.ContainerNo).HasMaxLength(50);

                entity.Property(e => e.ContentStatus).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.EmptyInDate).HasColumnType("datetime");

                entity.Property(e => e.EmptyInGrade).HasMaxLength(50);

                entity.Property(e => e.EmptyInRemark).HasMaxLength(255);

                entity.Property(e => e.EmptyInStatus).HasMaxLength(50);

                entity.Property(e => e.EmptyInTerminal).HasMaxLength(50);

                entity.Property(e => e.EmptyMovetoDate).HasColumnType("datetime");

                entity.Property(e => e.EmptyMovetoDepot).HasMaxLength(50);

                entity.Property(e => e.EmptyOutDate).HasColumnType("datetime");

                entity.Property(e => e.EmptyOutRemark).HasMaxLength(50);

                entity.Property(e => e.JobNo).HasMaxLength(50);

                entity.Property(e => e.LadenInDate).HasColumnType("datetime");

                entity.Property(e => e.LadenInRemark).HasMaxLength(255);

                entity.Property(e => e.LadenInStatus).HasMaxLength(50);

                entity.Property(e => e.LadenInTerminal).HasMaxLength(50);

                entity.Property(e => e.LadenOnboardStatus).HasMaxLength(50);

                entity.Property(e => e.LadenOutDate).HasColumnType("datetime");

                entity.Property(e => e.LadenOutRemark).HasMaxLength(255);

                entity.Property(e => e.LadenOutStatus).HasMaxLength(50);

                entity.Property(e => e.LadenOutTerminal).HasMaxLength(50);

                entity.Property(e => e.MBLNo).HasMaxLength(50);

                entity.Property(e => e.MovetoRepairDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.RepaidRemark).HasMaxLength(255);

                entity.Property(e => e.SealNo).HasMaxLength(50);

                entity.Property(e => e.StorageDepot).HasMaxLength(50);

                entity.Property(e => e.StorageOwnerRemark).HasMaxLength(50);

                entity.Property(e => e.StorageSelfRemark).HasMaxLength(50);

                entity.Property(e => e.TransMode).HasMaxLength(50);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<ContainerTransType>(entity =>
            {
                entity.HasKey(e => e.ContTransType);

                entity.Property(e => e.ContTransType).HasMaxLength(50);

                entity.Property(e => e.ContTransDescription).HasMaxLength(255);

                entity.Property(e => e.EmptyIn).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpyOut).HasDefaultValueSql("((0))");

                entity.Property(e => e.FullLadenIn).HasDefaultValueSql("((0))");

                entity.Property(e => e.LadenIn).HasDefaultValueSql("((0))");

                entity.Property(e => e.LadenOnboard).HasDefaultValueSql("((0))");

                entity.Property(e => e.LadenOut).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ContainerTransactionDetails>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.ContainerNo).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Depot).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Terminal).HasMaxLength(50);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.TransMode).HasMaxLength(50);

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.HasOne(d => d.IDKeyLinkedNavigation)
                    .WithMany(p => p.ContainerTransactionDetails)
                    .HasForeignKey(d => d.IDKeyLinked)
                    .HasConstraintName("FK_ContainerTransactionDetails_ContainerTransactions");

                entity.HasOne(d => d.TransModeNavigation)
                    .WithMany(p => p.ContainerTransactionDetails)
                    .HasForeignKey(d => d.TransMode)
                    .HasConstraintName("FK_ContainerTransactionDetails_ContainerTransType");
            });

            modelBuilder.Entity<ContainerTransactions>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.BKNo).HasMaxLength(50);

                entity.Property(e => e.ContainerNo).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DateofHire).HasColumnType("datetime");

                entity.Property(e => e.InDate).HasColumnType("datetime");

                entity.Property(e => e.OffHire).HasDefaultValueSql("((0))");

                entity.Property(e => e.OnHire).HasDefaultValueSql("((0))");

                entity.Property(e => e.OutDate).HasColumnType("datetime");

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.HasOne(d => d.ContainerNoNavigation)
                    .WithMany(p => p.ContainerTransactions)
                    .HasPrincipalKey(p => p.ContNo)
                    .HasForeignKey(d => d.ContainerNo)
                    .HasConstraintName("FK_ContainerTransactions_ContainersList");

                entity.HasOne(d => d.SPKeyIDLinkNavigation)
                    .WithMany(p => p.ContainerTransactions)
                    .HasForeignKey(d => d.SPKeyIDLink)
                    .HasConstraintName("FK_ContainerTransactions_ContainerListOnHBL");
            });

            modelBuilder.Entity<ContainersList>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.HasIndex(e => e.ContNo, "IX_ContainersList")
                    .IsUnique();

                entity.Property(e => e.BCurr).HasMaxLength(50);

                entity.Property(e => e.ContDescription).HasMaxLength(50);

                entity.Property(e => e.ContMode).HasMaxLength(50);

                entity.Property(e => e.ContNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContSize).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.HCurr).HasMaxLength(50);

                entity.Property(e => e.HireDateFrom).HasColumnType("datetime");

                entity.Property(e => e.HireDateTo).HasColumnType("datetime");

                entity.Property(e => e.Origin).HasMaxLength(50);

                entity.Property(e => e.OwnerID).HasMaxLength(50);

                entity.Property(e => e.SCurr).HasMaxLength(50);

                entity.Property(e => e.VenderName).HasMaxLength(50);

                entity.Property(e => e.WhoIsUnput).HasMaxLength(50);

                entity.Property(e => e.YearMade).HasMaxLength(50);
            });

            modelBuilder.Entity<ConvertToUnicode>(entity =>
            {
                entity.Property(e => e.ID)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateSync).HasColumnType("datetime");

                entity.Property(e => e.FromCode).HasMaxLength(20);

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.IPAddress).HasMaxLength(255);

                entity.Property(e => e.ToCode).HasMaxLength(20);

                entity.Property(e => e.WhoSync).HasMaxLength(255);
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryCode)
                    .HasName("aaaaaCountries_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.CountryCode, "NationalCode");

                entity.Property(e => e.CountryCode).HasMaxLength(50);

                entity.Property(e => e.CountryName).HasMaxLength(150);

                entity.Property(e => e.CountryZone).HasMaxLength(50);

                entity.Property(e => e.IDCountryCode).HasMaxLength(50);
            });

            modelBuilder.Entity<CrossTabTable>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.TransID, "TransID");

                entity.Property(e => e.CDFee1).HasDefaultValueSql("(0)");

                entity.Property(e => e.CDFee2).HasDefaultValueSql("(0)");

                entity.Property(e => e.CDHFee1).HasDefaultValueSql("(0)");

                entity.Property(e => e.CDHFee2).HasDefaultValueSql("(0)");

                entity.Property(e => e.CDHFee3).HasDefaultValueSql("(0)");

                entity.Property(e => e.DBFee1).HasDefaultValueSql("(0)");

                entity.Property(e => e.DBFee2).HasDefaultValueSql("(0)");

                entity.Property(e => e.DBFee3).HasDefaultValueSql("(0)");

                entity.Property(e => e.DBFee4).HasDefaultValueSql("(0)");

                entity.Property(e => e.DBFee5).HasDefaultValueSql("(0)");

                entity.Property(e => e.DBFee6).HasDefaultValueSql("(0)");

                entity.Property(e => e.DBFee7).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dest).HasMaxLength(50);

                entity.Property(e => e.HBL)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.Shipper).HasMaxLength(150);

                entity.Property(e => e.TransID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.Volume).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CrosstabTableCaption>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.TemplateID, "TemplateID");

                entity.HasIndex(e => e.TransID, "TransID");

                entity.Property(e => e.Field1).HasMaxLength(50);

                entity.Property(e => e.Field10).HasMaxLength(50);

                entity.Property(e => e.Field11).HasMaxLength(50);

                entity.Property(e => e.Field12).HasMaxLength(50);

                entity.Property(e => e.Field13).HasMaxLength(4000);

                entity.Property(e => e.Field2).HasMaxLength(50);

                entity.Property(e => e.Field3).HasMaxLength(50);

                entity.Property(e => e.Field4).HasMaxLength(50);

                entity.Property(e => e.Field5).HasMaxLength(50);

                entity.Property(e => e.Field6).HasMaxLength(50);

                entity.Property(e => e.Field7).HasMaxLength(50);

                entity.Property(e => e.Field8).HasMaxLength(50);

                entity.Property(e => e.Field9).HasMaxLength(50);

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.TemplateID).HasMaxLength(50);

                entity.Property(e => e.TransID)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CrosstabTableCaptionTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateID)
                    .HasName("aaaaaCrosstabTableCaptionTemplate_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.TemplateID, "TransID");

                entity.Property(e => e.TemplateID).HasMaxLength(50);

                entity.Property(e => e.Field1).HasMaxLength(50);

                entity.Property(e => e.Field10).HasMaxLength(50);

                entity.Property(e => e.Field11).HasMaxLength(50);

                entity.Property(e => e.Field12).HasMaxLength(50);

                entity.Property(e => e.Field2).HasMaxLength(50);

                entity.Property(e => e.Field3).HasMaxLength(50);

                entity.Property(e => e.Field4).HasMaxLength(50);

                entity.Property(e => e.Field5).HasMaxLength(50);

                entity.Property(e => e.Field6).HasMaxLength(50);

                entity.Property(e => e.Field7).HasMaxLength(50);

                entity.Property(e => e.Field8).HasMaxLength(50);

                entity.Property(e => e.Field9).HasMaxLength(50);

                entity.Property(e => e.ReportName).HasMaxLength(255);

                entity.Property(e => e.TemplateMode).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CurrExchangeLocalSystem>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.CurrDesc).HasMaxLength(150);

                entity.Property(e => e.CurrUnit).HasMaxLength(50);

                entity.Property(e => e.MCurr).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<CurrencyExchangeRate>(entity =>
            {
                entity.HasKey(e => new { e.ID, e.Unit });

                entity.Property(e => e.ID).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.ExtVNDSales).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExtVNDSalesKB).HasDefaultValueSql("(0)");

                entity.Property(e => e.Note).HasMaxLength(150);

                entity.Property(e => e.Price).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.IDNavigation)
                    .WithMany(p => p.CurrencyExchangeRate)
                    .HasForeignKey(d => d.ID)
                    .HasConstraintName("FK_CurrencyExchangeRate_SalesCurrencyExchange");
            });

            modelBuilder.Entity<CustomsDeclaration>(entity =>
            {
                entity.HasKey(e => e.MasoTK)
                    .HasName("aaaaaCustomsDeclaration_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.NuocNKID, "NuocNKID");

                entity.HasIndex(e => e.ShipmentID, "ShipmentID");

                entity.HasIndex(e => e.TransID, "SoID");

                entity.Property(e => e.MasoTK).HasMaxLength(50);

                entity.Property(e => e.BC1).HasMaxLength(50);

                entity.Property(e => e.BC2).HasMaxLength(50);

                entity.Property(e => e.BC3).HasMaxLength(50);

                entity.Property(e => e.BC4).HasMaxLength(50);

                entity.Property(e => e.BC5).HasMaxLength(50);

                entity.Property(e => e.BC6).HasMaxLength(50);

                entity.Property(e => e.BC7).HasMaxLength(50);

                entity.Property(e => e.BC8).HasMaxLength(50);

                entity.Property(e => e.BI1).HasMaxLength(50);

                entity.Property(e => e.BI2).HasMaxLength(50);

                entity.Property(e => e.BI3).HasMaxLength(50);

                entity.Property(e => e.BI4).HasMaxLength(50);

                entity.Property(e => e.BI5).HasMaxLength(50);

                entity.Property(e => e.BI6).HasMaxLength(50);

                entity.Property(e => e.BI7).HasMaxLength(50);

                entity.Property(e => e.BI8).HasMaxLength(50);

                entity.Property(e => e.BS1).HasMaxLength(50);

                entity.Property(e => e.BS2).HasMaxLength(50);

                entity.Property(e => e.BS3).HasMaxLength(50);

                entity.Property(e => e.BS4).HasMaxLength(50);

                entity.Property(e => e.BS5).HasMaxLength(50);

                entity.Property(e => e.BS6).HasMaxLength(50);

                entity.Property(e => e.BS7).HasMaxLength(50);

                entity.Property(e => e.BS8).HasMaxLength(50);

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillofLadingNo).HasMaxLength(50);

                entity.Property(e => e.CTNSType).HasMaxLength(50);

                entity.Property(e => e.CanBoDangKy).HasMaxLength(255);

                entity.Property(e => e.CangDo).HasMaxLength(150);

                entity.Property(e => e.CangXep).HasMaxLength(150);

                entity.Property(e => e.CangXepEng).HasMaxLength(255);

                entity.Property(e => e.ChiCucHQ).HasMaxLength(255);

                entity.Property(e => e.ChungTuDiKem1).HasMaxLength(150);

                entity.Property(e => e.ChungTuDiKem2).HasMaxLength(150);

                entity.Property(e => e.ChungTuDiKem3).HasMaxLength(150);

                entity.Property(e => e.ChungTuDiKem4).HasMaxLength(150);

                entity.Property(e => e.ChungTuTT).HasMaxLength(150);

                entity.Property(e => e.CoQuanCapNguoiGui).HasMaxLength(150);

                entity.Property(e => e.CoQuanCapNguoiNhan).HasMaxLength(150);

                entity.Property(e => e.CoQuanCapNguoiUyQuyen).HasMaxLength(150);

                entity.Property(e => e.ContQty).HasMaxLength(50);

                entity.Property(e => e.ContSize).HasMaxLength(150);

                entity.Property(e => e.Crate).HasMaxLength(150);

                entity.Property(e => e.CuakhauXH).HasMaxLength(50);

                entity.Property(e => e.CucHQ).HasMaxLength(255);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.CustomsDate).HasColumnType("datetime");

                entity.Property(e => e.DaiLy).HasMaxLength(255);

                entity.Property(e => e.DescriptionM).HasMaxLength(4000);

                entity.Property(e => e.DetailNotes).HasMaxLength(255);

                entity.Property(e => e.DieuKienDG).HasMaxLength(255);

                entity.Property(e => e.DieuKienGH).HasMaxLength(50);

                entity.Property(e => e.DonVT).HasMaxLength(254);

                entity.Property(e => e.DongiaNguyenTe).HasMaxLength(254);

                entity.Property(e => e.FooterNote).HasMaxLength(255);

                entity.Property(e => e.GTGTThuesuat).HasMaxLength(254);

                entity.Property(e => e.GTGTTienthue).HasMaxLength(254);

                entity.Property(e => e.GTGTTrigiaTT).HasMaxLength(254);

                entity.Property(e => e.GiayPhepCoQuanCap).HasMaxLength(255);

                entity.Property(e => e.GiayToKemTheo).HasMaxLength(4000);

                entity.Property(e => e.GrossW).HasDefaultValueSql("((0))");

                entity.Property(e => e.Loaihinh).HasMaxLength(100);

                entity.Property(e => e.LuongHH).HasMaxLength(254);

                entity.Property(e => e.MCBM).HasDefaultValueSql("((0))");

                entity.Property(e => e.MSTNguoiGui).HasMaxLength(50);

                entity.Property(e => e.MSTNguoiNhan).HasMaxLength(50);

                entity.Property(e => e.MSTNguoiUyQuyen).HasMaxLength(50);

                entity.Property(e => e.MaCK).HasMaxLength(50);

                entity.Property(e => e.MaCKXH).HasMaxLength(50);

                entity.Property(e => e.MaCangXH).HasMaxLength(50);

                entity.Property(e => e.Maloaihinh).HasMaxLength(50);

                entity.Property(e => e.MasoHH).HasMaxLength(254);

                entity.Property(e => e.NgayCapNguoiGui).HasColumnType("datetime");

                entity.Property(e => e.NgayCapNguoiNhan).HasColumnType("datetime");

                entity.Property(e => e.NgayCapNguoiUyQuyen).HasColumnType("datetime");

                entity.Property(e => e.NgayDangKy).HasColumnType("datetime");

                entity.Property(e => e.NgayDen).HasColumnType("datetime");

                entity.Property(e => e.NgayDi).HasColumnType("datetime");

                entity.Property(e => e.NgayGH).HasColumnType("datetime");

                entity.Property(e => e.NgayGP).HasColumnType("datetime");

                entity.Property(e => e.NgayGui).HasColumnType("datetime");

                entity.Property(e => e.NgayHD).HasMaxLength(50);

                entity.Property(e => e.NgayHDTM).HasColumnType("datetime");

                entity.Property(e => e.NgayHetHD).HasMaxLength(50);

                entity.Property(e => e.NgayHetHan).HasColumnType("datetime");

                entity.Property(e => e.NguoiGui).HasMaxLength(255);

                entity.Property(e => e.NguoiKhai).HasMaxLength(150);

                entity.Property(e => e.NguoiNhan).HasMaxLength(255);

                entity.Property(e => e.NguoiUyQuyen).HasMaxLength(255);

                entity.Property(e => e.NoteOfNonVAT).HasMaxLength(4000);

                entity.Property(e => e.NuocNKID).HasMaxLength(50);

                entity.Property(e => e.NuocNhapKhau).HasMaxLength(50);

                entity.Property(e => e.NuocXuatkhau).HasMaxLength(50);

                entity.Property(e => e.PLUONG).HasMaxLength(50);

                entity.Property(e => e.PhuongthucTDetail).HasMaxLength(255);

                entity.Property(e => e.PhuongthucTT).HasMaxLength(150);

                entity.Property(e => e.PlaceofDelivery).HasMaxLength(50);

                entity.Property(e => e.PortofDischarge).HasMaxLength(50);

                entity.Property(e => e.SCMTDaiLy).HasMaxLength(50);

                entity.Property(e => e.STT).HasMaxLength(50);

                entity.Property(e => e.ShipmentID).HasMaxLength(50);

                entity.Property(e => e.SoCMTNguoiGui).HasMaxLength(150);

                entity.Property(e => e.SoCMTNguoiNhan).HasMaxLength(150);

                entity.Property(e => e.SoCMTNguoiUyQuyen).HasMaxLength(150);

                entity.Property(e => e.SoGiayPhep).HasMaxLength(150);

                entity.Property(e => e.SoHDTM).HasMaxLength(50);

                entity.Property(e => e.SoHieuPTVT).HasMaxLength(50);

                entity.Property(e => e.SoHpdong).HasMaxLength(50);

                entity.Property(e => e.SoKien).HasMaxLength(150);

                entity.Property(e => e.SoluongTK).HasMaxLength(50);

                entity.Property(e => e.TKSo).HasMaxLength(50);

                entity.Property(e => e.TKSoAfter).HasMaxLength(50);

                entity.Property(e => e.TKSoAfter1).HasMaxLength(50);

                entity.Property(e => e.TauDi).HasMaxLength(150);

                entity.Property(e => e.TenhangHoa).HasMaxLength(254);

                entity.Property(e => e.ThueSuat).HasMaxLength(254);

                entity.Property(e => e.ThukhacSotien).HasMaxLength(254);

                entity.Property(e => e.ThukhacTyle).HasMaxLength(254);

                entity.Property(e => e.TienThue).HasMaxLength(254);

                entity.Property(e => e.TongBangChu).HasMaxLength(255);

                entity.Property(e => e.TongCongBS).HasDefaultValueSql("((0))");

                entity.Property(e => e.TongGTGTTienthue).HasDefaultValueSql("((0))");

                entity.Property(e => e.TongTGTT).HasDefaultValueSql("((0))");

                entity.Property(e => e.TongTienthue).HasDefaultValueSql("((0))");

                entity.Property(e => e.TongthuKhac).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.TrigiaTinhthue).HasMaxLength(254);

                entity.Property(e => e.TygiaTinhThue).HasDefaultValueSql("((0))");

                entity.Property(e => e.Xuatxu).HasMaxLength(254);
            });

            modelBuilder.Entity<CustomsDeclarationDetail>(entity =>
            {
                entity.HasKey(e => new { e.MasoTK, e.SoTT })
                    .HasName("aaaaaCustomsDeclarationDetail_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.MasoTK, "CustomsDeclarationCustomsDeclarationDetail");

                entity.Property(e => e.MasoTK).HasMaxLength(50);

                entity.Property(e => e.CBM).HasDefaultValueSql("((0))");

                entity.Property(e => e.CheDoUuDai).HasMaxLength(50);

                entity.Property(e => e.Ctns).HasDefaultValueSql("((0))");

                entity.Property(e => e.DVT).HasMaxLength(50);

                entity.Property(e => e.DonGiaNguyenTe).HasDefaultValueSql("((0))");

                entity.Property(e => e.GrossWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.LuongHang).HasDefaultValueSql("((0))");

                entity.Property(e => e.MasoHH).HasMaxLength(50);

                entity.Property(e => e.TenHang).HasMaxLength(255);

                entity.Property(e => e.ThuesuatGTGT).HasDefaultValueSql("((0))");

                entity.Property(e => e.ThuesuatNK).HasDefaultValueSql("((0))");

                entity.Property(e => e.ThukhacSotien).HasDefaultValueSql("((0))");

                entity.Property(e => e.ThukhacTyle).HasDefaultValueSql("((0))");

                entity.Property(e => e.TriGiaNguyenTe).HasDefaultValueSql("((0))");

                entity.Property(e => e.Xuatxu).HasMaxLength(50);

                entity.HasOne(d => d.MasoTKNavigation)
                    .WithMany(p => p.CustomsDeclarationDetail)
                    .HasForeignKey(d => d.MasoTK)
                    .HasConstraintName("CustomsDeclarationDetail_FK00");
            });

            modelBuilder.Entity<DODishList>(entity =>
            {
                entity.HasKey(e => e.DiskNo)
                    .HasName("aaaaaDODishList_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.SupplierID, "PartnersDODishList");

                entity.HasIndex(e => e.SupplierID, "SupplierID");

                entity.Property(e => e.DiskNo).HasMaxLength(50);

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.Portion).HasMaxLength(255);

                entity.Property(e => e.SupplierID).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.DODishList)
                    .HasForeignKey(d => d.SupplierID)
                    .HasConstraintName("DODishList_FK00");
            });

            modelBuilder.Entity<DOManaged>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("aaaaaDOManaged_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ContactID, "ContactID");

                entity.HasIndex(e => e.ContactID, "ContactsListDOManaged");

                entity.Property(e => e.Authorise).HasMaxLength(50);

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.DeathLine).HasDefaultValueSql("(0)");

                entity.Property(e => e.Msg).HasMaxLength(255);

                entity.Property(e => e.TimeFinish).HasMaxLength(50);

                entity.Property(e => e.Timestart).HasMaxLength(50);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.DOManaged)
                    .HasForeignKey(d => d.ContactID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("DOManaged_FK00");
            });

            modelBuilder.Entity<DOOrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.OrderID, e.DishNo })
                    .HasName("aaaaaDOOrderDetail_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.DishNo, "DODishListDOOrderDetail");

                entity.HasIndex(e => e.OrderID, "DOOrderListDOOrderDetail");

                entity.HasIndex(e => e.OrderID, "OrderID");

                entity.Property(e => e.OrderID).HasMaxLength(50);

                entity.Property(e => e.DishNo).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(150);

                entity.Property(e => e.Quantity).HasDefaultValueSql("(0)");

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.DishNoNavigation)
                    .WithMany(p => p.DOOrderDetail)
                    .HasForeignKey(d => d.DishNo)
                    .HasConstraintName("DOOrderDetail_FK00");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.DOOrderDetail)
                    .HasForeignKey(d => d.OrderID)
                    .HasConstraintName("DOOrderDetail_FK01");
            });

            modelBuilder.Entity<DOOrderList>(entity =>
            {
                entity.HasKey(e => e.OrderID)
                    .HasName("aaaaaDOOrderList_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ContactID, "ContactID");

                entity.HasIndex(e => e.ContactID, "ContactsListDOOrderList");

                entity.HasIndex(e => e.Managed, "ContactsListDOOrderList1");

                entity.HasIndex(e => e.OrderID, "OrderID");

                entity.Property(e => e.OrderID).HasMaxLength(50);

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.Managed).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.Payment).HasMaxLength(150);
            });

            modelBuilder.Entity<DOPaymentSheet>(entity =>
            {
                entity.HasKey(e => e.PmID)
                    .HasName("aaaaaDOPaymentSheet_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ContactID, "ContactID");

                entity.HasIndex(e => e.ContactID, "ContactsListDOPaymentSheet");

                entity.HasIndex(e => e.ManagedID, "ContactsListDOPaymentSheet1");

                entity.HasIndex(e => e.ManagedID, "ManagedID");

                entity.HasIndex(e => e.PmID, "PmID");

                entity.Property(e => e.PmID).HasMaxLength(50);

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.ManagedID).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.PmDate).HasColumnType("datetime");

                entity.Property(e => e.PmValue).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<DOSupplierList>(entity =>
            {
                entity.HasKey(e => e.SupplierID)
                    .HasName("aaaaaDOSupplierList_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.SupplierID, "SupplierID");

                entity.Property(e => e.SupplierID).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Cell).HasMaxLength(50);

                entity.Property(e => e.ContactName).HasMaxLength(150);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FieldInterested).HasColumnType("ntext");

                entity.Property(e => e.SupplierName).HasMaxLength(255);

                entity.Property(e => e.Tel).HasMaxLength(50);
            });

            modelBuilder.Entity<DataSourceSetup>(entity =>
            {
                entity.HasKey(e => e.FuncID);

                entity.Property(e => e.FuncID).HasMaxLength(50);

                entity.Property(e => e.AddedColFontBold).HasDefaultValueSql("((0))");

                entity.Property(e => e.AddedColFormular).HasMaxLength(255);

                entity.Property(e => e.Colswdth).HasMaxLength(1000);

                entity.Property(e => e.CompIDList).HasMaxLength(255);

                entity.Property(e => e.ConcatCols).HasMaxLength(50);

                entity.Property(e => e.CondStatement).HasMaxLength(255);

                entity.Property(e => e.CountOnCols).HasMaxLength(50);

                entity.Property(e => e.ExportTemplateFile).HasMaxLength(50);

                entity.Property(e => e.FieldsDefaultLoad).HasMaxLength(4000);

                entity.Property(e => e.FieldsStatement).HasMaxLength(4000);

                entity.Property(e => e.FilterCaption).HasMaxLength(255);

                entity.Property(e => e.ForeignKeyName).HasMaxLength(50);

                entity.Property(e => e.FormID).HasMaxLength(50);

                entity.Property(e => e.FuncDescription).HasMaxLength(150);

                entity.Property(e => e.FuncDescriptionReport).HasMaxLength(150);

                entity.Property(e => e.GroupOnCols).HasMaxLength(50);

                entity.Property(e => e.InwordTitle).HasMaxLength(50);

                entity.Property(e => e.JoinStatement).HasMaxLength(4000);

                entity.Property(e => e.LongDateFormat).HasMaxLength(50);

                entity.Property(e => e.Newable).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoOrderStatement).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderStatement).HasMaxLength(255);

                entity.Property(e => e.PrimaryKeyColIsNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrimaryKeyName).HasMaxLength(50);

                entity.Property(e => e.SearchCondition).HasMaxLength(255);

                entity.Property(e => e.ServiceList).HasMaxLength(255);

                entity.Property(e => e.SheetsCombined).HasMaxLength(500);

                entity.Property(e => e.ShortDateFormatCOLS).HasMaxLength(50);

                entity.Property(e => e.Sign1).HasMaxLength(50);

                entity.Property(e => e.Sign2).HasMaxLength(50);

                entity.Property(e => e.Sign3).HasMaxLength(50);

                entity.Property(e => e.SubofFuncID).HasMaxLength(50);

                entity.Property(e => e.SumOnCols).HasMaxLength(50);

                entity.Property(e => e.TotalCOLS).HasMaxLength(50);

                entity.Property(e => e.TotalCaption).HasMaxLength(50);

                entity.Property(e => e.TotalValueUnit).HasMaxLength(50);
            });

            modelBuilder.Entity<DataSourceSetupFieldDefine>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ColComboIsSQL).HasDefaultValueSql("((0))");

                entity.Property(e => e.ColComboItem).HasMaxLength(1000);

                entity.Property(e => e.ColSourceFieldName).HasMaxLength(50);

                entity.Property(e => e.ColSourceIDIsnumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.Editable).HasDefaultValueSql("((0))");

                entity.Property(e => e.FieldName).HasMaxLength(50);

                entity.Property(e => e.FuncID).HasMaxLength(50);

                entity.Property(e => e.IsAllpartners).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsAutorunID).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsContactList).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCurrentUsername).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDateCreate).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDateModify).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDatePicker).HasDefaultValueSql("((0))");

                entity.Property(e => e.PickCondition).HasMaxLength(255);

                entity.Property(e => e.PickItemfromDialog).HasDefaultValueSql("((0))");

                entity.Property(e => e.SourceTableName).HasMaxLength(50);
            });

            modelBuilder.Entity<DataSourceSetupSearch>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Datatype).HasMaxLength(50);

                entity.Property(e => e.DefaultValue).HasMaxLength(255);

                entity.Property(e => e.FieldName).HasMaxLength(50);

                entity.Property(e => e.FuncID).HasMaxLength(50);

                entity.Property(e => e.ItemSource).HasMaxLength(1000);

                entity.Property(e => e.NameDisplay).HasMaxLength(150);

                entity.Property(e => e.OperatorValue).HasMaxLength(50);

                entity.Property(e => e.PickCondition).HasMaxLength(255);
            });

            modelBuilder.Entity<DataSourceSetupSearchExecQuery>(entity =>
            {
                entity.HasKey(e => e.IDKey)
                    .HasName("PK_DataSourceSetup\r\nSearchExecQuery");

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ExecQuery).HasMaxLength(1000);

                entity.Property(e => e.FuncID).HasMaxLength(50);
            });

            modelBuilder.Entity<DataSourceSetupSubtotalSetting>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BackColor).HasMaxLength(50);

                entity.Property(e => e.CaptionStr).HasMaxLength(50);

                entity.Property(e => e.FontBold).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForeColor).HasMaxLength(50);

                entity.Property(e => e.FormatStr).HasMaxLength(50);

                entity.Property(e => e.FuncID).HasMaxLength(50);

                entity.Property(e => e.FunctionRef).HasComment("None=0, Clear=1, Sum=2, Percent=3, Count=4,Average-5, Max=6, Min=7, Std=8, Var=9");

                entity.Property(e => e.MatchFrom).HasMaxLength(50);

                entity.Property(e => e.TotalOnly).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DebitMemory>(entity =>
            {
                entity.HasKey(e => e.DebitID)
                    .HasName("aaaaaDebitMemory_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.DebitID, "ExpressDebitID")
                    .IsUnique();

                entity.Property(e => e.DebitID).HasMaxLength(50);

                entity.Property(e => e.CurrencyRate).HasMaxLength(255);

                entity.Property(e => e.DateUpto).HasColumnType("datetime");

                entity.Property(e => e.Descriptions).HasMaxLength(50);

                entity.Property(e => e.FormerlyBalance).HasDefaultValueSql("(0)");

                entity.Property(e => e.GrandTotal).HasDefaultValueSql("(0)");

                entity.Property(e => e.GrandTotalStr).HasMaxLength(255);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.SqlStatement).HasColumnType("ntext");

                entity.Property(e => e.TotalCredit).HasMaxLength(255);

                entity.Property(e => e.TotalCreditDue).HasMaxLength(255);

                entity.Property(e => e.TotalDebit).HasMaxLength(255);

                entity.Property(e => e.USDSayWord).HasMaxLength(255);

                entity.Property(e => e.VAT).HasDefaultValueSql("(0)");

                entity.Property(e => e.VatPer).HasMaxLength(50);
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.DeptID)
                    .HasName("aaaaaDepartments_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.CmpID, "CmpID");

                entity.HasIndex(e => e.DeptID, "DeptID");

                entity.HasIndex(e => e.MngCode, "MngCode");

                entity.HasIndex(e => e.CmpID, "YourCompanyDepartments");

                entity.Property(e => e.DeptID).HasMaxLength(50);

                entity.Property(e => e.AuthorizedBy).HasMaxLength(50);

                entity.Property(e => e.CmpID).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.DeputyUsers).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.DptBonus).HasDefaultValueSql("(0)");

                entity.Property(e => e.DptSalesTarget).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExtNo).HasMaxLength(50);

                entity.Property(e => e.ManagerContact).HasMaxLength(150);

                entity.Property(e => e.MngCode).HasDefaultValueSql("(0)");

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.Property(e => e.pushNotificationCTApp).HasMaxLength(50);

                entity.Property(e => e.pushNotificationCType).HasMaxLength(50);

                entity.Property(e => e.pushNotificationKey).HasMaxLength(255);

                entity.Property(e => e.pushNotificationSCTAU).HasMaxLength(50);

                entity.Property(e => e.pushNotificationURL).HasMaxLength(255);

                entity.HasOne(d => d.Cmp)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.CmpID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Departments_FK00");
            });

            modelBuilder.Entity<DisplayConfigInformation>(entity =>
            {
                entity.HasKey(e => e.ConfigID)
                    .HasName("aaaaaDisplayConfigInformation_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ConfigID, "ConfigID");

                entity.HasIndex(e => e.MaskEdBoxFormat, "VSFlexGrid");

                entity.Property(e => e.ConfigID).HasMaxLength(50);

                entity.Property(e => e.DTPCalendarBackColor).HasMaxLength(50);

                entity.Property(e => e.DTPCalendarForeColor).HasMaxLength(50);

                entity.Property(e => e.DTPCalendarTitleBackColor).HasMaxLength(50);

                entity.Property(e => e.DTPCalendarTitleForeColor).HasMaxLength(50);

                entity.Property(e => e.FrameBackcolor).HasMaxLength(50);

                entity.Property(e => e.LBLFont).HasMaxLength(50);

                entity.Property(e => e.LBLForeColor).HasMaxLength(50);

                entity.Property(e => e.MaskEdBoxDefault).HasMaxLength(50);

                entity.Property(e => e.MaskEdBoxFormat).HasMaxLength(50);

                entity.Property(e => e.TextBoxBackColor).HasMaxLength(50);

                entity.Property(e => e.TextBoxFontName).HasMaxLength(50);

                entity.Property(e => e.TextBoxForeColor).HasMaxLength(50);

                entity.Property(e => e.VSFlexGridAppearance).HasMaxLength(50);

                entity.Property(e => e.VSFlexGridBackColorBkg).HasMaxLength(50);

                entity.Property(e => e.VSFlexGridBackColorSel).HasMaxLength(50);

                entity.Property(e => e.VSFlexGridForeColorSel).HasMaxLength(50);

                entity.Property(e => e.VSFlexGridSheetBorder).HasMaxLength(50);

                entity.Property(e => e.cmbListRowsCount).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<ECUSConnection>(entity =>
            {
                entity.HasKey(e => e.IDKey)
                    .HasName("PK_ECUSConnrction");

                entity.Property(e => e.ActivateDB).HasDefaultValueSql("((0))");

                entity.Property(e => e.CategoryID).HasMaxLength(50);

                entity.Property(e => e.DBName).HasMaxLength(50);

                entity.Property(e => e.DBPassword).HasMaxLength(50);

                entity.Property(e => e.DBUsername).HasMaxLength(50);

                entity.Property(e => e.DateApply).HasColumnType("datetime");

                entity.Property(e => e.ServerName).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ECUSConnection)
                    .HasForeignKey(d => d.CategoryID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ECUSConnection_EcusCategory");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.ECUSConnection)
                    .HasPrincipalKey(p => p.Username)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ECUSConnection_ContactsList");
            });

            modelBuilder.Entity<ECusCucHQ>(entity =>
            {
                entity.HasKey(e => e.MaCuc);

                entity.Property(e => e.MaCuc).HasMaxLength(50);

                entity.Property(e => e.PhanLoai).HasMaxLength(50);

                entity.Property(e => e.TenCuc).HasMaxLength(150);
            });

            modelBuilder.Entity<EDIStructure>(entity =>
            {
                entity.HasKey(e => e.EDIID);

                entity.Property(e => e.EDIID).HasMaxLength(50);

                entity.Property(e => e.AMS).HasDefaultValueSql("((0))");

                entity.Property(e => e.AgentID).HasMaxLength(50);

                entity.Property(e => e.Deactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.EDIName).HasMaxLength(255);

                entity.Property(e => e.FileExt).HasMaxLength(255);

                entity.Property(e => e.FormName).HasMaxLength(50);

                entity.Property(e => e.FtpType).HasMaxLength(50);

                entity.Property(e => e.NoAddIfFieldsEmpty).HasDefaultValueSql("((0))");

                entity.Property(e => e.PwdWS).HasMaxLength(50);

                entity.Property(e => e.ReceiverID).HasMaxLength(50);

                entity.Property(e => e.SOAActionURLWS).HasMaxLength(150);

                entity.Property(e => e.SenderID).HasMaxLength(50);

                entity.Property(e => e.Sendftp).HasDefaultValueSql("((0))");

                entity.Property(e => e.SqlStatement).HasMaxLength(4000);

                entity.Property(e => e.URLWS).HasMaxLength(150);

                entity.Property(e => e.UsernameWS).HasMaxLength(50);

                entity.Property(e => e.sVersion).HasMaxLength(255);

                entity.Property(e => e.sqlARG).HasMaxLength(1000);
            });

            modelBuilder.Entity<EDIStructureCharReplace>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Deactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.EDIID).HasMaxLength(50);

                entity.Property(e => e.OriginalChar).HasMaxLength(50);

                entity.Property(e => e.ReplaceChar).HasMaxLength(50);
            });

            modelBuilder.Entity<EDIStructureDT>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.DeactiveRCD).HasDefaultValueSql("((0))");

                entity.Property(e => e.EDIID).HasMaxLength(50);

                entity.Property(e => e.ExtraFieldNameCond).HasMaxLength(50);

                entity.Property(e => e.ExtraNodeName).HasMaxLength(50);

                entity.Property(e => e.ExtraPRNodeSelName).HasMaxLength(50);

                entity.Property(e => e.ExtraSubFieldCond).HasMaxLength(255);

                entity.Property(e => e.ExtraSubSqlStatement).HasColumnType("ntext");

                entity.Property(e => e.FieldNameCond).HasMaxLength(50);

                entity.Property(e => e.InitialNode).HasDefaultValueSql("((0))");

                entity.Property(e => e.MTLoop).HasDefaultValueSql("((0))");

                entity.Property(e => e.NodeKey).HasMaxLength(50);

                entity.Property(e => e.NodeName).HasMaxLength(255);

                entity.Property(e => e.OrderExtraSubSqlStatement).HasMaxLength(255);

                entity.Property(e => e.OrderSubSqlStatement).HasMaxLength(255);

                entity.Property(e => e.PNodeName).HasMaxLength(50);

                entity.Property(e => e.PNodeSel).HasMaxLength(50);

                entity.Property(e => e.PRNode).HasDefaultValueSql("((0))");

                entity.Property(e => e.PRNodeSelName).HasMaxLength(255);

                entity.Property(e => e.SubFieldCond).HasMaxLength(255);

                entity.Property(e => e.SubSqlStatement).HasColumnType("ntext");

                entity.Property(e => e.TableFieldName).HasMaxLength(50);

                entity.HasOne(d => d.EDI)
                    .WithMany(p => p.EDIStructureDT)
                    .HasForeignKey(d => d.EDIID)
                    .HasConstraintName("FK_EDIStructureDT_EDIStructure");
            });

            modelBuilder.Entity<EDIStructureDTSub>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.AFieldName).HasMaxLength(50);

                entity.Property(e => e.EDIID).HasMaxLength(50);

                entity.Property(e => e.FieldCond).HasMaxLength(50);

                entity.Property(e => e.FieldName).HasMaxLength(50);

                entity.Property(e => e.FieldValue).HasMaxLength(50);

                entity.Property(e => e.Fieldssql).HasMaxLength(1000);

                entity.Property(e => e.HaveSubsql).HasMaxLength(1000);

                entity.Property(e => e.IsSequence).HasDefaultValueSql("((0))");

                entity.Property(e => e.RCDLoop).HasDefaultValueSql("((0))");

                entity.Property(e => e.SequenceCharEachLine).HasMaxLength(50);

                entity.Property(e => e.SequenceFieldDescriptionName).HasMaxLength(50);

                entity.Property(e => e.SequenceFieldNumberName).HasMaxLength(50);

                entity.Property(e => e.SubFieldCond).HasMaxLength(50);

                entity.Property(e => e.SubFieldValue).HasMaxLength(50);
            });

            modelBuilder.Entity<EDOSetting>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.APIHeader).HasMaxLength(255);

                entity.Property(e => e.APIManagerApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.APIURL).HasMaxLength(150);

                entity.Property(e => e.CDSOffice).HasMaxLength(255);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.LCPassword).HasMaxLength(50);

                entity.Property(e => e.Taxcode).HasMaxLength(50);
            });

            modelBuilder.Entity<EDOSettingStatus>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.StatusCode).HasMaxLength(50);

                entity.Property(e => e.StatusDescription).HasMaxLength(255);

                entity.Property(e => e.StatusType).HasMaxLength(50);
            });

            modelBuilder.Entity<EcusCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryID);

                entity.Property(e => e.CategoryID).HasMaxLength(50);

                entity.Property(e => e.CategoryName).HasMaxLength(150);

                entity.Property(e => e.Notes).HasMaxLength(150);
            });

            modelBuilder.Entity<EcusCuakhau>(entity =>
            {
                entity.HasKey(e => e.Ma_CK);

                entity.Property(e => e.Ma_CK).HasMaxLength(50);

                entity.Property(e => e.HienThi).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ma_Cuc).HasMaxLength(50);

                entity.Property(e => e.Ten_CK).HasMaxLength(150);

                entity.HasOne(d => d.Ma_CucNavigation)
                    .WithMany(p => p.EcusCuakhau)
                    .HasForeignKey(d => d.Ma_Cuc)
                    .HasConstraintName("FK_EcusCuakhau_ECusCucHQ");
            });

            modelBuilder.Entity<EcusJobApply>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BookingNo).HasMaxLength(50);

                entity.Property(e => e.DBName).HasMaxLength(50);

                entity.Property(e => e.DToKhaiMDID).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NgayApply).HasColumnType("datetime");

                entity.Property(e => e.PCApply).HasMaxLength(50);

                entity.Property(e => e.ServerName).HasMaxLength(50);

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.UserApply).HasMaxLength(50);

                entity.Property(e => e.VoidTransID).HasMaxLength(50);

                entity.HasOne(d => d.Trans)
                    .WithMany(p => p.EcusJobApply)
                    .HasForeignKey(d => d.TransID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EcusJobApply_Transactions");
            });

            modelBuilder.Entity<ExcelReportConfig>(entity =>
            {
                entity.HasKey(e => e.ReportID);

                entity.Property(e => e.ReportID).HasMaxLength(50);

                entity.Property(e => e.EnableProgressBar).HasDefaultValueSql("((0))");

                entity.Property(e => e.FieldCondName).HasMaxLength(50);

                entity.Property(e => e.FileTemplate).HasMaxLength(50);

                entity.Property(e => e.FormID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SQLSource).HasMaxLength(4000);
            });

            modelBuilder.Entity<ExcelReportConfigDetails>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ExportFieldName).HasMaxLength(50);

                entity.Property(e => e.FieldNameValue).HasMaxLength(50);

                entity.Property(e => e.InsertRow).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportID).HasMaxLength(50);

                entity.Property(e => e.SubFieldCondName).HasMaxLength(50);

                entity.Property(e => e.SubSQLSource).HasMaxLength(4000);

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ExcelReportConfigDetails)
                    .HasForeignKey(d => d.ReportID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ExcelReportConfigDetails_ExcelReportConfig");
            });

            modelBuilder.Entity<ExchangeRate>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("aaaaaExchangeRate_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ID, "ID");

                entity.HasIndex(e => e.Unit, "Unit")
                    .IsUnique();

                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.DeptExUSD).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExchangeRate1)
                    .HasColumnName("ExchangeRate")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ExtVND).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExtVNDSales).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExtVNDSalesKB).HasDefaultValueSql("(0)");

                entity.Property(e => e.KBExchangeRate).HasDefaultValueSql("(0)");

                entity.Property(e => e.LocalName).HasMaxLength(150);

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UnitName).HasMaxLength(150);
            });

            modelBuilder.Entity<ExpressZonePrice>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("aaaaaExpressZonePrice_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.DeptID, "DeptID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.AirlineID).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeptID).HasMaxLength(50);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.Weight).HasMaxLength(50);

                entity.Property(e => e.ZoneA).HasDefaultValueSql("(0)");

                entity.Property(e => e.ZoneB).HasDefaultValueSql("(0)");

                entity.Property(e => e.ZoneC).HasDefaultValueSql("(0)");

                entity.Property(e => e.ZoneD).HasDefaultValueSql("(0)");

                entity.Property(e => e.ZoneE).HasDefaultValueSql("(0)");

                entity.Property(e => e.ZoneF).HasDefaultValueSql("(0)");

                entity.Property(e => e.ZoneG).HasDefaultValueSql("(0)");

                entity.Property(e => e.ZoneH).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<ExpressZonePriceColoaders>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("aaaaaExpressZonePriceColoaders_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.DeptID, "DeptID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.ACChargesList).HasMaxLength(255);

                entity.Property(e => e.AMTCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.AirlineID).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeptID).HasMaxLength(50);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.Weight).HasMaxLength(50);

                entity.Property(e => e.ZoneA).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneB).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneC).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneD).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneE).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneF).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneG).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneH).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<FTPConfig>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.BundleCode).HasMaxLength(255);

                entity.Property(e => e.FTPPassword).HasMaxLength(255);

                entity.Property(e => e.FTPPort).HasMaxLength(255);

                entity.Property(e => e.FTPSource).HasMaxLength(255);

                entity.Property(e => e.FTPURL).HasMaxLength(255);

                entity.Property(e => e.FTPUserName).HasMaxLength(255);

                entity.Property(e => e.FolderResult).HasMaxLength(255);

                entity.Property(e => e.FolderUpload).HasMaxLength(255);

                entity.Property(e => e.FtpUploadOthersDir).HasMaxLength(50);

                entity.Property(e => e.PrivateKeyContent).HasColumnType("ntext");
            });

            modelBuilder.Entity<FTPProcess>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BundleCode).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FTPCheckStatusDir).HasMaxLength(50);

                entity.Property(e => e.FTPDir).HasMaxLength(50);

                entity.Property(e => e.FTPPwd).HasMaxLength(50);

                entity.Property(e => e.FTPSent).HasDefaultValueSql("((0))");

                entity.Property(e => e.FTPSentDate).HasColumnType("datetime");

                entity.Property(e => e.FTPSource).HasMaxLength(50);

                entity.Property(e => e.FTPStatus).HasMaxLength(50);

                entity.Property(e => e.FTPURL).HasMaxLength(150);

                entity.Property(e => e.FTPUserName).HasMaxLength(50);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.FtpUploadOthersDir).HasMaxLength(50);

                entity.Property(e => e.PCName).HasMaxLength(50);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.UserSent).HasMaxLength(50);
            });

            modelBuilder.Entity<FTPSourceConfig>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.FTPSource).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);
            });

            modelBuilder.Entity<FormBillList>(entity =>
            {
                entity.HasKey(e => e.IDKey)
                    .HasName("IDKey");

                entity.Property(e => e.APIHeader).HasMaxLength(255);

                entity.Property(e => e.APIManagerApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.APIURL).HasMaxLength(150);

                entity.Property(e => e.AttachedFilesFilterFieldHBLID).HasMaxLength(50);

                entity.Property(e => e.AttachedFilesFilterFieldPartnerID).HasMaxLength(50);

                entity.Property(e => e.Charset).HasMaxLength(50);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.ContainerName).HasMaxLength(50);

                entity.Property(e => e.CurrDF).HasMaxLength(50);

                entity.Property(e => e.DisplayName).HasMaxLength(50);

                entity.Property(e => e.DrawLine).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailBody).HasMaxLength(1000);

                entity.Property(e => e.EmailFooter).HasMaxLength(255);

                entity.Property(e => e.EmailHeader).HasMaxLength(255);

                entity.Property(e => e.EmailSubject).HasMaxLength(255);

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HeaderCOLW).HasMaxLength(1000);

                entity.Property(e => e.HeaderCaption).HasMaxLength(1000);

                entity.Property(e => e.KeepTemplateFooter).HasDefaultValueSql("((0))");

                entity.Property(e => e.OriginalForm).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartnerSQL).HasMaxLength(1000);

                entity.Property(e => e.ReportSubTitle).HasMaxLength(150);

                entity.Property(e => e.ReportTitle).HasMaxLength(150);

                entity.Property(e => e.SQLStatement).HasColumnType("ntext");

                entity.Property(e => e.TemplateFile).HasMaxLength(50);

                entity.Property(e => e.UsingMSOutlook).HasDefaultValueSql("((0))");

                entity.Property(e => e.tIndex).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<FormControlList>(entity =>
            {
                entity.HasKey(e => new { e.FormID, e.ControlID, e.ControlIndex })
                    .HasName("aaaaaFormControlList_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ControlID, "ControlID");

                entity.HasIndex(e => e.FormID, "FormID");

                entity.HasIndex(e => e.FormID, "FormListFormControlList");

                entity.Property(e => e.FormID).HasMaxLength(50);

                entity.Property(e => e.ControlID).HasMaxLength(50);

                entity.Property(e => e.ControlCaption).HasColumnType("ntext");

                entity.Property(e => e.ControlCaptionSND).HasMaxLength(4000);

                entity.Property(e => e.ControlType).HasMaxLength(50);

                entity.Property(e => e.DefaultValue).HasMaxLength(255);

                entity.Property(e => e.ExpressKeywords).HasMaxLength(1000);

                entity.Property(e => e.InredColor).HasDefaultValueSql("((0))");

                entity.Property(e => e.SelectOnly).HasDefaultValueSql("((0))");

                entity.Property(e => e.ToolTipText).HasMaxLength(150);

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.FormControlList)
                    .HasForeignKey(d => d.FormID)
                    .HasConstraintName("FormControlList_FK00");
            });

            modelBuilder.Entity<FormControlListDT>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ControlCaption).HasColumnType("ntext");

                entity.Property(e => e.ControlCaptionSND).HasMaxLength(4000);

                entity.Property(e => e.ControlID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ControlType).HasMaxLength(50);

                entity.Property(e => e.DefaultValue).HasMaxLength(255);

                entity.Property(e => e.ExpressKeywords).HasMaxLength(1000);

                entity.Property(e => e.FormID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InredColor).HasDefaultValueSql("((0))");

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<FormList>(entity =>
            {
                entity.HasKey(e => e.FormID)
                    .HasName("aaaaaFormList_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.FormID, "FormID");

                entity.Property(e => e.FormID).HasMaxLength(50);

                entity.Property(e => e.URLAddress).HasMaxLength(255);

                entity.Property(e => e.frmCaption).HasMaxLength(255);

                entity.Property(e => e.frmCaptionSND).HasMaxLength(255);
            });

            modelBuilder.Entity<FtpAttFileType>(entity =>
            {
                entity.HasKey(e => e.FileType);

                entity.Property(e => e.FileType).HasMaxLength(50);

                entity.Property(e => e.FileDesc).HasMaxLength(150);
            });

            modelBuilder.Entity<FtpFilesAttUpload>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.FileDescription).HasMaxLength(150);

                entity.Property(e => e.FileExt).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.FileSource).HasMaxLength(255);

                entity.Property(e => e.FileType).HasMaxLength(50);

                entity.Property(e => e.IDLinked).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UploadDir).HasMaxLength(50);

                entity.Property(e => e.XMLFileName).HasMaxLength(50);
            });

            modelBuilder.Entity<FunctionList>(entity =>
            {
                entity.HasKey(e => new { e.FunctId, e.FormID })
                    .HasName("aaaaaFunctionList_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.FunctId, "FunctId");

                entity.Property(e => e.FunctId).HasMaxLength(150);

                entity.Property(e => e.FormID).HasMaxLength(100);

                entity.Property(e => e.ChildFuncID).HasMaxLength(50);

                entity.Property(e => e.ColsWidth).HasMaxLength(1000);

                entity.Property(e => e.CondF).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DescriptionEN).HasMaxLength(255);

                entity.Property(e => e.DisableUserList).HasMaxLength(400);

                entity.Property(e => e.Display).HasMaxLength(150);

                entity.Property(e => e.DisplayVN).HasMaxLength(150);

                entity.Property(e => e.FieldsListID).HasMaxLength(50);

                entity.Property(e => e.FieldsOrder).HasMaxLength(255);

                entity.Property(e => e.GroupName).HasMaxLength(150);

                entity.Property(e => e.HeaderCaptionEN).HasMaxLength(255);

                entity.Property(e => e.HeaderCaptionVN).HasMaxLength(255);

                entity.Property(e => e.LoggedID).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.OriginalCurr).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartnerSQL).HasMaxLength(1000);

                entity.Property(e => e.ReportName).HasMaxLength(150);

                entity.Property(e => e.Sign1).HasMaxLength(50);

                entity.Property(e => e.Sign2).HasMaxLength(50);

                entity.Property(e => e.Sign3).HasMaxLength(50);

                entity.Property(e => e.UserUpdate).HasMaxLength(50);

                entity.Property(e => e.iIndex).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<FunctionListCompactToGrid>(entity =>
            {
                entity.HasKey(e => e.IDKey)
                    .HasName("PK_FunctionListCompact");

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ColDataFormat).HasMaxLength(50);

                entity.Property(e => e.ColIndex).HasMaxLength(50);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.DisplayName).HasMaxLength(150);

                entity.Property(e => e.FieldsListID).HasMaxLength(50);

                entity.Property(e => e.GroupCol1Total).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupCol2Total).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupCol3Total).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoIndex).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintTotal).HasDefaultValueSql("((0))");

                entity.Property(e => e.RunningTotal).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<FunctionListFieldCompact>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.HasIndex(e => e.FormID, "FormID");

                entity.HasIndex(e => e.FunctId, "FunctId");

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.FieldReplace).HasMaxLength(1000);

                entity.Property(e => e.FieldStatement).HasMaxLength(1000);

                entity.Property(e => e.FormID).HasMaxLength(50);

                entity.Property(e => e.FunctId).HasMaxLength(50);

                entity.Property(e => e.sqlStatement).HasColumnType("ntext");
            });

            modelBuilder.Entity<FunctionListFieldConditions>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ConditionField).HasMaxLength(255);

                entity.Property(e => e.DebtField).HasDefaultValueSql("((0))");

                entity.Property(e => e.FilterConditionName).HasMaxLength(50);

                entity.Property(e => e.FunctId).HasMaxLength(150);

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<GAGENT>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ACCGAGENT)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ADDRGAGENT)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AREACODE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AREACODEFAX)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CITY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLOSEDATE).HasColumnType("datetime");

                entity.Property(e => e.COUNTRYCODE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRYCODEFAX)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRYID)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DATEUPDATE).HasColumnType("smalldatetime");

                entity.Property(e => e.DEPT)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EMAILGAGENT)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FAXGAGENT)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GAGENT1)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GAGENT");

                entity.Property(e => e.GAGENTID)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LASTDATEUPDATE).HasColumnType("smalldatetime");

                entity.Property(e => e.LASTUSERUPDATE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NOTE)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PICGAGENT)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PORT)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.STATE)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TELGAGENT)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.USERUPDATE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WEBSITE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WPASSWORD)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WUSERNAME)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZIPCODEGAGENT)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GroupList>(entity =>
            {
                entity.HasKey(e => e.GroupID);

                entity.Property(e => e.GroupID).HasMaxLength(50);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.ContactMngID).HasMaxLength(50);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.GroupName).HasMaxLength(255);

                entity.Property(e => e.LeaderUser).HasMaxLength(50);

                entity.Property(e => e.Modified).HasColumnType("datetime");
            });

            modelBuilder.Entity<HAWB>(entity =>
            {
                entity.HasKey(e => e.HWBNO)
                    .HasName("aaaaaHAWB_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.AgentIATACode, "AgentIATACode");

                entity.HasIndex(e => e.AltHBLNo, "AltHBLNo_HAWB");

                entity.HasIndex(e => e.CHGSCode, "CHGSCode");

                entity.HasIndex(e => e.ConsigneeID, "ConsigneeID");

                entity.HasIndex(e => e.DestinationCode, "DestinationCode");

                entity.HasIndex(e => e.OriginCode, "OriginCode");

                entity.HasIndex(e => e.QuoID, "QuoID");

                entity.HasIndex(e => e.ReceivedZipCode, "ReceivedZipCode");

                entity.HasIndex(e => e.SenderZipCode, "SenderZipCode");

                entity.HasIndex(e => e.TRANSID, "TRANSID");

                entity.Property(e => e.HWBNO).HasMaxLength(50);

                entity.Property(e => e.ANChargesSyn).HasDefaultValueSql("((0))");

                entity.Property(e => e.ATA).HasColumnType("datetime");

                entity.Property(e => e.ATAAtDeliveryPlace).HasColumnType("datetime");

                entity.Property(e => e.ATAAtDestinationPlace).HasColumnType("datetime");

                entity.Property(e => e.ATAAtReceiptPlace).HasColumnType("datetime");

                entity.Property(e => e.ATDAtDeliveryPlace).HasColumnType("datetime");

                entity.Property(e => e.ATDAtDestinationPlace).HasColumnType("datetime");

                entity.Property(e => e.ATDAtReceiptPlace).HasColumnType("datetime");

                entity.Property(e => e.ATTN).HasMaxLength(255);

                entity.Property(e => e.AWBNO).HasMaxLength(50);

                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.AccountingInfo).HasMaxLength(250);

                entity.Property(e => e.AgentIATACode).HasMaxLength(50);

                entity.Property(e => e.AltHBLNo).HasMaxLength(50);

                entity.Property(e => e.ArrivalFooterNotice).HasColumnType("ntext");

                entity.Property(e => e.ArrivalNo).HasMaxLength(50);

                entity.Property(e => e.BKReason).HasMaxLength(150);

                entity.Property(e => e.BKStatus).HasMaxLength(50);

                entity.Property(e => e.BillRecipient).HasMaxLength(50);

                entity.Property(e => e.BillRecipientTax).HasMaxLength(50);

                entity.Property(e => e.BillSender).HasMaxLength(50);

                entity.Property(e => e.BillSenderTax).HasMaxLength(50);

                entity.Property(e => e.Buyer).HasMaxLength(255);

                entity.Property(e => e.BuyerID).HasMaxLength(50);

                entity.Property(e => e.CCChgDes).HasMaxLength(50);

                entity.Property(e => e.CHGSCode).HasMaxLength(50);

                entity.Property(e => e.CargoReceipt).HasDefaultValueSql("((0))");

                entity.Property(e => e.CargoReceiptRefNo).HasMaxLength(50);

                entity.Property(e => e.ChargeableWeight).HasDefaultValueSql("(0)");

                entity.Property(e => e.CleanOnBoard).HasMaxLength(255);

                entity.Property(e => e.ClosingDate).HasColumnType("datetime");

                entity.Property(e => e.Commodities).HasMaxLength(255);

                entity.Property(e => e.Commodity).HasMaxLength(255);

                entity.Property(e => e.Consignee).HasMaxLength(250);

                entity.Property(e => e.ConsigneeID).HasMaxLength(50);

                entity.Property(e => e.Consolidator).HasMaxLength(255);

                entity.Property(e => e.ContSealNo).HasMaxLength(255);

                entity.Property(e => e.ContainerStuffingLocation).HasMaxLength(255);

                entity.Property(e => e.CountryOfOriginCommodity).HasMaxLength(25);

                entity.Property(e => e.CurConvRate).HasMaxLength(50);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.CussignedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerID).HasMaxLength(50);

                entity.Property(e => e.DGCond).HasMaxLength(50);

                entity.Property(e => e.DONo).HasMaxLength(50);

                entity.Property(e => e.DateConfirm)
                    .HasColumnType("datetime")
                    .HasComment("Booking Confirm");

                entity.Property(e => e.DatePackage).HasColumnType("datetime");

                entity.Property(e => e.DeliveryOrderNote).HasColumnType("ntext");

                entity.Property(e => e.DeliveryStatus).HasMaxLength(50);

                entity.Property(e => e.DeliveryTransportTypeNo).HasMaxLength(50);

                entity.Property(e => e.DepartureAirport).HasMaxLength(150);

                entity.Property(e => e.DepartureAirportCode).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.DestCharge).HasMaxLength(50);

                entity.Property(e => e.DestinationCode).HasMaxLength(50);

                entity.Property(e => e.DestinationStatus).HasMaxLength(50);

                entity.Property(e => e.DestinationTransportTypeNo).HasMaxLength(50);

                entity.Property(e => e.Dimension).HasDefaultValueSql("(0)");

                entity.Property(e => e.DlvCarriage).HasMaxLength(255);

                entity.Property(e => e.DlvCustoms).HasMaxLength(255);

                entity.Property(e => e.DocPrinted).HasColumnType("datetime");

                entity.Property(e => e.DocumentReleaseBy).HasMaxLength(50);

                entity.Property(e => e.DocumentReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentReleaseUpdate).HasColumnType("datetime");

                entity.Property(e => e.Drawee).HasMaxLength(150);

                entity.Property(e => e.EDOApprovedBy).HasMaxLength(50);

                entity.Property(e => e.EDOApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.EDODateRead).HasColumnType("datetime");

                entity.Property(e => e.EDODateSent).HasColumnType("datetime");

                entity.Property(e => e.EDODeclineDate).HasColumnType("datetime");

                entity.Property(e => e.EDOErrorMessage).HasMaxLength(300);

                entity.Property(e => e.EDOID).HasMaxLength(50);

                entity.Property(e => e.EDOReady).HasDefaultValueSql("((0))");

                entity.Property(e => e.EDORecallReason).HasMaxLength(300);

                entity.Property(e => e.EDOUserSent).HasMaxLength(50);

                entity.Property(e => e.ETAAtDeliveryPlace).HasColumnType("datetime");

                entity.Property(e => e.ETAAtDestinationPlace).HasColumnType("datetime");

                entity.Property(e => e.ETAAtReceiptPlace).HasColumnType("datetime");

                entity.Property(e => e.ETDAtDeliveryPlace).HasColumnType("datetime");

                entity.Property(e => e.ETDAtDestinationPlace).HasColumnType("datetime");

                entity.Property(e => e.ETDAtReceiptPlace).HasColumnType("datetime");

                entity.Property(e => e.EXPIRY_TS).HasColumnType("datetime");

                entity.Property(e => e.EmpPhotoSize).HasMaxLength(255);

                entity.Property(e => e.EsVessel).HasMaxLength(100);

                entity.Property(e => e.EsVoyage).HasMaxLength(50);

                entity.Property(e => e.ExHDate)
                    .HasColumnType("datetime")
                    .HasComment("Express");

                entity.Property(e => e.ExecutedAt).HasMaxLength(50);

                entity.Property(e => e.ExecutedOn).HasMaxLength(50);

                entity.Property(e => e.FirstCarrier).HasMaxLength(50);

                entity.Property(e => e.FirstDestination).HasMaxLength(255);

                entity.Property(e => e.FlightDate).HasColumnType("datetime");

                entity.Property(e => e.FlightNo).HasMaxLength(50);

                entity.Property(e => e.FlightSchedule).HasColumnType("datetime");

                entity.Property(e => e.ForCarrier).HasMaxLength(255);

                entity.Property(e => e.FreightNotes).HasMaxLength(150);

                entity.Property(e => e.FreightPayAt).HasMaxLength(150);

                entity.Property(e => e.FromSea).HasMaxLength(50);

                entity.Property(e => e.FromSeaCode).HasMaxLength(50);

                entity.Property(e => e.GoodsDelivery).HasMaxLength(255);

                entity.Property(e => e.GrossWeight).HasDefaultValueSql("(0)");

                entity.Property(e => e.HBAgentID).HasMaxLength(50);

                entity.Property(e => e.HBAlsoNotifyID).HasMaxLength(50);

                entity.Property(e => e.HBNotifyID).HasMaxLength(50);

                entity.Property(e => e.HBShipperID).HasMaxLength(50);

                entity.Property(e => e.HSCode).HasMaxLength(50);

                entity.Property(e => e.HTSCode).HasMaxLength(50);

                entity.Property(e => e.HandlingInfo).HasMaxLength(250);

                entity.Property(e => e.ICASNC)
                    .HasMaxLength(250)
                    .HasComment("Issuing Carrier's Agent and City");

                entity.Property(e => e.ISSUED).HasMaxLength(255);

                entity.Property(e => e.Importer).HasMaxLength(255);

                entity.Property(e => e.ImporterID).HasMaxLength(50);

                entity.Property(e => e.InsurCarrier).HasMaxLength(50);

                entity.Property(e => e.InsurCover).HasMaxLength(50);

                entity.Property(e => e.InsurInvoice).HasMaxLength(50);

                entity.Property(e => e.InsurOREF).HasMaxLength(50);

                entity.Property(e => e.InsurOurRef).HasMaxLength(50);

                entity.Property(e => e.InsurPremium).HasMaxLength(50);

                entity.Property(e => e.InsurRegDate).HasColumnType("datetime");

                entity.Property(e => e.InsurRemark).HasColumnType("ntext");

                entity.Property(e => e.InsurSumInsured).HasMaxLength(50);

                entity.Property(e => e.InsurTerm).HasMaxLength(50);

                entity.Property(e => e.InsurYourRef).HasMaxLength(50);

                entity.Property(e => e.Insurance).HasMaxLength(50);

                entity.Property(e => e.Insured).HasMaxLength(50);

                entity.Property(e => e.InvoicePKNo).HasMaxLength(50);

                entity.Property(e => e.IssuingBank).HasMaxLength(150);

                entity.Property(e => e.KBEvidence).HasMaxLength(255);

                entity.Property(e => e.LCBILL).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastDestination).HasMaxLength(50);

                entity.Property(e => e.LoadingDate).HasColumnType("datetime");

                entity.Property(e => e.LocalVessel).HasMaxLength(150);

                entity.Property(e => e.MNFSubmitDeadline).HasColumnType("datetime");

                entity.Property(e => e.MOD_TRANS_CALLSIGN).HasMaxLength(50);

                entity.Property(e => e.MSG_FUNC)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.ManufacturerID).HasMaxLength(50);

                entity.Property(e => e.ModeMain).HasMaxLength(50);

                entity.Property(e => e.ModeOnCarriage).HasMaxLength(50);

                entity.Property(e => e.ModeReceipt).HasMaxLength(50);

                entity.Property(e => e.Movement).HasMaxLength(50);

                entity.Property(e => e.NoofOriginBL).HasMaxLength(50);

                entity.Property(e => e.Notify).HasMaxLength(255);

                entity.Property(e => e.OSI)
                    .HasColumnType("ntext")
                    .HasComment("Optional Shipping Information");

                entity.Property(e => e.OceanVessel).HasMaxLength(150);

                entity.Property(e => e.OrChrVal).HasMaxLength(255);

                entity.Property(e => e.OrChrW).HasMaxLength(255);

                entity.Property(e => e.OriginCode).HasMaxLength(50);

                entity.Property(e => e.OriginalBLPrintedDate).HasColumnType("datetime");

                entity.Property(e => e.OriginalBLPrintedLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Owner).HasMaxLength(50);

                entity.Property(e => e.PLACE_OF_MT_RETURN).HasMaxLength(150);

                entity.Property(e => e.PODate).HasColumnType("datetime");

                entity.Property(e => e.PONo).HasMaxLength(50);

                entity.Property(e => e.Packages).HasDefaultValueSql("(0)");

                entity.Property(e => e.PaidInvoiceNo).HasMaxLength(150);

                entity.Property(e => e.Pieces).HasDefaultValueSql("(0)");

                entity.Property(e => e.PlaceAtReceipt).HasMaxLength(150);

                entity.Property(e => e.PlaceAtReceiptCode).HasMaxLength(50);

                entity.Property(e => e.PlaceDelivery).HasMaxLength(150);

                entity.Property(e => e.PlaceDeliveryCode).HasMaxLength(50);

                entity.Property(e => e.PortofDischarge).HasMaxLength(50);

                entity.Property(e => e.PortofDischargeCode).HasMaxLength(50);

                entity.Property(e => e.QuoID).HasMaxLength(255);

                entity.Property(e => e.RELEASE_NO).HasMaxLength(50);

                entity.Property(e => e.RateConfirm).HasMaxLength(50);

                entity.Property(e => e.ReceiptStatus).HasMaxLength(50);

                entity.Property(e => e.ReceiptTransportTypeNo).HasMaxLength(50);

                entity.Property(e => e.ReceivedAddress).HasMaxLength(255);

                entity.Property(e => e.ReceivedCity).HasMaxLength(50);

                entity.Property(e => e.ReceivedContactName).HasMaxLength(50);

                entity.Property(e => e.ReceivedCountry).HasMaxLength(50);

                entity.Property(e => e.ReceivedName).HasMaxLength(150);

                entity.Property(e => e.ReceivedProvince).HasMaxLength(50);

                entity.Property(e => e.ReceivedTelNo).HasMaxLength(50);

                entity.Property(e => e.ReceivedZipCode).HasMaxLength(50);

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.ReferrenceNo).HasMaxLength(50);

                entity.Property(e => e.SCI).HasMaxLength(50);

                entity.Property(e => e.SContractNo).HasMaxLength(50);

                entity.Property(e => e.SECURE_CODE).HasMaxLength(50);

                entity.Property(e => e.SayWord).HasMaxLength(255);

                entity.Property(e => e.SayWordPkg).HasMaxLength(150);

                entity.Property(e => e.SecondCarrier).HasMaxLength(50);

                entity.Property(e => e.SecondDestination).HasMaxLength(255);

                entity.Property(e => e.Seller).HasMaxLength(255);

                entity.Property(e => e.SenderAddress).HasMaxLength(255);

                entity.Property(e => e.SenderCity).HasMaxLength(50);

                entity.Property(e => e.SenderContactName).HasMaxLength(150);

                entity.Property(e => e.SenderCountry).HasMaxLength(50);

                entity.Property(e => e.SenderName).HasMaxLength(150);

                entity.Property(e => e.SenderProvince).HasMaxLength(50);

                entity.Property(e => e.SenderTelNo).HasMaxLength(50);

                entity.Property(e => e.SenderZipCode).HasMaxLength(50);

                entity.Property(e => e.SerialNo).HasMaxLength(50);

                entity.Property(e => e.ShipPicture).HasColumnType("image");

                entity.Property(e => e.ShipTo).HasMaxLength(255);

                entity.Property(e => e.ShipmentTransit).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShipperCertf).HasMaxLength(250);

                entity.Property(e => e.ShipperDf).HasMaxLength(255);

                entity.Property(e => e.ShipperSigned).HasMaxLength(50);

                entity.Property(e => e.ShippingMarkImport).HasColumnType("ntext");

                entity.Property(e => e.Sign).HasMaxLength(50);

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.Property(e => e.Signature).HasMaxLength(50);

                entity.Property(e => e.SpecialInstruction).HasMaxLength(2000);

                entity.Property(e => e.SpecialNote).HasMaxLength(4000);

                entity.Property(e => e.StyleNo).HasMaxLength(50);

                entity.Property(e => e.TRANSID).HasMaxLength(50);

                entity.Property(e => e.TTChgAgentCC).HasMaxLength(50);

                entity.Property(e => e.TTChgAgentPP).HasMaxLength(50);

                entity.Property(e => e.TTChgCarrCC).HasMaxLength(50);

                entity.Property(e => e.TTChgCarrPP).HasMaxLength(50);

                entity.Property(e => e.TaxCC).HasMaxLength(50);

                entity.Property(e => e.TaxPP).HasMaxLength(50);

                entity.Property(e => e.ThirdCarrier).HasMaxLength(50);

                entity.Property(e => e.ThirdDestination).HasMaxLength(50);

                entity.Property(e => e.TimeAm).HasMaxLength(50);

                entity.Property(e => e.TimePm).HasMaxLength(50);

                entity.Property(e => e.TotalCC).HasMaxLength(50);

                entity.Property(e => e.TotalPP).HasMaxLength(50);

                entity.Property(e => e.TotalPackages).HasMaxLength(50);

                entity.Property(e => e.TranShipmentTo).HasMaxLength(255);

                entity.Property(e => e.TranShipmentToCode).HasMaxLength(50);

                entity.Property(e => e.ValChargeCC).HasMaxLength(50);

                entity.Property(e => e.ValChargePP).HasMaxLength(50);

                entity.Property(e => e.WChargeCC).HasMaxLength(50);

                entity.Property(e => e.WChargePP).HasMaxLength(50);

                entity.Property(e => e.WarehouseName).HasMaxLength(150);

                entity.Property(e => e.Weight).HasDefaultValueSql("(0)");

                entity.Property(e => e.insurAmount).HasMaxLength(255);
            });

            modelBuilder.Entity<HAWBDETAILS>(entity =>
            {
                entity.HasKey(e => e.HWBNO)
                    .HasName("aaaaaHAWBDETAILS_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.HWBNO, "HAWBHAWBDETAILS")
                    .IsUnique();

                entity.HasIndex(e => e.HWBNO, "HAWBNO");

                entity.Property(e => e.HWBNO).HasMaxLength(50);

                entity.Property(e => e.CBM).HasDefaultValueSql("(0)");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.GrossWeight).HasDefaultValueSql("(0)");

                entity.Property(e => e.HSCode).HasMaxLength(50);

                entity.Property(e => e.ItemNo).HasMaxLength(150);

                entity.Property(e => e.MaskNos).HasColumnType("ntext");

                entity.Property(e => e.NoPieces).HasMaxLength(150);

                entity.Property(e => e.NoPiecesSe).HasMaxLength(150);

                entity.Property(e => e.RateCharge).HasDefaultValueSql("(0)");

                entity.Property(e => e.RateClass).HasMaxLength(50);

                entity.Property(e => e.SIDescription).HasColumnType("ntext");

                entity.Property(e => e.Total).HasDefaultValueSql("(0)");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.WChargeable).HasDefaultValueSql("(0)");

                entity.Property(e => e.Wlbs).HasMaxLength(50);

                entity.HasOne(d => d.HWBNONavigation)
                    .WithOne(p => p.HAWBDETAILS)
                    .HasForeignKey<HAWBDETAILS>(d => d.HWBNO)
                    .HasConstraintName("HAWBDETAILS_FK00");
            });

            modelBuilder.Entity<HAWBRATE>(entity =>
            {
                entity.HasKey(e => new { e.HWBNO, e.FreightCharges });

                entity.Property(e => e.HWBNO).HasMaxLength(50);

                entity.Property(e => e.FreightCharges).HasMaxLength(255);

                entity.Property(e => e.Collect).HasDefaultValueSql("((0))");

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DueCarr).HasDefaultValueSql("((0))");

                entity.Property(e => e.IDKeyIX)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PerCharges).HasMaxLength(50);

                entity.Property(e => e.RateCharges).HasMaxLength(50);

                entity.Property(e => e.RevenueTons).HasMaxLength(50);

                entity.Property(e => e.Shmt).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.HWBNONavigation)
                    .WithMany(p => p.HAWBRATE)
                    .HasForeignKey(d => d.HWBNO)
                    .HasConstraintName("FK_HAWBRATE_HAWB");
            });

            modelBuilder.Entity<HAWBSEPDetails>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.GoodsDescription).HasMaxLength(1000);

                entity.Property(e => e.HAWBNo).HasMaxLength(50);

                entity.Property(e => e.MarksNo).HasMaxLength(255);

                entity.Property(e => e.UnitCNTS).HasMaxLength(50);

                entity.Property(e => e.UnitW).HasMaxLength(50);

                entity.HasOne(d => d.HAWBNoNavigation)
                    .WithMany(p => p.HAWBSEPDetails)
                    .HasForeignKey(d => d.HAWBNo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HAWBSEPDetails_HAWB");
            });

            modelBuilder.Entity<HAWBTranshipment>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Campaign).HasMaxLength(50);

                entity.Property(e => e.ChargeMode).HasMaxLength(50);

                entity.Property(e => e.ContainerNo).HasMaxLength(50);

                entity.Property(e => e.ContainerStuffing).HasMaxLength(50);

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DepartureDate).HasColumnType("datetime");

                entity.Property(e => e.DepartureFrom).HasMaxLength(50);

                entity.Property(e => e.HAWBNo).HasMaxLength(50);

                entity.Property(e => e.InvoiceCurr).HasMaxLength(50);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.LONumber).HasMaxLength(50);

                entity.Property(e => e.OnCarriageTo).HasMaxLength(50);

                entity.Property(e => e.PONumber).HasMaxLength(50);

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.QuantityUnit).HasMaxLength(50);

                entity.Property(e => e.ReceivedBy).HasMaxLength(50);

                entity.Property(e => e.SealNo).HasMaxLength(50);

                entity.Property(e => e.StyleNumber).HasMaxLength(50);

                entity.Property(e => e.TruckNo).HasMaxLength(50);

                entity.Property(e => e.Units).HasMaxLength(50);

                entity.HasOne(d => d.HAWBNoNavigation)
                    .WithMany(p => p.HAWBTranshipment)
                    .HasForeignKey(d => d.HAWBNo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HAWBTranshipment_HAWB");
            });

            modelBuilder.Entity<HandleServiceRate>(entity =>
            {
                entity.HasKey(e => new { e.RequestID, e.PartnerID, e.Unit, e.Description, e.Dpt })
                    .HasName("aaaaaHandleServiceRate_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.RequestID, "CargoOperationRequestHandleServiceRate");

                entity.HasIndex(e => e.FieldKey, "FieldKey_HandleServiceRate");

                entity.HasIndex(e => e.VoucherIDSE, "IX_HandleServiceRate_1");

                entity.HasIndex(e => e.InoiceNo, "InoiceNo_HandleServiceRate_2");

                entity.HasIndex(e => e.PartnerID, "PartnersHandleServiceRate");

                entity.HasIndex(e => new { e.DocsNo, e.VATInvID, e.SeriNo }, "VAT_HandleServiceRate_3");

                entity.HasIndex(e => e.VoucherID, "VoucherID");

                entity.Property(e => e.RequestID).HasMaxLength(50);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.AccsDateKey).HasColumnType("datetime");

                entity.Property(e => e.AccsLog).HasMaxLength(4000);

                entity.Property(e => e.AccsUserKey).HasMaxLength(50);

                entity.Property(e => e.AdvVoucherID).HasMaxLength(50);

                entity.Property(e => e.Advanced).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DataIndex).HasDefaultValueSql("((0))");

                entity.Property(e => e.DocsNo).HasMaxLength(50);

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.ExtRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtRateVND).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtVND).HasDefaultValueSql("((0))");

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.GWHeavyW).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gainloss).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupName).HasMaxLength(150);

                entity.Property(e => e.IDKeyIndex)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.INVSOANo).HasMaxLength(50);

                entity.Property(e => e.InoiceNo).HasMaxLength(50);

                entity.Property(e => e.InvDate).HasColumnType("datetime");

                entity.Property(e => e.MUnit).HasMaxLength(50);

                entity.Property(e => e.NoInv).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OBHFieldKey).HasMaxLength(50);

                entity.Property(e => e.OBHLink).HasDefaultValueSql("((0))");

                entity.Property(e => e.OBHPartnerID).HasMaxLength(50);

                entity.Property(e => e.Obh).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequisitionID).HasMaxLength(50);

                entity.Property(e => e.SeriNo).HasMaxLength(50);

                entity.Property(e => e.SettleIDLinked).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SettlementRefNo).HasMaxLength(50);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.SortDes).HasMaxLength(150);

                entity.Property(e => e.TotalValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.VAT).HasDefaultValueSql("((0))");

                entity.Property(e => e.VATDate).HasColumnType("datetime");

                entity.Property(e => e.VATInvID).HasMaxLength(50);

                entity.Property(e => e.VATName).HasMaxLength(255);

                entity.Property(e => e.VATSOANo).HasMaxLength(50);

                entity.Property(e => e.VATTaxCode).HasMaxLength(50);

                entity.Property(e => e.VoucherID).HasMaxLength(50);

                entity.Property(e => e.VoucherIDSE).HasMaxLength(50);

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.HandleServiceRate)
                    .HasForeignKey(d => d.PartnerID)
                    .HasConstraintName("HandleServiceRate_FK01");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.HandleServiceRate)
                    .HasForeignKey(d => d.RequestID)
                    .HasConstraintName("HandleServiceRate_FK00");
            });

            modelBuilder.Entity<INNER_ISIPTOFASTPRO>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.IPIDKey)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PCUpdate).HasMaxLength(50);

                entity.Property(e => e.UserUpdate).HasMaxLength(50);

                entity.Property(e => e.VoidIDIDKey).HasMaxLength(50);
            });

            modelBuilder.Entity<InfoNote>(entity =>
            {
                entity.HasKey(e => e.CmpID)
                    .HasName("aaaaaInfoNote_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.CmpID, "CmpID");

                entity.Property(e => e.CmpID).HasMaxLength(50);

                entity.Property(e => e.InfoNotes).HasMaxLength(4000);

                entity.Property(e => e.OnlineNo).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.Cmp)
                    .WithOne(p => p.InfoNote)
                    .HasForeignKey<InfoNote>(d => d.CmpID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InfoNote_YourCompany");
            });

            modelBuilder.Entity<InnerConnection>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.Activate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ApplyDate).HasColumnType("datetime");

                entity.Property(e => e.ConType).HasMaxLength(50);

                entity.Property(e => e.DBName).HasMaxLength(50);

                entity.Property(e => e.DBUser).HasMaxLength(50);

                entity.Property(e => e.DBUserPwd).HasMaxLength(50);

                entity.Property(e => e.ExceptionFieldsChangeCheck).HasMaxLength(255);

                entity.Property(e => e.FieldCondition).HasMaxLength(255);

                entity.Property(e => e.P1).HasMaxLength(50);

                entity.Property(e => e.P2).HasMaxLength(50);

                entity.Property(e => e.P3).HasMaxLength(50);

                entity.Property(e => e.P4).HasMaxLength(50);

                entity.Property(e => e.P5).HasMaxLength(50);

                entity.Property(e => e.ServerDBInstance).HasMaxLength(50);

                entity.Property(e => e.SubFieldCondition).HasMaxLength(255);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<InnerConnectionDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AcRefListLLinked).HasMaxLength(1000);

                entity.Property(e => e.IDKey).ValueGeneratedOnAdd();

                entity.Property(e => e.LinkedTable).HasMaxLength(50);
            });

            modelBuilder.Entity<InquiryFollowUpStatus>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.DisplayField).HasMaxLength(50);

                entity.Property(e => e.FilterCond).HasMaxLength(1000);

                entity.Property(e => e.FormID).HasMaxLength(50);

                entity.Property(e => e.JasonStatement).HasMaxLength(1000);

                entity.Property(e => e.SQLFieldSource).HasMaxLength(1000);
            });

            modelBuilder.Entity<InquiryFollowUpStatusDetails>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.KeyName).HasMaxLength(50);

                entity.Property(e => e.sqlStatement).HasMaxLength(1000);
            });

            modelBuilder.Entity<InttraCheckStatusHistory>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateChecked).HasColumnType("datetime");

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileName).HasMaxLength(150);

                entity.Property(e => e.PCName).HasMaxLength(50);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.ServiceName).HasMaxLength(50);

                entity.Property(e => e.UserChecked).HasMaxLength(50);
            });

            modelBuilder.Entity<InvoiceForm>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("aaaaaInvoiceForm_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ID, "ID")
                    .IsUnique();

                entity.HasIndex(e => e.InvoiceID, "InvoiceID");

                entity.HasIndex(e => e.Sign, "Sign");

                entity.Property(e => e.ID).HasMaxLength(50);

                entity.Property(e => e.APIEdit_URL).HasMaxLength(150);

                entity.Property(e => e.APIGET_URL).HasMaxLength(150);

                entity.Property(e => e.APIHeader).HasMaxLength(255);

                entity.Property(e => e.APIName).HasMaxLength(50);

                entity.Property(e => e.API_URL).HasMaxLength(150);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedUser).HasMaxLength(50);

                entity.Property(e => e.DateMask).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DisableChangeInvNoAndDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.EndInvoiceNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HBLdetail).HasDefaultValueSql("((0))");

                entity.Property(e => e.IgnoreInvNoLen).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvSize).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceDateFormat).HasMaxLength(50);

                entity.Property(e => e.InvoiceID).HasMaxLength(50);

                entity.Property(e => e.LIndex).HasDefaultValueSql("((0))");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.PageDetail).HasMaxLength(150);

                entity.Property(e => e.PartnerGUID).HasMaxLength(255);

                entity.Property(e => e.PartnerToken).HasMaxLength(255);

                entity.Property(e => e.ReportName).HasMaxLength(100);

                entity.Property(e => e.Sign).HasMaxLength(50);

                entity.Property(e => e.StartInvoiceNo)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<InvoiceFormDTS>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ID).HasMaxLength(50);

                entity.Property(e => e.ReportName).HasMaxLength(100);

                entity.Property(e => e.Whois).HasMaxLength(50);
            });

            modelBuilder.Entity<InvoiceFormDefault>(entity =>
            {
                entity.Property(e => e.ID).HasMaxLength(50);

                entity.Property(e => e.DefaultEmailToSend).HasMaxLength(255);

                entity.Property(e => e.DefaultNotes).HasMaxLength(255);

                entity.Property(e => e.FirstHBLNo).HasMaxLength(20);

                entity.Property(e => e.FirstJobID).HasMaxLength(20);
            });

            modelBuilder.Entity<InvoiceRefGrouping>(entity =>
            {
                entity.HasKey(e => new { e.IDTransType, e.Description, e.GroupOn })
                    .HasName("aaaaaInvoiceRefGrouping_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.IDTransType, "IDTransType");

                entity.Property(e => e.IDTransType).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.UserNotes).HasMaxLength(255);
            });

            modelBuilder.Entity<InvoiceReference>(entity =>
            {
                entity.HasKey(e => e.InvID)
                    .HasName("aaaaaInvoiceReference_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.InvID, "InvID");

                entity.HasIndex(e => e.ShipperID, "PartnersInvoiceReference");

                entity.HasIndex(e => e.ShipperID, "ShipperID");

                entity.HasIndex(e => e.TransID, "TransID");

                entity.HasIndex(e => e.TransID, "TransactionsInvoiceReference");

                entity.HasIndex(e => e.VoidTransID, "VoidTransID");

                entity.HasIndex(e => e.WhoisIssued, "WhoisIssued_InvoiceReference");

                entity.Property(e => e.InvID).HasMaxLength(50);

                entity.Property(e => e.AccsChecked).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccsCheckedDate).HasColumnType("datetime");

                entity.Property(e => e.AccsWhois).HasMaxLength(50);

                entity.Property(e => e.ApprovedIssuedDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.AssigntoUser).HasMaxLength(50);

                entity.Property(e => e.Credit).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreditCurrency).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateInvoice).HasMaxLength(50);

                entity.Property(e => e.DateMode).HasMaxLength(50);

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.DateofLock).HasColumnType("datetime");

                entity.Property(e => e.Debit).HasDefaultValueSql("((0))");

                entity.Property(e => e.DebitCurrency).HasMaxLength(50);

                entity.Property(e => e.DepositCurr).HasMaxLength(50);

                entity.Property(e => e.InnerInvoice).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvExportDate).HasColumnType("datetime");

                entity.Property(e => e.InvExported).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvLockOpenTrans).HasMaxLength(4000);

                entity.Property(e => e.InvSeriNo).HasMaxLength(50);

                entity.Property(e => e.InvWhosExport).HasMaxLength(50);

                entity.Property(e => e.IssueVATDateAsign).HasColumnType("datetime");

                entity.Property(e => e.IssuedDate).HasColumnType("datetime");

                entity.Property(e => e.MngCheckedDate).HasColumnType("datetime");

                entity.Property(e => e.MngWhois).HasMaxLength(50);

                entity.Property(e => e.NoIssueVATInv).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OtherRef).HasMaxLength(255);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentAssignReceived).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentAssignReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDateAssign).HasColumnType("datetime");

                entity.Property(e => e.ReceiverRead)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportName).HasMaxLength(50);

                entity.Property(e => e.RevenueOP).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReviseDate).HasColumnType("datetime");

                entity.Property(e => e.SOANO).HasMaxLength(50);

                entity.Property(e => e.ServiceID).HasMaxLength(50);

                entity.Property(e => e.ShipperAddress).HasMaxLength(4000);

                entity.Property(e => e.ShipperID).HasMaxLength(50);

                entity.Property(e => e.ShipperName).HasMaxLength(255);

                entity.Property(e => e.StatementINV).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.VATIssueAssignReceived).HasDefaultValueSql("((0))");

                entity.Property(e => e.VATIssueAssignReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.VoidDate).HasColumnType("datetime");

                entity.Property(e => e.VoidTransID).HasMaxLength(50);

                entity.Property(e => e.WhoisIssued).HasMaxLength(150);

                entity.Property(e => e.WhoisPaid).HasMaxLength(50);

                entity.Property(e => e.WhoisVoid).HasMaxLength(50);

                entity.HasOne(d => d.SOANONavigation)
                    .WithMany(p => p.InvoiceReference)
                    .HasForeignKey(d => d.SOANO)
                    .HasConstraintName("FK_InvoiceReference_InvoiceSOA");

                entity.HasOne(d => d.Shipper)
                    .WithMany(p => p.InvoiceReference)
                    .HasForeignKey(d => d.ShipperID)
                    .HasConstraintName("InvoiceReference_FK00");

                entity.HasOne(d => d.Trans)
                    .WithMany(p => p.InvoiceReference)
                    .HasForeignKey(d => d.TransID)
                    .HasConstraintName("InvoiceReference_FK01");
            });

            modelBuilder.Entity<InvoiceReferenceDetail>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceNo, e.Curr, e.Dpt })
                    .HasName("aaaaaInvoiceReferenceDetail_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.InvoiceNo, "InvoiceReferenceInvoiceReferenceDetail");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.Amount).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExtVND).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.InvoiceNoNavigation)
                    .WithMany(p => p.InvoiceReferenceDetail)
                    .HasForeignKey(d => d.InvoiceNo)
                    .HasConstraintName("InvoiceReferenceDetail_FK00");
            });

            modelBuilder.Entity<InvoiceReferenceMode>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.ReportName).HasMaxLength(150);

                entity.Property(e => e.ReportNameList).HasMaxLength(1000);

                entity.Property(e => e.ServiceID).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.InvoiceReferenceMode)
                    .HasForeignKey(d => d.ServiceID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_InvoiceReferenceMode_TransactionType");
            });

            modelBuilder.Entity<InvoiceSOA>(entity =>
            {
                entity.HasKey(e => e.SOANO);

                entity.HasIndex(e => e.IssuedBy, "IssuedBy_InvoiceSOA");

                entity.HasIndex(e => e.PartnerID, "PartnerID_InvoiceSOA");

                entity.HasIndex(e => e.PayablePartnerID, "PayablePartnerID_InvoiceSOA");

                entity.Property(e => e.SOANO).HasMaxLength(50);

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DateOfIssued).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.IssuedBy).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.PartnerName).HasMaxLength(255);

                entity.Property(e => e.PayablePartnerID).HasMaxLength(50);

                entity.Property(e => e.ReceiverDateApp).HasColumnType("datetime");

                entity.Property(e => e.ReceiverReadDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiverUser).HasMaxLength(50);

                entity.Property(e => e.RevisedDate).HasColumnType("datetime");

                entity.Property(e => e.SOADate).HasColumnType("datetime");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.VATInvoiceID).HasMaxLength(50);

                entity.Property(e => e.VATInvoiceNo).HasMaxLength(50);

                entity.Property(e => e.VATIssuedDate).HasColumnType("datetime");

                entity.Property(e => e.VATSeriNo).HasMaxLength(50);

                entity.Property(e => e.VoidDate).HasColumnType("datetime");

                entity.Property(e => e.WhoisPaid).HasMaxLength(50);

                entity.Property(e => e.WhoisRevised).HasMaxLength(50);

                entity.Property(e => e.WhoisVoid).HasMaxLength(50);
            });

            modelBuilder.Entity<JobApplyExchangeRate>(entity =>
            {
                entity.HasKey(e => e.TransID);

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.ExchangeRateID).HasMaxLength(50);
            });

            modelBuilder.Entity<MailSendingMsg>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.MailBody).HasMaxLength(4000);

                entity.Property(e => e.MailMode).HasMaxLength(50);

                entity.Property(e => e.MailSubject).HasMaxLength(255);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<MainMenu>(entity =>
            {
                entity.HasKey(e => e.MenuID)
                    .HasName("aaaaaMainMenu_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.MenuID, "MenuID");

                entity.Property(e => e.MenuID).HasMaxLength(50);

                entity.Property(e => e.Acerator).HasMaxLength(50);

                entity.Property(e => e.InvisibleUsernameList).HasMaxLength(1000);

                entity.Property(e => e.MenuDisplay).HasMaxLength(150);

                entity.Property(e => e.MenuDisplaySND).HasMaxLength(150);

                entity.Property(e => e.iIndex).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MainTool>(entity =>
            {
                entity.HasKey(e => e.sKey)
                    .HasName("aaaaaMainTool_PK")
                    .IsClustered(false);

                entity.Property(e => e.sKey).HasMaxLength(50);

                entity.Property(e => e.ButonStyle).HasMaxLength(50);

                entity.Property(e => e.ButtonText).HasMaxLength(150);

                entity.Property(e => e.ButtonTextSND).HasMaxLength(150);

                entity.Property(e => e.ImageIcon).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvisibleUsernameList).HasMaxLength(1000);

                entity.Property(e => e.Tiptext).HasMaxLength(150);

                entity.Property(e => e.iIndex).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MenuSubList>(entity =>
            {
                entity.HasKey(e => new { e.MenuID, e.SubMenuID })
                    .HasName("aaaaaMenuSubList_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.MenuID, "MenuID");

                entity.HasIndex(e => e.SubMenuID, "SubMenuID");

                entity.HasIndex(e => e.SubMenuShortcutKey, "SubMenuShortcutKey");

                entity.HasIndex(e => e.SubP2ID, "SubP2ID");

                entity.HasIndex(e => e.iIndex, "iIndex");

                entity.Property(e => e.MenuID).HasMaxLength(50);

                entity.Property(e => e.SubMenuID).HasMaxLength(50);

                entity.Property(e => e.Acerator).HasMaxLength(50);

                entity.Property(e => e.IconNo).HasDefaultValueSql("((-1))");

                entity.Property(e => e.InvisibleUsernameList).HasMaxLength(1000);

                entity.Property(e => e.SubMenuDisplay).HasMaxLength(150);

                entity.Property(e => e.SubMenuDisplaySND).HasMaxLength(150);

                entity.Property(e => e.SubMenuShortcutKey).HasMaxLength(50);

                entity.Property(e => e.SubP2ID).HasMaxLength(50);

                entity.Property(e => e.SubmenuEnable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.iIndex).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NACCS_CNTR>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.CNTR_FM_IND).HasMaxLength(50);

                entity.Property(e => e.CNTR_NO).HasMaxLength(50);

                entity.Property(e => e.CNTR_SUPL_CD).HasMaxLength(50);

                entity.Property(e => e.CNTR_SZ_CD).HasMaxLength(50);

                entity.Property(e => e.CNTR_TP_CD).HasMaxLength(50);

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.HBLNo).HasMaxLength(50);

                entity.Property(e => e.SEAL_NO).HasMaxLength(50);

                entity.HasOne(d => d.IDLinkedNavigation)
                    .WithMany(p => p.NACCS_CNTR)
                    .HasForeignKey(d => d.IDLinked)
                    .HasConstraintName("FK_NACCS_CNTR_NACCS_HBL");
            });

            modelBuilder.Entity<NACCS_HBL>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.BL_NO).HasMaxLength(50);

                entity.Property(e => e.CUST_REF_NO).HasMaxLength(50);

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.DEL_CD).HasMaxLength(50);

                entity.Property(e => e.DEL_NAME).HasMaxLength(50);

                entity.Property(e => e.DGS_IMDG_CD).HasMaxLength(50);

                entity.Property(e => e.DGS_IMO_CD).HasMaxLength(50);

                entity.Property(e => e.DGS_UN_NO).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.FINAL_DEST_CD).HasMaxLength(50);

                entity.Property(e => e.FINAL_DEST_NAME).HasMaxLength(50);

                entity.Property(e => e.FREIGHT).HasMaxLength(50);

                entity.Property(e => e.FREIGHT_CURR_CD).HasMaxLength(50);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.GOODS_DESC).HasMaxLength(255);

                entity.Property(e => e.GOODS_HS_CD).HasMaxLength(50);

                entity.Property(e => e.HBLMSG_ID).HasMaxLength(50);

                entity.Property(e => e.HBLMSG_TYPE).HasMaxLength(50);

                entity.Property(e => e.HBL_F_IND).HasMaxLength(50);

                entity.Property(e => e.IT_ARR_CD).HasMaxLength(50);

                entity.Property(e => e.IT_ARR_NAME).HasMaxLength(50);

                entity.Property(e => e.IT_ETA).HasMaxLength(50);

                entity.Property(e => e.IT_ETD).HasMaxLength(50);

                entity.Property(e => e.IT_MODE).HasMaxLength(50);

                entity.Property(e => e.LAW_CD).HasMaxLength(50);

                entity.Property(e => e.MARK_NO).HasMaxLength(255);

                entity.Property(e => e.MBL_NO).HasMaxLength(50);

                entity.Property(e => e.MEA_CD).HasMaxLength(50);

                entity.Property(e => e.MSG_NO).HasMaxLength(50);

                entity.Property(e => e.NET_WGT_CD).HasMaxLength(50);

                entity.Property(e => e.NOTI_PARTY_CD).HasMaxLength(50);

                entity.Property(e => e.NOTI_PARTY_CD2).HasMaxLength(50);

                entity.Property(e => e.NOTI_PARTY_CD3).HasMaxLength(50);

                entity.Property(e => e.NStatus).HasMaxLength(50);

                entity.Property(e => e.ORG_CNT_CD).HasMaxLength(50);

                entity.Property(e => e.ORG_POL_CD).HasMaxLength(50);

                entity.Property(e => e.ORG_POL_NAME).HasMaxLength(50);

                entity.Property(e => e.PARTNER_NOTI_EMAIL).HasMaxLength(50);

                entity.Property(e => e.PKG_CD).HasMaxLength(50);

                entity.Property(e => e.PKG_QTY).HasMaxLength(50);

                entity.Property(e => e.POD_CD).HasMaxLength(50);

                entity.Property(e => e.POD_ETA).HasMaxLength(50);

                entity.Property(e => e.REMARK).HasMaxLength(255);

                entity.Property(e => e.SPC_CGO_CD).HasMaxLength(50);

                entity.Property(e => e.TEMP_DSC_DUR).HasMaxLength(50);

                entity.Property(e => e.TEMP_DSC_IND).HasMaxLength(50);

                entity.Property(e => e.TEMP_DSC_REASON).HasMaxLength(50);

                entity.Property(e => e.TOT_WGT_CD).HasMaxLength(50);

                entity.Property(e => e.Uploaded).HasColumnType("datetime");

                entity.Property(e => e.UploadedUser).HasMaxLength(50);

                entity.Property(e => e.VALUE).HasMaxLength(50);

                entity.Property(e => e.VALUE_CURR_CD).HasMaxLength(50);

                entity.HasOne(d => d.IDLinkedNavigation)
                    .WithMany(p => p.NACCS_HBL)
                    .HasForeignKey(d => d.IDLinked)
                    .HasConstraintName("FK_NACCS_HBL_NACCS_MBL");
            });

            modelBuilder.Entity<NACCS_MBL>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.APP_AREA_IND).HasMaxLength(50);

                entity.Property(e => e.CUST_ID).HasMaxLength(50);

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ETD_DATE).HasColumnType("datetime");

                entity.Property(e => e.ETD_TIME).HasMaxLength(50);

                entity.Property(e => e.FUNC_CD).HasMaxLength(50);

                entity.Property(e => e.GMT_TIME_GAP).HasMaxLength(50);

                entity.Property(e => e.JobNo).HasMaxLength(50);

                entity.Property(e => e.MSG_ID).HasMaxLength(50);

                entity.Property(e => e.MSG_TYPE).HasMaxLength(50);

                entity.Property(e => e.POL_CD).HasMaxLength(50);

                entity.Property(e => e.POL_NAME).HasMaxLength(150);

                entity.Property(e => e.POL_SFX).HasMaxLength(50);

                entity.Property(e => e.RPT_ID).HasMaxLength(50);

                entity.Property(e => e.RPT_PW).HasMaxLength(50);

                entity.Property(e => e.SCAC).HasMaxLength(50);

                entity.Property(e => e.SenderID).HasMaxLength(50);

                entity.Property(e => e.VOYAGE_NO).HasMaxLength(50);

                entity.Property(e => e.VSL_CD).HasMaxLength(50);

                entity.Property(e => e.VSL_CNT_CD).HasMaxLength(50);

                entity.Property(e => e.VSL_INFO_CHNG_IND).HasMaxLength(50);

                entity.Property(e => e.VSL_NAME).HasMaxLength(150);

                entity.HasOne(d => d.JobNoNavigation)
                    .WithMany(p => p.NACCS_MBL)
                    .HasForeignKey(d => d.JobNo)
                    .HasConstraintName("FK_NACCS_MBL_Transactions");
            });

            modelBuilder.Entity<NACCS_PARTY>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.HBLNo).HasMaxLength(50);

                entity.Property(e => e.PARTY_ADD).HasMaxLength(255);

                entity.Property(e => e.PARTY_CD).HasMaxLength(50);

                entity.Property(e => e.PARTY_CITY).HasMaxLength(50);

                entity.Property(e => e.PARTY_CNT_CD).HasMaxLength(50);

                entity.Property(e => e.PARTY_CNT_NAME).HasMaxLength(50);

                entity.Property(e => e.PARTY_NAME).HasMaxLength(255);

                entity.Property(e => e.PARTY_STREET1).HasMaxLength(50);

                entity.Property(e => e.PARTY_STREET2).HasMaxLength(50);

                entity.Property(e => e.PARTY_TEL_NO).HasMaxLength(50);

                entity.Property(e => e.PARTY_TP).HasMaxLength(50);

                entity.Property(e => e.PARTY_ZIP_CD).HasMaxLength(50);

                entity.HasOne(d => d.IDLinkedNavigation)
                    .WithMany(p => p.NACCS_PARTY)
                    .HasForeignKey(d => d.IDLinked)
                    .HasConstraintName("FK_NACCS_PARTY_NACCS_HBL");
            });

            modelBuilder.Entity<NameFeeAcDefault>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.AcCo).HasMaxLength(50);

                entity.Property(e => e.AcNo).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.FeeCodeRef).HasMaxLength(50);

                entity.Property(e => e.OBHAcCo).HasMaxLength(50);

                entity.Property(e => e.OBHAcNo).HasMaxLength(50);

                entity.Property(e => e.UserEdit).HasMaxLength(50);

                entity.Property(e => e.VATAcCo).HasMaxLength(50);

                entity.Property(e => e.VATAcNo).HasMaxLength(50);

                entity.Property(e => e.VATOBHAcCo).HasMaxLength(50);

                entity.Property(e => e.VATOBHAcNo).HasMaxLength(50);

                entity.Property(e => e.VCMode).HasMaxLength(50);
            });

            modelBuilder.Entity<NameFeeDescription>(entity =>
            {
                entity.HasKey(e => e.FeeID);

                entity.Property(e => e.FeeID).HasMaxLength(50);

                entity.Property(e => e.AccCo).HasMaxLength(50);

                entity.Property(e => e.AccNo).HasMaxLength(50);

                entity.Property(e => e.AirFreight).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompChargeCode).HasMaxLength(50);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.CostInsChargeCode).HasMaxLength(50);

                entity.Property(e => e.CurrUnit).HasMaxLength(50);

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DeptCode).HasMaxLength(50);

                entity.Property(e => e.Domestics).HasDefaultValueSql("((0))");

                entity.Property(e => e.EffectToShipmentProfit).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpAdmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpFSC).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpOthers).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.FeeCode).HasMaxLength(50);

                entity.Property(e => e.FeeDescEn).HasMaxLength(255);

                entity.Property(e => e.FeeDescLocal).HasMaxLength(255);

                entity.Property(e => e.FormularAC).HasMaxLength(150);

                entity.Property(e => e.FormularACCond).HasMaxLength(50);

                entity.Property(e => e.GWHeavyW).HasDefaultValueSql("((0))");

                entity.Property(e => e.GainAC).HasMaxLength(50);

                entity.Property(e => e.GainLossCharge).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupName).HasMaxLength(150);

                entity.Property(e => e.InnerPartnerIDCharges).HasMaxLength(50);

                entity.Property(e => e.IssueFrom).HasMaxLength(50);

                entity.Property(e => e.IssueMoreACCode).HasMaxLength(50);

                entity.Property(e => e.IssueTo).HasMaxLength(50);

                entity.Property(e => e.KBCK).HasDefaultValueSql("((0))");

                entity.Property(e => e.KBMode).HasDefaultValueSql("((0))");

                entity.Property(e => e.LossAC).HasMaxLength(50);

                entity.Property(e => e.MapDeptCode).HasMaxLength(50);

                entity.Property(e => e.MapFeeCode).HasMaxLength(50);

                entity.Property(e => e.NoUpdateKBCharge).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartnerIDCharges).HasMaxLength(50);

                entity.Property(e => e.PayablePartnerID).HasMaxLength(50);

                entity.Property(e => e.QtyPercent).HasDefaultValueSql("((0))");

                entity.Property(e => e.SOAGroupName).HasMaxLength(150);

                entity.Property(e => e.SeaFreight).HasDefaultValueSql("((0))");

                entity.Property(e => e.TruckingRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitEn).HasMaxLength(50);

                entity.Property(e => e.UnitLocal).HasMaxLength(50);

                entity.Property(e => e.UpdateToLinkedHBL).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.Property(e => e.UserIssued).HasMaxLength(50);

                entity.Property(e => e.VAT).HasMaxLength(50);

                entity.Property(e => e.VATCharge).HasDefaultValueSql("((0))");

                entity.Property(e => e.VATCode).HasMaxLength(50);
            });

            modelBuilder.Entity<OPSManagement>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.HasIndex(e => e.JobNo, "JobNo_OPSManagement");

                entity.HasIndex(e => e.OPStaffID, "OPStaffID_OPSManagement");

                entity.HasIndex(e => e.RefNo, "RefNo");

                entity.HasIndex(e => e.RefNo, "RefNo_OPSManagement");

                entity.HasIndex(e => e.RequestNo, "RequestNo_OPSManagement");

                entity.HasIndex(e => e.UserApproved, "UserApproved_OPSManagement");

                entity.HasIndex(e => e.UserEdit, "UserEdit_OPSManagement");

                entity.Property(e => e.ApproveNotes).HasMaxLength(255);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.Attached).HasColumnType("ntext");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.DateSenderReadAPPDECL).HasColumnType("datetime");

                entity.Property(e => e.Deadline).HasMaxLength(50);

                entity.Property(e => e.DeclineDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DoneApp).HasDefaultValueSql("((0))");

                entity.Property(e => e.DoneAppDate).HasColumnType("datetime");

                entity.Property(e => e.DoneDate).HasColumnType("datetime");

                entity.Property(e => e.DoneInputDate).HasColumnType("datetime");

                entity.Property(e => e.DoneJob).HasDefaultValueSql("((0))");

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.ForwardUser).HasMaxLength(50);

                entity.Property(e => e.JobNo).HasMaxLength(50);

                entity.Property(e => e.MethodEx).HasMaxLength(50);

                entity.Property(e => e.Modify).HasColumnType("datetime");

                entity.Property(e => e.OPStaffID).HasMaxLength(50);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.RequestNo).HasMaxLength(50);

                entity.Property(e => e.RequestType).HasMaxLength(50);

                entity.Property(e => e.Sended).HasDefaultValueSql("((0))");

                entity.Property(e => e.SenderNotes).HasMaxLength(255);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UserApproved).HasMaxLength(50);

                entity.Property(e => e.UserEdit).HasMaxLength(50);

                entity.Property(e => e.WhoisDoneApp).HasMaxLength(50);

                entity.HasOne(d => d.JobNoNavigation)
                    .WithMany(p => p.OPSManagement)
                    .HasForeignKey(d => d.JobNo)
                    .HasConstraintName("FK_OPSManagement_Transactions");

                entity.HasOne(d => d.OPStaff)
                    .WithMany(p => p.OPSManagement)
                    .HasForeignKey(d => d.OPStaffID)
                    .HasConstraintName("FK_OPSManagement_ContactsList");

                entity.HasOne(d => d.RequestNoNavigation)
                    .WithMany(p => p.OPSManagement)
                    .HasForeignKey(d => d.RequestNo)
                    .HasConstraintName("FK_OPSManagement_CargoOperationRequest");
            });

            modelBuilder.Entity<OPSManagementAttachedFiles>(entity =>
            {
                entity.HasKey(e => e.FieldKey);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<OPSManagementDefaultList>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.ServiceMode).HasMaxLength(50);

                entity.Property(e => e.ServiceName).HasMaxLength(255);

                entity.Property(e => e.UserDefault).HasMaxLength(50);
            });

            modelBuilder.Entity<OPSRequestType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CaptionForm).HasMaxLength(255);

                entity.Property(e => e.Conditions).HasMaxLength(255);

                entity.Property(e => e.FieldCondition).HasMaxLength(50);

                entity.Property(e => e.FieldDisplay).HasMaxLength(50);

                entity.Property(e => e.FieldName).HasMaxLength(50);

                entity.Property(e => e.FormOJCaption).HasMaxLength(50);

                entity.Property(e => e.FormObjectName).HasMaxLength(50);

                entity.Property(e => e.IsFieldNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSettlement).HasDefaultValueSql("((0))");

                entity.Property(e => e.Payment).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequestDes).HasMaxLength(255);

                entity.Property(e => e.RequestTypeID).HasMaxLength(50);

                entity.Property(e => e.ShipmentDocs).HasDefaultValueSql("((0))");

                entity.Property(e => e.SqlStatement).HasMaxLength(1000);

                entity.Property(e => e.TableRef).HasMaxLength(50);
            });

            modelBuilder.Entity<OnlineSupportConnect>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Activate).HasDefaultValueSql("((0))");

                entity.Property(e => e.DBName).HasMaxLength(50);

                entity.Property(e => e.DBPwd).HasMaxLength(150);

                entity.Property(e => e.EncodeST).HasDefaultValueSql("((0))");

                entity.Property(e => e.ServerName).HasMaxLength(150);

                entity.Property(e => e.UserDB).HasMaxLength(50);
            });

            modelBuilder.Entity<OnlineSupports>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AnswerContent).HasMaxLength(4000);

                entity.Property(e => e.AnswerTime).HasColumnType("datetime");

                entity.Property(e => e.Attached).HasColumnType("ntext");

                entity.Property(e => e.CancelHelp).HasDefaultValueSql("((0))");

                entity.Property(e => e.Category).HasMaxLength(150);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.Contents).HasMaxLength(4000);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.DoneJob).HasDefaultValueSql("((0))");

                entity.Property(e => e.IDLinked).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NewUpate).HasDefaultValueSql("((0))");

                entity.Property(e => e.SendHelp).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserReceived).HasMaxLength(50);
            });

            modelBuilder.Entity<OnlineSupportsAttachedFiles>(entity =>
            {
                entity.HasKey(e => e.FieldKey);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<Opportunity>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.AsignedtoGroup).HasMaxLength(50);

                entity.Property(e => e.AsignedtoUser).HasMaxLength(50);

                entity.Property(e => e.Attached).HasColumnType("ntext");

                entity.Property(e => e.Company).HasMaxLength(255);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.OPDate).HasColumnType("datetime");

                entity.Property(e => e.OPName).HasMaxLength(50);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.Pic).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UserInput).HasMaxLength(50);
            });

            modelBuilder.Entity<OpportunityAttachedFiles>(entity =>
            {
                entity.HasKey(e => e.FieldKey);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<PODetail>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.HSCode).HasMaxLength(50);

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.PONumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PlaceOfDelivery).HasMaxLength(50);

                entity.Property(e => e.ProductionDate).HasColumnType("datetime");

                entity.Property(e => e.QTYUnit).HasMaxLength(50);

                entity.Property(e => e.VendorCode).HasMaxLength(50);

                entity.HasOne(d => d.PONumberNavigation)
                    .WithMany(p => p.PODetail)
                    .HasForeignKey(d => d.PONumber)
                    .HasConstraintName("FK_PODetail_POList");

                entity.HasOne(d => d.VendorCodeNavigation)
                    .WithMany(p => p.PODetail)
                    .HasForeignKey(d => d.VendorCode)
                    .HasConstraintName("FK_PODetail_Partners");
            });

            modelBuilder.Entity<POList>(entity =>
            {
                entity.HasKey(e => e.PONumber);

                entity.Property(e => e.PONumber).HasMaxLength(50);

                entity.Property(e => e.Attached).HasColumnType("ntext");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.ETA).HasColumnType("datetime");

                entity.Property(e => e.ETD).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.Origin).HasMaxLength(50);

                entity.Property(e => e.PCName).HasMaxLength(50);

                entity.Property(e => e.POD).HasMaxLength(50);

                entity.Property(e => e.PODate).HasColumnType("datetime");

                entity.Property(e => e.POL).HasMaxLength(50);

                entity.Property(e => e.PaymentTerm).HasMaxLength(50);

                entity.Property(e => e.ShipmentDelivery).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShipmentDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentTerm).HasMaxLength(50);
            });

            modelBuilder.Entity<POListAttachedFiles>(entity =>
            {
                entity.HasKey(e => e.FieldKey);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PONo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.PONoNavigation)
                    .WithMany(p => p.POListAttachedFiles)
                    .HasForeignKey(d => d.PONo)
                    .HasConstraintName("FK_POListAttachedFiles_POList");
            });

            modelBuilder.Entity<PackageType>(entity =>
            {
                entity.HasKey(e => e.IDKey)
                    .HasName("PK_PackageType_1");

                entity.Property(e => e.Cont).HasDefaultValueSql("((0))");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(50);

                entity.Property(e => e.MapedUnit).HasMaxLength(50);

                entity.Property(e => e.PACKAGE_CODE)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PackingListDetails>(entity =>
            {
                entity.HasKey(e => new { e.PackingNo, e.No })
                    .HasName("aaaaaPackingListDetails_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.PackingNo, "HAWBPackingListDetails");

                entity.HasIndex(e => e.ProCode, "ProCode");

                entity.Property(e => e.PackingNo)
                    .HasMaxLength(50)
                    .HasComment("HAWB NO");

                entity.Property(e => e.No).HasComment("DETAIL");

                entity.Property(e => e.CBM)
                    .HasDefaultValueSql("(0)")
                    .HasComment("m");

                entity.Property(e => e.CtnsNo).HasMaxLength(50);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .HasComment("Description of Goods");

                entity.Property(e => e.GrossWeight)
                    .HasDefaultValueSql("(0)")
                    .HasComment("kg");

                entity.Property(e => e.NetWeight)
                    .HasDefaultValueSql("(0)")
                    .HasComment("kg");

                entity.Property(e => e.PerKgs).HasDefaultValueSql("(0)");

                entity.Property(e => e.ProCode).HasMaxLength(50);

                entity.Property(e => e.QtyPkg).HasDefaultValueSql("(0)");

                entity.Property(e => e.Quantity)
                    .HasDefaultValueSql("(0)")
                    .HasComment("pcs,set");

                entity.Property(e => e.SumWeight).HasDefaultValueSql("(0)");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UnitPkg).HasMaxLength(50);

                entity.Property(e => e.UnitPrice)
                    .HasDefaultValueSql("(0)")
                    .HasComment("usd");

                entity.HasOne(d => d.PackingNoNavigation)
                    .WithMany(p => p.PackingListDetails)
                    .HasForeignKey(d => d.PackingNo)
                    .HasConstraintName("PackingListDetails_FK00");
            });

            modelBuilder.Entity<PackingLists>(entity =>
            {
                entity.HasKey(e => e.PackingNo)
                    .HasName("aaaaaPackingLists_PK")
                    .IsClustered(false);

                entity.Property(e => e.PackingNo).HasMaxLength(50);

                entity.Property(e => e.BuyerName)
                    .HasMaxLength(100)
                    .HasComment("Packing List (Name & Address)");

                entity.Property(e => e.BuylerAddress).HasMaxLength(150);

                entity.Property(e => e.CBM).HasDefaultValueSql("(0)");

                entity.Property(e => e.Commodity).HasMaxLength(150);

                entity.Property(e => e.ContainerNo).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FlightDateConfirm).HasMaxLength(50);

                entity.Property(e => e.GrossWeight).HasDefaultValueSql("(0)");

                entity.Property(e => e.HWBNO)
                    .HasMaxLength(50)
                    .HasComment("Bill of Lading (House)");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OrderNo).HasMaxLength(50);

                entity.Property(e => e.SayGroup).HasMaxLength(150);

                entity.Property(e => e.SellerAddress).HasMaxLength(150);

                entity.Property(e => e.SellerName)
                    .HasMaxLength(100)
                    .HasComment("Packing List (Name & Address)");

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShippingMark).HasMaxLength(150);
            });

            modelBuilder.Entity<PartnerContact>(entity =>
            {
                entity.HasKey(e => e.ContactID);

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.AsignedtoGroup).HasDefaultValueSql("((0))");

                entity.Property(e => e.AsignedtoGroupID).HasMaxLength(50);

                entity.Property(e => e.AsignedtoUser).HasDefaultValueSql("((0))");

                entity.Property(e => e.AsignedtoUserID).HasMaxLength(50);

                entity.Property(e => e.Attached).HasColumnType("ntext");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CellPhone).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.ContactType).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EnglishName).HasMaxLength(255);

                entity.Property(e => e.FieldInterested).HasMaxLength(4000);

                entity.Property(e => e.FristName).HasMaxLength(50);

                entity.Property(e => e.Industry).HasMaxLength(50);

                entity.Property(e => e.Inlist).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobTitle).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LeadSource).HasMaxLength(50);

                entity.Property(e => e.LeadStatus).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.Onomatology).HasMaxLength(50);

                entity.Property(e => e.POBox).HasMaxLength(50);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.Rating).HasMaxLength(50);

                entity.Property(e => e.Sexual).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Street).HasMaxLength(255);

                entity.Property(e => e.Taxcode).HasMaxLength(50);

                entity.Property(e => e.TelNo).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.PartnerContact)
                    .HasForeignKey(d => d.PartnerID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PartnerContact_Partners");
            });

            modelBuilder.Entity<PartnerContactAttachedFiles>(entity =>
            {
                entity.HasKey(e => e.FieldKey);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FieldKeyLinked).HasMaxLength(50);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<PartnerIDMaker>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.tempID, "tempID");

                entity.Property(e => e.ReportName).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.tempID).HasMaxLength(50);
            });

            modelBuilder.Entity<PartnerTransactions>(entity =>
            {
                entity.HasKey(e => e.TransID);

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.Attached).HasColumnType("ntext");

                entity.Property(e => e.Category).HasMaxLength(255);

                entity.Property(e => e.CompanyContact).HasMaxLength(255);

                entity.Property(e => e.Competitor).HasMaxLength(255);

                entity.Property(e => e.DateInput).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DateRead).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FieldInterested).HasMaxLength(255);

                entity.Property(e => e.GuestPersonals).HasMaxLength(255);

                entity.Property(e => e.NextDateContact).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.TransStatus).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserRead).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.PartnerTransactions)
                    .HasForeignKey(d => d.PartnerID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PartnerTransactions_Partners");
            });

            modelBuilder.Entity<PartnerTransactionsAttachedFiles>(entity =>
            {
                entity.HasKey(e => e.FieldKey);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FieldKeyLinked).HasMaxLength(50);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<Partners>(entity =>
            {
                entity.HasKey(e => e.PartnerID)
                    .HasName("aaaaaPartners_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.AccRef, "AccRef_Partners");

                entity.HasIndex(e => e.Category, "Category");

                entity.HasIndex(e => e.ContactID, "ContactID");

                entity.HasIndex(e => e.ContactID, "ContactsListPartners");

                entity.HasIndex(e => e.PartnerID, "CustomerID");

                entity.HasIndex(e => e.GroupID, "GroupID");

                entity.HasIndex(e => e.HomeZipCode, "HomeZipCode");

                entity.HasIndex(e => e.InputPeople, "InputPeople");

                entity.HasIndex(e => e.Taxcode, "TaxCode");

                entity.HasIndex(e => e.WorkZipcode, "WorkZipcode");

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.AccRef).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Address2).HasMaxLength(255);

                entity.Property(e => e.AlternateMail1).HasMaxLength(150);

                entity.Property(e => e.AlternateMail2).HasMaxLength(150);

                entity.Property(e => e.Anni_Month).HasMaxLength(50);

                entity.Property(e => e.Anni_Year).HasMaxLength(50);

                entity.Property(e => e.Anni_day).HasMaxLength(50);

                entity.Property(e => e.Attached).HasColumnType("ntext");

                entity.Property(e => e.BankAccsNo).HasMaxLength(50);

                entity.Property(e => e.BankAddress).HasMaxLength(255);

                entity.Property(e => e.BankName).HasMaxLength(255);

                entity.Property(e => e.Birthday_Month).HasMaxLength(50);

                entity.Property(e => e.Birthday_Year).HasMaxLength(50);

                entity.Property(e => e.Birthday_day).HasMaxLength(50);

                entity.Property(e => e.BondActivityCode).HasMaxLength(5);

                entity.Property(e => e.BondHolderID).HasMaxLength(50);

                entity.Property(e => e.BondType).HasMaxLength(50);

                entity.Property(e => e.Category).HasMaxLength(150);

                entity.Property(e => e.Cell).HasMaxLength(50);

                entity.Property(e => e.Childrent1).HasMaxLength(150);

                entity.Property(e => e.Childrent2).HasMaxLength(150);

                entity.Property(e => e.ChildrentBirthday1).HasColumnType("datetime");

                entity.Property(e => e.ChildrentBirthday2).HasColumnType("datetime");

                entity.Property(e => e.CompIDLinked).HasMaxLength(50);

                entity.Property(e => e.Competitor).HasMaxLength(255);

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CusTypeService).HasMaxLength(50);

                entity.Property(e => e.DateConvert).HasColumnType("datetime");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Denied).HasDefaultValueSql("(0)");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.Facility).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FieldInterested).HasMaxLength(150);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Group).HasMaxLength(50);

                entity.Property(e => e.GroupID).HasMaxLength(50);

                entity.Property(e => e.GroupType).HasMaxLength(150);

                entity.Property(e => e.HighlightBestMonths).HasMaxLength(50);

                entity.Property(e => e.HomeAddress).HasMaxLength(150);

                entity.Property(e => e.HomeCity).HasMaxLength(150);

                entity.Property(e => e.HomeCountry).HasMaxLength(150);

                entity.Property(e => e.HomeState).HasMaxLength(150);

                entity.Property(e => e.HomeZipCode).HasMaxLength(150);

                entity.Property(e => e.Homephone).HasMaxLength(50);

                entity.Property(e => e.Industry).HasMaxLength(50);

                entity.Property(e => e.InputPeople).HasMaxLength(50);

                entity.Property(e => e.InvestStyle).HasMaxLength(50);

                entity.Property(e => e.JobTitle).HasMaxLength(150);

                entity.Property(e => e.Lastname).HasMaxLength(50);

                entity.Property(e => e.LegalCapitalCurr).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(150);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.NickName).HasMaxLength(50);

                entity.Property(e => e.NoDebt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.NotesLess).HasMaxLength(255);

                entity.Property(e => e.OnlineChat).HasMaxLength(150);

                entity.Property(e => e.OtherPhone).HasMaxLength(255);

                entity.Property(e => e.PartnerName)
                    .HasMaxLength(150)
                    .HasComment("Company name");

                entity.Property(e => e.PartnerName2)
                    .HasMaxLength(150)
                    .HasComment("Company name");

                entity.Property(e => e.PartnerName3).HasMaxLength(255);

                entity.Property(e => e.PartnerRating).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PaymentTerm).HasDefaultValueSql("(0)");

                entity.Property(e => e.PersonalContact).HasMaxLength(150);

                entity.Property(e => e.PhonePager).HasMaxLength(150);

                entity.Property(e => e.PotentialCS).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesmanDateAssigned).HasColumnType("datetime");

                entity.Property(e => e.Spouse).HasMaxLength(150);

                entity.Property(e => e.SpouseBirthday).HasColumnType("datetime");

                entity.Property(e => e.SwiftCode).HasMaxLength(50);

                entity.Property(e => e.Taxcode).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.VIP).HasMaxLength(255);

                entity.Property(e => e.Warning).HasDefaultValueSql("(0)");

                entity.Property(e => e.WarningMasg).HasMaxLength(255);

                entity.Property(e => e.Website).HasMaxLength(150);

                entity.Property(e => e.WorkAddress).HasMaxLength(150);

                entity.Property(e => e.WorkCity).HasMaxLength(150);

                entity.Property(e => e.WorkState).HasMaxLength(150);

                entity.Property(e => e.WorkZipcode).HasMaxLength(150);

                entity.Property(e => e.Workphone).HasMaxLength(50);
            });

            modelBuilder.Entity<PartnersAttachedFiles>(entity =>
            {
                entity.HasKey(e => e.FieldKey);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PartnerID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<PartnersCARRIER>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccRef).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Address2).HasMaxLength(255);

                entity.Property(e => e.AlternateMail1).HasMaxLength(150);

                entity.Property(e => e.AlternateMail2).HasMaxLength(150);

                entity.Property(e => e.Anni_Month).HasMaxLength(50);

                entity.Property(e => e.Anni_Year).HasMaxLength(50);

                entity.Property(e => e.Anni_day).HasMaxLength(50);

                entity.Property(e => e.BankAccsNo).HasMaxLength(50);

                entity.Property(e => e.BankAddress).HasMaxLength(255);

                entity.Property(e => e.BankName).HasMaxLength(255);

                entity.Property(e => e.Birthday_Month).HasMaxLength(50);

                entity.Property(e => e.Birthday_Year).HasMaxLength(50);

                entity.Property(e => e.Birthday_day).HasMaxLength(50);

                entity.Property(e => e.Category).HasMaxLength(150);

                entity.Property(e => e.Cell).HasMaxLength(50);

                entity.Property(e => e.Childrent1).HasMaxLength(150);

                entity.Property(e => e.Childrent2).HasMaxLength(150);

                entity.Property(e => e.ChildrentBirthday1).HasColumnType("datetime");

                entity.Property(e => e.ChildrentBirthday2).HasColumnType("datetime");

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CusTypeService).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasMaxLength(50);

                entity.Property(e => e.DateModify).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FieldInterested).HasMaxLength(150);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Group).HasMaxLength(50);

                entity.Property(e => e.GroupID).HasMaxLength(50);

                entity.Property(e => e.GroupType).HasMaxLength(150);

                entity.Property(e => e.HomeAddress).HasMaxLength(150);

                entity.Property(e => e.HomeCity).HasMaxLength(150);

                entity.Property(e => e.HomeCountry).HasMaxLength(150);

                entity.Property(e => e.HomeState).HasMaxLength(150);

                entity.Property(e => e.HomeZipCode).HasMaxLength(150);

                entity.Property(e => e.Homephone).HasMaxLength(50);

                entity.Property(e => e.InputPeople).HasMaxLength(50);

                entity.Property(e => e.JobTitle).HasMaxLength(150);

                entity.Property(e => e.Lastname).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(150);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.NickName).HasMaxLength(50);

                entity.Property(e => e.Notes)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NotesLess).HasMaxLength(255);

                entity.Property(e => e.OnlineChat).HasMaxLength(150);

                entity.Property(e => e.OtherPhone).HasMaxLength(255);

                entity.Property(e => e.PartnerID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PartnerName).HasMaxLength(150);

                entity.Property(e => e.PartnerName2).HasMaxLength(150);

                entity.Property(e => e.PartnerName3).HasMaxLength(255);

                entity.Property(e => e.PersonalContact).HasMaxLength(150);

                entity.Property(e => e.PhonePager).HasMaxLength(150);

                entity.Property(e => e.Spouse).HasMaxLength(150);

                entity.Property(e => e.SpouseBirthday).HasColumnType("datetime");

                entity.Property(e => e.SwiftCode).HasMaxLength(50);

                entity.Property(e => e.Taxcode).HasMaxLength(50);

                entity.Property(e => e.VIP).HasMaxLength(255);

                entity.Property(e => e.WarningMasg).HasMaxLength(255);

                entity.Property(e => e.Website).HasMaxLength(150);

                entity.Property(e => e.WorkAddress).HasMaxLength(150);

                entity.Property(e => e.WorkCity).HasMaxLength(150);

                entity.Property(e => e.WorkState).HasMaxLength(150);

                entity.Property(e => e.WorkZipcode).HasMaxLength(150);

                entity.Property(e => e.Workphone).HasMaxLength(50);
            });

            modelBuilder.Entity<PartnersCargo>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ACNotes).HasMaxLength(255);

                entity.Property(e => e.ACNotesCRBy).HasMaxLength(50);

                entity.Property(e => e.ACNotesCRDate).HasColumnType("datetime");

                entity.Property(e => e.ACNotesPre).HasMaxLength(255);

                entity.Property(e => e.ACNotesPreBy).HasMaxLength(255);

                entity.Property(e => e.ACNotesPreDate).HasColumnType("datetime");

                entity.Property(e => e.ACOthers).HasMaxLength(255);

                entity.Property(e => e.Agent).HasMaxLength(50);

                entity.Property(e => e.Attached).HasColumnType("ntext");

                entity.Property(e => e.CDSTransfer).HasMaxLength(255);

                entity.Property(e => e.CO).HasDefaultValueSql("((0))");

                entity.Property(e => e.CUSTOMS).HasDefaultValueSql("((0))");

                entity.Property(e => e.CUSTOMSNotes).HasMaxLength(255);

                entity.Property(e => e.CUSTOMSNotesCustomer).HasMaxLength(255);

                entity.Property(e => e.Clearance).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContainerType).HasMaxLength(50);

                entity.Property(e => e.ContractNo).HasMaxLength(50);

                entity.Property(e => e.CreditTerm).HasMaxLength(50);

                entity.Property(e => e.CustomsOffice).HasMaxLength(50);

                entity.Property(e => e.CustomsOthers).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateCreatedCS).HasColumnType("datetime");

                entity.Property(e => e.DateCreatedFN).HasColumnType("datetime");

                entity.Property(e => e.DateCreatedOPS).HasColumnType("datetime");

                entity.Property(e => e.DateCreatedTT).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateModifiedCS).HasColumnType("datetime");

                entity.Property(e => e.DateModifiedFN).HasColumnType("datetime");

                entity.Property(e => e.DateModifiedOPS).HasColumnType("datetime");

                entity.Property(e => e.DateModifiedTT).HasColumnType("datetime");

                entity.Property(e => e.Debt).HasDefaultValueSql("((0))");

                entity.Property(e => e.DebtDuration).HasMaxLength(50);

                entity.Property(e => e.DeliveryAddr).HasMaxLength(255);

                entity.Property(e => e.EmailAddr).HasMaxLength(255);

                entity.Property(e => e.FreetimeRequest).HasMaxLength(50);

                entity.Property(e => e.Fumi).HasDefaultValueSql("((0))");

                entity.Property(e => e.GoodsDescription).HasMaxLength(255);

                entity.Property(e => e.GoodsType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HSCode).HasMaxLength(50);

                entity.Property(e => e.HTCBInvoiceCustomer).HasDefaultValueSql("((0))");

                entity.Property(e => e.IMPEXType).HasMaxLength(50);

                entity.Property(e => e.LiffONOFFInvoiceCustomer).HasDefaultValueSql("((0))");

                entity.Property(e => e.Liner).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.NotesCRBy).HasMaxLength(50);

                entity.Property(e => e.NotesCRDate).HasColumnType("datetime");

                entity.Property(e => e.NotesPre).HasMaxLength(255);

                entity.Property(e => e.NotesPreBy).HasMaxLength(50);

                entity.Property(e => e.NotesPreDate).HasColumnType("datetime");

                entity.Property(e => e.POD).HasMaxLength(150);

                entity.Property(e => e.PODTerminal).HasMaxLength(150);

                entity.Property(e => e.POL).HasMaxLength(150);

                entity.Property(e => e.POLTerminal).HasMaxLength(150);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.Phyto).HasDefaultValueSql("((0))");

                entity.Property(e => e.PickupAddr).HasMaxLength(255);

                entity.Property(e => e.PriceRequest).HasDefaultValueSql("((0))");

                entity.Property(e => e.QualityCheck).HasDefaultValueSql("((0))");

                entity.Property(e => e.SEA).HasDefaultValueSql("((0))");

                entity.Property(e => e.SEANotes).HasMaxLength(255);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TRUCK).HasDefaultValueSql("((0))");

                entity.Property(e => e.TRUCKNotes).HasMaxLength(255);

                entity.Property(e => e.Temperature).HasMaxLength(50);

                entity.Property(e => e.Thread).HasMaxLength(50);

                entity.Property(e => e.UpdateType).HasMaxLength(50);

                entity.Property(e => e.UserCreated).HasMaxLength(50);

                entity.Property(e => e.UserCreatedCS).HasMaxLength(50);

                entity.Property(e => e.UserCreatedFN).HasMaxLength(50);

                entity.Property(e => e.UserCreatedOPS).HasMaxLength(50);

                entity.Property(e => e.UserCreatedTT).HasMaxLength(50);

                entity.Property(e => e.UserEdited).HasMaxLength(50);

                entity.Property(e => e.VATAddress).HasMaxLength(255);

                entity.Property(e => e.VATEmailAddr).HasMaxLength(255);

                entity.Property(e => e.VATInvName).HasMaxLength(255);

                entity.Property(e => e.VATTaxcode).HasMaxLength(50);

                entity.Property(e => e.Ventilation).HasMaxLength(50);

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.PartnersCargo)
                    .HasForeignKey(d => d.PartnerID)
                    .HasConstraintName("FK_PartnersCargo_Partners");
            });

            modelBuilder.Entity<PartnersCargoAttachedFiles>(entity =>
            {
                entity.HasKey(e => e.FieldKey);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<PartnersEDIMapping>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EDIPartnerID).HasMaxLength(50);

                entity.Property(e => e.EDIPartnerName).HasMaxLength(255);

                entity.Property(e => e.PartnerIDMapped).HasMaxLength(50);
            });

            modelBuilder.Entity<PersonalProfile>(entity =>
            {
                entity.HasKey(e => e.CmpID)
                    .HasName("aaaaaPersonalProfile_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.CmpID, "CmpID");

                entity.HasIndex(e => e.Group, "ContactID");

                entity.HasIndex(e => e.IbanCode, "IbanCode");

                entity.HasIndex(e => e.SwiftCode, "SwiftCode");

                entity.HasIndex(e => e.Taxcode, "Taxcode");

                entity.Property(e => e.CmpID).HasMaxLength(50);

                entity.Property(e => e.AccountName).HasMaxLength(150);

                entity.Property(e => e.AccountNote).HasMaxLength(150);

                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.Address2).HasMaxLength(150);

                entity.Property(e => e.AddressLocal).HasMaxLength(255);

                entity.Property(e => e.BankAddress).HasMaxLength(255);

                entity.Property(e => e.BankName).HasMaxLength(150);

                entity.Property(e => e.City).HasMaxLength(150);

                entity.Property(e => e.CompanyLocal).HasMaxLength(150);

                entity.Property(e => e.Companyname).HasMaxLength(150);

                entity.Property(e => e.ContactInfo).HasMaxLength(50);

                entity.Property(e => e.DaysofReLock).HasDefaultValueSql("(1)");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmpPhotoSize).HasMaxLength(255);

                entity.Property(e => e.ExportLockDays).HasDefaultValueSql("(5)");

                entity.Property(e => e.FNAccountNo).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Group).HasMaxLength(50);

                entity.Property(e => e.IbanCode).HasMaxLength(50);

                entity.Property(e => e.ImportLockDays).HasDefaultValueSql("(5)");

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.Paymentterms).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(150);

                entity.Property(e => e.SwiftCode).HasMaxLength(50);

                entity.Property(e => e.Taxcode).HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.VNAccountNo).HasMaxLength(50);

                entity.Property(e => e.Website).HasMaxLength(50);

                entity.Property(e => e.YearInstall).HasMaxLength(50);

                entity.Property(e => e.YearInstallTrue).HasMaxLength(50);

                entity.Property(e => e.ZipCode).HasMaxLength(150);
            });

            modelBuilder.Entity<PhieuThuChi>(entity =>
            {
                entity.HasKey(e => e.Maso)
                    .HasName("aaaaaPhieuThuChi_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.PartnerID, "PartnerID");

                entity.HasIndex(e => e.PartnerID, "PartnersPhieuThuChi");

                entity.HasIndex(e => e.MaLoaiPhieu, "PhieuThuChiPLPhieuThuChi");

                entity.Property(e => e.Maso).HasMaxLength(50);

                entity.Property(e => e.AdvanceVC).HasDefaultValueSql("((0))");

                entity.Property(e => e.BFAllocationRefNo).HasMaxLength(50);

                entity.Property(e => e.BangChu).HasMaxLength(255);

                entity.Property(e => e.BankRefNo).HasMaxLength(50);

                entity.Property(e => e.CashChecked).HasDefaultValueSql("((0))");

                entity.Property(e => e.CashComment).HasMaxLength(255);

                entity.Property(e => e.CashFlowCode).HasMaxLength(50);

                entity.Property(e => e.CashedUser).HasMaxLength(50);

                entity.Property(e => e.Cashier).HasMaxLength(50);

                entity.Property(e => e.ChangeDateTime).HasColumnType("datetime");

                entity.Property(e => e.ChargesInside).HasDefaultValueSql("((0))");

                entity.Property(e => e.ChargesOutside).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.ConnectStringOrigin).HasMaxLength(1000);

                entity.Property(e => e.DateChecked).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DebitedAC).HasMaxLength(50);

                entity.Property(e => e.Description2).HasMaxLength(4000);

                entity.Property(e => e.Diachi).HasMaxLength(255);

                entity.Property(e => e.Diengiai).HasColumnType("ntext");

                entity.Property(e => e.Donvi).HasMaxLength(255);

                entity.Property(e => e.GLCode).HasMaxLength(50);

                entity.Property(e => e.GainLossCalc).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ghichu).HasMaxLength(255);

                entity.Property(e => e.GroupRefID).HasMaxLength(50);

                entity.Property(e => e.Hinhthuc).HasMaxLength(50);

                entity.Property(e => e.ImportedDate).HasColumnType("datetime");

                entity.Property(e => e.LinkedDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LoaiTien).HasMaxLength(50);

                entity.Property(e => e.LoaitienNT).HasMaxLength(50);

                entity.Property(e => e.Log).HasMaxLength(4000);

                entity.Property(e => e.Lydo).HasMaxLength(150);

                entity.Property(e => e.MaLoaiPhieu).HasMaxLength(50);

                entity.Property(e => e.MarkImported).HasDefaultValueSql("((0))");

                entity.Property(e => e.MasoRefNo).HasMaxLength(50);

                entity.Property(e => e.MidBankName).HasMaxLength(255);

                entity.Property(e => e.MidBankSwiftCode).HasMaxLength(255);

                entity.Property(e => e.MultiACRefNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.Nguoilap).HasMaxLength(50);

                entity.Property(e => e.Nguoinoptien).HasMaxLength(150);

                entity.Property(e => e.OriginRefNo).HasMaxLength(50);

                entity.Property(e => e.OtherRefNo).HasMaxLength(50);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.PayrollRefNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PrintedDate).HasColumnType("datetime");

                entity.Property(e => e.RMUpdatedUser).HasMaxLength(50);

                entity.Property(e => e.RealPartnerID).HasMaxLength(50);

                entity.Property(e => e.ReceiverAccountNo).HasMaxLength(255);

                entity.Property(e => e.ReceiverBank).HasMaxLength(255);

                entity.Property(e => e.ReceiverBankAddress).HasMaxLength(255);

                entity.Property(e => e.ReceiverSwiftCode).HasMaxLength(50);

                entity.Property(e => e.ReportName).HasMaxLength(50);

                entity.Property(e => e.ReportTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.Roundable).HasDefaultValueSql("((0))");

                entity.Property(e => e.SOANo).HasMaxLength(50);

                entity.Property(e => e.SoTaikhoan).HasMaxLength(50);

                entity.Property(e => e.Sotien).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tygia).HasDefaultValueSql("((0))");

                entity.Property(e => e.TypeID).HasMaxLength(50);

                entity.Property(e => e.VCLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.VCLockDate).HasColumnType("datetime");

                entity.Property(e => e.VCOpenTrans).HasMaxLength(4000);

                entity.Property(e => e.WareHID).HasMaxLength(50);

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.PhieuThuChi)
                    .HasForeignKey(d => d.PartnerID)
                    .HasConstraintName("PhieuThuChi_FK00");
            });

            modelBuilder.Entity<PhieuThuChiDetail>(entity =>
            {
                entity.HasKey(e => new { e.MasoPhieu, e.Taikhoan, e.SIndex });

                entity.Property(e => e.MasoPhieu).HasMaxLength(50);

                entity.Property(e => e.Taikhoan).HasMaxLength(50);

                entity.Property(e => e.ApplyNew).HasDefaultValueSql("((0))");

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DNNo).HasMaxLength(255);

                entity.Property(e => e.DepCode).HasMaxLength(50);

                entity.Property(e => e.DiaChiDonVi).HasMaxLength(255);

                entity.Property(e => e.DienGiai).HasMaxLength(255);

                entity.Property(e => e.GainLoss).HasDefaultValueSql("((0))");

                entity.Property(e => e.HBLNo).HasMaxLength(255);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.JobNo).HasMaxLength(255);

                entity.Property(e => e.MBLNo).HasMaxLength(255);

                entity.Property(e => e.MaDonVi).HasMaxLength(50);

                entity.Property(e => e.OBH).HasDefaultValueSql("((0))");

                entity.Property(e => e.OBHPartnerID).HasMaxLength(50);

                entity.Property(e => e.Reduce).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeriNo).HasMaxLength(50);

                entity.Property(e => e.SotienCo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SotienCoNT).HasDefaultValueSql("((0))");

                entity.Property(e => e.SotienNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SotienNoNT).HasDefaultValueSql("((0))");

                entity.Property(e => e.TKVAT).HasDefaultValueSql("((0))");

                entity.Property(e => e.TenDonVi).HasMaxLength(255);

                entity.HasOne(d => d.MasoPhieuNavigation)
                    .WithMany(p => p.PhieuThuChiDetail)
                    .HasForeignKey(d => d.MasoPhieu)
                    .HasConstraintName("PhieuThuChiDetail_FK00");
            });

            modelBuilder.Entity<PhieuThuChiDetails>(entity =>
            {
                entity.HasKey(e => new { e.SoCT, e.KeyField });

                entity.Property(e => e.SoCT).HasMaxLength(50);

                entity.Property(e => e.KeyField).HasMaxLength(50);

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DepCode).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.DoituongVAT).HasMaxLength(255);

                entity.Property(e => e.HBLNo).HasMaxLength(50);

                entity.Property(e => e.IndexKeySource).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InvoiceID).HasMaxLength(50);

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.JobID).HasMaxLength(50);

                entity.Property(e => e.KeyFieldSource).HasMaxLength(50);

                entity.Property(e => e.MSTVAT).HasMaxLength(50);

                entity.Property(e => e.MaDoituongOBH).HasMaxLength(50);

                entity.Property(e => e.MathangVAT).HasMaxLength(255);

                entity.Property(e => e.NgayHD).HasColumnType("datetime");

                entity.Property(e => e.Reduce).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.SoHD).HasMaxLength(50);

                entity.Property(e => e.SoSeriVAT).HasMaxLength(50);

                entity.Property(e => e.SoTKDU).HasMaxLength(50);

                entity.Property(e => e.SoTKGainLoss).HasMaxLength(50);

                entity.Property(e => e.SoTKOBH).HasMaxLength(50);

                entity.Property(e => e.SoTKVAT).HasMaxLength(50);

                entity.Property(e => e.Source_data).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.HasOne(d => d.SoCTNavigation)
                    .WithMany(p => p.PhieuThuChiDetails)
                    .HasForeignKey(d => d.SoCT)
                    .HasConstraintName("FK_PhieuThuChiDetails_PhieuThuChi");
            });

            modelBuilder.Entity<PhieuThuChiMULTI>(entity =>
            {
                entity.HasKey(e => e.IDKEY);

                entity.Property(e => e.IDKEY)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ACDescription).HasMaxLength(255);

                entity.Property(e => e.DATECREATE).HasColumnType("datetime");

                entity.Property(e => e.DATEMODIFY).HasColumnType("datetime");

                entity.Property(e => e.NOTES).HasMaxLength(255);

                entity.Property(e => e.Paid).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportName).HasMaxLength(50);

                entity.Property(e => e.USEREDIT).HasMaxLength(50);

                entity.Property(e => e.VCDATE).HasColumnType("datetime");

                entity.Property(e => e.VoucherNo).HasMaxLength(50);
            });

            modelBuilder.Entity<PhieuThuChiMULTIDT>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ACCode).HasMaxLength(50);

                entity.Property(e => e.ACNAME).HasMaxLength(255);

                entity.Property(e => e.ACNO).HasMaxLength(50);

                entity.Property(e => e.ACREF).HasMaxLength(50);

                entity.Property(e => e.CURR).HasMaxLength(50);

                entity.Property(e => e.DATECREATE).HasColumnType("datetime");

                entity.Property(e => e.DATEMODIFY).HasColumnType("datetime");

                entity.Property(e => e.GroupID).HasMaxLength(50);

                entity.Property(e => e.HBLNO).HasMaxLength(50);

                entity.Property(e => e.IDLINKED).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.INVNO).HasMaxLength(50);

                entity.Property(e => e.JBOBNO).HasMaxLength(50);

                entity.Property(e => e.KEYFIELD).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OBHM).HasDefaultValueSql("((0))");

                entity.Property(e => e.PARTNERID).HasMaxLength(50);

                entity.Property(e => e.TSOURCE).HasMaxLength(50);

                entity.Property(e => e.USERINPUTED).HasMaxLength(50);

                entity.Property(e => e.VATINDATEREPORT).HasColumnType("datetime");

                entity.Property(e => e.VATINVDATE).HasColumnType("datetime");

                entity.Property(e => e.VATINVID).HasMaxLength(50);

                entity.Property(e => e.VATINVNO).HasMaxLength(50);

                entity.Property(e => e.VATINVSERINO).HasMaxLength(50);

                entity.Property(e => e.VATM).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IDLINKEDNavigation)
                    .WithMany(p => p.PhieuThuChiMULTIDT)
                    .HasForeignKey(d => d.IDLINKED)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PhieuThuChiMULTIDT_PhieuThuChiMULTI");

                entity.HasOne(d => d.PARTNER)
                    .WithMany(p => p.PhieuThuChiMULTIDT)
                    .HasForeignKey(d => d.PARTNERID)
                    .HasConstraintName("FK_PhieuThuChiMULTIDT_Partners");
            });

            modelBuilder.Entity<PhieuThuChiPL>(entity =>
            {
                entity.HasKey(e => e.MaLoai)
                    .HasName("aaaaaPhieuThuChiPL_PK")
                    .IsClustered(false);

                entity.Property(e => e.MaLoai).HasMaxLength(50);

                entity.Property(e => e.AccountReferrence).HasMaxLength(255);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasMaxLength(255);

                entity.Property(e => e.TenLoai).HasMaxLength(255);
            });

            modelBuilder.Entity<PhieuThuChiPLDetail>(entity =>
            {
                entity.HasKey(e => e.MaLoaiPhi)
                    .HasName("aaaaaPhieuThuChiPLDetail_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.MaLoai, "PhieuThuChiPLPhieuThuChiPLDetail");

                entity.Property(e => e.MaLoaiPhi).HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasMaxLength(255);

                entity.Property(e => e.MaLoai).HasMaxLength(50);

                entity.Property(e => e.TenLoaiPhi).HasMaxLength(255);

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.PhieuThuChiPLDetail)
                    .HasForeignKey(d => d.MaLoai)
                    .HasConstraintName("PhieuThuChiPLDetail_FK00");
            });

            modelBuilder.Entity<PhieuThuChiTaxReport>(entity =>
            {
                entity.HasKey(e => e.KeyfieldID);

                entity.Property(e => e.KeyfieldID).HasMaxLength(50);

                entity.Property(e => e.DateofReport).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DtSource).HasMaxLength(50);

                entity.Property(e => e.ExportLog).HasMaxLength(1000);

                entity.Property(e => e.HBLNo).HasMaxLength(50);

                entity.Property(e => e.INVLink).HasMaxLength(500);

                entity.Property(e => e.InvDate).HasColumnType("datetime");

                entity.Property(e => e.InvSection).HasMaxLength(50);

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.Kindof).HasMaxLength(50);

                entity.Property(e => e.MBLNo).HasMaxLength(50);

                entity.Property(e => e.MultRefNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.OBH).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartnerName).HasMaxLength(255);

                entity.Property(e => e.PartnerTaxCode).HasMaxLength(255);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.SeriesID).HasMaxLength(50);

                entity.Property(e => e.TaxDateExport).HasColumnType("datetime");

                entity.Property(e => e.TaxExported).HasDefaultValueSql("((0))");

                entity.Property(e => e.VATNull).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.RefNoNavigation)
                    .WithMany(p => p.PhieuThuChiTaxReport)
                    .HasForeignKey(d => d.RefNo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PhieuThuChiTaxReport_PhieuThuChi");
            });

            modelBuilder.Entity<PriceCenterDetails>(entity =>
            {
                entity.HasKey(e => new { e.PriceID, e.Description })
                    .HasName("aaaaaPriceCenterDetails_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.PriceID, "PriceCentersPriceCenterDetails");

                entity.HasIndex(e => e.PriceID, "PriceID");

                entity.Property(e => e.PriceID).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.BAF).HasMaxLength(50);

                entity.Property(e => e.C20DC).HasMaxLength(50);

                entity.Property(e => e.C20RF).HasMaxLength(50);

                entity.Property(e => e.C40DC).HasMaxLength(50);

                entity.Property(e => e.C40HC).HasMaxLength(50);

                entity.Property(e => e.C40RF).HasMaxLength(50);

                entity.Property(e => e.CAF).HasMaxLength(50);

                entity.Property(e => e.FREQ).HasMaxLength(50);

                entity.Property(e => e.ISPS).HasMaxLength(50);

                entity.Property(e => e.LCL).HasMaxLength(50);

                entity.Property(e => e.PortofDestination).HasMaxLength(150);

                entity.Property(e => e.TT).HasMaxLength(50);

                entity.Property(e => e.TypeMode).HasMaxLength(150);

                entity.Property(e => e.ZoneLA).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneLB).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneLC).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneLD).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneLE).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneLF).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneLG).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneLH).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Price)
                    .WithMany(p => p.PriceCenterDetails)
                    .HasForeignKey(d => d.PriceID)
                    .HasConstraintName("PriceCenterDetails_FK00");
            });

            modelBuilder.Entity<PriceCenters>(entity =>
            {
                entity.HasKey(e => e.PriceID)
                    .HasName("aaaaaPriceCenters_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ColoaderID, "ColoaderID");

                entity.HasIndex(e => e.ColoaderID, "PartnersPriceCenters");

                entity.HasIndex(e => e.PriceID, "PriceID");

                entity.Property(e => e.PriceID).HasMaxLength(50);

                entity.Property(e => e.AdditionalNote).HasColumnType("ntext");

                entity.Property(e => e.ColoaderID).HasMaxLength(50);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.IssueBy).HasMaxLength(50);

                entity.Property(e => e.ServiceMode).HasMaxLength(50);

                entity.Property(e => e.ValidDate).HasColumnType("datetime");

                entity.HasOne(d => d.Coloader)
                    .WithMany(p => p.PriceCenters)
                    .HasForeignKey(d => d.ColoaderID)
                    .HasConstraintName("PriceCenters_FK00");
            });

            modelBuilder.Entity<ProductMaintenance>(entity =>
            {
                entity.HasKey(e => new { e.MID, e.ProductID })
                    .HasName("aaaaaProductMaintenance_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.MID, "MID");

                entity.HasIndex(e => e.ProductID, "ProductID");

                entity.HasIndex(e => e.ProductID, "ProductsProductMaintenance");

                entity.Property(e => e.ProductID).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DocNo).HasMaxLength(50);

                entity.Property(e => e.MDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.Solution).HasMaxLength(255);

                entity.Property(e => e.Transactions).HasColumnType("ntext");

                entity.Property(e => e.outlay).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductMaintenance)
                    .HasForeignKey(d => d.ProductID)
                    .HasConstraintName("ProductMaintenance_FK00");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductID)
                    .HasName("aaaaaProducts_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.Managed, "ContactsListProducts");

                entity.HasIndex(e => e.ProductID, "ProductID");

                entity.Property(e => e.ProductID).HasMaxLength(50);

                entity.Property(e => e.BuyingDate).HasColumnType("datetime");

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.Managed).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.Original).HasMaxLength(255);

                entity.Property(e => e.ProBelong).HasMaxLength(50);

                entity.Property(e => e.ProValue).HasDefaultValueSql("(0)");

                entity.Property(e => e.ProductDescription).HasMaxLength(255);

                entity.HasOne(d => d.ManagedNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Managed)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Products_FK00");
            });

            modelBuilder.Entity<ProfitShareCalc>(entity =>
            {
                entity.HasKey(e => e.RefNo)
                    .HasName("PK_ProfitShareCalc_1");

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.AccountRef).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.HBLList).HasMaxLength(255);

                entity.Property(e => e.IDKeyIndex)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.Modify).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.ProfitShareDesc).HasMaxLength(255);

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.ProfitShareCalc)
                    .HasForeignKey(d => d.PartnerID)
                    .HasConstraintName("FK_ProfitShareCalc_Partners");

                entity.HasOne(d => d.Trans)
                    .WithMany(p => p.ProfitShareCalc)
                    .HasForeignKey(d => d.TransID)
                    .HasConstraintName("FK_ProfitShareCalc_Transactions");
            });

            modelBuilder.Entity<ProfitShareCalcDetail>(entity =>
            {
                entity.HasKey(e => e.FieldKeyID)
                    .HasName("PK_ProfitShareCalc");

                entity.Property(e => e.FieldKeyID).HasMaxLength(50);

                entity.Property(e => e.Collect).HasDefaultValueSql("((0))");

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.Dbt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.GroupName).HasMaxLength(255);

                entity.Property(e => e.HBLNo).HasMaxLength(50);

                entity.Property(e => e.Linkto).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OBH).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.HasOne(d => d.RefNoNavigation)
                    .WithMany(p => p.ProfitShareCalcDetail)
                    .HasForeignKey(d => d.RefNo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProfitShareCalcDetail_ProfitShareCalc");
            });

            modelBuilder.Entity<ProfitShares>(entity =>
            {
                entity.HasKey(e => new { e.HAWBNO, e.PartnerID, e.QUnit, e.Notes, e.Dpt })
                    .HasName("aaaaaProfitShares_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.CostSheetIDLinked, "CostSheetIDLinked");

                entity.HasIndex(e => e.CostSheetIDLinked, "CostSheetIDLinked_ProfitShares");

                entity.HasIndex(e => e.DataInput, "DataInput_ProfitShares");

                entity.HasIndex(e => e.Docs, "Docs_ProfitShares");

                entity.HasIndex(e => e.FieldKey, "FieldKey_ProfitShares");

                entity.HasIndex(e => e.HAWBNO, "HAWBProfitShares");

                entity.HasIndex(e => e.IDKeyLinked, "IDKeyLinked_ProfitShares");

                entity.HasIndex(e => e.InoiceNo, "InoiceNo_ProfitShares");

                entity.HasIndex(e => e.MTKeyLinked, "MTKeyLinked_ProfitShares");

                entity.HasIndex(e => e.OBHFieldKey, "OBHFieldKey_ProfitShares");

                entity.HasIndex(e => e.OBHPartnerID, "OBHPartnerID_ProfitShares");

                entity.HasIndex(e => e.PartnerID, "PartnerID");

                entity.HasIndex(e => e.PartnerID, "PartnersProfitShares");

                entity.HasIndex(e => e.SeriNo, "SeriNo_ProfitShares");

                entity.HasIndex(e => e.SettlementRefNo, "SettlementRefNo_ProfitShares");

                entity.HasIndex(e => e.VATInvID, "VATInvID_ProfitShares");

                entity.HasIndex(e => new { e.Docs, e.VATInvID, e.SeriNo }, "VAT_ProfitShares");

                entity.HasIndex(e => e.VoucherID, "VoucherID");

                entity.HasIndex(e => e.VoucherIDSE, "VoucherIDSE_ProfitShares");

                entity.Property(e => e.HAWBNO).HasMaxLength(50);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.QUnit).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.AccsDateKey).HasColumnType("datetime");

                entity.Property(e => e.AccsUserKey).HasMaxLength(50);

                entity.Property(e => e.AdvVoucherID).HasMaxLength(50);

                entity.Property(e => e.Advanced).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.AutoDivide).HasMaxLength(50);

                entity.Property(e => e.AutoInput).HasDefaultValueSql("((0))");

                entity.Property(e => e.CC).HasDefaultValueSql("((0))");

                entity.Property(e => e.CIDIndex).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CostSheetIDLinked).HasMaxLength(50);

                entity.Property(e => e.CurrencyConvertRate).HasMaxLength(50);

                entity.Property(e => e.DataInput).HasMaxLength(50);

                entity.Property(e => e.Docs).HasMaxLength(50);

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.EqcId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtRateVND).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtVND).HasDefaultValueSql("((0))");

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.FieldName).HasMaxLength(50);

                entity.Property(e => e.FixedCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.GWHeavyW).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gainloss).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupName).HasMaxLength(150);

                entity.Property(e => e.IDKeyIndex)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IDKeyShipmentDT).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.INVSOANo).HasMaxLength(50);

                entity.Property(e => e.InoiceNo).HasMaxLength(50);

                entity.Property(e => e.InvDate).HasColumnType("datetime");

                entity.Property(e => e.MTKeyLinked).HasMaxLength(50);

                entity.Property(e => e.MUnit).HasMaxLength(50);

                entity.Property(e => e.NoInv).HasDefaultValueSql("((0))");

                entity.Property(e => e.OBHFieldKey).HasMaxLength(50);

                entity.Property(e => e.OBHLink).HasDefaultValueSql("((0))");

                entity.Property(e => e.OBHPartnerID).HasMaxLength(50);

                entity.Property(e => e.PFSNotes).HasMaxLength(255);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.RemoteCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.RemoteChargesRef).HasMaxLength(50);

                entity.Property(e => e.RequisitionID).HasMaxLength(50);

                entity.Property(e => e.SeriNo).HasMaxLength(50);

                entity.Property(e => e.SettleExisting).HasDefaultValueSql("((0))");

                entity.Property(e => e.SettleIDLinked).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SettlementRefNo).HasMaxLength(50);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.SortDes).HasMaxLength(150);

                entity.Property(e => e.TT).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserInputRCD).HasMaxLength(50);

                entity.Property(e => e.VAT).HasDefaultValueSql("((0))");

                entity.Property(e => e.VATDate).HasColumnType("datetime");

                entity.Property(e => e.VATInvID).HasMaxLength(50);

                entity.Property(e => e.VATName).HasMaxLength(255);

                entity.Property(e => e.VATSOANo).HasMaxLength(50);

                entity.Property(e => e.VATTaxCode).HasMaxLength(50);

                entity.Property(e => e.VoucherID).HasMaxLength(50);

                entity.Property(e => e.VoucherIDSE).HasMaxLength(50);
            });

            modelBuilder.Entity<ProfitSharesCost>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.AccsDateKey).HasColumnType("datetime");

                entity.Property(e => e.AccsLog).HasMaxLength(4000);

                entity.Property(e => e.AccsUserKey).HasMaxLength(50);

                entity.Property(e => e.AdvVoucherID).HasMaxLength(50);

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.AutoDivide).HasMaxLength(50);

                entity.Property(e => e.AutoInput).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostSheetIDLinked).HasMaxLength(50);

                entity.Property(e => e.CurrencyConvertRate).HasMaxLength(50);

                entity.Property(e => e.DataInput).HasMaxLength(50);

                entity.Property(e => e.Docs).HasMaxLength(50);

                entity.Property(e => e.ExtRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtRateVND).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtVND).HasDefaultValueSql("((0))");

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.FieldName).HasMaxLength(50);

                entity.Property(e => e.GWHeavyW).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupName).HasMaxLength(150);

                entity.Property(e => e.HAWBNO)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IDKeyShipmentDT).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InoiceNo).HasMaxLength(50);

                entity.Property(e => e.NoInv).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OBHPartnerID).HasMaxLength(50);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PartnerID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.QUnit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeriNo).HasMaxLength(50);

                entity.Property(e => e.SettlementRefNo).HasMaxLength(50);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.SortDes).HasMaxLength(150);

                entity.Property(e => e.TotalValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserInputRCD).HasMaxLength(50);

                entity.Property(e => e.VAT).HasDefaultValueSql("((0))");

                entity.Property(e => e.VATName).HasMaxLength(255);

                entity.Property(e => e.VATTaxCode).HasMaxLength(50);

                entity.Property(e => e.VoucherID).HasMaxLength(50);

                entity.Property(e => e.VoucherIDSE).HasMaxLength(50);

                entity.HasOne(d => d.HAWBNONavigation)
                    .WithMany(p => p.ProfitSharesCost)
                    .HasForeignKey(d => d.HAWBNO)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfitSharesCost_HAWB");
            });

            modelBuilder.Entity<QUOTATIONDETAILS>(entity =>
            {
                entity.HasKey(e => new { e.QuotationID, e.Nameofservice });

                entity.HasIndex(e => e.QuotationID, "QUOTATIONSQUOTATIONDETAILS1");

                entity.HasIndex(e => e.QuotationID, "QuotationID");

                entity.Property(e => e.QuotationID).HasMaxLength(50);

                entity.Property(e => e.Nameofservice)
                    .HasMaxLength(150)
                    .HasComment("Weightable");

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.Fee).HasDefaultValueSql("((0))");

                entity.Property(e => e.Level1TACT).HasMaxLength(50);

                entity.Property(e => e.Level2TACT).HasMaxLength(50);

                entity.Property(e => e.Level3TACT).HasMaxLength(50);

                entity.Property(e => e.Level4TACT).HasMaxLength(50);

                entity.Property(e => e.Level5TACT).HasMaxLength(50);

                entity.Property(e => e.Level6TACT).HasMaxLength(50);

                entity.Property(e => e.Level7TACT).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OBH).HasDefaultValueSql("((0))");

                entity.Property(e => e.PricingACID).HasMaxLength(50);

                entity.Property(e => e.PricingMID).HasMaxLength(50);

                entity.Property(e => e.QuoACID).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.ZoneAdt).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneBdt).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneCdt).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneDdt).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneEdt).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneFdt).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneGdt).HasDefaultValueSql("((0))");

                entity.Property(e => e.ZoneHdt).HasDefaultValueSql("((0))");

                entity.Property(e => e.iIndex).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QUOTATIONDETAILSOTS>(entity =>
            {
                entity.HasKey(e => new { e.QuotationID, e.Nameofservice })
                    .HasName("PK_QUOTATIONDETAILS_OTS");

                entity.Property(e => e.QuotationID).HasMaxLength(50);

                entity.Property(e => e.Nameofservice)
                    .HasMaxLength(255)
                    .HasComment("Weightable");

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.Fee).HasDefaultValueSql("((0))");

                entity.Property(e => e.Level1TACT).HasMaxLength(50);

                entity.Property(e => e.Level2TACT).HasMaxLength(50);

                entity.Property(e => e.Level3TACT).HasMaxLength(50);

                entity.Property(e => e.Level4TACT).HasMaxLength(50);

                entity.Property(e => e.Level5TACT).HasMaxLength(50);

                entity.Property(e => e.Level6TACT).HasMaxLength(50);

                entity.Property(e => e.Level7TACT).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OBH).HasDefaultValueSql("((0))");

                entity.Property(e => e.PayableACID).HasMaxLength(50);

                entity.Property(e => e.PricingACID).HasMaxLength(50);

                entity.Property(e => e.PricingMID).HasMaxLength(50);

                entity.Property(e => e.QuoACID).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.iIndex).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Quotation)
                    .WithMany(p => p.QUOTATIONDETAILSOTS)
                    .HasForeignKey(d => d.QuotationID)
                    .HasConstraintName("FK_QUOTATIONDETAILS_OTS_QUOTATIONS");
            });

            modelBuilder.Entity<QUOTATIONS>(entity =>
            {
                entity.HasKey(e => e.QuotaionNo)
                    .HasName("aaaaaQUOTATIONS_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ShipperID, "PartnersQUOTATIONS");

                entity.HasIndex(e => e.QuotaionNo, "QuotaionID");

                entity.HasIndex(e => e.ShipperID, "ShipperId");

                entity.Property(e => e.QuotaionNo).HasMaxLength(50);

                entity.Property(e => e.AWB).HasMaxLength(50);

                entity.Property(e => e.Attn).HasMaxLength(255);

                entity.Property(e => e.BottomNotes).HasColumnType("ntext");

                entity.Property(e => e.ComChargeType).HasMaxLength(50);

                entity.Property(e => e.ComPartnerID).HasMaxLength(50);

                entity.Property(e => e.ComPerRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Consignee).HasMaxLength(255);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.Destination).HasMaxLength(255);

                entity.Property(e => e.Discount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FLC20).HasMaxLength(255);

                entity.Property(e => e.FLC20COOL).HasMaxLength(255);

                entity.Property(e => e.FLC40DC).HasMaxLength(255);

                entity.Property(e => e.FLC40DCCOLL).HasMaxLength(255);

                entity.Property(e => e.FLC40HC).HasMaxLength(255);

                entity.Property(e => e.FSC).HasMaxLength(255);

                entity.Property(e => e.GrossCharges).HasMaxLength(150);

                entity.Property(e => e.ImportFrom).HasMaxLength(150);

                entity.Property(e => e.ImportTo).HasMaxLength(150);

                entity.Property(e => e.LCL)
                    .HasMaxLength(255)
                    .HasComment("Less than container load");

                entity.Property(e => e.LCLCOOL).HasMaxLength(50);

                entity.Property(e => e.LCLUnit).HasMaxLength(50);

                entity.Property(e => e.LEVEL1)
                    .HasMaxLength(255)
                    .HasComment("MIN 1-10");

                entity.Property(e => e.LEVEL2)
                    .HasMaxLength(255)
                    .HasComment("<45");

                entity.Property(e => e.LEVEL3)
                    .HasMaxLength(255)
                    .HasComment("45-<100");

                entity.Property(e => e.LEVEL4)
                    .HasMaxLength(255)
                    .HasComment("100-<299");

                entity.Property(e => e.LEVEL5)
                    .HasMaxLength(255)
                    .HasComment("300-<499");

                entity.Property(e => e.LEVEL6)
                    .HasMaxLength(255)
                    .HasComment("500-<999");

                entity.Property(e => e.LEVEL7)
                    .HasMaxLength(255)
                    .HasComment("1000");

                entity.Property(e => e.MiddleNotes).HasMaxLength(255);

                entity.Property(e => e.MngApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.Modify).HasColumnType("datetime");

                entity.Property(e => e.NominatedCargo).HasDefaultValueSql("((0))");

                entity.Property(e => e.PickupAir).HasMaxLength(150);

                entity.Property(e => e.PickupCargoFCL).HasMaxLength(150);

                entity.Property(e => e.PickupCargoLCL).HasMaxLength(150);

                entity.Property(e => e.QuoHistory).HasMaxLength(4000);

                entity.Property(e => e.QuoUnit).HasMaxLength(50);

                entity.Property(e => e.QuotationDate).HasColumnType("datetime");

                entity.Property(e => e.Refno).HasMaxLength(255);

                entity.Property(e => e.Routine).HasMaxLength(150);

                entity.Property(e => e.SVInqID).HasMaxLength(50);

                entity.Property(e => e.SendApproval).HasDefaultValueSql("((0))");

                entity.Property(e => e.Service).HasMaxLength(150);

                entity.Property(e => e.ServiceMode).HasMaxLength(50);

                entity.Property(e => e.ShipperID).HasMaxLength(50);

                entity.Property(e => e.SupplierID).HasMaxLength(50);

                entity.Property(e => e.TT).HasMaxLength(255);

                entity.Property(e => e.TopNotes)
                    .HasMaxLength(255)
                    .HasComment("Express");

                entity.Property(e => e.UseAllin).HasDefaultValueSql("((0))");

                entity.Property(e => e.ValidDate).HasColumnType("datetime");

                entity.Property(e => e.WR).HasMaxLength(255);

                entity.Property(e => e.Whois)
                    .HasMaxLength(50)
                    .HasComment("userid");

                entity.Property(e => e.ZoneA).HasMaxLength(50);

                entity.Property(e => e.ZoneB).HasMaxLength(50);

                entity.Property(e => e.ZoneC).HasMaxLength(50);

                entity.Property(e => e.ZoneD).HasMaxLength(50);

                entity.Property(e => e.ZoneE).HasMaxLength(50);

                entity.Property(e => e.ZoneF).HasMaxLength(50);

                entity.Property(e => e.ZoneG).HasMaxLength(50);

                entity.Property(e => e.ZoneH).HasMaxLength(50);

                entity.Property(e => e.ZoneI).HasMaxLength(50);

                entity.Property(e => e.ZoneJ).HasMaxLength(50);

                entity.HasOne(d => d.Shipper)
                    .WithMany(p => p.QUOTATIONS)
                    .HasForeignKey(d => d.ShipperID)
                    .HasConstraintName("QUOTATIONS_FK00");
            });

            modelBuilder.Entity<QuoSentHistory>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.BookingID).HasMaxLength(50);

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.InqID).HasMaxLength(50);

                entity.Property(e => e.PCSent).HasMaxLength(50);

                entity.Property(e => e.QuoID).HasMaxLength(50);

                entity.Property(e => e.QuoMode).HasMaxLength(50);

                entity.Property(e => e.SVDate).HasColumnType("datetime");

                entity.Property(e => e.SentBy).HasMaxLength(50);
            });

            modelBuilder.Entity<QuotationFreightDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Carrier).HasMaxLength(50);

                entity.Property(e => e.CarrierID).HasMaxLength(50);

                entity.Property(e => e.Cutoff).HasMaxLength(50);

                entity.Property(e => e.FSC)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Phu phi xang dau");

                entity.Property(e => e.Freq).HasMaxLength(50);

                entity.Property(e => e.GW).HasDefaultValueSql("((0))");

                entity.Property(e => e.Level1TACT).HasMaxLength(53);

                entity.Property(e => e.Level2TACT).HasMaxLength(53);

                entity.Property(e => e.Level3TACT).HasMaxLength(53);

                entity.Property(e => e.Level4TACT).HasMaxLength(53);

                entity.Property(e => e.Level5TACT).HasMaxLength(53);

                entity.Property(e => e.Level6TACT).HasMaxLength(53);

                entity.Property(e => e.Level7TACT).HasMaxLength(53);

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.POD).HasMaxLength(50);

                entity.Property(e => e.POL).HasMaxLength(50);

                entity.Property(e => e.PricingID).HasMaxLength(50);

                entity.Property(e => e.QuoID).HasMaxLength(50);

                entity.Property(e => e.SSC)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Phu phi chuien tranh");

                entity.Property(e => e.TT).HasMaxLength(50);

                entity.Property(e => e.VendorID).HasMaxLength(50);

                entity.HasOne(d => d.Quo)
                    .WithMany()
                    .HasForeignKey(d => d.QuoID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_QuotationFreightDetail_QUOTATIONS");
            });

            modelBuilder.Entity<RateHistory>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.DescKey, "DescKey");

                entity.HasIndex(e => e.HBLNo, "HBLNo_RateHistory");

                entity.HasIndex(e => e.PartnerID, "PartnerID");

                entity.HasIndex(e => e.PartnerKey, "PartnerKey");

                entity.HasIndex(e => e.RefID, "RefID");

                entity.HasIndex(e => e.TableName, "TableName_RateHistory");

                entity.Property(e => e.Admin).HasMaxLength(50);

                entity.Property(e => e.Amount).HasDefaultValueSql("(0)");

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DataSource).HasMaxLength(50);

                entity.Property(e => e.DateProcess).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.DescKey).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ExeptionInfo).HasMaxLength(255);

                entity.Property(e => e.GWHeavyW).HasDefaultValueSql("((0))");

                entity.Property(e => e.HBLNo).HasMaxLength(50);

                entity.Property(e => e.KeyfieldData).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.OBHPartnerID).HasMaxLength(50);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.PartnerKey).HasMaxLength(50);

                entity.Property(e => e.Quantity).HasDefaultValueSql("(0)");

                entity.Property(e => e.Reason).HasMaxLength(255);

                entity.Property(e => e.RefID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TableName).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("(0)");

                entity.Property(e => e.UserInfo).HasMaxLength(50);

                entity.Property(e => e.VAT).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<RateTemp>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.TransID, "TransID");

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.HawbNo).HasMaxLength(50);

                entity.Property(e => e.TotalValue).HasDefaultValueSql("(0)");

                entity.Property(e => e.TransID).HasMaxLength(50);
            });

            modelBuilder.Entity<SMTPServerConfig>(entity =>
            {
                entity.Property(e => e.ID)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EmailSendTest).HasMaxLength(255);

                entity.Property(e => e.SMTPPassword).HasMaxLength(255);

                entity.Property(e => e.SMTPServer).HasMaxLength(255);

                entity.Property(e => e.SMTPUserName).HasMaxLength(255);
            });

            modelBuilder.Entity<SOFTEKVIEW>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SOFTEKVIEW");

                entity.Property(e => e.BranchCode).HasMaxLength(2);

                entity.Property(e => e.CDSNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.D_C).HasColumnName("D/C");

                entity.Property(e => e.DateInvoice).HasMaxLength(50);

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.DeptID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FeeCode).HasMaxLength(150);

                entity.Property(e => e.HBLNO).HasMaxLength(4000);

                entity.Property(e => e.InvDate).HasColumnType("datetime");

                entity.Property(e => e.InvID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InvNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobNo).HasMaxLength(50);

                entity.Property(e => e.MBLNO).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.PONo).HasMaxLength(50);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.PartnerName).HasMaxLength(255);

                entity.Property(e => e.RPartnerID).HasMaxLength(50);

                entity.Property(e => e.RPartnerName).HasMaxLength(255);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VATNo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<STAFFLOCATION>(entity =>
            {
                entity.HasKey(e => e.IDKey)
                    .HasName("PK__STAFFLOC__939E78BB24AAADFD");

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContactId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeviceId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UPLOADEDTIME).HasColumnType("datetime");
            });

            modelBuilder.Entity<SalesCurrencyExchange>(entity =>
            {
                entity.Property(e => e.ID).HasMaxLength(50);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.CompIDList).HasMaxLength(255);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<SalesIncentive>(entity =>
            {
                entity.HasKey(e => e.IDKeyField);

                entity.Property(e => e.IDKeyField).HasMaxLength(50);

                entity.Property(e => e.ApprovedBy).HasMaxLength(50);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.DateApp).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.UserCreated).HasMaxLength(50);
            });

            modelBuilder.Entity<SalesIncentiveDetails>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IDKeyIndex)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IDKeyLinked).HasMaxLength(50);
            });

            modelBuilder.Entity<SeaBookingContainer>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.BookingID, "TransID");

                entity.Property(e => e.BookingID).HasMaxLength(50);

                entity.Property(e => e.Container).HasMaxLength(150);

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.Qty).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<SeaBookingNote>(entity =>
            {
                entity.HasKey(e => e.BookingID)
                    .HasName("aaaaaSeaBookingNote_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ConsigneeCode, "ConsigneeCode");

                entity.HasIndex(e => e.ShipperID, "PartnersSeaBookingNote");

                entity.HasIndex(e => e.ShipperID, "ShipperID");

                entity.HasIndex(e => e.TransID, "TransID");

                entity.Property(e => e.BookingID).HasMaxLength(50);

                entity.Property(e => e.Attn).HasMaxLength(150);

                entity.Property(e => e.BKApp).HasDefaultValueSql("((0))");

                entity.Property(e => e.BKAppBy).HasMaxLength(50);

                entity.Property(e => e.BKAppComment).HasMaxLength(255);

                entity.Property(e => e.BKAppDate).HasColumnType("datetime");

                entity.Property(e => e.BlCorrection).HasMaxLength(50);

                entity.Property(e => e.CBMSea).HasDefaultValueSql("((0))");

                entity.Property(e => e.CancelBooking).HasDefaultValueSql("((0))");

                entity.Property(e => e.CancelMsg).HasMaxLength(4000);

                entity.Property(e => e.CarrierID).HasMaxLength(50);

                entity.Property(e => e.CloseTime20).HasMaxLength(50);

                entity.Property(e => e.CloseTime40).HasMaxLength(50);

                entity.Property(e => e.CloseTimeLCL).HasMaxLength(50);

                entity.Property(e => e.ClosingTimeDate).HasColumnType("datetime");

                entity.Property(e => e.Commidity).HasMaxLength(150);

                entity.Property(e => e.ConsigneeAddress).HasMaxLength(255);

                entity.Property(e => e.ConsigneeCode).HasMaxLength(50);

                entity.Property(e => e.ConsigneeName)
                    .HasMaxLength(150)
                    .HasComment("avc");

                entity.Property(e => e.ContainerNo).HasMaxLength(150);

                entity.Property(e => e.ContainerSize).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateMaking).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Deliveryat).HasMaxLength(150);

                entity.Property(e => e.DestinationDate).HasColumnType("datetime");

                entity.Property(e => e.DropoffAt).HasMaxLength(150);

                entity.Property(e => e.DropoffDate).HasColumnType("datetime");

                entity.Property(e => e.ETADest).HasColumnType("datetime");

                entity.Property(e => e.ETDTransit).HasColumnType("datetime");

                entity.Property(e => e.EmptyReturnDate).HasColumnType("datetime");

                entity.Property(e => e.EstimatedVessel).HasMaxLength(50);

                entity.Property(e => e.FDAgentID).HasMaxLength(50);

                entity.Property(e => e.FeederVessel).HasMaxLength(150);

                entity.Property(e => e.FormName).HasMaxLength(50);

                entity.Property(e => e.ForwardingAgent).HasMaxLength(50);

                entity.Property(e => e.FullLadenDate).HasColumnType("datetime");

                entity.Property(e => e.GrosWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.HBLData).HasMaxLength(50);

                entity.Property(e => e.HBLNoASGN).HasMaxLength(50);

                entity.Property(e => e.LoadingDate).HasColumnType("datetime");

                entity.Property(e => e.LotNo).HasMaxLength(50);

                entity.Property(e => e.ModeSea).HasMaxLength(50);

                entity.Property(e => e.NMPartyID).HasMaxLength(50);

                entity.Property(e => e.NominatedContainer).HasMaxLength(255);

                entity.Property(e => e.OperationCode).HasMaxLength(50);

                entity.Property(e => e.PickupAt).HasMaxLength(150);

                entity.Property(e => e.PickupDate).HasColumnType("datetime");

                entity.Property(e => e.PortofLading).HasMaxLength(150);

                entity.Property(e => e.PortofUnlading).HasMaxLength(150);

                entity.Property(e => e.Quantity).HasMaxLength(50);

                entity.Property(e => e.ReceiptAt).HasMaxLength(150);

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.ReleaseNo).HasMaxLength(50);

                entity.Property(e => e.Remark).HasColumnType("ntext");

                entity.Property(e => e.Revision).HasColumnType("datetime");

                entity.Property(e => e.SC).HasMaxLength(50);

                entity.Property(e => e.SCIACI).HasMaxLength(50);

                entity.Property(e => e.SalesmantID).HasMaxLength(50);

                entity.Property(e => e.ServiceMode).HasMaxLength(150);

                entity.Property(e => e.ShipmentType).HasMaxLength(50);

                entity.Property(e => e.ShipperAddress).HasMaxLength(255);

                entity.Property(e => e.ShipperCode).HasMaxLength(50);

                entity.Property(e => e.ShipperID).HasMaxLength(50);

                entity.Property(e => e.ShipperName).HasMaxLength(150);

                entity.Property(e => e.SpecialRequest).HasMaxLength(150);

                entity.Property(e => e.StuffingTime).HasMaxLength(50);

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.TransitPort).HasMaxLength(150);

                entity.Property(e => e.VGMCutofftime).HasMaxLength(50);

                entity.Property(e => e.WHNo).HasMaxLength(50);

                entity.Property(e => e.WhoisMaking).HasMaxLength(50);
            });

            modelBuilder.Entity<SeaBookingRequest>(entity =>
            {
                entity.HasKey(e => e.KBRefNo);

                entity.Property(e => e.KBRefNo).HasMaxLength(50);

                entity.Property(e => e.AddNotifyParty2ID).HasMaxLength(50);

                entity.Property(e => e.AddNotifyPartyID).HasMaxLength(50);

                entity.Property(e => e.AmendmentJustification).HasMaxLength(255);

                entity.Property(e => e.ArrivalDateCF).HasColumnType("datetime");

                entity.Property(e => e.BKOffice).HasMaxLength(150);

                entity.Property(e => e.BKStatus).HasMaxLength(50);

                entity.Property(e => e.BKType).HasMaxLength(50);

                entity.Property(e => e.BLNo).HasMaxLength(50);

                entity.Property(e => e.CargoAllocate).HasDefaultValueSql("((0))");

                entity.Property(e => e.CarrierBKNo).HasMaxLength(50);

                entity.Property(e => e.CarrierFile).HasMaxLength(50);

                entity.Property(e => e.CarrierID).HasMaxLength(50);

                entity.Property(e => e.CarrierNotFile).HasDefaultValueSql("((0))");

                entity.Property(e => e.CarrierNotFileRef).HasMaxLength(50);

                entity.Property(e => e.ConsigneeID).HasMaxLength(50);

                entity.Property(e => e.ConsigneeRefNo).HasMaxLength(50);

                entity.Property(e => e.ContractNo).HasMaxLength(50);

                entity.Property(e => e.ContractParty).HasMaxLength(50);

                entity.Property(e => e.ContractPartyRefNo).HasMaxLength(50);

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.CustomerComment).HasMaxLength(255);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateMotify).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DepartureDate).HasColumnType("datetime");

                entity.Property(e => e.DepartureDateCF).HasColumnType("datetime");

                entity.Property(e => e.EmailNotify).HasMaxLength(255);

                entity.Property(e => e.EmptyContainer).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForwarderID).HasMaxLength(50);

                entity.Property(e => e.ForwarderRefNo).HasMaxLength(50);

                entity.Property(e => e.InttraBKNo).HasMaxLength(50);

                entity.Property(e => e.LockedRecord).HasDefaultValueSql("((0))");

                entity.Property(e => e.MoveType).HasMaxLength(50);

                entity.Property(e => e.NotifyCargoStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.NotifyPartyID).HasMaxLength(50);

                entity.Property(e => e.PerContainerReleaseNbrReqst).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlaceOfDelivery).HasMaxLength(150);

                entity.Property(e => e.PlaceOfReceipt).HasMaxLength(150);

                entity.Property(e => e.PurchaseOrderNo).HasMaxLength(50);

                entity.Property(e => e.ShipperID).HasMaxLength(50);

                entity.Property(e => e.ShipperRefNo).HasMaxLength(50);

                entity.Property(e => e.TariffNo).HasMaxLength(50);

                entity.Property(e => e.VesselNameCF).HasMaxLength(50);

                entity.Property(e => e.VoyageNumberCF).HasMaxLength(50);
            });

            modelBuilder.Entity<SeaBookingRequestCargo>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BKRefNo).HasMaxLength(50);

                entity.Property(e => e.CargoDescription).HasMaxLength(255);

                entity.Property(e => e.GVUnit).HasMaxLength(50);

                entity.Property(e => e.HSCode).HasMaxLength(50);

                entity.Property(e => e.IMOClassCode).HasMaxLength(50);

                entity.Property(e => e.NatureOfCargo).HasMaxLength(50);

                entity.Property(e => e.PackageUnit).HasMaxLength(50);

                entity.Property(e => e.ProperShippingName).HasMaxLength(150);

                entity.Property(e => e.TareUnit).HasMaxLength(50);

                entity.Property(e => e.UNDGNumber).HasMaxLength(50);

                entity.HasOne(d => d.BKRefNoNavigation)
                    .WithMany(p => p.SeaBookingRequestCargo)
                    .HasForeignKey(d => d.BKRefNo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SeaBookingRequestCargo_SeaBookingRequest");
            });

            modelBuilder.Entity<SeaBookingRequestCarriage>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BKRefNo).HasMaxLength(50);

                entity.Property(e => e.CarriageMode).HasMaxLength(50);

                entity.Property(e => e.ConfirmCR).HasDefaultValueSql("((0))");

                entity.Property(e => e.ConveyanceType).HasMaxLength(50);

                entity.Property(e => e.DischargePort).HasMaxLength(150);

                entity.Property(e => e.ETA).HasColumnType("datetime");

                entity.Property(e => e.ETD).HasColumnType("datetime");

                entity.Property(e => e.LloydsCode).HasMaxLength(50);

                entity.Property(e => e.LoadingPort).HasMaxLength(150);

                entity.Property(e => e.Mode).HasMaxLength(50);

                entity.Property(e => e.OperatorIdentifierCode).HasMaxLength(50);

                entity.Property(e => e.OperatorIdentifierType).HasMaxLength(50);

                entity.Property(e => e.RegistrationCountryCode).HasMaxLength(50);

                entity.Property(e => e.VesselName).HasMaxLength(50);

                entity.Property(e => e.Voyage).HasMaxLength(50);

                entity.HasOne(d => d.BKRefNoNavigation)
                    .WithMany(p => p.SeaBookingRequestCarriage)
                    .HasForeignKey(d => d.BKRefNo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SeaBookingRequestCarriage_SeaBookingRequest");
            });

            modelBuilder.Entity<SeaBookingRequestContainers>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BKRefNo).HasMaxLength(50);

                entity.Property(e => e.CType).HasMaxLength(50);

                entity.Property(e => e.CargoMovement).HasMaxLength(50);

                entity.Property(e => e.ContainerComment).HasMaxLength(255);

                entity.Property(e => e.ContainerNo).HasMaxLength(50);

                entity.Property(e => e.EquipmentPartyID).HasMaxLength(50);

                entity.Property(e => e.EquipmentRole).HasMaxLength(50);

                entity.Property(e => e.EquipmentType).HasMaxLength(50);

                entity.Property(e => e.FullIndicator).HasMaxLength(50);

                entity.Property(e => e.HaulageArrangements).HasMaxLength(50);

                entity.Property(e => e.NonActiveReefer).HasDefaultValueSql("((0))");

                entity.Property(e => e.PickupDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.PickupDeliveryDate2).HasColumnType("datetime");

                entity.Property(e => e.RequestType).HasMaxLength(50);

                entity.Property(e => e.RequestType2).HasMaxLength(50);

                entity.Property(e => e.RootID).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ShipperOwner).HasDefaultValueSql("((0))");

                entity.Property(e => e.Subof).HasDefaultValueSql("((0))");

                entity.Property(e => e.TemperatureUOM).HasMaxLength(50);

                entity.Property(e => e.VLUnit).HasMaxLength(50);

                entity.Property(e => e.WUnit).HasMaxLength(50);

                entity.HasOne(d => d.BKRefNoNavigation)
                    .WithMany(p => p.SeaBookingRequestContainers)
                    .HasForeignKey(d => d.BKRefNo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SeaBookingRequestContainers_SeaBookingRequest");
            });

            modelBuilder.Entity<SeaBookingRequestPaymentDetails>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BKRefNo).HasMaxLength(50);

                entity.Property(e => e.ChargeType).HasMaxLength(150);

                entity.Property(e => e.FreightTerm).HasMaxLength(50);

                entity.Property(e => e.PayerID).HasMaxLength(50);

                entity.Property(e => e.PaymentLocation).HasMaxLength(50);

                entity.HasOne(d => d.BKRefNoNavigation)
                    .WithMany(p => p.SeaBookingRequestPaymentDetails)
                    .HasForeignKey(d => d.BKRefNo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SeaBookingRequestPaymentDetails_SeaBookingRequest");
            });

            modelBuilder.Entity<SeaFreightPricing>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.NoID, "NoID");

                entity.HasIndex(e => e.Lines, "PartnersSeaFreightPricing");

                entity.Property(e => e.AccountRef).HasMaxLength(255);

                entity.Property(e => e.Amend).HasMaxLength(50);

                entity.Property(e => e.Baf).HasMaxLength(50);

                entity.Property(e => e.Caf).HasMaxLength(50);

                entity.Property(e => e.Carrier).HasMaxLength(255);

                entity.Property(e => e.Commodity).HasMaxLength(255);

                entity.Property(e => e.ContType).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.Cutoff).HasMaxLength(50);

                entity.Property(e => e.Destination).HasMaxLength(150);

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.EmptyReturn).HasMaxLength(50);

                entity.Property(e => e.Freq).HasMaxLength(50);

                entity.Property(e => e.Gri).HasMaxLength(50);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ImportMode).HasDefaultValueSql("((0))");

                entity.Property(e => e.InlAddon).HasMaxLength(50);

                entity.Property(e => e.Isps).HasMaxLength(50);

                entity.Property(e => e.Lines).HasMaxLength(50);

                entity.Property(e => e.LockedRCD).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.NoID).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.POD).HasMaxLength(150);

                entity.Property(e => e.POL).HasMaxLength(150);

                entity.Property(e => e.Pss).HasMaxLength(50);

                entity.Property(e => e.PublicPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.Service).HasMaxLength(50);

                entity.Property(e => e.TT).HasMaxLength(50);

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.Property(e => e.Validity).HasColumnType("datetime");

                entity.HasOne(d => d.LinesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Lines)
                    .HasConstraintName("SeaFreightPricing_FK00");
            });

            modelBuilder.Entity<SeaFreightPricingDetail>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.CC).HasDefaultValueSql("((0))");

                entity.Property(e => e.CCPartnerID).HasMaxLength(50);

                entity.Property(e => e.ContType).HasMaxLength(50);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.Nameofservice).HasMaxLength(255);

                entity.Property(e => e.NoID).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OBH).HasDefaultValueSql("((0))");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UnitCtnr).HasMaxLength(50);
            });

            modelBuilder.Entity<SeaQuotationCtnrs>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CUnit).HasMaxLength(50);

                entity.Property(e => e.Carrier).HasMaxLength(255);

                entity.Property(e => e.CarrierID).HasMaxLength(50);

                entity.Property(e => e.ContType).HasMaxLength(50);

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DeliveryPlace).HasMaxLength(255);

                entity.Property(e => e.EmptyReturn).HasMaxLength(50);

                entity.Property(e => e.Freq).HasMaxLength(50);

                entity.Property(e => e.Inland).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.POD).HasMaxLength(255);

                entity.Property(e => e.POL).HasMaxLength(255);

                entity.Property(e => e.PricingID).HasMaxLength(50);

                entity.Property(e => e.QuoID).HasMaxLength(50);

                entity.Property(e => e.ReceiptAt).HasMaxLength(255);

                entity.Property(e => e.TT)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VIA).HasMaxLength(50);

                entity.Property(e => e.Validity).HasColumnType("datetime");

                entity.Property(e => e.Volume).HasMaxLength(255);

                entity.Property(e => e.VolumeB).HasMaxLength(50);
            });

            modelBuilder.Entity<SeaQuotationDetails>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.QuotationID, "QuotationID");

                entity.HasIndex(e => e.QuotationID, "SeaQuotationsSeaQuotationDetails");

                entity.Property(e => e.CurrB).HasMaxLength(50);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.Fee).HasDefaultValueSql("((0))");

                entity.Property(e => e.KB).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nameofservice)
                    .HasMaxLength(255)
                    .HasComment("Weightable");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OBH).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.QuotationID).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UnitCtnr).HasMaxLength(50);

                entity.Property(e => e.iIndex).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Quotation)
                    .WithMany()
                    .HasForeignKey(d => d.QuotationID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SeaQuotationDetails_FK00");
            });

            modelBuilder.Entity<SeaQuotationOthers>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CurrB).HasMaxLength(50);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.KB).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OBH).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.QuoID).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UnitCtnr).HasMaxLength(50);
            });

            modelBuilder.Entity<SeaQuotations>(entity =>
            {
                entity.HasKey(e => e.QuoNo)
                    .HasName("aaaaaSeaQuotations_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.Managed, "ContactsListSeaQuotations");

                entity.HasIndex(e => e.ShipperID, "PartnersSeaQuotations");

                entity.HasIndex(e => e.ShipperID, "ShipperID");

                entity.Property(e => e.QuoNo).HasMaxLength(50);

                entity.Property(e => e.Attn).HasMaxLength(150);

                entity.Property(e => e.Commodity).HasMaxLength(255);

                entity.Property(e => e.Cont20).HasMaxLength(4000);

                entity.Property(e => e.Cont40).HasMaxLength(4000);

                entity.Property(e => e.Cont40HQ).HasMaxLength(4000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.CusCurrency).HasMaxLength(4000);

                entity.Property(e => e.CusDescription).HasMaxLength(4000);

                entity.Property(e => e.CusFee).HasMaxLength(4000);

                entity.Property(e => e.CusNotes).HasMaxLength(4000);

                entity.Property(e => e.CusUnit).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Customs).HasMaxLength(4000);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.FHistory).HasMaxLength(4000);

                entity.Property(e => e.FooterNotes).HasColumnType("ntext");

                entity.Property(e => e.HeaderOb).HasMaxLength(4000);

                entity.Property(e => e.InlandOrder).HasMaxLength(50);

                entity.Property(e => e.LCL).HasMaxLength(4000);

                entity.Property(e => e.Lines).HasMaxLength(4000);

                entity.Property(e => e.Managed).HasMaxLength(50);

                entity.Property(e => e.MngApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.Modify).HasColumnType("datetime");

                entity.Property(e => e.NominatedCargo).HasDefaultValueSql("((0))");

                entity.Property(e => e.OceanFreight).HasMaxLength(255);

                entity.Property(e => e.OtCurrency).HasMaxLength(4000);

                entity.Property(e => e.OtDescription).HasMaxLength(4000);

                entity.Property(e => e.OtFee).HasMaxLength(4000);

                entity.Property(e => e.OtNotes).HasMaxLength(4000);

                entity.Property(e => e.OtUnit).HasMaxLength(4000);

                entity.Property(e => e.OtherCharges).HasMaxLength(4000);

                entity.Property(e => e.POD).HasMaxLength(255);

                entity.Property(e => e.POL).HasMaxLength(255);

                entity.Property(e => e.QuoAgentID).HasMaxLength(50);

                entity.Property(e => e.QuoDate).HasColumnType("datetime");

                entity.Property(e => e.QuoSubject).HasMaxLength(150);

                entity.Property(e => e.QuoTitle).HasMaxLength(150);

                entity.Property(e => e.SendApproval).HasDefaultValueSql("((0))");

                entity.Property(e => e.Service).HasMaxLength(50);

                entity.Property(e => e.ShipperID).HasMaxLength(50);

                entity.Property(e => e.TelNo).HasMaxLength(50);

                entity.Property(e => e.UseAllin).HasDefaultValueSql("((0))");

                entity.Property(e => e.ValidDate).HasColumnType("datetime");

                entity.Property(e => e.Volume).HasMaxLength(4000);

                entity.HasOne(d => d.ManagedNavigation)
                    .WithMany(p => p.SeaQuotations)
                    .HasPrincipalKey(p => p.Username)
                    .HasForeignKey(d => d.Managed)
                    .HasConstraintName("SeaQuotations_FK00");

                entity.HasOne(d => d.Shipper)
                    .WithMany(p => p.SeaQuotations)
                    .HasForeignKey(d => d.ShipperID)
                    .HasConstraintName("SeaQuotations_FK01");
            });

            modelBuilder.Entity<SellingRate>(entity =>
            {
                entity.HasKey(e => new { e.HAWBNO, e.Description, e.QUnit, e.Collect })
                    .HasName("aaaaaSellingRate_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.CurrencyConvertRate, "Curr_SellingRate");

                entity.HasIndex(e => e.DocNo, "DocNo_SellingRate");

                entity.HasIndex(e => e.FieldKey, "FieldKey_SellingRate");

                entity.HasIndex(e => e.HAWBNO, "HAWBSellingRate");

                entity.HasIndex(e => e.IDKeyIndex, "IDKeyIndex_SellingRate");

                entity.HasIndex(e => e.InoiceNo, "InoiceNo_SellingRate");

                entity.HasIndex(e => e.InputData, "InputData_SellingRate");

                entity.HasIndex(e => e.OBHPartnerID, "OBHPartnerID_SellingRate");

                entity.HasIndex(e => e.RequisitionID, "RequisitionID_SellingRatee");

                entity.HasIndex(e => e.SeriNo, "SeriNo_SellingRate");

                entity.HasIndex(e => e.SortDes, "SortDes_SellingRate");

                entity.HasIndex(e => e.TaxCode, "TaxCode");

                entity.HasIndex(e => e.VATInvID, "VATInvID_SellingRate");

                entity.HasIndex(e => new { e.DocNo, e.VATInvID, e.SeriNo }, "VAT_SellingRate");

                entity.HasIndex(e => e.VoucherID, "VoucherID");

                entity.HasIndex(e => e.VoucherIDSE, "VoucherIDSE_SellingRate");

                entity.Property(e => e.HAWBNO).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.QUnit).HasMaxLength(50);

                entity.Property(e => e.AccsDateKey).HasColumnType("datetime");

                entity.Property(e => e.AccsUserKey).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.AdvVoucherID).HasMaxLength(50);

                entity.Property(e => e.Advanced).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.AutoInput).HasDefaultValueSql("((0))");

                entity.Property(e => e.CIDIndex).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContactCollect).HasMaxLength(150);

                entity.Property(e => e.CostSheetIDLinked).HasMaxLength(50);

                entity.Property(e => e.CurrencyConvertRate).HasMaxLength(50);

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.DocNo).HasMaxLength(50);

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.ExtRateVND).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtVND).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.FieldName).HasMaxLength(50);

                entity.Property(e => e.GWHeavyW).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gainloss).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupName).HasMaxLength(150);

                entity.Property(e => e.IDKeyIndex)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IDKeyShipmentDT).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.INVSOANo).HasMaxLength(50);

                entity.Property(e => e.InnerImported).HasDefaultValueSql("((0))");

                entity.Property(e => e.InoiceNo).HasMaxLength(50);

                entity.Property(e => e.InputData).HasMaxLength(50);

                entity.Property(e => e.InvDate).HasColumnType("datetime");

                entity.Property(e => e.IsSyncEqc).HasDefaultValueSql("((0))");

                entity.Property(e => e.MUnit).HasMaxLength(50);

                entity.Property(e => e.NameOfCollect).HasMaxLength(150);

                entity.Property(e => e.NoInv).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.OBH).HasDefaultValueSql("((0))");

                entity.Property(e => e.OBHPartnerID).HasMaxLength(50);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.RequisitionID).HasMaxLength(50);

                entity.Property(e => e.SExpAdmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeriNo).HasMaxLength(50);

                entity.Property(e => e.SettlementRefNo).HasMaxLength(50);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.SortDes).HasMaxLength(150);

                entity.Property(e => e.SortInv).HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxCode).HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.VATDate).HasColumnType("datetime");

                entity.Property(e => e.VATInvID).HasMaxLength(50);

                entity.Property(e => e.VATSOANo).HasMaxLength(50);

                entity.Property(e => e.VoucherID).HasMaxLength(50);

                entity.Property(e => e.VoucherIDSE).HasMaxLength(50);

                entity.HasOne(d => d.HAWBNONavigation)
                    .WithMany(p => p.SellingRate)
                    .HasForeignKey(d => d.HAWBNO)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SellingRate_FK00");
            });

            modelBuilder.Entity<SendMails>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.HTMLBody).HasColumnType("ntext");

                entity.Property(e => e.IDKeyShipment).HasMaxLength(1000);

                entity.Property(e => e.JobNo).HasMaxLength(50);

                entity.Property(e => e.MailSentDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiverCC).HasMaxLength(1000);

                entity.Property(e => e.ReceiverTo).HasMaxLength(255);

                entity.Property(e => e.Subject).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.emailPassword).HasMaxLength(50);

                entity.Property(e => e.sendusing).HasMaxLength(50);

                entity.Property(e => e.smtpauthenticate).HasMaxLength(50);

                entity.Property(e => e.smtpserver).HasMaxLength(150);

                entity.Property(e => e.smtpserverport).HasMaxLength(50);
            });

            modelBuilder.Entity<SendMailsAttachedFiles>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IDKeyLinked).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<ServiceInquiry>(entity =>
            {
                entity.HasKey(e => e.ServiceID);

                entity.Property(e => e.ServiceID).HasMaxLength(50);

                entity.Property(e => e.ApprovedCmd).HasDefaultValueSql("((0))");

                entity.Property(e => e.Commodity).HasMaxLength(255);

                entity.Property(e => e.ConQty).HasMaxLength(50);

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateLocked).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DeliveryTerm).HasMaxLength(50);

                entity.Property(e => e.Dimention).HasMaxLength(255);

                entity.Property(e => e.ETA).HasColumnType("datetime");

                entity.Property(e => e.ETD).HasColumnType("datetime");

                entity.Property(e => e.EmptyContReturn).HasMaxLength(50);

                entity.Property(e => e.FinalDestination).HasMaxLength(50);

                entity.Property(e => e.HVComment).HasDefaultValueSql("((0))");

                entity.Property(e => e.ImportShipment).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.PCName).HasMaxLength(50);

                entity.Property(e => e.POD).HasMaxLength(50);

                entity.Property(e => e.POL).HasMaxLength(50);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.PickupCargo).HasMaxLength(50);

                entity.Property(e => e.SVLocked).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesmanID).HasMaxLength(50);

                entity.Property(e => e.ServiceInquiry1)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceInquiry");

                entity.Property(e => e.UnitQuantity).HasMaxLength(50);

                entity.Property(e => e.UserComment).HasMaxLength(50);

                entity.Property(e => e.VesselName).HasMaxLength(50);

                entity.Property(e => e.VoyNo).HasMaxLength(50);
            });

            modelBuilder.Entity<ServiceInquiryDetails>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.AsignedtoUser).HasMaxLength(50);

                entity.Property(e => e.AsigntoGroup).HasMaxLength(50);

                entity.Property(e => e.Attached).HasColumnType("ntext");

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.ConQty).HasMaxLength(50);

                entity.Property(e => e.DateProcess).HasColumnType("datetime");

                entity.Property(e => e.Deadline).HasMaxLength(50);

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.HBLNo).HasMaxLength(50);

                entity.Property(e => e.JobID).HasMaxLength(50);

                entity.Property(e => e.ModeDB).HasMaxLength(50);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.POLOrigin).HasMaxLength(50);

                entity.Property(e => e.PriceID).HasMaxLength(50);

                entity.Property(e => e.PriceIDList).HasMaxLength(1000);

                entity.Property(e => e.PriceINLID).HasMaxLength(50);

                entity.Property(e => e.ReadRQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReadRQDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceID).HasMaxLength(50);

                entity.Property(e => e.ServiceInquiry).HasMaxLength(255);

                entity.Property(e => e.ServiceType).HasMaxLength(50);

                entity.Property(e => e.TargetRate).HasMaxLength(50);

                entity.Property(e => e.UnitQuantity).HasMaxLength(50);

                entity.Property(e => e.UserCommentDT).HasMaxLength(50);

                entity.Property(e => e.WhoisProcess).HasMaxLength(50);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceInquiryDetails)
                    .HasForeignKey(d => d.ServiceID)
                    .HasConstraintName("FK_ServiceInquiryDetails_ServiceInquiry");
            });

            modelBuilder.Entity<ServiceInquiryDetailsAttachedFiles>(entity =>
            {
                entity.HasKey(e => e.FieldKey);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<ServiceInquiryRate>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DataIndex).HasDefaultValueSql("(0)");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.ExtRate).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExtVND).HasDefaultValueSql("(0)");

                entity.Property(e => e.NoInv).HasDefaultValueSql("(0)");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.Quantity).HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalValue).HasDefaultValueSql("(0)");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("(0)");

                entity.Property(e => e.VAT).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("aaaaaServices_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.AgentID, "AgentID_Services");

                entity.HasIndex(e => e.CarrierID, "CarrierID_Services");

                entity.HasIndex(e => e.Commodity, "Commodity_Services");

                entity.HasIndex(e => e.CustomerID, "CustomerID_Services");

                entity.HasIndex(e => e.ID, "ID");

                entity.Property(e => e.ID).HasMaxLength(50);

                entity.Property(e => e.ACFormular).HasMaxLength(1000);

                entity.Property(e => e.AgentID).HasMaxLength(50);

                entity.Property(e => e.BDPM).HasDefaultValueSql("((0))");

                entity.Property(e => e.CDSType).HasMaxLength(50);

                entity.Property(e => e.COForm).HasMaxLength(50);

                entity.Property(e => e.CarrierID).HasMaxLength(50);

                entity.Property(e => e.CategoryID).HasMaxLength(50);

                entity.Property(e => e.Commodity).HasMaxLength(50);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.CustomerID).HasMaxLength(50);

                entity.Property(e => e.ERPC).HasMaxLength(50);

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.FUnit).HasMaxLength(50);

                entity.Property(e => e.FeeCode).HasMaxLength(50);

                entity.Property(e => e.GroupID).HasMaxLength(50);

                entity.Property(e => e.ListACRef).HasMaxLength(150);

                entity.Property(e => e.LitmitUnit).HasMaxLength(50);

                entity.Property(e => e.Mode).HasMaxLength(150);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.OBH).HasDefaultValueSql("((0))");

                entity.Property(e => e.PHYTO).HasDefaultValueSql("((0))");

                entity.Property(e => e.PMTerm).HasMaxLength(50);

                entity.Property(e => e.PODC).HasMaxLength(50);

                entity.Property(e => e.POLC).HasMaxLength(50);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.QuoNo).HasMaxLength(50);

                entity.Property(e => e.RouteAssigned).HasMaxLength(50);

                entity.Property(e => e.SHPTType).HasMaxLength(50);

                entity.Property(e => e.SVType).HasMaxLength(50);

                entity.Property(e => e.ServiceMode).HasMaxLength(50);

                entity.Property(e => e.ServiceName).HasMaxLength(150);

                entity.Property(e => e.TASKREGISTERID).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TruckStatus).HasMaxLength(50);

                entity.Property(e => e.TruckStatusLinked).HasMaxLength(50);

                entity.Property(e => e.TruckSubServiceLinked).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.VName).HasMaxLength(150);

                entity.Property(e => e.ValidityDate).HasColumnType("datetime");

                entity.Property(e => e.Whois).HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.CategoryID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Services_EcusCategory");
            });

            modelBuilder.Entity<ShipmentChargesActivities>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Approved).HasDefaultValueSql("((0))");

                entity.Property(e => e.ChargeCode).HasMaxLength(50);

                entity.Property(e => e.ChargeDescription).HasMaxLength(255);

                entity.Property(e => e.CommentAPPDECL).HasMaxLength(255);

                entity.Property(e => e.ConditionDesc).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DateProcess).HasColumnType("datetime");

                entity.Property(e => e.Debt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Decline).HasDefaultValueSql("((0))");

                entity.Property(e => e.FieldKeyCharge).HasMaxLength(50);

                entity.Property(e => e.HBLNo).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OBHPartnerID).HasMaxLength(50);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.QtyUnit).HasMaxLength(50);

                entity.Property(e => e.SendRQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.TableSource).HasMaxLength(50);

                entity.Property(e => e.TransDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.TransNew).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransUpdate).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateChargeDescription).HasMaxLength(255);

                entity.Property(e => e.UpdateCurr).HasMaxLength(50);

                entity.Property(e => e.UpdateNotes).HasMaxLength(255);

                entity.Property(e => e.UpdateQtyUnit).HasMaxLength(50);

                entity.Property(e => e.UpdateUser).HasMaxLength(50);

                entity.Property(e => e.UserApp).HasMaxLength(50);

                entity.Property(e => e.UserAppReadDate).HasColumnType("datetime");

                entity.Property(e => e.UserReceivedReadDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShippingDetails>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.Activate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Attached).HasColumnType("ntext");

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Commodity).HasMaxLength(50);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Desription).HasMaxLength(255);

                entity.Property(e => e.Destination).HasMaxLength(255);

                entity.Property(e => e.EstimateGP).HasMaxLength(50);

                entity.Property(e => e.Mode).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.Origin).HasMaxLength(255);

                entity.Property(e => e.POD).HasMaxLength(50);

                entity.Property(e => e.POL).HasMaxLength(50);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.SDDate).HasColumnType("datetime");

                entity.Property(e => e.Terms).HasMaxLength(50);

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.Property(e => e.Volume).HasMaxLength(50);
            });

            modelBuilder.Entity<ShippingDetailsAttachedFiles>(entity =>
            {
                entity.HasKey(e => e.FieldKey);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<ShippingInstruction>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.BAGSNO).HasMaxLength(50);

                entity.Property(e => e.ContStatus).HasMaxLength(50);

                entity.Property(e => e.Container).HasMaxLength(50);

                entity.Property(e => e.ContainerNo).HasMaxLength(255);

                entity.Property(e => e.DeliveryPlace).HasMaxLength(150);

                entity.Property(e => e.DemApp).HasDefaultValueSql("((0))");

                entity.Property(e => e.DemCurr).HasMaxLength(50);

                entity.Property(e => e.DemDate).HasColumnType("datetime");

                entity.Property(e => e.DemUser).HasMaxLength(50);

                entity.Property(e => e.DepApp).HasDefaultValueSql("((0))");

                entity.Property(e => e.DepCurr).HasMaxLength(50);

                entity.Property(e => e.DepDate).HasColumnType("datetime");

                entity.Property(e => e.DepUser).HasMaxLength(50);

                entity.Property(e => e.Depot).HasMaxLength(50);

                entity.Property(e => e.DescriptionofGoods).HasMaxLength(4000);

                entity.Property(e => e.DestDepot).HasMaxLength(150);

                entity.Property(e => e.EmptyDestDepot).HasMaxLength(150);

                entity.Property(e => e.EmptyDestDepotDate).HasColumnType("datetime");

                entity.Property(e => e.EmptyPickup).HasMaxLength(150);

                entity.Property(e => e.EmptyPickupDate).HasColumnType("datetime");

                entity.Property(e => e.Finished).HasDefaultValueSql("((0))");

                entity.Property(e => e.FullPickup).HasMaxLength(150);

                entity.Property(e => e.FullPickupDate).HasColumnType("datetime");

                entity.Property(e => e.FullToport).HasMaxLength(150);

                entity.Property(e => e.FullToportDate).HasColumnType("datetime");

                entity.Property(e => e.FumiCo).HasMaxLength(150);

                entity.Property(e => e.HBLNo).HasMaxLength(4000);

                entity.Property(e => e.HSCode).HasMaxLength(50);

                entity.Property(e => e.MovedForRepair).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNo).HasMaxLength(50);

                entity.Property(e => e.OrderSubject).HasMaxLength(150);

                entity.Property(e => e.PALLET).HasMaxLength(50);

                entity.Property(e => e.RepairCompleted).HasColumnType("datetime");

                entity.Property(e => e.SealNo).HasMaxLength(255);

                entity.Property(e => e.SfuffingDate).HasColumnType("datetime");

                entity.Property(e => e.ShippingMarks).HasMaxLength(4000);

                entity.Property(e => e.Slot).HasMaxLength(50);

                entity.Property(e => e.StuffingLocation).HasMaxLength(150);

                entity.Property(e => e.StuffingPhoto).HasMaxLength(50);

                entity.Property(e => e.StuffingPlace).HasMaxLength(150);

                entity.Property(e => e.Term).HasMaxLength(50);

                entity.Property(e => e.TermIC).HasMaxLength(50);

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.TruckingCo).HasMaxLength(150);

                entity.Property(e => e.UnitPack).HasMaxLength(50);

                entity.Property(e => e.VGMCutofftime).HasMaxLength(50);

                entity.HasOne(d => d.Trans)
                    .WithMany(p => p.ShippingInstruction)
                    .HasForeignKey(d => d.TransID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ShippingInstruction_Transactions");
            });

            modelBuilder.Entity<ShippingInstructionGoodsDetail>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContainerNo).HasMaxLength(50);

                entity.Property(e => e.GVUnit).HasMaxLength(50);

                entity.Property(e => e.GWUnit).HasMaxLength(50);

                entity.Property(e => e.ItemTypeIdCode).HasMaxLength(50);

                entity.Property(e => e.JobNo).HasMaxLength(50);

                entity.Property(e => e.PackageDetailComments).HasMaxLength(255);

                entity.Property(e => e.PackageDetailLevel).HasMaxLength(50);

                entity.Property(e => e.PackageTypeCode).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasMaxLength(50);

                entity.Property(e => e.SMarks).HasMaxLength(255);

                entity.HasOne(d => d.JobNoNavigation)
                    .WithMany(p => p.ShippingInstructionGoodsDetail)
                    .HasForeignKey(d => d.JobNo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ShippingInstructionGoodsDetail_Transactions");
            });

            modelBuilder.Entity<StartUpMasseages>(entity =>
            {
                entity.HasKey(e => e.MsgID)
                    .HasName("aaaaaStartUpMasseages_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ContactID, "ContactID");

                entity.HasIndex(e => e.WhoisMaking, "ContactsListStartUpMasseages");

                entity.HasIndex(e => e.ContactID, "ContactsListStartUpMasseages1");

                entity.HasIndex(e => e.MsgID, "MsgID");

                entity.Property(e => e.MsgID).HasMaxLength(50);

                entity.Property(e => e.Attached).HasColumnType("ntext");

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.DateStop).HasDefaultValueSql("(0)");

                entity.Property(e => e.DayStartup).HasDefaultValueSql("(0)");

                entity.Property(e => e.ListContact).HasMaxLength(255);

                entity.Property(e => e.Masseges).HasColumnType("ntext");

                entity.Property(e => e.MsgDate).HasColumnType("datetime");

                entity.Property(e => e.PCName).HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(150);

                entity.Property(e => e.WhoisMaking).HasMaxLength(50);
            });

            modelBuilder.Entity<StartUpMasseagesAttached>(entity =>
            {
                entity.HasKey(e => e.FieldKey);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.StartUpNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<StartUpMasseagesView>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.MsgID).HasMaxLength(50);

                entity.Property(e => e.PCName).HasMaxLength(50);

                entity.Property(e => e.ViewDate).HasColumnType("datetime");

                entity.Property(e => e.WhoisView).HasMaxLength(50);

                entity.HasOne(d => d.Msg)
                    .WithMany(p => p.StartUpMasseagesView)
                    .HasForeignKey(d => d.MsgID)
                    .HasConstraintName("FK_StartUpMasseagesView_StartUpMasseages");
            });

            modelBuilder.Entity<SupplychainDetails>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.Activate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Attached).HasColumnType("ntext");

                entity.Property(e => e.Customs).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Incoterm).HasMaxLength(50);

                entity.Property(e => e.Insurance).HasDefaultValueSql("((0))");

                entity.Property(e => e.InsuranceDes).HasMaxLength(50);

                entity.Property(e => e.Others).HasMaxLength(50);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.SCDate).HasColumnType("datetime");

                entity.Property(e => e.Service).HasMaxLength(50);

                entity.Property(e => e.Trucking).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserInput).HasMaxLength(50);
            });

            modelBuilder.Entity<SupplychainDetailsAttachedFiles>(entity =>
            {
                entity.HasKey(e => e.FieldKey);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<SystemIDConfig>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("aaaaaSystemIDConfig_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ID, "IDTransType");

                entity.Property(e => e.ID).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.IDResetOn).HasDefaultValueSql("((0))");

                entity.Property(e => e.Increment).HasMaxLength(50);

                entity.Property(e => e.No).HasMaxLength(50);

                entity.Property(e => e.Sign).HasMaxLength(50);

                entity.Property(e => e.Ys).HasMaxLength(50);

                entity.Property(e => e.sMonth).HasMaxLength(50);

                entity.Property(e => e.sYear).HasMaxLength(50);
            });

            modelBuilder.Entity<SystemIDConfigDTLS>(entity =>
            {
                entity.HasKey(e => new { e.ID, e.Description })
                    .HasName("aaaaaSystemIDConfigDTLS_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.Description, "FieldName");

                entity.HasIndex(e => e.ID, "ID");

                entity.HasIndex(e => e.IDResetOn, "IDResetOn");

                entity.HasIndex(e => e.ID, "SystemIDConfigSystemIDConfigDTLS");

                entity.Property(e => e.ID).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.ContactList).HasMaxLength(255);

                entity.Property(e => e.IDResetOn).HasDefaultValueSql("((0))");

                entity.Property(e => e.Increment).HasMaxLength(50);

                entity.Property(e => e.No).HasMaxLength(50);

                entity.Property(e => e.Sign).HasMaxLength(50);

                entity.Property(e => e.Ys).HasMaxLength(50);

                entity.Property(e => e.sMonth).HasMaxLength(50);

                entity.Property(e => e.sYear).HasMaxLength(50);

                entity.HasOne(d => d.IDNavigation)
                    .WithMany(p => p.SystemIDConfigDTLS)
                    .HasForeignKey(d => d.ID)
                    .HasConstraintName("SystemIDConfigDTLS_FK00");
            });

            modelBuilder.Entity<SystemIDConfigDTLSSub>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ContactList).HasMaxLength(4000);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ParentMode).HasMaxLength(50);
            });

            modelBuilder.Entity<SystemIDConfigDetail>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.FieldName, "FieldName");

                entity.HasIndex(e => e.ID, "ID");

                entity.HasIndex(e => e.ID, "SystemIDConfigSystemIDConfigDTLS");

                entity.HasIndex(e => e.ID, "SystemIDConfigSystemIDConfigDetail");

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.Contents).HasMaxLength(4000);

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.IDNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ID)
                    .HasConstraintName("SystemIDConfigDetail_FK00");
            });

            modelBuilder.Entity<TASK>(entity =>
            {
                entity.Property(e => e.TASKID)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ACCEPTEDON).HasColumnType("datetime");

                entity.Property(e => e.ASSIGNEDON).HasColumnType("datetime");

                entity.Property(e => e.CREATEDBY).HasMaxLength(50);

                entity.Property(e => e.CREATEDON).HasColumnType("datetime");

                entity.Property(e => e.DEADLINE).HasMaxLength(50);

                entity.Property(e => e.DEPARTMENTID).HasMaxLength(50);

                entity.Property(e => e.DeadlineOn).HasColumnType("datetime");

                entity.Property(e => e.FINISHDATE).HasColumnType("datetime");

                entity.Property(e => e.FileExt).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.HBLNo).HasMaxLength(50);

                entity.Property(e => e.IDKEYSHIPMENT).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ISDOC).HasDefaultValueSql("((0))");

                entity.Property(e => e.NOTES).HasMaxLength(500);

                entity.Property(e => e.RETURNEDON).HasColumnType("datetime");

                entity.Property(e => e.STAFFID).HasMaxLength(50);

                entity.Property(e => e.TASKADDRESS).HasMaxLength(500);

                entity.Property(e => e.TASKGROUPADDRESS).HasMaxLength(50);

                entity.Property(e => e.TASKNAME).HasMaxLength(500);

                entity.Property(e => e.TASKREGISTERID).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TRANSACTIONID)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TASKREGISTERS>(entity =>
            {
                entity.Property(e => e.ID)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.APPLICATIONID).HasMaxLength(50);

                entity.Property(e => e.COMMODITY).HasMaxLength(50);

                entity.Property(e => e.CREATEDBY)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CREATEDON).HasColumnType("datetime");

                entity.Property(e => e.CUSTOMERID).HasMaxLength(50);

                entity.Property(e => e.CUSTOMTYPE).HasMaxLength(50);

                entity.Property(e => e.DEADLINE).HasMaxLength(50);

                entity.Property(e => e.DEPARTMENTID).HasMaxLength(50);

                entity.Property(e => e.FEECODE).HasMaxLength(50);

                entity.Property(e => e.GROUPTASK).HasMaxLength(50);

                entity.Property(e => e.ISDOC).HasDefaultValueSql("((0))");

                entity.Property(e => e.MODIFIEDBY).HasMaxLength(50);

                entity.Property(e => e.MODIFIEDON).HasColumnType("datetime");

                entity.Property(e => e.ROUTER).HasMaxLength(50);

                entity.Property(e => e.SERVICES).HasMaxLength(50);

                entity.Property(e => e.SERVICESID).HasMaxLength(50);

                entity.Property(e => e.STAFFID).HasMaxLength(50);

                entity.Property(e => e.TASKNAME).HasMaxLength(50);

                entity.Property(e => e.TRANSACTIONTYPEID).HasMaxLength(50);

                entity.Property(e => e.WAREHOUSE).HasMaxLength(50);
            });

            modelBuilder.Entity<TableFieldsDescription>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Activate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ColComboItem).HasMaxLength(1000);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.FieldDescription).HasMaxLength(1000);

                entity.Property(e => e.FieldDisplay).HasMaxLength(150);

                entity.Property(e => e.FieldName).HasMaxLength(150);

                entity.Property(e => e.TableName).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<TasksList>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("aaaaaTasksList_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ID, "ID");

                entity.HasIndex(e => e.IDPost, "IDPost");

                entity.HasIndex(e => e.UserName, "UserName_TasksList");

                entity.HasIndex(e => e.Whois, "Whois_TasksList");

                entity.Property(e => e.DatePost).HasColumnType("datetime");

                entity.Property(e => e.DateRead).HasColumnType("datetime");

                entity.Property(e => e.IDPost).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.SqlStatement).HasColumnType("ntext");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.Whois).HasMaxLength(50);
            });

            modelBuilder.Entity<TempMsg>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.MsgID, "ID");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.MsgContents).HasColumnType("ntext");

                entity.Property(e => e.MsgID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PCName).HasMaxLength(50);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.TypeUpdate).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<ToKhaiThue>(entity =>
            {
                entity.Property(e => e.ID)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.IDInvoice).HasMaxLength(255);

                entity.Property(e => e.IPAddress).HasMaxLength(255);

                entity.Property(e => e.Ky).HasMaxLength(255);

                entity.Property(e => e.LoaiThue).HasMaxLength(255);

                entity.Property(e => e.Nam).HasMaxLength(255);

                entity.Property(e => e.Thang).HasMaxLength(255);

                entity.Property(e => e.ToKhai).HasMaxLength(255);

                entity.Property(e => e.WhoCreate).HasMaxLength(255);
            });

            modelBuilder.Entity<TrackAndTraceMT>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ATA).HasColumnType("datetime");

                entity.Property(e => e.ATD).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ETA).HasColumnType("datetime");

                entity.Property(e => e.ETD).HasColumnType("datetime");

                entity.Property(e => e.PODC).HasMaxLength(50);

                entity.Property(e => e.POLC).HasMaxLength(50);

                entity.Property(e => e.TransJobNo).HasMaxLength(50);

                entity.Property(e => e.TransMode).HasMaxLength(50);

                entity.Property(e => e.TransStatus).HasMaxLength(50);

                entity.Property(e => e.UserEdit).HasMaxLength(50);

                entity.Property(e => e.VesselFlightNo).HasMaxLength(255);
            });

            modelBuilder.Entity<TrackingExpress>(entity =>
            {
                entity.HasKey(e => e.KeyIDTC);

                entity.HasIndex(e => e.TransactionID, "TransactionID");

                entity.HasIndex(e => e.HAWB, "TransactionsTrackingExpress");

                entity.Property(e => e.KeyIDTC)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ArrivalDate).HasMaxLength(50);

                entity.Property(e => e.ArrivalTime).HasMaxLength(50);

                entity.Property(e => e.Carrier).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Departure).HasMaxLength(50);

                entity.Property(e => e.FlightNo).HasMaxLength(50);

                entity.Property(e => e.HAWB).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(150);

                entity.Property(e => e.Pieces).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(150);

                entity.Property(e => e.TM).HasMaxLength(50);

                entity.Property(e => e.Time).HasMaxLength(50);

                entity.Property(e => e.TransactionID).HasMaxLength(50);

                entity.Property(e => e.Weight).HasMaxLength(50);
            });

            modelBuilder.Entity<TransServiceType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ServiceID).HasMaxLength(50);

                entity.Property(e => e.ServiceName).HasMaxLength(50);

                entity.Property(e => e.TransTypeID).HasMaxLength(50);
            });

            modelBuilder.Entity<TransTracking>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.HasIndex(e => e.HAWB, "TransactionDetailsTransTracking");

                entity.HasIndex(e => e.TransactionID, "TransactionID");

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ArrivalDate).HasMaxLength(50);

                entity.Property(e => e.ArrivalTime).HasMaxLength(50);

                entity.Property(e => e.Carrier).HasMaxLength(50);

                entity.Property(e => e.ContainerNo).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateInput).HasColumnType("datetime");

                entity.Property(e => e.Departure).HasMaxLength(50);

                entity.Property(e => e.FlightNo).HasMaxLength(50);

                entity.Property(e => e.HAWB).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(150);

                entity.Property(e => e.Pieces).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(150);

                entity.Property(e => e.TM).HasMaxLength(50);

                entity.Property(e => e.Time).HasMaxLength(50);

                entity.Property(e => e.TransactionID).HasMaxLength(50);

                entity.Property(e => e.Weight).HasMaxLength(50);

                entity.Property(e => e.Whois).HasMaxLength(50);
            });

            modelBuilder.Entity<TransactionDetails>(entity =>
            {
                entity.HasKey(e => new { e.TransID, e.LotNo })
                    .HasName("aaaaaTransactionDetails_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ConsigneeCode, "ConsigneeCode");

                entity.HasIndex(e => e.ContactID, "ContactID_TransactionDetails");

                entity.HasIndex(e => e.CustomsID, "CustomsDeclarationTransactionDetails");

                entity.HasIndex(e => e.CustomsID, "CustomsID");

                entity.HasIndex(e => e.HWBNO, "HAWBTransactionDetails");

                entity.HasIndex(e => e.HWBNO, "HWBNO");

                entity.HasIndex(e => e.IDKeyShipment, "IX_TransactionDetails")
                    .IsUnique();

                entity.HasIndex(e => e.LotNo, "LotNo");

                entity.HasIndex(e => e.MAWB, "MAWB");

                entity.HasIndex(e => e.MAWBSE, "MAWBSE");

                entity.HasIndex(e => e.NominationParty, "NominationParty");

                entity.HasIndex(e => e.ShipperID, "PartnersTransactionDetails");

                entity.HasIndex(e => e.QuoNo, "QuoNo");

                entity.HasIndex(e => e.SCIACI, "SCIACI");

                entity.HasIndex(e => e.SalesManID, "SalesManID_TransactionDetails");

                entity.HasIndex(e => e.BookingID, "SeaBookingNoteTransactionDetails");

                entity.HasIndex(e => e.ShipmentType, "ShipmentType");

                entity.HasIndex(e => e.ShipperID, "ShipperID");

                entity.HasIndex(e => e.TransID, "TransactionID");

                entity.HasIndex(e => e.TransID, "TransactionsTransactionDetails");

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.LotNo).HasMaxLength(50);

                entity.Property(e => e.AcDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.Attn)
                    .HasMaxLength(150)
                    .HasComment("Booking Confirm");

                entity.Property(e => e.AttnLoadingConfig).HasMaxLength(255);

                entity.Property(e => e.BLReady).HasDefaultValueSql("((0))");

                entity.Property(e => e.BLType).HasMaxLength(50);

                entity.Property(e => e.BlCorrection).HasMaxLength(150);

                entity.Property(e => e.BookingID).HasMaxLength(50);

                entity.Property(e => e.CBMSea).HasDefaultValueSql("((0))");

                entity.Property(e => e.CDSExtra).HasDefaultValueSql("((0))");

                entity.Property(e => e.CSCurr).HasMaxLength(50);

                entity.Property(e => e.CUSTOMERSATISFACTIONNOTES).HasMaxLength(500);

                entity.Property(e => e.ChargesDesc).HasMaxLength(255);

                entity.Property(e => e.CloseTime20).HasMaxLength(50);

                entity.Property(e => e.CloseTime40).HasMaxLength(50);

                entity.Property(e => e.CloseTimeLCL).HasMaxLength(50);

                entity.Property(e => e.ComChargeType).HasMaxLength(50);

                entity.Property(e => e.Commidity).HasMaxLength(150);

                entity.Property(e => e.ConfirmReceived).HasDefaultValueSql("((0))");

                entity.Property(e => e.ConsigneeAddress).HasMaxLength(150);

                entity.Property(e => e.ConsigneeCode).HasMaxLength(50);

                entity.Property(e => e.ConsigneeName).HasMaxLength(150);

                entity.Property(e => e.ContSealNo)
                    .HasMaxLength(150)
                    .HasComment("Connecting Vessel (Mother vessel)");

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.ContainerNo).HasMaxLength(150);

                entity.Property(e => e.ContainerSize).HasMaxLength(150);

                entity.Property(e => e.CustomsID).HasMaxLength(50);

                entity.Property(e => e.DEADLINEON).HasColumnType("datetime");

                entity.Property(e => e.DOExpired).HasColumnType("datetime");

                entity.Property(e => e.DOStatus).HasMaxLength(50);

                entity.Property(e => e.DTDeadline).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateMaking).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateReceivedConfirm).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate).HasMaxLength(50);

                entity.Property(e => e.DeliveryStatus).HasMaxLength(50);

                entity.Property(e => e.Deliveryat).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Dimension).HasDefaultValueSql("((0))");

                entity.Property(e => e.DocsReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.DocsReceiver).HasMaxLength(150);

                entity.Property(e => e.DropoffAt).HasMaxLength(150);

                entity.Property(e => e.DropoffDate).HasColumnType("datetime");

                entity.Property(e => e.ENCRYPTSEADO).HasMaxLength(500);

                entity.Property(e => e.ETA)
                    .HasColumnType("datetime")
                    .HasComment("Connecting");

                entity.Property(e => e.ETD).HasColumnType("datetime");

                entity.Property(e => e.ETDConnecting).HasColumnType("datetime");

                entity.Property(e => e.EsDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ExConsigneeSign).HasMaxLength(50);

                entity.Property(e => e.ExpressDTUnit).HasMaxLength(50);

                entity.Property(e => e.GrosWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.HBLData).HasMaxLength(50);

                entity.Property(e => e.HWBNO).HasMaxLength(50);

                entity.Property(e => e.Height).HasDefaultValueSql("((0))");

                entity.Property(e => e.IDKeyShipment)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ISCANTDELIVER).HasDefaultValueSql("((0))");

                entity.Property(e => e.ISCANTPICKUP).HasDefaultValueSql("((0))");

                entity.Property(e => e.ISCREATEDHANDLINGTASK).HasDefaultValueSql("((0))");

                entity.Property(e => e.ISCREATEDMOBILETASK).HasDefaultValueSql("((0))");

                entity.Property(e => e.Incoterm).HasMaxLength(50);

                entity.Property(e => e.Length).HasDefaultValueSql("((0))");

                entity.Property(e => e.LoadingConfirmShipper).HasMaxLength(255);

                entity.Property(e => e.MAWB).HasMaxLength(50);

                entity.Property(e => e.MAWBSE).HasMaxLength(50);

                entity.Property(e => e.MaymentAPPName).HasMaxLength(150);

                entity.Property(e => e.MoocPKDate).HasColumnType("datetime");

                entity.Property(e => e.MoocStorageDate).HasColumnType("datetime");

                entity.Property(e => e.NMDeliverName).HasMaxLength(150);

                entity.Property(e => e.NMDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.NominationParty).HasMaxLength(255);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OwnerShipmentID).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PaidChecked).HasDefaultValueSql("((0))");

                entity.Property(e => e.PayableAC).HasMaxLength(50);

                entity.Property(e => e.PaymentMethod).HasMaxLength(50);

                entity.Property(e => e.PickupAt).HasMaxLength(150);

                entity.Property(e => e.PickupDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessNotes).HasMaxLength(255);

                entity.Property(e => e.ProfitShared).HasDefaultValueSql("((0))");

                entity.Property(e => e.Quantity)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Number of pieces");

                entity.Property(e => e.QuoNo).HasMaxLength(50);

                entity.Property(e => e.RateConfirm).HasMaxLength(50);

                entity.Property(e => e.ReceiptAt).HasMaxLength(50);

                entity.Property(e => e.RemoocNo).HasMaxLength(50);

                entity.Property(e => e.SC).HasMaxLength(50);

                entity.Property(e => e.SCIACI).HasMaxLength(50);

                entity.Property(e => e.SHMTPriority).HasMaxLength(50);

                entity.Property(e => e.STUFFINGEIR).HasMaxLength(50);

                entity.Property(e => e.SalesManID).HasMaxLength(50);

                entity.Property(e => e.SellTotalValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.ServiceMode).HasMaxLength(50);

                entity.Property(e => e.ServiceRQNo).HasMaxLength(50);

                entity.Property(e => e.ShipmentType).HasMaxLength(50);

                entity.Property(e => e.ShipperID).HasMaxLength(50);

                entity.Property(e => e.SpecialRequest).HasMaxLength(255);

                entity.Property(e => e.TKArrivedOn).HasColumnType("datetime");

                entity.Property(e => e.TKContactID).HasMaxLength(50);

                entity.Property(e => e.TKDeliveryOn).HasColumnType("datetime");

                entity.Property(e => e.TKDeployID).HasMaxLength(50);

                entity.Property(e => e.TKRomoocNo).HasMaxLength(25);

                entity.Property(e => e.TKSent).HasDefaultValueSql("((0))");

                entity.Property(e => e.TKSentOn).HasColumnType("datetime");

                entity.Property(e => e.TKStartPosition).HasMaxLength(50);

                entity.Property(e => e.TKStartedOn).HasColumnType("datetime");

                entity.Property(e => e.TKStatusReadDate).HasColumnType("datetime");

                entity.Property(e => e.TKStatusReadUser).HasMaxLength(50);

                entity.Property(e => e.TkRomoocReturnedOn).HasColumnType("datetime");

                entity.Property(e => e.TruckJob).HasMaxLength(50);

                entity.Property(e => e.TruckStorageDate).HasColumnType("datetime");

                entity.Property(e => e.UNSTUFFINGEIR).HasMaxLength(50);

                entity.Property(e => e.UnitDetail).HasMaxLength(50);

                entity.Property(e => e.UserConfirm).HasMaxLength(50);

                entity.Property(e => e.VesselVoyFlight).HasMaxLength(150);

                entity.Property(e => e.WeightChargeable).HasDefaultValueSql("((0))");

                entity.Property(e => e.Width).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.BookingID)
                    .HasConstraintName("FK_TransactionDetails_SeaBookingNote");

                entity.HasOne(d => d.Customs)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.CustomsID)
                    .HasConstraintName("FK_TransactionDetails_CustomsDeclaration");

                entity.HasOne(d => d.HWBNONavigation)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.HWBNO)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TransactionDetails_HAWB");

                entity.HasOne(d => d.Shipper)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.ShipperID)
                    .HasConstraintName("FK_TransactionDetails_Partners");

                entity.HasOne(d => d.Trans)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.TransID)
                    .HasConstraintName("FK_TransactionDetails_Transactions");
            });

            modelBuilder.Entity<TransactionDetailsRelatedPartners>(entity =>
            {
                entity.HasKey(e => e.TransIDKey);

                entity.Property(e => e.TransIDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.DateInput).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DateTrans).HasColumnType("datetime");

                entity.Property(e => e.HAWBNO).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.HasOne(d => d.HAWBNONavigation)
                    .WithMany(p => p.TransactionDetailsRelatedPartners)
                    .HasForeignKey(d => d.HAWBNO)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TransactionDetailsRelatedPartners_HAWB");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.TransactionDetailsRelatedPartners)
                    .HasForeignKey(d => d.PartnerID)
                    .HasConstraintName("FK_TransactionDetailsRelatedPartners_Partners");
            });

            modelBuilder.Entity<TransactionInfo>(entity =>
            {
                entity.HasKey(e => new { e.HAWBNO, e.Description })
                    .HasName("aaaaaTransactionInfo_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.HAWBNO, "HAWBTransactionInfo");

                entity.Property(e => e.HAWBNO).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ACTFinishDate).HasColumnType("datetime");

                entity.Property(e => e.Attached).HasColumnType("ntext");

                entity.Property(e => e.AttachedChecked).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasMaxLength(50);

                entity.Property(e => e.DateModifiedDT).HasColumnType("datetime");

                entity.Property(e => e.DescriptionDisplay).HasMaxLength(255);

                entity.Property(e => e.Evaluation).HasMaxLength(50);

                entity.Property(e => e.EvaluationDate).HasColumnType("datetime");

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.InfoDate).HasColumnType("datetime");

                entity.Property(e => e.JSSentDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OPStaffID).HasMaxLength(50);

                entity.Property(e => e.Object).HasMaxLength(50);

                entity.Property(e => e.WhoisMaking).HasMaxLength(50);

                entity.HasOne(d => d.HAWBNONavigation)
                    .WithMany(p => p.TransactionInfo)
                    .HasForeignKey(d => d.HAWBNO)
                    .HasConstraintName("TransactionInfo_FK00");
            });

            modelBuilder.Entity<TransactionInfoDetail>(entity =>
            {
                entity.HasKey(e => e.FieldKey);

                entity.Property(e => e.FieldKey).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileContent).HasColumnType("image");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.HAWBNO)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobNo).HasMaxLength(50);

                entity.Property(e => e.KeyDes).HasMaxLength(255);

                entity.Property(e => e.PartnerNo).HasMaxLength(50);

                entity.Property(e => e.UpdateHistory).HasMaxLength(4000);

                entity.Property(e => e.UserEdit).HasMaxLength(50);

                entity.HasOne(d => d.HAWBNONavigation)
                    .WithMany(p => p.TransactionInfoDetail)
                    .HasForeignKey(d => d.HAWBNO)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionInfoDetail_HAWB");
            });

            modelBuilder.Entity<TransactionLog>(entity =>
            {
                entity.HasKey(e => e.TransLogID)
                    .HasName("aaaaaTransactionLog_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.DateKey, "DateKey");

                entity.HasIndex(e => e.TransID, "TransactionID");

                entity.Property(e => e.TransLogID).HasMaxLength(50);

                entity.Property(e => e.ChangeValue).HasMaxLength(50);

                entity.Property(e => e.DateKey).HasColumnType("datetime");

                entity.Property(e => e.LogFile)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.Whois).HasMaxLength(50);
            });

            modelBuilder.Entity<TransactionType>(entity =>
            {
                entity.HasKey(e => e.IDTransType)
                    .HasName("aaaaaTransactionType_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.IDTransType, "IDTransType");

                entity.Property(e => e.IDTransType).HasMaxLength(50);

                entity.Property(e => e.ApproveManager).HasMaxLength(50);

                entity.Property(e => e.DayofLogisticsLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.IDResetOn).HasDefaultValueSql("((0))");

                entity.Property(e => e.Increment).HasMaxLength(50);

                entity.Property(e => e.LockAgainAfterUnlock).HasDefaultValueSql("((0))");

                entity.Property(e => e.MngAPP).HasDefaultValueSql("((0))");

                entity.Property(e => e.No).HasMaxLength(50);

                entity.Property(e => e.NoDaysLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.ObjectList).HasMaxLength(1000);

                entity.Property(e => e.Sign).HasMaxLength(50);

                entity.Property(e => e.SignaturePre).HasMaxLength(1000);

                entity.Property(e => e.TypeList).HasMaxLength(1000);

                entity.Property(e => e.TypeListComboboxStyle).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ys).HasMaxLength(50);

                entity.Property(e => e.sMonth).HasMaxLength(50);

                entity.Property(e => e.sYear).HasMaxLength(50);
            });

            modelBuilder.Entity<TransactionTypeDetail>(entity =>
            {
                entity.HasKey(e => e.IDKey)
                    .HasName("aaaaaTransactionTypeDetail_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.IDTransType, "IDTransType");

                entity.Property(e => e.ApproveManager).HasMaxLength(50);

                entity.Property(e => e.CompID).HasMaxLength(50);

                entity.Property(e => e.DayofLogisticsLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeptID).HasMaxLength(50);

                entity.Property(e => e.IDResetOn).HasDefaultValueSql("((0))");

                entity.Property(e => e.IDTransType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Increment).HasMaxLength(50);

                entity.Property(e => e.IsSystem).HasDefaultValueSql("((0))");

                entity.Property(e => e.LockAgainAfterUnlock).HasDefaultValueSql("((0))");

                entity.Property(e => e.MngAPP).HasDefaultValueSql("((0))");

                entity.Property(e => e.No).HasMaxLength(50);

                entity.Property(e => e.NoDaysLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.RateRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.Request).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sign).HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ys).HasMaxLength(50);

                entity.Property(e => e.sMonth).HasMaxLength(50);

                entity.Property(e => e.sYear).HasMaxLength(50);
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.HasKey(e => e.TransID)
                    .HasName("aaaaaTransactions_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.AgentID, "AgentID");

                entity.HasIndex(e => e.AgentID, "AgentID_Transactions");

                entity.HasIndex(e => new { e.AgentID, e.WhoisMaking, e.ColoaderID }, "Agent_WhoisMaking_Coloader");

                entity.HasIndex(e => e.AirPortID, "AirPortID");

                entity.HasIndex(e => e.ColoaderID, "ColoaderID");

                entity.HasIndex(e => e.ColoaderID, "ColoaderID_Transactions");

                entity.HasIndex(e => e.ContactID, "ContactID");

                entity.HasIndex(e => e.WhoisMaking, "ContactsListTransactions");

                entity.HasIndex(e => e.ContactID, "ContactsListTransactions1");

                entity.HasIndex(e => e.Destination, "DEST_Transactions");

                entity.HasIndex(e => e.MAWB, "IX_Transactions");

                entity.HasIndex(e => e.MAWB, "MAWB_Transactions");

                entity.HasIndex(e => e.PortofUnlading, "POD_Transactions");

                entity.HasIndex(e => e.PortofLading, "POL_Transactions");

                entity.HasIndex(e => e.ColoaderID, "PartnersTransactions");

                entity.HasIndex(e => e.AgentID, "PartnersTransactions1");

                entity.HasIndex(e => e.PayableAgentID, "PayableAgentID");

                entity.HasIndex(e => e.TransID, "TransID");

                entity.HasIndex(e => e.TpyeofService, "TransactionTypeTransactions");

                entity.HasIndex(e => e.WhoisMaking, "WhoisMaking_Transactions");

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.ATA3).HasColumnType("datetime");

                entity.Property(e => e.ATA4).HasColumnType("datetime");

                entity.Property(e => e.ATD3).HasColumnType("datetime");

                entity.Property(e => e.ATD4).HasColumnType("datetime");

                entity.Property(e => e.ATTNofPrealert).HasMaxLength(150);

                entity.Property(e => e.AcsCTRLDate).HasColumnType("datetime");

                entity.Property(e => e.AcsCTRLDateRun).HasColumnType("datetime");

                entity.Property(e => e.AcsCTRLDateRunUser).HasMaxLength(50);

                entity.Property(e => e.AgentID).HasMaxLength(50);

                entity.Property(e => e.AirDimension).HasMaxLength(150);

                entity.Property(e => e.AirLine).HasMaxLength(255);

                entity.Property(e => e.AirPortID).HasMaxLength(150);

                entity.Property(e => e.Amount).HasMaxLength(50);

                entity.Property(e => e.ApproveDate).HasColumnType("datetime");

                entity.Property(e => e.Approvedby).HasMaxLength(50);

                entity.Property(e => e.ArrivalDate).HasColumnType("datetime");

                entity.Property(e => e.Attn).HasMaxLength(150);

                entity.Property(e => e.BookingRequestNotes).HasMaxLength(150);

                entity.Property(e => e.Cancelled).HasDefaultValueSql("((0))");

                entity.Property(e => e.ChildShipment).HasDefaultValueSql("((0))");

                entity.Property(e => e.ClearedDate).HasColumnType("datetime");

                entity.Property(e => e.ColoaderID).HasMaxLength(50);

                entity.Property(e => e.ColoaderRouting).HasColumnType("ntext");

                entity.Property(e => e.Consign).HasMaxLength(50);

                entity.Property(e => e.ConsoleNoteAgent).HasMaxLength(255);

                entity.Property(e => e.ConsoleNoteCarrier).HasMaxLength(255);

                entity.Property(e => e.ConsoleNoteOthers).HasMaxLength(255);

                entity.Property(e => e.ConsoleNoteShipper).HasMaxLength(255);

                entity.Property(e => e.Consolidatater).HasMaxLength(150);

                entity.Property(e => e.ContSealNo).HasMaxLength(150);

                entity.Property(e => e.ContactID).HasMaxLength(50);

                entity.Property(e => e.ContainerSize).HasMaxLength(150);

                entity.Property(e => e.DateofPrealert).HasColumnType("datetime");

                entity.Property(e => e.DeConsolidatater).HasMaxLength(150);

                entity.Property(e => e.DeliverDateText).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Destination).HasMaxLength(150);

                entity.Property(e => e.DestinationDate).HasColumnType("datetime");

                entity.Property(e => e.ETA).HasColumnType("datetime");

                entity.Property(e => e.ETA3).HasColumnType("datetime");

                entity.Property(e => e.ETA4).HasColumnType("datetime");

                entity.Property(e => e.ETAConnect).HasColumnType("datetime");

                entity.Property(e => e.ETATransit).HasColumnType("datetime");

                entity.Property(e => e.ETD3).HasColumnType("datetime");

                entity.Property(e => e.ETD4).HasColumnType("datetime");

                entity.Property(e => e.ETDConnect).HasColumnType("datetime");

                entity.Property(e => e.ETDTransit).HasColumnType("datetime");

                entity.Property(e => e.ErrorAttr).HasDefaultValueSql("((0))");

                entity.Property(e => e.EstimatedVessel).HasMaxLength(150);

                entity.Property(e => e.ExpressNotes).HasMaxLength(255);

                entity.Property(e => e.ExpressUnit).HasMaxLength(50);

                entity.Property(e => e.FlghtNo).HasMaxLength(50);

                entity.Property(e => e.FlightDateConfirm).HasColumnType("datetime");

                entity.Property(e => e.FlightNo3).HasMaxLength(50);

                entity.Property(e => e.FlightNo4).HasMaxLength(50);

                entity.Property(e => e.FlightScheduleRequest).HasColumnType("datetime");

                entity.Property(e => e.Forwarder).HasMaxLength(255);

                entity.Property(e => e.FullJob).HasDefaultValueSql("((0))");

                entity.Property(e => e.FullJobDate).HasColumnType("datetime");

                entity.Property(e => e.HandlingInformation).HasMaxLength(255);

                entity.Property(e => e.INVReady).HasDefaultValueSql("((0))");

                entity.Property(e => e.INVReadyDate).HasColumnType("datetime");

                entity.Property(e => e.IssuedDate).HasColumnType("datetime");

                entity.Property(e => e.IssuedPlace).HasMaxLength(50);

                entity.Property(e => e.LoadingDate).HasColumnType("datetime");

                entity.Property(e => e.LogSV).HasMaxLength(50);

                entity.Property(e => e.MAWB).HasMaxLength(50);

                entity.Property(e => e.MTDeadline).HasColumnType("datetime");

                entity.Property(e => e.ManifestNo).HasMaxLength(50);

                entity.Property(e => e.MarksRegistration).HasMaxLength(150);

                entity.Property(e => e.ModeSea).HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.NatureofGoods).HasColumnType("ntext");

                entity.Property(e => e.NoofPages).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OMB).HasMaxLength(50);

                entity.Property(e => e.OceanVesselName).HasMaxLength(50);

                entity.Property(e => e.OceanVoy).HasMaxLength(50);

                entity.Property(e => e.OtherInfo).HasMaxLength(255);

                entity.Property(e => e.PODC3).HasMaxLength(50);

                entity.Property(e => e.PODC4).HasMaxLength(50);

                entity.Property(e => e.POLC3).HasMaxLength(50);

                entity.Property(e => e.POLC4).HasMaxLength(50);

                entity.Property(e => e.PayableAgentID).HasMaxLength(50);

                entity.Property(e => e.PaymentTerm).HasMaxLength(50);

                entity.Property(e => e.PortofLading).HasMaxLength(150);

                entity.Property(e => e.PortofUnlading).HasMaxLength(150);

                entity.Property(e => e.RateRequest).HasMaxLength(50);

                entity.Property(e => e.Ref).HasMaxLength(255);

                entity.Property(e => e.RefNoSea).HasMaxLength(150);

                entity.Property(e => e.RefSellingRate).HasMaxLength(255);

                entity.Property(e => e.Remark).HasMaxLength(4000);

                entity.Property(e => e.ReportInfor)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Revision).HasColumnType("datetime");

                entity.Property(e => e.RoleATTN).HasMaxLength(255);

                entity.Property(e => e.RoleFrom).HasMaxLength(255);

                entity.Property(e => e.RoleShipper).HasMaxLength(255);

                entity.Property(e => e.RouteDelivery).HasMaxLength(50);

                entity.Property(e => e.SIConsigneeID).HasMaxLength(50);

                entity.Property(e => e.SIMoveType).HasMaxLength(50);

                entity.Property(e => e.SINotifyID).HasMaxLength(50);

                entity.Property(e => e.SIServiceType).HasMaxLength(50);

                entity.Property(e => e.SIShipperID).HasMaxLength(50);

                entity.Property(e => e.SIStatus).HasMaxLength(50);

                entity.Property(e => e.SeaRevised).HasMaxLength(150);

                entity.Property(e => e.SeaUnit).HasMaxLength(50);

                entity.Property(e => e.ShipmentCommentBLClause).HasMaxLength(50);

                entity.Property(e => e.ShipmentCommentGen).HasMaxLength(50);

                entity.Property(e => e.ShipperRef).HasMaxLength(50);

                entity.Property(e => e.ShowMark).HasDefaultValueSql("((0))");

                entity.Property(e => e.Starus).HasMaxLength(1000);

                entity.Property(e => e.StatusRoutine1).HasMaxLength(50);

                entity.Property(e => e.StatusRoutine2).HasMaxLength(50);

                entity.Property(e => e.StatusRoutine3).HasMaxLength(50);

                entity.Property(e => e.StatusRoutine4).HasMaxLength(50);

                entity.Property(e => e.TpyeofService).HasMaxLength(50);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionNotes)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TransitCBMRndUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.TransitCBMRoundable).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransitPortDes).HasMaxLength(150);

                entity.Property(e => e.UnitPieaces).HasMaxLength(50);

                entity.Property(e => e.WhoisMaking).HasMaxLength(50);

                entity.HasOne(d => d.TpyeofServiceNavigation)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.TpyeofService)
                    .HasConstraintName("FK_Transactions_TransactionType");
            });

            modelBuilder.Entity<TransactionsChange>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ChangeMode).HasMaxLength(50);

                entity.Property(e => e.DateInsert).HasColumnType("datetime");

                entity.Property(e => e.DateReceipt).HasColumnType("datetime");

                entity.Property(e => e.HBLNo).HasMaxLength(50);

                entity.Property(e => e.NewValue).HasMaxLength(150);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OldValue).HasMaxLength(150);

                entity.Property(e => e.PCName).HasMaxLength(100);

                entity.Property(e => e.Received).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransID).HasMaxLength(50);

                entity.Property(e => e.Userchange).HasMaxLength(50);
            });

            modelBuilder.Entity<TransactionsChangeHis>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCheck).HasColumnType("datetime");

                entity.Property(e => e.IDKeyLinked).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.SourceType).HasMaxLength(50);

                entity.Property(e => e.UserChecked).HasMaxLength(50);
            });

            modelBuilder.Entity<UN_LOC_Code>(entity =>
            {
                entity.HasKey(e => e.CITY_UN_CODE);

                entity.Property(e => e.CITY_UN_CODE).HasMaxLength(50);

                entity.Property(e => e.CITY_NAME).HasMaxLength(150);

                entity.Property(e => e.COUNTRY_NAME).HasMaxLength(50);

                entity.Property(e => e.STATE_NAME).HasMaxLength(150);
            });

            modelBuilder.Entity<UnitContents>(entity =>
            {
                entity.HasKey(e => e.UnitID)
                    .HasName("aaaaaUnitContents_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.UnitID, "UnitID");

                entity.Property(e => e.UnitID).HasMaxLength(50);

                entity.Property(e => e.AMSCode).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Height).HasDefaultValueSql("((0))");

                entity.Property(e => e.InttraUnit).HasMaxLength(50);

                entity.Property(e => e.KGs).HasMaxLength(50);

                entity.Property(e => e.Lenght).HasDefaultValueSql("((0))");

                entity.Property(e => e.LocalUnit).HasMaxLength(50);

                entity.Property(e => e.LocalUnitVAT).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.OrgeCountry).HasMaxLength(50);

                entity.Property(e => e.Width).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UpdateProcess>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("aaaaaUpdateProcess_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ID, "ID")
                    .IsUnique();

                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.CHINHANH).HasMaxLength(255);

                entity.Property(e => e.ComputerLog).HasColumnType("ntext");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Destination).HasMaxLength(255);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.Source).HasMaxLength(255);
            });

            modelBuilder.Entity<VATInvSOA>(entity =>
            {
                entity.HasKey(e => e.SOANO);

                entity.Property(e => e.SOANO).HasMaxLength(50);

                entity.Property(e => e.DateOfIssued).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.IssuedBy).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.PartnerName).HasMaxLength(255);

                entity.Property(e => e.RevisedDate).HasColumnType("datetime");

                entity.Property(e => e.SOADate).HasColumnType("datetime");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.VoidDate).HasColumnType("datetime");

                entity.Property(e => e.WhoisPaid).HasMaxLength(50);

                entity.Property(e => e.WhoisRevised).HasMaxLength(50);

                entity.Property(e => e.WhoisVoid).HasMaxLength(50);
            });

            modelBuilder.Entity<VATInvoice>(entity =>
            {
                entity.HasKey(e => new { e.ID, e.InvoiceNo })
                    .HasName("aaaaaVATInvoice_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.CustomerID, "CustomerID");

                entity.HasIndex(e => e.RedInvIDKey, "IX_VATInvoice")
                    .IsUnique();

                entity.HasIndex(e => e.ID, "InvoiceFormVATInvoice");

                entity.HasIndex(e => e.ID, "InvoiceID");

                entity.HasIndex(e => e.InvoiceID, "InvoiceID1");

                entity.HasIndex(e => e.InvoiceNo, "InvoiceNo");

                entity.HasIndex(e => e.CustomerID, "PartnersVATInvoice");

                entity.HasIndex(e => e.RedInvIDKey, "RedInvIDKey_U")
                    .IsUnique();

                entity.Property(e => e.ID).HasMaxLength(50);

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.ACVoucher).HasDefaultValueSql("((0))");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.AttachDescription).HasMaxLength(255);

                entity.Property(e => e.AttachNo).HasMaxLength(50);

                entity.Property(e => e.AttachUnit).HasMaxLength(50);

                entity.Property(e => e.Attached).HasDefaultValueSql("((0))");

                entity.Property(e => e.Attn).HasMaxLength(255);

                entity.Property(e => e.ChangeDateTime).HasColumnType("datetime");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.ConnectStringOrigin).HasMaxLength(1000);

                entity.Property(e => e.Consignee).HasMaxLength(255);

                entity.Property(e => e.Consignor).HasMaxLength(255);

                entity.Property(e => e.ContractDate).HasColumnType("datetime");

                entity.Property(e => e.ContractNo).HasMaxLength(50);

                entity.Property(e => e.CurConvert).HasMaxLength(50);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.CustomNo).HasMaxLength(255);

                entity.Property(e => e.CustomerID).HasMaxLength(50);

                entity.Property(e => e.DDHG).HasMaxLength(50);

                entity.Property(e => e.DDNH).HasMaxLength(50);

                entity.Property(e => e.DateExport).HasColumnType("datetime");

                entity.Property(e => e.DateGET).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DateReadCancelStatus).HasColumnType("datetime");

                entity.Property(e => e.DateSync).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.DisplayBLDetail).HasDefaultValueSql("((0))");

                entity.Property(e => e.DraftInv).HasDefaultValueSql("((0))");

                entity.Property(e => e.ESigned).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportLog).HasMaxLength(1000);

                entity.Property(e => e.Exported).HasDefaultValueSql("((0))");

                entity.Property(e => e.FKeyTemp).HasMaxLength(50);

                entity.Property(e => e.Fkey).HasMaxLength(255);

                entity.Property(e => e.FkeyRandom).HasMaxLength(255);

                entity.Property(e => e.FkeyTMP).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ForeignCurr).HasDefaultValueSql("((0))");

                entity.Property(e => e.GETEINV).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupByBLInv).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupByCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupByJob).HasDefaultValueSql("((0))");

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.INVLockDate).HasColumnType("datetime");

                entity.Property(e => e.INVOpenTrans).HasMaxLength(4000);

                entity.Property(e => e.IPAddress).HasMaxLength(255);

                entity.Property(e => e.ISSYNC).HasDefaultValueSql("((0))");

                entity.Property(e => e.ImportedDate).HasColumnType("datetime");

                entity.Property(e => e.InvEDIT).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvHelpof).HasMaxLength(255);

                entity.Property(e => e.InvIDEDITOf).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InvoiceBkavLog).HasColumnType("ntext");

                entity.Property(e => e.InvoiceCode).HasMaxLength(255);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceID).HasMaxLength(50);

                entity.Property(e => e.InvoiceNoSync).HasMaxLength(255);

                entity.Property(e => e.InvoiceSyncLog).HasColumnType("ntext");

                entity.Property(e => e.Inword).HasMaxLength(255);

                entity.Property(e => e.JobNo).HasMaxLength(50);

                entity.Property(e => e.LinkEInvoice).HasMaxLength(255);

                entity.Property(e => e.LinkedFkey).HasMaxLength(255);

                entity.Property(e => e.LogFile).HasMaxLength(4000);

                entity.Property(e => e.MBLNo).HasMaxLength(50);

                entity.Property(e => e.NgayVanBan).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.OriginCustomerID).HasMaxLength(50);

                entity.Property(e => e.OriginRefNo).HasMaxLength(50);

                entity.Property(e => e.OriginalInvoiceIdentify).HasMaxLength(255);

                entity.Property(e => e.PaymentMethod).HasMaxLength(255);

                entity.Property(e => e.RMUpdatedUser).HasMaxLength(50);

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.RedInvIDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RefNoType).HasMaxLength(50);

                entity.Property(e => e.SOANO).HasMaxLength(50);

                entity.Property(e => e.SalesMethod).HasMaxLength(50);

                entity.Property(e => e.SelectedPage).HasMaxLength(50);

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.Property(e => e.SoVanBan).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.StatusAdjust).HasMaxLength(255);

                entity.Property(e => e.StatusAdjustTo).HasMaxLength(255);

                entity.Property(e => e.StatusAdjustedBy).HasMaxLength(255);

                entity.Property(e => e.StatusCancel).HasMaxLength(255);

                entity.Property(e => e.StatusReplace).HasMaxLength(255);

                entity.Property(e => e.StatusReplaceTo).HasMaxLength(255);

                entity.Property(e => e.StatusReplacedBy).HasMaxLength(255);

                entity.Property(e => e.TMPDDHG).HasMaxLength(255);

                entity.Property(e => e.TMPDDNH).HasMaxLength(255);

                entity.Property(e => e.TMPETA).HasColumnType("datetime");

                entity.Property(e => e.TMPETD).HasColumnType("datetime");

                entity.Property(e => e.TRSOANo).HasMaxLength(50);

                entity.Property(e => e.TaxDateExport).HasColumnType("datetime");

                entity.Property(e => e.TaxExported).HasDefaultValueSql("((0))");

                entity.Property(e => e.Taxcode).HasMaxLength(50);

                entity.Property(e => e.TempInvoiceCode).HasMaxLength(255);

                entity.Property(e => e.TempInvoiceNoSync).HasMaxLength(255);

                entity.Property(e => e.TypeAdjust).HasMaxLength(255);

                entity.Property(e => e.VATEDIT).HasDefaultValueSql("((0))");

                entity.Property(e => e.VATPaid).HasDefaultValueSql("((0))");

                entity.Property(e => e.VATPaidDate).HasColumnType("datetime");

                entity.Property(e => e.VATRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.VATReceived).HasDefaultValueSql("((0))");

                entity.Property(e => e.VATTotal).HasDefaultValueSql("((0))");

                entity.Property(e => e.VesselVoy).HasMaxLength(255);

                entity.Property(e => e.VoucherNo).HasMaxLength(50);

                entity.Property(e => e.VoucherNoSE).HasMaxLength(50);

                entity.Property(e => e.WhoModify).HasMaxLength(50);

                entity.Property(e => e.WhoSync).HasMaxLength(255);

                entity.Property(e => e.WhoisMaking).HasMaxLength(50);

                entity.Property(e => e.WhoisPaid).HasMaxLength(50);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.VATInvoice)
                    .HasForeignKey(d => d.CustomerID)
                    .HasConstraintName("VATInvoice_FK01");

                entity.HasOne(d => d.IDNavigation)
                    .WithMany(p => p.VATInvoice)
                    .HasForeignKey(d => d.ID)
                    .HasConstraintName("VATInvoice_FK00");

                entity.HasOne(d => d.SOANONavigation)
                    .WithMany(p => p.VATInvoice)
                    .HasForeignKey(d => d.SOANO)
                    .HasConstraintName("FK_VATInvoice_VATInvSOA");
            });

            modelBuilder.Entity<VATInvoiceDetail>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Description, "Description");

                entity.HasIndex(e => e.ID, "ID");

                entity.HasIndex(e => e.InvoiceNo, "InvoiceNo");

                entity.HasIndex(e => new { e.ID, e.InvoiceNo }, "VATInvoiceVATInvoiceDetail");

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DeptCode).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.Property(e => e.HBLNo)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ID)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.I)
                    .WithMany()
                    .HasForeignKey(d => new { d.ID, d.InvoiceNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("VATInvoiceDetail_FK00");
            });

            modelBuilder.Entity<VATInvoiceDetailAT>(entity =>
            {
                entity.HasKey(e => new { e.ID, e.InvoiceNo, e.No });

                entity.Property(e => e.ID).HasMaxLength(50);

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DeptCode).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.HBLNo).HasMaxLength(150);

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.I)
                    .WithMany(p => p.VATInvoiceDetailAT)
                    .HasForeignKey(d => new { d.ID, d.InvoiceNo })
                    .HasConstraintName("FK_VATInvoiceDetailAT_VATInvoice");
            });

            modelBuilder.Entity<VATInvoiceDetailSource>(entity =>
            {
                entity.HasKey(e => new { e.ID, e.InvoiceNo, e.No });

                entity.Property(e => e.ID).HasMaxLength(50);

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DeptCode).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.HBLNo).HasMaxLength(150);

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.I)
                    .WithMany(p => p.VATInvoiceDetailSource)
                    .HasForeignKey(d => new { d.ID, d.InvoiceNo })
                    .HasConstraintName("FK_VATInvoiceDetailSource_VATInvoice");
            });

            modelBuilder.Entity<VATInvoiceLog>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.IDKey)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(155);

                entity.Property(e => e.IDKeyLinked).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InvoiceType).HasMaxLength(50);

                entity.Property(e => e.NotifyContent).HasMaxLength(150);

                entity.Property(e => e.NotifyDate).HasColumnType("datetime");

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.HasOne(d => d.IDKeyLinkedNavigation)
                    .WithMany(p => p.VATInvoiceLog)
                    .HasPrincipalKey(p => p.RedInvIDKey)
                    .HasForeignKey(d => d.IDKeyLinked)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VATInvoiceLog_VATInvoice");
            });

            modelBuilder.Entity<VATInvoiceSyncLog>(entity =>
            {
                entity.Property(e => e.ID)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateLog).HasColumnType("datetime");

                entity.Property(e => e.FkeyRandom).HasMaxLength(255);

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.IDKey).HasMaxLength(255);

                entity.Property(e => e.IPAddress).HasMaxLength(255);

                entity.Property(e => e.InvoiceID).HasMaxLength(255);

                entity.Property(e => e.InvoiceNo).HasMaxLength(255);

                entity.Property(e => e.ReferenceKey).HasMaxLength(255);

                entity.Property(e => e.TypeAdjust).HasMaxLength(255);

                entity.Property(e => e.WhoSync).HasMaxLength(255);

                entity.Property(e => e.btnText).HasMaxLength(255);
            });

            modelBuilder.Entity<VehicleAlerterConfig>(entity =>
            {
                entity.Property(e => e.ID)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AlerterTypeId).HasMaxLength(50);

                entity.Property(e => e.AlerterTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<VehicleAlerterHistory>(entity =>
            {
                entity.Property(e => e.ID)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AlerterTypeId).HasMaxLength(50);

                entity.Property(e => e.ContactID).HasMaxLength(200);

                entity.Property(e => e.DeadLine).HasColumnType("datetime");

                entity.Property(e => e.VehicleNo).HasMaxLength(50);

                entity.Property(e => e.maxFkey).HasMaxLength(50);
            });

            modelBuilder.Entity<VehicleFuelConsumption>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.VHUnitNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.VHUnitNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.VHUnitNo)
                    .HasConstraintName("FK_VehicleFuelConsumption_VehicleList");
            });

            modelBuilder.Entity<VehicleList>(entity =>
            {
                entity.HasKey(e => e.VHUnitNo);

                entity.Property(e => e.VHUnitNo).HasMaxLength(50);

                entity.Property(e => e.BLTruckNo).HasMaxLength(50);

                entity.Property(e => e.DateInput).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.EmpPhotoSize).HasMaxLength(255);

                entity.Property(e => e.Inuse).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlateNo).HasMaxLength(50);

                entity.Property(e => e.PlateRewal).HasMaxLength(50);

                entity.Property(e => e.Remooc).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.Property(e => e.VHBuyingDate).HasColumnType("datetime");

                entity.Property(e => e.VHColor).HasMaxLength(50);

                entity.Property(e => e.VHCurrency).HasMaxLength(50);

                entity.Property(e => e.VHDeptID).HasMaxLength(50);

                entity.Property(e => e.VHDriver).HasMaxLength(255);

                entity.Property(e => e.VHDriverPhone).HasMaxLength(50);

                entity.Property(e => e.VHEmployeeNumber).HasMaxLength(50);

                entity.Property(e => e.VHFuelType).HasMaxLength(50);

                entity.Property(e => e.VHGroup).HasMaxLength(50);

                entity.Property(e => e.VHImage).HasColumnType("image");

                entity.Property(e => e.VHMake).HasMaxLength(50);

                entity.Property(e => e.VHModel).HasMaxLength(50);

                entity.Property(e => e.VHNote).HasMaxLength(255);

                entity.Property(e => e.VHOdometer).HasMaxLength(50);

                entity.Property(e => e.VHType).HasMaxLength(50);

                entity.Property(e => e.VHUnitDT).HasMaxLength(50);

                entity.Property(e => e.VHUnitFC).HasMaxLength(50);

                entity.Property(e => e.VHVIN).HasMaxLength(50);

                entity.Property(e => e.VHYear).HasMaxLength(50);

                entity.Property(e => e.VendorID).HasMaxLength(50);
            });

            modelBuilder.Entity<VehicleServiceFeeDefined>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.ActiveSV).HasDefaultValueSql("(0)");

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DateInput).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DirecttoShipment).HasDefaultValueSql("((0))");

                entity.Property(e => e.DistanceApply).HasDefaultValueSql("(0)");

                entity.Property(e => e.FeeCode).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.PerRev).HasDefaultValueSql("(0)");

                entity.Property(e => e.PerRevEx).HasDefaultValueSql("(0)");

                entity.Property(e => e.ServiceName).HasMaxLength(255);

                entity.Property(e => e.TransEMPTYRETURN).HasMaxLength(50);

                entity.Property(e => e.TransFrom).HasMaxLength(50);

                entity.Property(e => e.TransTo).HasMaxLength(50);

                entity.Property(e => e.TripApply).HasDefaultValueSql("(0)");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.Property(e => e.VAT).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VHUnitNo).HasMaxLength(50);
            });

            modelBuilder.Entity<VehicleServiceFeeDefinedHis>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.ActiveSV).HasDefaultValueSql("(0)");

                entity.Property(e => e.Curr).HasMaxLength(50);

                entity.Property(e => e.DateInput).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.DistanceApply).HasDefaultValueSql("(0)");

                entity.Property(e => e.FeeCode).HasMaxLength(50);

                entity.Property(e => e.IDKeyMaster).HasMaxLength(255);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.PerRev).HasDefaultValueSql("(0)");

                entity.Property(e => e.PerRevEx).HasDefaultValueSql("(0)");

                entity.Property(e => e.ServiceName).HasMaxLength(255);

                entity.Property(e => e.TransEMPTYRETURN).HasMaxLength(50);

                entity.Property(e => e.TransFrom).HasMaxLength(50);

                entity.Property(e => e.TransTo).HasMaxLength(50);

                entity.Property(e => e.TripApply).HasDefaultValueSql("(0)");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.Property(e => e.VAT).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VHUnitNo).HasMaxLength(50);
            });

            modelBuilder.Entity<Vessel>(entity =>
            {
                entity.HasKey(e => e.VesselCode);

                entity.Property(e => e.VesselCode).HasMaxLength(50);

                entity.Property(e => e.Qualifier).HasMaxLength(50);

                entity.Property(e => e.Scac).HasMaxLength(50);

                entity.Property(e => e.VesselFlag).HasMaxLength(50);

                entity.Property(e => e.VesselName).HasMaxLength(150);
            });

            modelBuilder.Entity<VesselSchedules>(entity =>
            {
                entity.HasKey(e => e.IDKey);

                entity.Property(e => e.CargoCutoff).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DOCCutoff).HasMaxLength(50);

                entity.Property(e => e.DestC).HasMaxLength(50);

                entity.Property(e => e.ETADest).HasMaxLength(50);

                entity.Property(e => e.ETAPOP).HasMaxLength(50);

                entity.Property(e => e.ETD).HasMaxLength(50);

                entity.Property(e => e.ETDDest).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.PODC).HasMaxLength(50);

                entity.Property(e => e.POLC).HasMaxLength(50);

                entity.Property(e => e.PartnerID).HasMaxLength(50);

                entity.Property(e => e.ServiceID).HasMaxLength(255);

                entity.Property(e => e.ServiceType).HasMaxLength(50);

                entity.Property(e => e.StuffingPlace).HasMaxLength(50);

                entity.Property(e => e.TransitTime).HasMaxLength(50);

                entity.Property(e => e.UserInput).HasMaxLength(50);

                entity.Property(e => e.VesselName).HasMaxLength(50);

                entity.Property(e => e.VoyageNo).HasMaxLength(50);
            });

            modelBuilder.Entity<YourCompany>(entity =>
            {
                entity.HasKey(e => e.CmpID)
                    .HasName("aaaaaYourCompany_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.CmpID, "CmpID");

                entity.HasIndex(e => e.IbanCode, "IbanCode");

                entity.HasIndex(e => e.SwiftCode, "SwiftCode");

                entity.HasIndex(e => e.Taxcode, "Taxcode");

                entity.Property(e => e.CmpID).HasMaxLength(50);

                entity.Property(e => e.ACApproveAfterMNg).HasDefaultValueSql("((0))");

                entity.Property(e => e.ACAsignGroupByVATInvOnly).HasDefaultValueSql("((0))");

                entity.Property(e => e.ACStaffDeleteEntire).HasDefaultValueSql("((0))");

                entity.Property(e => e.ADVSTLCurrency).HasMaxLength(50);

                entity.Property(e => e.AMSACISubmit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AMSCUST_ID).HasMaxLength(50);

                entity.Property(e => e.AMSReceiverID).HasMaxLength(50);

                entity.Property(e => e.AMSSenderID).HasMaxLength(50);

                entity.Property(e => e.APP_AREA_IND).HasMaxLength(50);

                entity.Property(e => e.AccountName).HasMaxLength(150);

                entity.Property(e => e.AccountNote).HasMaxLength(150);

                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.Address2).HasMaxLength(150);

                entity.Property(e => e.AddressLocal).HasMaxLength(255);

                entity.Property(e => e.AgentUseInternal).HasDefaultValueSql("((0))");

                entity.Property(e => e.AllowOPUpdatePartners).HasDefaultValueSql("((0))");

                entity.Property(e => e.ApproveMode).HasDefaultValueSql("((0))");

                entity.Property(e => e.AuthorizedStopAPP).HasDefaultValueSql("((0))");

                entity.Property(e => e.AverageQarterOT).HasDefaultValueSql("((0))");

                entity.Property(e => e.BILL_DO_RequireDOCSRelease).HasDefaultValueSql("((0))");

                entity.Property(e => e.BankAddress).HasMaxLength(255);

                entity.Property(e => e.BankName).HasMaxLength(150);

                entity.Property(e => e.BaseOnTotalAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.BravoCostAcNo).HasMaxLength(255);

                entity.Property(e => e.BravoOBHAcNo).HasMaxLength(255);

                entity.Property(e => e.BravoRevAcNo).HasMaxLength(255);

                entity.Property(e => e.CDSManualInput).HasDefaultValueSql("((0))");

                entity.Property(e => e.CSApprovedPayment).HasDefaultValueSql("((0))");

                entity.Property(e => e.CUST_ID).HasMaxLength(50);

                entity.Property(e => e.ChangeDefaultIllegal).HasDefaultValueSql("((0))");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyLocal).HasMaxLength(150);

                entity.Property(e => e.Companyname).HasMaxLength(150);

                entity.Property(e => e.ContManagement).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrAmount).HasMaxLength(50);

                entity.Property(e => e.DFRPCurr).HasMaxLength(50);

                entity.Property(e => e.DNVCBaseonVATInv).HasDefaultValueSql("((0))");

                entity.Property(e => e.DaysofReLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeleteTempFilesAfterSubmit).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeniedChangeShipmentAfterSettled).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DirectACSettleCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmpPhotoSize).HasMaxLength(255);

                entity.Property(e => e.EnableCustomerAdvanceTab).HasDefaultValueSql("((0))");

                entity.Property(e => e.EnableDuplicatedPartners).HasDefaultValueSql("((0))");

                entity.Property(e => e.EnforcePasswordPolicy).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExchangeUpdateWhenINVIssued).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportLockDays).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtoLocalCurrInVATInv).HasDefaultValueSql("((0))");

                entity.Property(e => e.FHPrefix).HasMaxLength(50);

                entity.Property(e => e.FNAccountNo).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FillUSDAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForeignCurrRoundable).HasDefaultValueSql("((0))");

                entity.Property(e => e.FtpDir).HasMaxLength(50);

                entity.Property(e => e.FtpPwd).HasMaxLength(50);

                entity.Property(e => e.FtpRCDir).HasMaxLength(50);

                entity.Property(e => e.FtpURL).HasMaxLength(50);

                entity.Property(e => e.FtpUsername).HasMaxLength(50);

                entity.Property(e => e.HBLQtySyn).HasDefaultValueSql("((0))");

                entity.Property(e => e.HidePasswordCharAdmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.IbanCode).HasMaxLength(50);

                entity.Property(e => e.IgnoreInvNoWhenCheckSettlementDuplicate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ImportLockDays).HasDefaultValueSql("((0))");

                entity.Property(e => e.InternalPartnerUseOnly).HasDefaultValueSql("((0))");

                entity.Property(e => e.InttraBookerID).HasMaxLength(50);

                entity.Property(e => e.InttraFtpBKCDir).HasMaxLength(50);

                entity.Property(e => e.InttraFtpDir).HasMaxLength(50);

                entity.Property(e => e.InttraFtpPwd).HasMaxLength(50);

                entity.Property(e => e.InttraFtpSIDir).HasMaxLength(50);

                entity.Property(e => e.InttraFtpTNTDir).HasMaxLength(50);

                entity.Property(e => e.InttraFtpURL).HasMaxLength(50);

                entity.Property(e => e.InttraFtpUsername).HasMaxLength(50);

                entity.Property(e => e.InttraSIID).HasMaxLength(50);

                entity.Property(e => e.InttraSenderID).HasMaxLength(50);

                entity.Property(e => e.InvoiceNeedACCApp).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceNeedMNGApp).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCDateFormat).HasMaxLength(50);

                entity.Property(e => e.LCSalesProfitBaseonUSDProfit).HasDefaultValueSql("((0))");

                entity.Property(e => e.LeadsToPotential).HasDefaultValueSql("((0))");

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.LockChargesAfterInput).HasDefaultValueSql("((0))");

                entity.Property(e => e.LockNewPartner).HasDefaultValueSql("((0))");

                entity.Property(e => e.LockShipmentAfterPrintPL).HasDefaultValueSql("((0))");

                entity.Property(e => e.LockedInvInpayment).HasDefaultValueSql("((0))");

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.MAWBF).HasDefaultValueSql("((0))");

                entity.Property(e => e.ManageOfficeID).HasMaxLength(255);

                entity.Property(e => e.NACCS_ID).HasMaxLength(50);

                entity.Property(e => e.NACCS_PWD).HasMaxLength(50);

                entity.Property(e => e.NewIDGenerateAfter).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoIncludeCountry).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoRestrictOverDue).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoVATInRemoteCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.NolockDocument).HasDefaultValueSql("((0))");

                entity.Property(e => e.NomiPrefix).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.ObligeAccount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ObligeAccountCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenFileAfterExport).HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherPartnerUseInternal).HasDefaultValueSql("((0))");

                entity.Property(e => e.OwnerRestricted).HasDefaultValueSql("((0))");

                entity.Property(e => e.OwnerRestrictedWithTotal).HasDefaultValueSql("((0))");

                entity.Property(e => e.PLDateFormat).HasMaxLength(50);

                entity.Property(e => e.Paymentterms).HasMaxLength(50);

                entity.Property(e => e.PublicNewPartner).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportFolder).HasMaxLength(255);

                entity.Property(e => e.RestrictEmptPartner).HasDefaultValueSql("((0))");

                entity.Property(e => e.SENDER_ID).HasMaxLength(50);

                entity.Property(e => e.SGLUnitList).HasMaxLength(300);

                entity.Property(e => e.SeparateOfficeIDCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.SettleInclude).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShipmentChangedNotify).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShipmentNeedtoApprove).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShipmentTypeList).HasMaxLength(255);

                entity.Property(e => e.ShowLotNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.StopSuggestExportBK).HasDefaultValueSql("((0))");

                entity.Property(e => e.SupplierUseInternal).HasDefaultValueSql("((0))");

                entity.Property(e => e.SwiftCode).HasMaxLength(50);

                entity.Property(e => e.SynNumberofBLtoBLType).HasDefaultValueSql("((0))");

                entity.Property(e => e.SynSellingRateToAN).HasDefaultValueSql("((0))");

                entity.Property(e => e.SynShipmentETD).HasDefaultValueSql("((0))");

                entity.Property(e => e.SynVoucherPMForOBH).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tax).HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxAccount).HasMaxLength(50);

                entity.Property(e => e.TaxDescription).HasMaxLength(255);

                entity.Property(e => e.Taxcode).HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.TransferLogCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.TurnoffWrightLog).HasDefaultValueSql("((0))");

                entity.Property(e => e.TurnoffWrightLogEffectQuery).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateNewExchangeRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.UseKBSalesExForPaymentExchange).HasDefaultValueSql("((0))");

                entity.Property(e => e.UseSubLockRange).HasDefaultValueSql("((0))");

                entity.Property(e => e.UseSystemJobNoDefine).HasDefaultValueSql("((0))");

                entity.Property(e => e.VCLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.VCLockAfterPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.VNAccountNo).HasMaxLength(50);

                entity.Property(e => e.VSDateNeedUpdateToRUN).HasColumnType("datetime");

                entity.Property(e => e.ViewLocalCurrency).HasDefaultValueSql("((0))");

                entity.Property(e => e.Website).HasMaxLength(50);

                entity.Property(e => e.YearInstall).HasMaxLength(50);

                entity.Property(e => e.YearInstallTrue).HasMaxLength(50);

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<ZoneCountry>(entity =>
            {
                entity.HasKey(e => e.CountryID)
                    .HasName("aaaaaZoneCountry_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.CountryID, "Code");

                entity.HasIndex(e => e.ColoaderID, "ColoaderID");

                entity.HasIndex(e => e.ColoaderID, "PartnersZoneCountry");

                entity.Property(e => e.CountryID).HasMaxLength(50);

                entity.Property(e => e.ColoaderID).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(150);

                entity.Property(e => e.CountryZone).HasMaxLength(50);

                entity.Property(e => e.TTDx).HasMaxLength(50);

                entity.Property(e => e.TTXs).HasMaxLength(50);

                entity.Property(e => e.TransServiceID).HasMaxLength(50);

                entity.HasOne(d => d.Coloader)
                    .WithMany(p => p.ZoneCountry)
                    .HasForeignKey(d => d.ColoaderID)
                    .HasConstraintName("ZoneCountry_FK00");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
