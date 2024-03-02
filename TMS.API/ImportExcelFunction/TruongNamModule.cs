using Core.Exceptions;
using Core.Extensions;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Text;
using TMS.API.Enums;
using TMS.API.FastTruongNamModels;
using TMS.API.Models;
using TMS.API.Services;
using TMS.API.ViewModels;

namespace TMS.API.ImportExcelFunction
{
    public class TruongNamModule
    {
        private static FastTruongNamContext _fast;
        private static TMSContext db;
        private string FastConn;
        private string FastTenant;
        protected readonly UserService _userSvc;
        private static string path;
        private static List<ImportChargeVM> staticFee;
        private IConfiguration configuration;

        public TruongNamModule(IHttpContextAccessor httpContextAccessor) 
        {
            var _httpContext = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
            var serviceProvider = _httpContext.HttpContext.RequestServices.GetService(typeof(IServiceProvider)) as IServiceProvider;
            configuration = _httpContext.HttpContext.RequestServices.GetService(typeof(IConfiguration)) as IConfiguration;
            _userSvc = _httpContext.HttpContext.RequestServices.GetService(typeof(UserService)) as UserService;

            _fast = serviceProvider.GetRequiredService<FastTruongNamContext>();
            db = serviceProvider.GetRequiredService<TMSContext>();
            FastTenant = "FastTruongnam";
            FastConn = Startup.GetConnectionString(serviceProvider, configuration, FastTenant);
        }
        public async Task<List<ImportChargeVM>> ExecuteFunction(List<ImportChargeVM> fee)
        {
            try
            {
                var fees = db.ImportExcelResult.ToList();
                fees.ForEach(f => f.Active = false);
                await db.SaveChangesAsync();
                var error = new StringBuilder();
                ResultErrorViewModel checkCreate;
                ResultErrorViewModel checkIsAllNumber;
                ResultErrorViewModel checkUpdate;
                foreach (var item in fee)
                {
                    await FindHBLNo(item);
                }
                staticFee = fee;
                foreach (var item in fee)
                {
                    checkIsAllNumber = await IsAllNumber(item);
                    checkUpdate = await ShouldUpdateRate(item);
                    checkCreate = await ShouldCreateRate(item);
                    if (checkUpdate.Result && checkIsAllNumber.Result)
                    {
                        item.Status = (int)ImportFeeStatusEnum.Update;
                        item.StatusFeeText = checkUpdate.Error;
                    }
                    else if (checkCreate.Result && checkIsAllNumber.Result)
                    {
                        item.Status = (int)ImportFeeStatusEnum.Insert;
                        item.StatusFeeText = checkCreate.Error;
                    }
                    else if (!checkIsAllNumber.Result)
                    {
                        item.Status = (int)ImportFeeStatusEnum.Error;
                        item.StatusFeeText = checkIsAllNumber.Error;
                    }
                    else if (!checkCreate.Result && !checkUpdate.Result)
                    {
                        item.Status = (int)ImportFeeStatusEnum.Error;
                        bool existFee = false;
                        switch (item.TYPE.ToUpper())
                        {
                            case "SELLINGRATE":
                                existFee = await _fast.SellingRate.AnyAsync(x => x.HAWBNO == item.HBL && x.Description == item.Description && x.QUnit == item.Unit.Replace("'", "`"));
                                break;
                            case "BUYINGRATE":
                                existFee = await _fast.BuyingRateWithHBL.AnyAsync(x => x.HAWBNO == item.HBL && x.Description == item.Description && x.Unit == item.Unit.Replace("'", "`"));
                                break;
                            case "OTHERCREDIT":
                                existFee = await _fast.ProfitShares.AnyAsync(x => x.HAWBNO == item.HBL && x.Notes == item.Description && x.Dpt == false && x.PartnerID == item.PartnerID && x.QUnit == item.Unit.Replace("'", "`"));
                                break;
                            case "OTHERDEBIT":
                                existFee = await _fast.ProfitShares.AnyAsync(x => x.HAWBNO == item.HBL && x.Notes == item.Description && x.Dpt == true && x.PartnerID == item.PartnerID && x.QUnit == item.Unit.Replace("'", "`"));
                                break;
                        }
                        if (existFee)
                        {
                            item.StatusFeeText = checkUpdate.Error;
                        }
                        else
                        {
                            item.StatusFeeText = checkCreate.Error;
                        }
                    }
                    else if (!checkCreate.Result)
                    {
                        item.Status = (int)ImportFeeStatusEnum.Error;
                        item.StatusFeeText = checkCreate.Error;
                    }
                    else if (!checkUpdate.Result)
                    {
                        item.Status = (int)ImportFeeStatusEnum.Error;
                        item.StatusFeeText = checkUpdate.Error;
                    }
                };
                foreach (var f in fee)
                {
                    try
                    {
                        var newRes = new ImportExcelResult()
                        {
                            Job = f.Job,
                            PartnerID = f.PartnerID,
                            HBL = f.HBL,
                            Description = f.Description,
                            Quantity = f.Quantity,
                            Unit = f.Unit,
                            UnitPrice = f.UnitPrice,
                            Currency = f.Currency,
                            ExtRate = f.ExtRate,
                            VAT = f.VAT,
                            Total = decimal.Parse(f.Total),
                            Docs = f.Docs,
                            FeeCode = f.FeeCode,
                            OBHPartnerID = f.OBHPartnerID,
                            TYPE = f.TYPE,
                            Status = f.Status,
                            StatusFeeText = f.StatusFeeText,
                            FileImportId = db.ImportExcel.Where(x => path.Contains(x.Attachment)).OrderByDescending(x => x.Id).Select(x => x.Id).FirstOrDefault(),
                        };
                        _userSvc.SetAuditInfo(newRes);
                        newRes.ClearReferences();
                        db.ImportExcelResult.Add(newRes);
                        await db.SaveChangesAsync();
                    }
                    catch (Exception e)
                    {
                        throw new ApiException($"Lỗi format template. Vui lòng kiểm tra lại file! {e}");
                    };
                }
            }
            catch (Exception e)
            {
                throw new ApiException(e.ToString());
            }

            return fee;
        }

