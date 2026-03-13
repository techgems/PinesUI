using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesRating;

public class PinesRating : StaticComponent
{
    [HtmlAttributeName("max-stars")]
    public int MaxStars { get; set; } = 5;

    [HtmlAttributeName("initial-value")]
    public int InitialValue { get; set; } = 0;

    [HtmlAttributeName("disabled")]
    public bool Disabled { get; set; } = false;

    [HtmlAttributeName("rating-type")]
    public PinesRatingTypeEnum RatingType { get; set; } = PinesRatingTypeEnum.Star;

    [HtmlAttributeName("asp-for")]
    public ModelExpression? InputExpression { get; set; }
}
