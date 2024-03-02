﻿using Core.Components.Extensions;
using Core.Components.Forms;
using Core.Extensions;
using Core.Models;

namespace Core.Components.Framework
{
    public class FeatureBL : PopupEditor
    {
        public FeatureBL() : base(nameof(Feature))
        {
            Name = "Feature management";
            Title = "Feature";
            Icon = "icons/config.png";
            Config = true;
            DOMContentLoaded += AlterPosition;
        }

        private void AlterPosition()
        {
            Element.ParentElement.AddClass("properties");
        }

        public void EditFeature(Feature feature)
        {
            var id = "Feature_" + feature.Id;
            this.OpenTab(id, () => new FeatureDetailBL
            {
                Id = id,
                Entity = feature,
                Title = $"Feature {feature.Name ?? feature.Label ?? feature.Description}"
            });
        }
    }
}
