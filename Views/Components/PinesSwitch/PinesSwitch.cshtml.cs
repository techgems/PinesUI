using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesSwitch;

public class PinesSwitch : StaticComponent
{
    [HtmlAttributeName("label")]
    public string Label { get; set; } = string.Empty;

    [HtmlAttributeName("asp-for")]
    public ModelExpression? InputExpression { get; set; }

    [HtmlAttributeName("switch-on")]
    public bool SwitchOn { get; set; } = false;
}
