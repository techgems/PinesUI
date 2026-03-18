using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesCard;

public class PinesImageCard : StaticComponent
{
    public PinesImageCard()
    {
        
    }

    public const string CardContentSlot = "CardContent_Slot";
    
    public string ImageUrl { get; set; }

    [HtmlAttributeName("title")]
    public string CardTitle { get; set; }

    public string Class { get; set; }

}
