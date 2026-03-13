using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesButton;


public class PinesButton : StaticComponent
{
    [HtmlAttributeName("type")]
    public PinesButtonTypeEnum ButtonType { get; set; }

    [HtmlAttributeName("color")]
    public PinesButtonColorEnum Color { get; set; }
}
