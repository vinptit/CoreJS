using Bridge.Html5;
using Core.Clients;
using Core.Components;
using Core.Components.Extensions;
using Core.Components.Forms;
using Core.Enums;
using Core.Extensions;
using Core.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS.API.Models;

namespace TMS.UI.Business.Accountant
{
    public class ContractBL : TabEditor
    {
        public ContractBL() : base(nameof(Contract))
        {
            Name = "Contract List";
        }
        public async Task AddContract()
        {
            await this.OpenPopup(
                featureName: "Contract Editor",
                factory: () =>
                {
                    var type = Type.GetType("TMS.UI.Business.Accountant.ContractEditorBL");
                    var instance = Activator.CreateInstance(type) as PopupEditor;
                    instance.Title = "Thêm mới hợp đồng";
                    instance.Entity = new Contract();
                    return instance;
                });
        }
        public async Task EditContract(Contract entity)
        {
            await this.OpenPopup(
                featureName: "Contract Editor",
                factory: () =>
                {
                    var type = Type.GetType("TMS.UI.Business.Accountant.ContractEditorBL");
                    var instance = Activator.CreateInstance(type) as PopupEditor;
                    instance.Title = $"Chỉnh sửa hợp đồng: {entity.Code}";
                    instance.Entity = entity;
                    return instance;
                });
        }
    }
}