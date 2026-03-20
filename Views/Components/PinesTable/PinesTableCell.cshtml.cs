using Microsoft.AspNetCore.Razor.TagHelpers;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesTable;

public class PinesTableCell : StaticComponent
{
    [HtmlAttributeName("class")]
    public string? CssClass { get; set; }

    [HtmlAttributeName("is-header")]
    public bool IsHeader { get; set; }
}
