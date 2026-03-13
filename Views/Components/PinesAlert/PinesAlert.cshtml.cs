using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesAlert;

public class PinesAlert : StaticComponent
{

    [HtmlAttributeName("type")]
    public PinesAlertTypeEnum AlertType { get; set; }

    [HtmlAttributeName("color")]
    public PinesAlertColorEnum AlertColor { get; set; }

    public string Header { get; set; }
}
