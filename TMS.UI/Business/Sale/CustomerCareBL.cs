using Core.Enums;
using Core.ViewModels;
using Core.Clients;
using Core.Components;
using Core.Components.Extensions;
using Core.Components.Forms;
using System;
using System.Linq;
using System.Threading.Tasks;
using TMS.API.Models;
using TMS.API.Enums;

namespace TMS.UI.Business.Sale
{
    public class CustomerCareBL : TabEditor
    {
        public CustomerCareBL() : base(nameof(Vendor))
        {
            Name = "Customer care";
            Title = Name;
        }

        public async Task CreateCustomer()
        {
            await InitCustomerCareForm(new Vendor()
            {
             //   VendorTypeId = (int)VendorTypeEnum.Customer,
                SaleId = Client.Token.UserId
            });
        }

        public async Task EditCustomer(Vendor customer)
        {
            await InitCustomerCareForm(customer);
        }

        private async Task InitCustomerCareForm(Vendor customer)
        {
            await this.OpenTab(
                id: "Vendor" + customer.Id,
                featureName: "CustomerCare Detail",
                factory: () =>
                {
                    var type = Type.GetType("TMS.UI.Business.Sale.CustomerCareDetailBL");
                    var instance = Activator.CreateInstance(type) as TabEditor;
                    instance.Title = "Thông tin khách hàng";
                    instance.Entity = customer;
                    return instance;
                });
        }

        public async Task Email()
        {
            var customers = this.FindActiveComponent<GridView>();
            var selected = customers.SelectMany(x => x.GetSelectedRows()).Cast<Vendor>();
            var res = await new Client(nameof(Vendor)).SendMail(new EmailVM
            {
                ToAddresses = selected.Select(x => x.Email).ToList()
            });
        }
    }
}