        public async Task<string> AddOrUpdateList()
        {
            var errorMessage = new StringBuilder();

            foreach (var item in staticFee)
            {
                if (item.Status == 3)
                {
                    continue;
                }
                using (SqlConnection connection = new SqlConnection(FastConn))
                {
                    connection.Open();
                    string query = $@"
                SELECT ISNULL(
                    (SELECT CurrencyExchangeRate.Price AS USDEx FROM CurrencyExchangeRate 
                        LEFT JOIN SalesCurrencyExchange ON SalesCurrencyExchange.ID = CurrencyExchangeRate.ID
                    WHERE CurrencyExchangeRate.Unit = '{item.Currency}'
                        AND (SELECT Transactions.LoadingDate FROM Transactions 
                            LEFT JOIN TransactionDetails ON TransactionDetails.TransId = Transactions.TransId 
                            WHERE TransactionDetails.HWBNO = '{item.HBL}') >= SalesCurrencyExchange.DateFrom
                        AND (SELECT Transactions.LoadingDate FROM Transactions 
                            LEFT JOIN TransactionDetails ON TransactionDetails.TransId = Transactions.TransId 
                            WHERE TransactionDetails.HWBNO = '{item.HBL}') <= SalesCurrencyExchange.DateTo)
                    , (SELECT TOP 1 ExchangeRate AS USDEx FROM ExchangeRate 
                        WHERE ExchangeRate.Unit= '{item.Currency}' AND ISNULL(ExchangeRate.ExtVND,0)<>0)) AS USDEx";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            double usdExchangeRate = 0;
                            while (reader.Read())
                            {
                                usdExchangeRate = Convert.ToDouble(reader["USDEx"]);
                                Console.WriteLine($"USD Exchange Rate: {usdExchangeRate}");
                            }
                            try
                            {
                                switch (item.TYPE.ToUpper())
                                {
                                    case "SELLINGRATE":
                                        await AddOrUpdateSellingRate(item, usdExchangeRate);
                                        break;
                                    case "BUYINGRATE":
                                        await AddOrUpdateBuyingRate(item, usdExchangeRate);
                                        break;
                                    case "OTHERCREDIT":
                                        await AddOrUpdateProfigShare(item, usdExchangeRate);
                                        break;
                                    case "OTHERDEBIT":
                                        await AddOrUpdateProfigShare(item, usdExchangeRate);
                                        break;
                                }
                            }
                            catch (Exception ex)
                            {
                                errorMessage.Append(ex.Message);
                            }
                        }
                    }
                }
            }
            return errorMessage.ToString();
        }

        public async Task AddOrUpdateSellingRate(ImportChargeVM item, double USDEx)
        {
            var queryIdkeyshipment = _fast.TransactionDetails.Where(x => x.HWBNO == item.HBL).Select(x => x.IDKeyShipment).FirstOrDefault();
            if (item.Status == 1) // >>>>>>>>>> ADD
            {
                await AddSellingRate(item, USDEx, queryIdkeyshipment);
            }
            else if (item.Status == 2)  //>>>>>>>>>> UPDATE
            {
                await UpdateSellingRate(item, USDEx);
            }
        }

        private async Task UpdateSellingRate(ImportChargeVM item, double USDEx)
        {
            if (!string.IsNullOrEmpty(item.OBHPartnerID)) //>>>>>>>> OBH Partner
            {
                try
                {
                    var sellingRate = await _fast.SellingRate.FirstAsync(x => x.HAWBNO == item.HBL && x.Description == item.Description && x.QUnit == item.Unit.Replace("'", "`"));
                    sellingRate.SortDes = item.FeeCode;
                    sellingRate.Quantity = double.Parse(item.Quantity);
                    sellingRate.QUnit = item.Unit.Replace("'", "`");
                    sellingRate.Unit = item.Currency;
                    sellingRate.UnitPrice = double.Parse(item.UnitPrice);
                    sellingRate.VAT = string.IsNullOrEmpty(item.VAT) ? null : double.Parse(item.VAT);
                    sellingRate.DocNo = item.Docs;
                    sellingRate.TotalValue = float.Parse(item.Total);
                    sellingRate.ExtRateVND = double.Parse(item.ExtRate);
                    sellingRate.ExtVND = double.Parse(item.ExtRate);
                    sellingRate.USDEx = USDEx;
                    sellingRate.USDExPM = USDEx;
                    sellingRate.IDKeyIndex = sellingRate.IDKeyIndex;
                    sellingRate.CurrencyRate = 0;
                    sellingRate.OBH = true;
                    sellingRate.OBHPartnerID = item.OBHPartnerID;
                    await _fast.SaveChangesAsync();
                    await AddProfitShareForBuyingAndSelling(item, USDEx, sellingRate.FieldKey);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                try
                {
                    var sellingRate = await _fast.SellingRate.FirstAsync(x => x.HAWBNO == item.HBL && x.Description == item.Description && x.QUnit == item.Unit.Replace("'", "`"));
                    sellingRate.SortDes = item.FeeCode;
                    sellingRate.Quantity = double.Parse(item.Quantity);
                    sellingRate.QUnit = item.Unit.Replace("'", "`");
                    sellingRate.Unit = item.Currency;
                    sellingRate.UnitPrice = double.Parse(item.UnitPrice);
                    sellingRate.VAT = string.IsNullOrEmpty(item.VAT) ? null : double.Parse(item.VAT);
                    sellingRate.TotalValue = float.Parse(item.Total);
                    sellingRate.DocNo = item.Docs;
                    sellingRate.ExtRateVND = double.Parse(item.ExtRate);
                    sellingRate.ExtVND = double.Parse(item.ExtRate);
                    sellingRate.USDEx = USDEx;
                    sellingRate.USDExPM = USDEx;
                    sellingRate.IDKeyIndex = sellingRate.IDKeyIndex;
                    sellingRate.CurrencyRate = double.Parse(item.Quantity) * double.Parse(item.UnitPrice) * USDEx;
                    await _fast.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        private async Task AddSellingRate(ImportChargeVM item, double USDEx, decimal queryIdkeyshipment)
        {
            if (!string.IsNullOrEmpty(item.OBHPartnerID)) // >>>>>>>>>>>>> OBH Partner
            {
                var feeTemp = new SellingRate()
                {
                    HAWBNO = item.HBL,
                    Description = item.Description,
                    SortDes = item.FeeCode,
                    Quantity = double.Parse(item.Quantity),
                    QUnit = item.Unit.Replace("'", "`"),
                    Unit = item.Currency,
                    UnitPrice = double.Parse(item.UnitPrice),
                    VAT = string.IsNullOrEmpty(item.VAT) ? null : double.Parse(item.VAT),
                    DocNo = item.Docs,
                    TotalValue = float.Parse(item.Total),
                    ExtRateVND = double.Parse(item.ExtRate),
                    ExtVND = double.Parse(item.ExtRate),
                    USDEx = USDEx,
                    USDExPM = USDEx,
                    CurrencyRate = 0,
                    IDKeyShipmentDT = queryIdkeyshipment,
                    InputData = await GetInputDataForEachHBL(item),
                    ShipmentDate = await GetLoadingDate(item),
                    AutoInput = true,
                    FieldKey = await GetFieldKey(item),
                    Collect = false,
                    OBH = true,
                    OBHPartnerID = item.OBHPartnerID,
                    Paid = false,
                    NoInv = false,
                    SortInv = false,
                };
                await _fast.AddAsync(feeTemp);
                await _fast.SaveChangesAsync();
                await AddProfitShareForBuyingAndSelling(item, USDEx, feeTemp.FieldKey);
            }
            else
            {
                try
                {
                    var feeTemp = new SellingRate()
                    {
                        HAWBNO = item.HBL,
                        Description = item.Description,
                        SortDes = item.FeeCode,
                        Quantity = double.Parse(item.Quantity),
                        QUnit = item.Unit.Replace("'", "`"),
                        Unit = item.Currency,
                        UnitPrice = double.Parse(item.UnitPrice),
                        VAT = string.IsNullOrEmpty(item.VAT) ? null : double.Parse(item.VAT),
                        DocNo = item.Docs,
                        TotalValue = float.Parse(item.Total),
                        ExtRateVND = double.Parse(item.ExtRate),
                        ExtVND = double.Parse(item.ExtRate),
                        USDEx = USDEx,
                        USDExPM = USDEx,
                        CurrencyRate = double.Parse(item.Quantity) * double.Parse(item.UnitPrice) * USDEx,
                        InputData = await GetInputDataForEachHBL(item),
                        FieldKey = await GetFieldKey(item),
                        ShipmentDate = await GetLoadingDate(item),
                        AutoInput = true,
                        Collect = false,
                        OBH = false,
                        Paid = false,
                        NoInv = false,
                        SortInv = false,
                    };
                    await _fast.AddAsync(feeTemp);
                    await _fast.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        private async Task AddOrUpdateBuyingRate(ImportChargeVM item, double USDEx)
        {
            var queryIdkeyshipment = _fast.TransactionDetails.Where(x => x.HWBNO == item.HBL).Select(x => x.IDKeyShipment).FirstOrDefault();
            if (item.Status == 1) // >>>>>>>>>> ADD
            {
                await AddBuyingRate(item, USDEx, queryIdkeyshipment);
            }
            else if (item.Status == 2) // >>>>>>> UPDATE
            {
                await UpdateBuyingRate(item, USDEx);
            }
        }

        private async Task UpdateBuyingRate(ImportChargeVM item, double USDEx)
        {
            if (!string.IsNullOrEmpty(item.OBHPartnerID)) //>>>>>> OBH
            {
                try
                {
                    var querryBuyingRate = await _fast.BuyingRateWithHBL.FirstAsync(x => x.HAWBNO == item.HBL && x.Description == item.Description && x.Unit == item.Unit.Replace("'", "`"));
                    querryBuyingRate.SortDes = item.FeeCode;
                    querryBuyingRate.Quantity = double.Parse(item.Quantity);
                    querryBuyingRate.Unit = item.Unit.Replace("'", "`");
                    querryBuyingRate.CurrencyConvertRate = item.Currency;
                    querryBuyingRate.UnitPrice = double.Parse(item.UnitPrice);
                    querryBuyingRate.VAT = string.IsNullOrEmpty(item.VAT) ? null : double.Parse(item.VAT);
                    querryBuyingRate.TotalValue = float.Parse(item.Total);
                    querryBuyingRate.Docs = item.Docs;
                    querryBuyingRate.ExtRateVND = double.Parse(item.ExtRate);
                    querryBuyingRate.ExtVND = double.Parse(item.ExtRate);
                    querryBuyingRate.USDEx = USDEx;
                    querryBuyingRate.USDExPM = USDEx;
                    querryBuyingRate.IDKeyIndex = querryBuyingRate.IDKeyIndex;
                    querryBuyingRate.OBH = true;
                    querryBuyingRate.OBHPartnerID = item.OBHPartnerID;
                    querryBuyingRate.ExtRate = 0;
                    await _fast.SaveChangesAsync();
                    await AddProfitShareForBuyingAndSelling(item, USDEx, querryBuyingRate.FieldKey);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                try
                {
                    var querryBuyingRate = await _fast.BuyingRateWithHBL.FirstAsync(x => x.HAWBNO == item.HBL && x.Description == item.Description && x.Unit == item.Unit.Replace("'", "`"));
                    querryBuyingRate.SortDes = item.FeeCode;
                    querryBuyingRate.Quantity = double.Parse(item.Quantity);
                    querryBuyingRate.Unit = item.Unit.Replace("'", "`");
                    querryBuyingRate.CurrencyConvertRate = item.Currency;
                    querryBuyingRate.UnitPrice = double.Parse(item.UnitPrice);
                    querryBuyingRate.VAT = string.IsNullOrEmpty(item.VAT) ? null : double.Parse(item.VAT);
                    querryBuyingRate.Docs = item.Docs;
                    querryBuyingRate.TotalValue = float.Parse(item.Total);
                    querryBuyingRate.ExtRateVND = double.Parse(item.ExtRate);
                    querryBuyingRate.ExtVND = double.Parse(item.ExtRate);
                    querryBuyingRate.USDEx = USDEx;
                    querryBuyingRate.USDExPM = USDEx;
                    querryBuyingRate.ExtRate = double.Parse(item.Quantity) * double.Parse(item.UnitPrice) * USDEx;
                    querryBuyingRate.IDKeyIndex = querryBuyingRate.IDKeyIndex;
                    await _fast.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    throw e;
                }

            }
        }

        private async Task AddBuyingRate(ImportChargeVM item, double USDEx, decimal queryIdkeyshipment)
        {
            if (!string.IsNullOrEmpty(item.OBHPartnerID)) // >>>> OBH Partner
            {
                var feeTemp = new BuyingRateWithHBL()
                {
                    HAWBNO = item.HBL,
                    Description = item.Description,
                    SortDes = item.FeeCode,
                    Quantity = double.Parse(item.Quantity),
                    Unit = item.Unit.Replace("'", "`"),
                    CurrencyConvertRate = item.Currency,
                    UnitPrice = double.Parse(item.UnitPrice),
                    VAT = string.IsNullOrEmpty(item.VAT) ? null : double.Parse(item.VAT),
                    Docs = item.Docs,
                    TotalValue = float.Parse(item.Total),
                    ExtRateVND = double.Parse(item.ExtRate),
                    ExtVND = double.Parse(item.ExtRate),
                    ExtRate = 0,
                    USDEx = USDEx,
                    USDExPM = USDEx,
                    InputData = await GetInputDataForEachHBL(item),
                    IDKeyShipmentDT = queryIdkeyshipment,
                    ShipmentDate = await GetLoadingDate(item),
                    FieldKey = await GetFieldKey(item),
                    AutoInput = true,
                    Collect = false,
                    OBH = true,
                    OBHPartnerID = item.OBHPartnerID,
                    Paid = false,
                    NoInv = false,
                    SortInv = false,
                };
                await _fast.AddAsync(feeTemp);
                await _fast.SaveChangesAsync();
                await AddProfitShareForBuyingAndSelling(item, USDEx, feeTemp.FieldKey);
            }
            else
            {
                var feeTemp = new BuyingRateWithHBL()
                {
                    HAWBNO = item.HBL,
                    Description = item.Description,
                    SortDes = item.FeeCode,
                    Quantity = double.Parse(item.Quantity),
                    Unit = item.Unit.Replace("'", "`"),
                    CurrencyConvertRate = item.Currency,
                    UnitPrice = double.Parse(item.UnitPrice),
                    VAT = string.IsNullOrEmpty(item.VAT) ? null : double.Parse(item.VAT),
                    Docs = item.Docs,
                    TotalValue = float.Parse(item.Total),
                    ExtRateVND = double.Parse(item.ExtRate),
                    ExtVND = double.Parse(item.ExtRate),
                    USDEx = USDEx,
                    USDExPM = USDEx,
                    ExtRate = double.Parse(item.Quantity) * double.Parse(item.UnitPrice) * USDEx,
                    InputData = await GetInputDataForEachHBL(item),
                    IDKeyShipmentDT = queryIdkeyshipment,
                    ShipmentDate = await GetLoadingDate(item),
                    FieldKey = await GetFieldKey(item),
                    AutoInput = true,
                    Collect = false,
                    OBH = false,
                    Paid = false,
                    NoInv = false,
                    SortInv = false,
                };
                await _fast.AddAsync(feeTemp);
                await _fast.SaveChangesAsync();
            }
        }

        private async Task AddOrUpdateProfigShare(ImportChargeVM item, double USDEx)
        {
            var queryidkeyshipment = (decimal)_fast.TransactionDetails.Where(x => x.HWBNO == item.HBL).Select(x => x.IDKeyShipment).FirstOrDefault();
            if (item.Status == 1) // >>>>> ADD
            {
                await AddProfitShare(item, USDEx, queryidkeyshipment);
            }
            else if (item.Status == 2)
            {
                await UpdateProfitShare(item, USDEx);
            }
        }

        private async Task UpdateProfitShare(ImportChargeVM item, double USDEx)
        {
            if (!string.IsNullOrEmpty(item.OBHPartnerID)) // >>>> OBH
            {
                try
                {
                    var dept = item.TYPE.ToUpper() == "OTHERCREDIT" ? false : true;
                    var profitShare = await _fast.ProfitShares.FirstAsync(x => x.HAWBNO == item.HBL && x.Notes == item.Description && x.QUnit == item.Unit.Replace("'", "`") && x.Dpt == dept && x.PartnerID == item.PartnerID);
                    profitShare.PartnerID = item.PartnerID;
                    profitShare.SortDes = item.FeeCode;
                    profitShare.Quantity = double.Parse(item.Quantity);
                    profitShare.QUnit = item.Unit.Replace("'", "`");
                    profitShare.CurrencyConvertRate = item.Currency;
                    profitShare.UnitPrice = double.Parse(item.UnitPrice);
                    profitShare.VAT = string.IsNullOrEmpty(item.VAT) ? null : double.Parse(item.VAT);
                    profitShare.Docs = item.Docs;
                    profitShare.TotalValue = float.Parse(item.Total);
                    profitShare.ExtRateVND = double.Parse(item.ExtRate);
                    profitShare.ExtVND = double.Parse(item.ExtRate);
                    profitShare.USDEx = USDEx;
                    profitShare.USDExPM = USDEx;
                    profitShare.ExtRate = 0;
                    profitShare.Obh = true;
                    profitShare.OBHPartnerID = item.OBHPartnerID;
                    await _fast.SaveChangesAsync();
                    await AddProfitShareForBuyingAndSelling(item, USDEx, profitShare.FieldKey);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                try
                {
                    var dept = item.TYPE.ToUpper() == "OTHERCREDIT" ? false : true;
                    var profitShare = await _fast.ProfitShares.FirstAsync(x => x.HAWBNO == item.HBL && x.Notes == item.Description && x.QUnit == item.Unit.Replace("'", "`") && x.Dpt == dept && x.PartnerID == item.PartnerID);
                    profitShare.PartnerID = item.PartnerID;
                    profitShare.SortDes = item.FeeCode;
                    profitShare.Quantity = double.Parse(item.Quantity);
                    profitShare.QUnit = item.Unit.Replace("'", "`");
                    profitShare.CurrencyConvertRate = item.Currency;
                    profitShare.UnitPrice = double.Parse(item.UnitPrice);
                    profitShare.VAT = string.IsNullOrEmpty(item.VAT) ? null : double.Parse(item.VAT);
                    profitShare.Docs = item.Docs;
                    profitShare.TotalValue = float.Parse(item.Total);
                    profitShare.ExtRateVND = double.Parse(item.ExtRate);
                    profitShare.ExtVND = double.Parse(item.ExtRate);
                    profitShare.USDEx = USDEx;
                    profitShare.USDExPM = USDEx;
                    profitShare.IDKeyIndex = profitShare.IDKeyIndex;
                    profitShare.ExtRate = double.Parse(item.Quantity) * double.Parse(item.UnitPrice) * USDEx;
                    await _fast.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        private async Task AddProfitShare(ImportChargeVM item, double USDEx, decimal queryidkeyshipment)
        {
            if (!string.IsNullOrEmpty(item.OBHPartnerID)) // >>>>> OBH
            {
                try
                {
                    var feeTemp = new ProfitShares()
                    {
                        HAWBNO = item.HBL,
                        PartnerID = item.PartnerID,
                        Notes = item.Description,
                        SortDes = item.FeeCode,
                        Quantity = double.Parse(item.Quantity),
                        QUnit = item.Unit.Replace("'", "`"),
                        CurrencyConvertRate = item.Currency,
                        UnitPrice = double.Parse(item.UnitPrice),
                        VAT = string.IsNullOrEmpty(item.VAT) ? null : double.Parse(item.VAT),
                        Docs = item.Docs,
                        TotalValue = float.Parse(item.Total),
                        ExtRateVND = double.Parse(item.ExtRate),
                        ExtVND = double.Parse(item.ExtRate),
                        USDEx = USDEx,
                        USDExPM = USDEx,
                        ExtRate = 0,
                        IDKeyShipmentDT = queryidkeyshipment,
                        DataInput = await GetInputDataForEachHBL(item),
                        ShipmentDate = await GetLoadingDate(item),
                        AutoInput = true,
                        FieldKey = await GetFieldKey(item),
                        Paid = false,
                        NoInv = false,
                        Obh = true,
                        OBHPartnerID = item.OBHPartnerID,
                        SortInv = false,
                        Dpt = item.TYPE.ToUpper() == "OTHERCREDIT" ? false : true,
                    };
                    await _fast.AddAsync(feeTemp);
                    await _fast.SaveChangesAsync();
                    await AddProfitShareForBuyingAndSelling(item, USDEx, feeTemp.FieldKey);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                try
                {
                    var feeTemp = new ProfitShares()
                    {
                        HAWBNO = item.HBL,
                        PartnerID = item.PartnerID,
                        Notes = item.Description,
                        SortDes = item.FeeCode,
                        Quantity = double.Parse(item.Quantity),
                        QUnit = item.Unit.Replace("'", "`"),
                        CurrencyConvertRate = item.Currency,
                        UnitPrice = double.Parse(item.UnitPrice),
                        VAT = string.IsNullOrEmpty(item.VAT) ? null : double.Parse(item.VAT),
                        Docs = item.Docs,
                        TotalValue = float.Parse(item.Total),
                        ExtRateVND = double.Parse(item.ExtRate),
                        ExtVND = double.Parse(item.ExtRate),
                        USDEx = USDEx,
                        USDExPM = USDEx,
                        ExtRate = double.Parse(item.Quantity) * double.Parse(item.UnitPrice) * USDEx,
                        IDKeyShipmentDT = (decimal)queryidkeyshipment,
                        DataInput = await GetInputDataForEachHBL(item),
                        ShipmentDate = await GetLoadingDate(item),
                        AutoInput = true,
                        FieldKey = await GetFieldKey(item),
                        Paid = false,
                        NoInv = false,
                        Obh = false,
                        SortInv = false,
                        Dpt = item.TYPE.ToUpper() == "OTHERCREDIT" ? false : true,
                    };
                    await _fast.AddAsync(feeTemp);
                    await _fast.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        private async Task<DateTime?> GetLoadingDate(ImportChargeVM item)
        {
            return await (
                from tran in _fast.Transactions
                join details in _fast.TransactionDetails on tran.TransID equals details.TransID
                where details.HWBNO == item.HBL
                select tran.LoadingDate
            ).FirstOrDefaultAsync();
        }

        public async Task<ResultErrorViewModel> ShouldCreateRate(ImportChargeVM fee)
        {
            if (fee.TYPE.ToUpper() == "SELLINGRATE")
            {
                var existFee = await _fast.SellingRate.AnyAsync(x => x.HAWBNO == fee.HBL && x.Description == fee.Description && x.QUnit == fee.Unit.Replace("'", "`"));
                if (existFee)
                {
                    return new ResultErrorViewModel()
                    {
                        Result = false,
                        Error = "Duplicate HAWBNO"
                    };
                }
            }
            else if (fee.TYPE.ToUpper() == "BUYINGRATE")
            {
                var existFee = await _fast.BuyingRateWithHBL.AnyAsync(x => x.HAWBNO == fee.HBL && x.Description == fee.Description && x.Unit == fee.Unit.Replace("'", "`"));
                if (existFee)
                {
                    return new ResultErrorViewModel()
                    {
                        Result = false,
                        Error = "Duplicate HAWBNO"
                    };
                }

            }
            else if (fee.TYPE.ToUpper() == "OTHERCREDIT" || fee.TYPE.ToUpper() == "OTHERDEBIT")
            {
                if (string.IsNullOrEmpty(fee.PartnerID))
                {
                    return new ResultErrorViewModel()
                    {
                        Result = false,
                        Error = "Partner ID is null"
                    };
                }
                var dept = fee.TYPE.ToUpper() == "OTHERCREDIT" ? false : true;
                var existFee = await _fast.ProfitShares.AnyAsync(x => x.HAWBNO == fee.HBL && x.Notes == fee.Description && x.Dpt == dept && x.PartnerID == fee.PartnerID && x.QUnit == fee.Unit.Replace("'", "`"));
                if (existFee)
                {
                    return new ResultErrorViewModel()
                    {
                        Result = false,
                        Error = "Duplicate HAWBNO"
                    };
                }
            }
            if (!string.IsNullOrEmpty(fee.PartnerID))
            {
                var partnerID = await _fast.Partners.AnyAsync(x => x.PartnerID == fee.PartnerID);
                if (!partnerID)
                {
                    return new ResultErrorViewModel()
                    {
                        Result = false,
                        Error = "Invalid PartnerID"
                    };
                }
            };
            if (!string.IsNullOrEmpty(fee.OBHPartnerID))
            {
                var OBHpartnerID = await _fast.Partners.AnyAsync(x => x.PartnerID == fee.OBHPartnerID);
                if (!OBHpartnerID)
                {
                    return new ResultErrorViewModel()
                    {
                        Result = false,
                        Error = "Invalid OBH PartnerID"
                    };
                }
            }
            var isValidHbl = await _fast.HAWB.Where(x => x.HWBNO == fee.HBL).CountAsync();
            if (isValidHbl < 1)
            {
                return new ResultErrorViewModel()
                {
                    Result = false,
                    Error = "Not exist HAWBNO"
                };
            };
            var isExistJob = await _fast.Transactions.AnyAsync(x => x.TransID == fee.Job);
            if (!isExistJob)
            {
                return new ResultErrorViewModel()
                {
                    Result = false,
                    Error = "Not exist JobCode"
                };
            }
            else
            {
                var matchJobAndHbl = await _fast.TransactionDetails.AnyAsync(x => x.TransID == fee.Job && x.HWBNO == fee.HBL);
                if (!matchJobAndHbl)
                {
                    return new ResultErrorViewModel()
                    {
                        Result = false,
                        Error = "Not match Job and HAWBNO"
                    };
                }
            }

            return new ResultErrorViewModel()
            {
                Result = true,
                Error = "Insert"
            };
        }

        public async Task<ResultErrorViewModel> ShouldUpdateRate(ImportChargeVM fee)
        {
            if (fee.TYPE.ToUpper() == "SELLINGRATE")
            {
                var existFee = await _fast.SellingRate.AnyAsync(x => x.HAWBNO == fee.HBL && x.Description == fee.Description && x.QUnit == fee.Unit.Replace("'", "`"));
                if (!existFee)
                {
                    return new ResultErrorViewModel()
                    {
                        Result = false,
                        Error = "Cannot update"
                    };
                }
                else
                {
                    var isLock = await _fast.SellingRate.AnyAsync(x => x.HAWBNO == fee.HBL && x.Description == fee.Description && x.QUnit == fee.Unit.Replace("'", "`")
                    && (!string.IsNullOrEmpty(x.DocNo) || !string.IsNullOrEmpty(x.SeriNo) || !string.IsNullOrEmpty(x.InoiceNo) || !string.IsNullOrEmpty(x.VoucherID) || x.PaidDate != null || x.Paid != false));
                    if (isLock)
                    {
                        return new ResultErrorViewModel()
                        {
                            Result = false,
                            Error = "Locked"
                        };
                    }
                }
            }
            else if (fee.TYPE.ToUpper() == "BUYINGRATE")
            {
                var existFee = await _fast.BuyingRateWithHBL.AnyAsync(x => x.HAWBNO == fee.HBL && x.Description == fee.Description && x.Unit == fee.Unit.Replace("'", "`"));
                if (!existFee)
                {
                    return new ResultErrorViewModel()
                    {
                        Result = false,
                        Error = "Cannot update"
                    };
                }
                else
                if (existFee)
                {
                    var isLock = await _fast.BuyingRateWithHBL.AnyAsync(x => x.HAWBNO == fee.HBL && x.Description == fee.Description && x.Unit == fee.Unit.Replace("'", "`") &&
                    (!string.IsNullOrEmpty(x.Docs) || !string.IsNullOrEmpty(x.SeriNo) || !string.IsNullOrEmpty(x.InoiceNo) || !string.IsNullOrEmpty(x.VoucherID) || x.DatePaid != null || x.Paid != false));
                    if (isLock)
                    {
                        return new ResultErrorViewModel()
                        {
                            Result = false,
                            Error = "Locked"
                        };
                    }
                }
            }
            else if (fee.TYPE.ToUpper() == "OTHERCREDIT" || fee.TYPE.ToUpper() == "OTHERDEBIT")
            {
                if (string.IsNullOrEmpty(fee.PartnerID))
                {
                    return new ResultErrorViewModel()
                    {
                        Result = false,
                        Error = "Partner ID is null"
                    };
                }
                var dept = fee.TYPE.ToUpper() == "OTHERCREDIT" ? false : true;

                var existFee = await _fast.ProfitShares.AnyAsync(x => x.HAWBNO == fee.HBL && x.Notes == fee.Description && x.Dpt == dept && x.PartnerID == fee.PartnerID && x.QUnit == fee.Unit.Replace("'", "`"));
                if (!existFee)
                {
                    return new ResultErrorViewModel()
                    {
                        Result = false,
                        Error = "Cannot update"
                    };
                }
                else
                if (existFee)
                {
                    var isLock = await _fast.ProfitShares.AnyAsync(x => x.HAWBNO == fee.HBL && x.Notes == fee.Description && x.Dpt == dept && x.PartnerID == fee.PartnerID && x.QUnit == fee.Unit.Replace("'", "`")
                    && (!string.IsNullOrEmpty(x.Docs) || !string.IsNullOrEmpty(x.SeriNo) || !string.IsNullOrEmpty(x.InoiceNo) || !string.IsNullOrEmpty(x.VoucherID) || x.PaidDate != null || x.Paid != false));
                    if (isLock)
                    {
                        return new ResultErrorViewModel()
                        {
                            Result = false,
                            Error = "Locked"
                        };
                    }
                }
            }
            if (!string.IsNullOrEmpty(fee.PartnerID))
            {
                var partnerID = await _fast.Partners.AnyAsync(x => x.PartnerID == fee.PartnerID);
                if (!partnerID)
                {
                    return new ResultErrorViewModel()
                    {
                        Result = false,
                        Error = "Invalid PartnerID"
                    };
                }
            };
            if (!string.IsNullOrEmpty(fee.OBHPartnerID))
            {
                var OBHpartnerID = await _fast.Partners.AnyAsync(x => x.PartnerID == fee.OBHPartnerID);
                if (!OBHpartnerID)
                {
                    return new ResultErrorViewModel()
                    {
                        Result = false,
                        Error = "Invalid OBH PartnerID"
                    };
                }
            }
            var isValidHbl = await _fast.HAWB.Where(x => x.HWBNO == fee.HBL).CountAsync();
            if (isValidHbl < 1)
            {
                return new ResultErrorViewModel()
                {
                    Result = false,
                    Error = "Not exist HAWBNO"
                };
            };
            var isExistJob = await _fast.Transactions.AnyAsync(x => x.TransID == fee.Job);
            if (!isExistJob)
            {
                return new ResultErrorViewModel()
                {
                    Result = false,
                    Error = "Not exist JobCode"
                };
            }
            else
            {
                var matchJobAndHbl = await _fast.TransactionDetails.AnyAsync(x => x.TransID == fee.Job && x.HWBNO == fee.HBL);
                if (!matchJobAndHbl)
                {
                    return new ResultErrorViewModel()
                    {
                        Result = false,
                        Error = "Not match Job and HAWBNO"
                    };
                }
            }
            return new ResultErrorViewModel()
            {
                Result = true,
                Error = "Update"
            };
        }

        public async Task AddProfitShareForBuyingAndSelling(ImportChargeVM item, double USDEx, string OBHFieldKey)
        {
            var queryidkeyshipment = _fast.TransactionDetails.Where(x => x.HWBNO == item.HBL).Select(x => x.IDKeyShipment).FirstOrDefault();
            var dept = item.TYPE.ToUpper() == "OTHERDEBIT" || item.TYPE.ToUpper() == "SELLINGRATE" ? false : true;
            var existFee = await _fast.ProfitShares.Where(x => x.HAWBNO == item.HBL && x.Notes == item.Description && x.QUnit == item.Unit.Replace("'", "`") && x.Dpt == dept && x.PartnerID == item.OBHPartnerID).CountAsync();
            if (existFee < 1)
            {
                try
                {
                    var feeTemp = new ProfitShares()
                    {
                        HAWBNO = item.HBL,
                        PartnerID = item.OBHPartnerID,
                        Notes = item.Description,
                        SortDes = item.FeeCode,
                        Quantity = double.Parse(item.Quantity),
                        QUnit = item.Unit.Replace("'", "`"),
                        CurrencyConvertRate = item.Currency,
                        UnitPrice = double.Parse(item.UnitPrice),
                        VAT = string.IsNullOrEmpty(item.VAT) ? null : double.Parse(item.VAT),
                        Docs = item.Docs,
                        TotalValue = float.Parse(item.Total),
                        ExtRateVND = double.Parse(item.ExtRate),
                        ExtVND = double.Parse(item.ExtRate),
                        USDEx = USDEx,
                        USDExPM = USDEx,
                        ExtRate = 0,
                        IDKeyShipmentDT = queryidkeyshipment,
                        DataInput = await GetInputDataForSubProfitShare(item),
                        ShipmentDate = await GetLoadingDate(item),
                        AutoInput = true,
                        FieldKey = await GetFieldKeyForSubProfitShare(item),
                        OBHFieldKey = OBHFieldKey,
                        Paid = false,
                        NoInv = false,
                        SortInv = false,
                        Dpt = item.TYPE.ToUpper() == "OTHERDEBIT" || item.TYPE.ToUpper() == "SELLINGRATE" ? false : true,
                    };
                    await _fast.AddAsync(feeTemp);
                    await _fast.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public async Task<string> GetFieldKey(ImportChargeVM fee)
        {
            var intFieldKey = 0;
            switch (fee.TYPE.ToUpper())
            {
                case "BUYINGRATE":
                    var fieldKey = await _fast.BuyingRateWithHBL.MaxAsync(x => (decimal?)x.IDKeyIndex) ?? decimal.Zero;
                    intFieldKey = Convert.ToInt32(fieldKey) + 1;
                    break;
                case "SELLINGRATE":
                    fieldKey = await _fast.SellingRate.MaxAsync(x => (decimal?)x.IDKeyIndex) ?? decimal.Zero;
                    intFieldKey = Convert.ToInt32(fieldKey) + 1;
                    break;
                case "OTHERCREDIT":
                    fieldKey = await _fast.ProfitShares.MaxAsync(x => (decimal?)x.IDKeyIndex) ?? decimal.Zero;
                    intFieldKey = Convert.ToInt32(fieldKey) + 1;
                    break;
                case "OTHERDEBIT":
                    fieldKey = await _fast.ProfitShares.MaxAsync(x => (decimal?)x.IDKeyIndex) ?? decimal.Zero;
                    intFieldKey = Convert.ToInt32(fieldKey) + 1;
                    break;
            }
            return "vnpt." + intFieldKey.ToString();
        }

        public async Task<string> GetInputDataForEachHBL(ImportChargeVM fee)
        {
            var inputData = 0;

            switch (fee.TYPE.ToUpper())
            {
                case "SELLINGRATE":
                    var isExistHbl = await _fast.SellingRate.AnyAsync(x => x.HAWBNO == fee.HBL);
                    if (isExistHbl)
                    {
                        var inputDataHBL = await _fast.SellingRate.Where(t => t.HAWBNO == fee.HBL)
                                                   .OrderByDescending(x => x.IDKeyIndex)
                                                   .FirstOrDefaultAsync();
                        if (inputDataHBL != null && inputDataHBL.InputData != null)
                        {
                            inputData = int.Parse(inputDataHBL.InputData) + 1;
                        }
                    }
                    else
                    {
                        inputData = 1;
                    }
                    break;

                case "BUYINGRATE":
                    isExistHbl = await _fast.BuyingRateWithHBL.AnyAsync(x => x.HAWBNO == fee.HBL);
                    if (isExistHbl)
                    {
                        var inputDataHBL = await _fast.BuyingRateWithHBL.Where(t => t.HAWBNO == fee.HBL)
                                                       .OrderByDescending(x => x.IDKeyIndex)
                                                       .FirstOrDefaultAsync();
                        inputData = int.Parse(inputDataHBL.InputData) + 1;
                    }
                    else
                    {
                        inputData = 1;
                    }
                    break;
                case "OTHERDEBIT":
                    isExistHbl = await _fast.ProfitShares.AnyAsync(x => x.HAWBNO == fee.HBL);
                    if (isExistHbl)
                    {
                        var inputDataHBL = await _fast.ProfitShares.Where(t => t.HAWBNO == fee.HBL)
                                                       .OrderByDescending(x => x.IDKeyIndex)
                                                       .FirstOrDefaultAsync();
                        inputData = int.Parse(inputDataHBL.DataInput) + 1;
                    }
                    else
                    {
                        inputData = 1;
                    }
                    break;
                case "OTHERCREDIT":
                    isExistHbl = await _fast.ProfitShares.AnyAsync(x => x.HAWBNO == fee.HBL);
                    if (isExistHbl)
                    {
                        var inputDataHBL = await _fast.ProfitShares.Where(t => t.HAWBNO == fee.HBL)
                                                       .OrderByDescending(x => x.IDKeyIndex)
                                                       .FirstOrDefaultAsync();
                        inputData = int.Parse(inputDataHBL.DataInput) + 1;
                    }
                    else
                    {
                        inputData = 1;
                    }
                    break;
            }
            return inputData.ToString();
        }

        public async Task<string> GetInputDataForSubProfitShare(ImportChargeVM fee)
        {
            var inputData = 0;
            var isExistHbl = await _fast.ProfitShares.AnyAsync(x => x.HAWBNO == fee.HBL);
            if (isExistHbl)
            {
                var inputDataHBL = await _fast.ProfitShares.Where(t => t.HAWBNO == fee.HBL)
                                               .OrderByDescending(x => x.IDKeyIndex)
                                               .FirstOrDefaultAsync();
                inputData = int.Parse(inputDataHBL.DataInput) + 1;
            }
            else
            {
                inputData = 1;
            }
            return inputData.ToString();
        }

        public async Task<string> GetFieldKeyForSubProfitShare(ImportChargeVM fee)
        {
            var intFieldKey = 0;
            var fieldKey = await _fast.ProfitShares.MaxAsync(x => x.IDKeyIndex);
            intFieldKey = Convert.ToInt32(fieldKey) + 1;
            return "vnpt." + intFieldKey.ToString();
        }

        public async Task<ResultErrorViewModel> IsAllNumber(ImportChargeVM fee)
        {
            double isNumber;
            bool test;
            if (string.IsNullOrEmpty(fee.Total))
            {
                return new ResultErrorViewModel()
                {
                    Result = false,
                    Error = "Total is null"
                };
            }
            if (string.IsNullOrEmpty(fee.Unit))
            {
                return new ResultErrorViewModel()
                {
                    Result = false,
                    Error = "Unit is null"
                };
            }
            if (string.IsNullOrEmpty(fee.TYPE))
            {
                return new ResultErrorViewModel()
                {
                    Result = false,
                    Error = "TYPE is null"
                };
            }
            if (string.IsNullOrEmpty(fee.Description))
            {
                return new ResultErrorViewModel()
                {
                    Result = false,
                    Error = "Description is null"
                };
            }
            if (fee.Currency != "VND" && fee.Currency != "USD")
            {
                return new ResultErrorViewModel()
                {
                    Result = false,
                    Error = "Currency incorrect"
                };
            }

            test = double.TryParse(fee.Quantity, out isNumber);
            if (!test)
            {
                return new ResultErrorViewModel()
                {
                    Result = false,
                    Error = "Invalid Quantity"
                };
            }
            test = double.TryParse(fee.UnitPrice, out isNumber);
            if (!test)
            {
                return new ResultErrorViewModel()
                {
                    Result = false,
                    Error = "Invalid UnitPrice"
                };
            }
            test = double.TryParse(fee.ExtRate, out isNumber);
            if (!test)
            {
                return new ResultErrorViewModel()
                {
                    Result = false,
                    Error = "Invalid ExtRate"
                };
            }
            test = double.TryParse(fee.VAT, out isNumber);
            if (!test && !string.IsNullOrEmpty(fee.VAT))
            {
                return new ResultErrorViewModel()
                {
                    Result = false,
                    Error = "Invalid VAT"
                };
            }
            test = double.TryParse(fee.Total, out isNumber);
            if (!test)
            {
                return new ResultErrorViewModel()
                {
                    Result = false,
                    Error = "Invalid Total"
                };
            }
            if (fee.TYPE.ToUpper() != "SELLINGRATE" && fee.TYPE.ToUpper() != "BUYINGRATE" && fee.TYPE.ToUpper() != "OTHERCREDIT" && fee.TYPE.ToUpper() != "OTHERDEBIT")
            {
                return new ResultErrorViewModel()
                {
                    Result = false,
                    Error = "TYPE incorrect"
                };

            }
            if (fee.TYPE.ToUpper() == "BUYINGRATE")
            {
                var query = from transaction in _fast.Transactions
                            join transdetails in _fast.TransactionDetails on transaction.TransID equals transdetails.TransID
                            into transJoin
                            from transLeft in transJoin.DefaultIfEmpty()
                            where transLeft.HWBNO == fee.HBL
                            select new
                            {
                                vendor = transaction.TpyeofService == "InlandTrucking" ? transLeft.SCIACI : transaction.ColoaderID
                            };

                if (string.IsNullOrEmpty(query.First().vendor))
                {
                    return new ResultErrorViewModel()
                    {
                        Result = false,
                        Error = "No Vendor for BuyingRate"
                    };
                }
                else
                {
                    var partnerID = await _fast.Partners.AnyAsync(x => x.PartnerID == query.First().vendor);
                    if (!partnerID)
                    {
                        return new ResultErrorViewModel()
                        {
                            Result = false,
                            Error = "Invalid Vendor"
                        };
                    }
                }
            }
            return new ResultErrorViewModel()
            {
                Result = true,
                Error = "OK"
            };
        }
        public async Task FindHBLNo(ImportChargeVM fee)
        {
            // user type HBL
            var isCorrectHBL = await _fast.HAWB.AnyAsync(x => x.HWBNO == fee.HBL);
            if (isCorrectHBL)
            {
                return;
            }

            //user type CDS
            var numberCharacter = configuration.GetValue<int>("NumberCharacter");
            var houseBill = await _fast.TransactionDetails.Where(x => x.TransID == fee.Job).Select(x => x.HWBNO).ToListAsync();
            var query = (from transDetail in _fast.TransactionDetails
                         join customsDeclaration in _fast.CustomsDeclaration
                         on transDetail.CustomsID equals customsDeclaration.MasoTK into customsJoin
                         from customsLeft in customsJoin.DefaultIfEmpty()
                         where customsLeft != null && customsLeft.TKSo == fee.HBL.Substring(0, numberCharacter)
                         select transDetail.HWBNO);
            foreach (var item in query)
            {
                if (houseBill.Contains(item))
                {
                    fee.HBL = item;
                    return;
                }
            }

            // user type CTNR
            var query2 = (from transDetail in _fast.TransactionDetails
                    join trans in _fast.Transactions on transDetail.TransID equals trans.TransID
                    into transJoin
                    from transLeft in transJoin.DefaultIfEmpty()
                    where transLeft != null
                          && transLeft.TpyeofService == "INLANDTRUCKING"
                          && transLeft.transLock == false
                          && transDetail.ContSealNo == fee.HBL
                    orderby transLeft.LoadingDate descending
                    select transDetail.HWBNO).FirstOrDefault();

            if (!string.IsNullOrEmpty(query2))
            {
                fee.HBL = query2;
                return;
            }
        }
    }
}
