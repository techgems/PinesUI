using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TechGems.StaticComponents;

namespace PinesUI.StaticComponents.TagHelpers.PinesInput;

[HtmlTargetElement("pines-input")]
public class PinesInput : StaticComponent
{
    public PinesInput()
    {

    }

    [HtmlAttributeName("asp-for")]
    public ModelExpression? InputExpression { get; set; }

    [HtmlAttributeName("show-label")]
    public bool ShowLabel { get; set; }

    [HtmlAttributeName("disabled")]
    public bool Disabled { get; set; }

}
