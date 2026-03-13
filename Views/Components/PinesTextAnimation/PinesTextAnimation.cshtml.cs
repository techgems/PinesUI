using Microsoft.AspNetCore.Razor.TagHelpers;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesTextAnimation;

public class PinesTextAnimation : StaticComponent
{
    [HtmlAttributeName("animation-type")]
    public PinesTextAnimationTypeEnum AnimationType { get; set; } = PinesTextAnimationTypeEnum.FadeIn;
}
