using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesBanner;

public class PinesBanner : StaticComponent
{
    [HtmlAttributeName("head")]
    public string BannerHead { get; set; }


    [HtmlAttributeName("body")]
    public string BannerBody { get; set; }


    [HtmlAttributeName("initial-state")]
    public PinesBannerState BannerState { get; set; } = new PinesBannerState();
}
