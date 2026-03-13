using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesBadge;

public class PinesBadge : StaticComponent
{
    public PinesBadge()
    {
        
    }

    public BadgeType Type { get; set; }

    public BadgeColor Color { get; set; }
}
