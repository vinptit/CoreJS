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
        public ContractBL() : base(nameof(Vendor))
        {
            Name = "Contract List";

        }
    }
}