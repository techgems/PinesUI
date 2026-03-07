using System;
using System.Collections.Generic;
using System.Text;
using TechGems.StaticComponents;

namespace PinesUI.StaticComponents.Views.Components.PinesQuote;

public class PinesQuote : StaticComponent
{
    public string Author { get; set; }

    public string? AuthorTitle { get; set; }

    public string? ImageUrl { get; set; }

    public string? ImageAlt { get; set; }
}
