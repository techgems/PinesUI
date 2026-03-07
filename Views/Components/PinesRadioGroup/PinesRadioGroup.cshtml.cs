using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TechGems.StaticComponents;

namespace PinesUI.StaticComponents.Views.Components.PinesRadioGroup;

public class PinesRadioGroup : StaticComponent
{
    [HtmlAttributeName("asp-for")]
    public ModelExpression? InputExpression { get; set; }

    public List<PinesRadioElement<string>> OptionsList { get; set; }
}
