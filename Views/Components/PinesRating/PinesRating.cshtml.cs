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

    private bool IsInputModelValid(Type type)
    {
        var validTypes = new List<Type> { typeof(int), typeof(short) };
        return validTypes.Contains(type);
    }

    public int GetInitialOrPresetValue()
    {
        if(InputExpression is not null && InputExpression.Model is not null)
        {
            return Convert.ToInt32(InputExpression.Model);
        }

        return InitialValue;
    } 

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        if (InputExpression is not null)
        {
            var modelType = InputExpression.Metadata?.ModelType!;

            if (!IsInputModelValid(modelType))
            {
                throw new ArgumentException(@"The model type used in ""asp-for"" is not supported by this component. Only ""int"" and ""short"" are supported in PinesRating.");
            }
        }

        await base.ProcessAsync(context, output);
    }
}
