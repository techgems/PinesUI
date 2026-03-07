using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TechGems.StaticComponents;

namespace PinesUI.StaticComponents.Views.Components.PinesAlert;

public class PinesAlert : StaticComponent
{
    public PinesAlert()
    {
        
    }

    [HtmlAttributeName("type")]
    public PinesAlertTypeEnum AlertType { get; set; }

    [HtmlAttributeName("color")]
    public PinesAlertColorEnum AlertColor { get; set; }

    public string Header { get; set; }
}
