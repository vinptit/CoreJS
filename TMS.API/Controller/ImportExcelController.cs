using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq.Dynamic.Core;
using TMS.API.Models;
using TMS.API.ViewModels;
using System.Linq;
using System.Collections.Generic;
using TMS.API.Enums;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.Extensions.DependencyInjection;
using Core.Extensions;
using Task = System.Threading.Tasks.Task;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Newtonsoft.Json;
using Polly;
using System.Globalization;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Build.Framework;
using Microsoft.Extensions.Primitives;
using Microsoft.AspNetCore.Components.Forms;
using System.Net;
using Core.Exceptions;
using TMS.API.FastTruongNamModels;
using OfficeOpenXml;
using Windows.Storage;
using FileIO = System.IO.File;
using Microsoft.IdentityModel.Tokens;
using System.Net.Mail;
using DocumentFormat.OpenXml.Spreadsheet;
using TMS.API.FastKiowayModels;
using Windows.UI.Xaml;
using TMS.API.ImportExcelFunction;

namespace TMS.API.Controllers
{
    public class ImportExcelController : TMSController<ImportExcel>
    {
        private static string path;
        private static string tenant;
        KiowayModule kiowayFunc;
        TruongNamModule truongnamFunc;
        public ImportExcelController(TMSContext context, EntityService entityService, IHttpContextAccessor httpContextAccessor, IServiceProvider serviceProvider) : base(context, entityService, httpContextAccessor)
        {
            tenant = Startup.GetConnectionString(_serviceProvider, _config, "fastweb");
            kiowayFunc = new KiowayModule(httpContextAccessor);
            truongnamFunc = new TruongNamModule(httpContextAccessor);
        }

        [HttpPost("api/[Controller]/ImportExcelAttachment")]
        public async Task<List<ImportChargeVM>> ImportExcelAttachment([FromServices] IWebHostEnvironment host, List<IFormFile> fileImport)
        {
            try
            {
                var listCharge = new List<ImportChargeVM>();
                var formFile = fileImport.FirstOrDefault();
                if (formFile == null || formFile.Length <= 0)
                {
                    return null;
                }
                if (!Path.GetExtension(formFile.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
                {
                    return null;
                }
                path = GetUploadPath(formFile.FileName, host.WebRootPath);
                EnsureDirectoryExist(path);
                path = IncreaseFileName(path);
                using var stream = FileIO.Create(path);
                await formFile.CopyToAsync(stream);
                using var package = new ExcelPackage(stream);
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var currentSheet = package.Workbook.Worksheets;
                var worksheet = currentSheet.First();
                var noOfCol = worksheet.Dimension.End.Column;
                var noOfRow = worksheet.Dimension.End.Row;


                for (int row = 2; row <= noOfRow; row++)
                {
                    var newCharge = new ImportChargeVM();
                    CopyDataChargeFromExcel(worksheet, row, newCharge);
                    if (!string.IsNullOrEmpty(newCharge.Job))
                    {
                        listCharge.Add(newCharge);
                    }
                }
                await AddUploadHistory();
                return listCharge;
            }
            catch (ApiException ex)
            {
                throw ex;
            }
        }
        private void CopyDataChargeFromExcel(ExcelWorksheet worksheet, int row, ImportChargeVM data)
        {
            try
            {
                // Job null thi dung
                if (string.IsNullOrEmpty(worksheet.Cells[row, (int)ExcelColumnsEnum.A].Value?.ToString()))
                {
                    return;
                }
                data.Job = worksheet.Cells[row, (int)ExcelColumnsEnum.A].Value?.ToString();
                data.PartnerID = worksheet.Cells[row, (int)ExcelColumnsEnum.B].Value?.ToString();
                data.HBL = worksheet.Cells[row, (int)ExcelColumnsEnum.C].Value?.ToString();
                data.Description = worksheet.Cells[row, (int)ExcelColumnsEnum.D].Value?.ToString();
                data.Quantity = worksheet.Cells[row, (int)ExcelColumnsEnum.E].Value?.ToString();
                data.Unit = worksheet.Cells[row, (int)ExcelColumnsEnum.F].Value?.ToString();
                data.UnitPrice = worksheet.Cells[row, (int)ExcelColumnsEnum.G].Value?.ToString();
                data.Currency = worksheet.Cells[row, (int)ExcelColumnsEnum.H].Value?.ToString();
                data.ExtRate = worksheet.Cells[row, (int)ExcelColumnsEnum.I].Value?.ToString();
                data.VAT = worksheet.Cells[row, (int)ExcelColumnsEnum.J].Value?.ToString();
                data.Total = worksheet.Cells[row, (int)ExcelColumnsEnum.K].Value?.ToString();
                data.FeeCode = worksheet.Cells[row, (int)ExcelColumnsEnum.L].Value?.ToString();
                data.Docs = worksheet.Cells[row, (int)ExcelColumnsEnum.M].Value?.ToString();
                data.OBHPartnerID = worksheet.Cells[row, (int)ExcelColumnsEnum.N].Value?.ToString();
                data.TYPE = worksheet.Cells[row, (int)ExcelColumnsEnum.O].Value?.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<ImportExcel> AddUploadHistory()
        {
            var history = new ImportExcel()
            {
                Attachment = path.Replace(_host.WebRootPath.ToString(), "")
            };
            SetAuditInfo(history);
            db.Add(history);
            await db.SaveChangesAsync();
            return history;
        }

        [HttpPost("api/[Controller]/CheckFee/")]
        public async Task<List<ImportChargeVM>> CheckFeeFunction([FromBody] List<ImportChargeVM> fee)
        {
            if (tenant.ToUpper().Contains("TRUONGNAM"))
            {
                var res = await truongnamFunc.ExecuteFunction(fee);
                return res;
            }
            else if (tenant.ToUpper().Contains("KIOWAY"))
            {
                var res = await kiowayFunc.ExecuteFunction(fee);
                return res;
            }
            return null;
        }
        [HttpPost("api/[Controller]/AddOrUpdateList/")]
        public async Task<string> AddOrUpdateList([FromBody] List<ImportChargeVM> fee)
        {
            if (tenant.ToUpper().Contains("TRUONGNAM"))
            {
                var res = await truongnamFunc.AddOrUpdateList();
                return res;
            }
            else if (tenant.ToUpper().Contains("KIOWAY"))
            {
                var res = await kiowayFunc.AddOrUpdateList(fee);
                return res;
            }
            return null;
        }
    }
}