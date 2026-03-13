using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesTabs;

public class PinesTabs : StaticComponent
{
    [HtmlAttributeName("tab-names")]
    public List<string> TabNames { get; set; } = new List<string>();
}
