using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesSelect;

public class PinesSelect : StaticComponent
{
    [HtmlAttributeName("items")]
    public List<PinesSelectItem> Items { get; set; } = new List<PinesSelectItem>();

    [HtmlAttributeName("placeholder")]
    public string Placeholder { get; set; } = "Select Item";

    [HtmlAttributeName("asp-for")]
    public ModelExpression? InputExpression { get; set; }
}
