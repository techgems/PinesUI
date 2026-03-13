using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesBreadcrumbs;

public class PinesBreadcrumbItem : StaticComponent
{
    public bool IsFirst { get; set; }

    public bool HasNext { get; set; }

    /// <summary>
    /// Must only be used if asp-controller and asp-action are not set.
    /// </summary>
    [HtmlAttributeName("asp-page")]
    public string? Page { get; set; }

    /// <summary>
    /// Must only be used if asp-page is not set.
    /// </summary>
    [HtmlAttributeName("asp-controller")]
    public string? Controller { get; set; }

    /// <summary>
    /// Must only be used if asp-page is not set.
    /// </summary>
    [HtmlAttributeName("asp-action")]
    public string? Action { get; set; }

}
