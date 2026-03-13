using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesTypingEffect;

public class PinesTypingEffect : StaticComponent
{
    [HtmlAttributeName("text-array")]
    public List<string> TextArray { get; set; } = new List<string>();

    [HtmlAttributeName("type-speed")]
    public int TypeSpeed { get; set; } = 110;

    [HtmlAttributeName("cursor-speed")]
    public int CursorSpeed { get; set; } = 550;

    [HtmlAttributeName("pause-end")]
    public int PauseEnd { get; set; } = 1500;

    [HtmlAttributeName("pause-start")]
    public int PauseStart { get; set; } = 20;
}
