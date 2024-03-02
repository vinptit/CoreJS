using System;
using System.Threading.Tasks;
using TMS.API.Models;
using Core.Components.Extensions;
using Core.Components.Forms;
using Core.Clients;
using Core.Extensions;
using Bridge.Html5;
using Core.MVVM;
using System.Collections.Generic;
using Core.Enums;
using static Retyped.canvasjs.Literals.Options;
using Core.Components;
using System.Linq;

namespace TMS.UI.Business.Setting
{
    public class ConfigIdBL : TabEditor
    {
        private ConfigID _configID => Entity as ConfigID;
        private List<string> _format = new List<string>() { "MM", "YY", "YYYY", "DD"};
        public ConfigIdBL() : base(nameof(ConfigID))
        {
            Name = "Config ID";
            Entity = new ConfigID();
            DOMContentLoaded += () =>
            {
                var thisGrid = this.FindActiveComponent<VirtualGrid>().FirstOrDefault();
            };
        }
        
        public async Task CheckValidateNumber(ConfigID p)
        {
            if (!string.IsNullOrEmpty(p.P4) && !_format.Contains(p.P4.ToUpper()) && !IsSharpDegit(p.P4))
            {
                Toast.Warning("Vui lòng định dạng ngày tháng hoặc chuỗi '#' !");
                p.P4 = null;
            }
            if (!string.IsNullOrEmpty(p.P5) && !IsSharpDegit(p.P5))
            {
                Toast.Warning("Vui lòng định dạng ngày tháng hoặc chuỗi '#' !");
                p.P5 = null;
            }
            UpdateView();
        }

        public bool IsSharpDegit(string context)
        {
            context = context.Replace("#", "");
            if (context != "")
            {
                return false;
            }
            return true;
        }
    }
}
