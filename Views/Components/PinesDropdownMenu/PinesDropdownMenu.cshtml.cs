using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesDropdownMenu;

public class PinesDropdownMenu : StaticComponent
{
    [HtmlAttributeName("header")]
    public string MenuHeader { get; set; }

    public string UserName { get; set; }

    [HtmlAttributeName("image-url")]
    public string ProfileImageUrl { get; set; }
}
