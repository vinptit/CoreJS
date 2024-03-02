using Core.Clients;
using Core.Components.Extensions;
using Core.Components;
using Core.Components.Forms;
using System.Threading.Tasks;
using TMS.API.Models;

namespace TMS.UI.Business.Setting
{
    class SurchargeTypeBL : TabEditor
    {
        public SurchargeTypeBL() : base(nameof(SurchargeType))
        {
            Entity = new SurchargeType();
            Name = "Surcharge List";
        }

        /* public async Task PinSurchargeType(SurchargeType type)
         {
             var grid = this.FindComponentByName<GridView>(nameof(SurchargeType));
             var max = 10000;
             if (type.IsPin == false)
             {
                 type.PinId = max;
                 await new Client(nameof(SurchargeType)).UpdateAsync(type);
                 await grid.ReloadData();
                 return;
             }
             var surType = await new Client(nameof(SurchargeType)).FirstOrDefaultAsync<SurchargeType>($"?$filter=Active eq true and IsPin eq true &$orderby PinId des c");
             if (surType != null)
             {
                 var newPinId = surType.PinId + 1;
                 type.PinId = newPinId;
             }
             else
             {
                 type.PinId = 1;
             }
             await new Client(nameof(SurchargeType)).UpdateAsync(type);
             await grid.ReloadData();
           }*/
    }
}
