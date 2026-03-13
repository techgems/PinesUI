using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesDropdownMenu;

public class DropdownMenuOption : StaticComponent
{


    [HtmlAttributeName("link")]
    public string Link { get; set; }
}
