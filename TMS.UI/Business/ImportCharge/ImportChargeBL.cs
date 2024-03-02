using Core.Clients;
using Core.Components.Extensions;
using Core.Components;
using Core.Components.Forms;
using Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.API.ViewModels;
using TMS.API.Models;
using Bridge.Html5;
using Core.MVVM;
using Core.Enums;

namespace TMS.UI.Business.ImportCharge
{
    public class ImportChargeBL : TabEditor
    {
        public static List<ImportChargeVM> list;
        public static List<ImportChargeVM> checkList;
        private HTMLInputElement _uploader;
        public ImportChargeBL() : base(nameof(ImportExcel))
        {
            Name = "Import Charge";
        }
        private void ResetGridViewResult()
        {
            var gridViewResult = this.FindComponentByName<GridView>("GridResult");
            gridViewResult.ClearRowData();
            UpdateView();
        }
        public void ImportExcelAttachment()
        {
            UploadFile();
            _uploader.Click();
        }

        private void UploadFile()
        {
            Html.Take("Body").Form.Attr("method", "POST").Attr("enctype", "multipart/form-data")
                           .Display(false).Input.Event(EventType.Change, async (ev) => await SelectedExcel(ev))
                           .Type("file").Id($"id_{GetHashCode()}").Attr("name", "fileImport").Attr("accept", ".xlsx");
            _uploader = Html.Context as HTMLInputElement;
        }
        public async Task SelectedExcel(Bridge.Html5.Event e)
        {
            try
            {
                var grid = this.FindComponentByName<GridView>("GridResult");
                if (grid != null)
                {
                    Spinner.AppendTo(grid.Element);
                }
                var files = e.Target["files"] as FileList;
                if (files.Nothing())
                {
                    return;
                }
                var uploadForm = _uploader.ParentElement as HTMLFormElement;
                var formData = new FormData(uploadForm);
                var res = await Client.SubmitAsync<List<ImportChargeVM>>(new XHRWrapper
                {
                    FormData = formData,
                    Url = "ImportExcelAttachment",
                    Method = HttpMethod.POST,
                    ResponseMimeType = Utils.GetMimeType("xlsx")
                });
                if (res != null)
                {
                    Toast.Success("Import successfully. Waiting to check data...");
                    Spinner.AppendTo(grid.Element);
                    checkList = await new Client(nameof(ImportExcel)).PostAsync<List<ImportChargeVM>>(res, "CheckFee");
                    grid.ClearRowData();
                    await grid.AddRows(checkList);
                    Toast.Success("Check completed!");
                    Spinner.Hide();
                    UpdateView();
                }
            }
            catch (Exception ex)
            {
                Spinner.Hide();
                Toast.Warning($"Error: {ex}");
            }
        }

        public void DownloadTemplate()
        {
            Client.Download($"{Core.Clients.Client.Origin}TemplateExcel/ImportChargeTemplate.xlsx");
        }
        public void DownloadDocument()
        {
            Client.Download($"{Core.Clients.Client.Origin}TemplateExcel/ImportExpense_Docs.pdf");           
        }

        public async Task AddOrUpdateItems(ImportChargeVM entity)
        {

            var confirm = new ConfirmDialog
            {
                Content = "Are you sure to save data to the system ?",
            };
            confirm.Render();
            confirm.YesConfirmed += async () =>
            {
                var resultImport = await new Client(nameof(ImportExcel)).SubmitAsync<string>(new XHRWrapper
                {
                    Value = JSON.Stringify(checkList),
                    Url = "AddOrUpdateList",
                    Method = Core.Enums.HttpMethod.POST,
                    AllowNestedObject = true,
                    IsRaw = true
                });
                if (!string.IsNullOrEmpty(resultImport))
                {
                    Toast.Warning(resultImport);
                }
                else
                {
                    Toast.Success("Successfully!");
                }
            };
        }
    }
}
