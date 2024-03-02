using Core.Components.Extensions;
using Core.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.API.Models;

namespace TMS.UI.Business.Accountant
{
    public class ContractEditorBL : PopupEditor
    {
        public Contract ContractEntity => Entity as Contract;
        public ContractEditorBL() : base(nameof(Contract))
        {
            Name = "Contract Editor";
        }
    }
}
