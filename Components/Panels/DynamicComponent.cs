using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;


namespace FerryFinder.Panels
{
    public class DynamicComponent : ComponentBase
    {

        [Parameter]
        public Type Type { get; set; }

        [Parameter]
        public Dictionary<string, object> ActivationParameters { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenComponent(0, Type);
            builder.AddAttribute(1, "ActivationParameters", ActivationParameters);
            builder.CloseComponent();
        }
    }
    
}
