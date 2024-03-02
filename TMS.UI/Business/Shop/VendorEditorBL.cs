using Core.Clients;
using Core.Components.Extensions;
using Core.Components.Forms;
using Core.Extensions;
using System.Threading.Tasks;
using TMS.API.Models;
using TMS.API.ViewModels;

namespace TMS.UI.Business.Shop
{
    public class VendorEditorBL : PopupEditor
    {
        public Vendor vendorEntity => Entity as Vendor;
        public VendorEditorBL() : base(nameof(Vendor))
        {
            Name = "Vendor Editor";
            DOMContentLoaded += () =>
            {
                Entity["TypeId"] = 7551;
                if (vendorEntity.Id > 0)
                {
                    this.SetDisabled(true, "CustomerTypeId");
                    this.SetDisabled(true, "IsBought");
                }
            };
        }
        public async Task<APIResponseVM> CheckTaxcode()
        {
            var res = await new Client(nameof(Vendor)).PostAsync<APIResponseVM>(vendorEntity, "CheckTaxcode");
            if (res.data is null)
            {
                Toast.Warning("Invalid Taxcode!");
                vendorEntity.TaxCode = null;
            }
            else
            {
                vendorEntity.CompanyName = vendorEntity.Name = res.data.name;
                vendorEntity.Address = vendorEntity.Address = res.data.address;
            }
            UpdateView();
            return res;
        }
    }
}
