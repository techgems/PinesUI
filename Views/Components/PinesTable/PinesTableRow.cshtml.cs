using Microsoft.AspNetCore.Razor.TagHelpers;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesTable;

public class PinesTableRow : StaticComponent
{
    [HtmlAttributeName("class")]
    public string? CssClass { get; set; }
}
