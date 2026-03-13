using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesDatePicker;

public class PinesDatePicker : StaticComponent
{
    [HtmlAttributeName("date-format")]
    public string DateFormat { get; set; } = "M d, Y";

    [HtmlAttributeName("label")]
    public string Label { get; set; } = "Select Date";

    [HtmlAttributeName("placeholder")]
    public string Placeholder { get; set; } = "Select date";

    [HtmlAttributeName("asp-for")]
    public ModelExpression? InputExpression { get; set; }
}
