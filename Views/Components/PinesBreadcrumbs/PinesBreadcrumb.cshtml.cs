using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesBreadcrumbs;

public class PinesBreadcrumb : StaticComponent
{
    [HtmlAttributeName("items")]
    public List<PinesBreadcrumbItem> Items { get; set; } = new List<PinesBreadcrumbItem>();

}
