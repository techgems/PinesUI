using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.PinesSetup.PinesCss;

public class PinesCss : StaticComponent
{
    [HtmlAttributeName("asp-append-version")]
    public bool AppendVersion { get; set; } = true;
}
