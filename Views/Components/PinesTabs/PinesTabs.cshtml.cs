using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesTabs;

public class PinesTabs : StaticComponent
{
    [HtmlAttributeName("tab-config")]
    public Dictionary<string, PinesTabConfigItem> TabConfig { get; set; } = new Dictionary<string, PinesTabConfigItem>();

    public string Class { get; set; }
}
