using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesSwitch;

public class PinesSwitch : StaticComponent
{
    [HtmlAttributeName("label")]
    public string Label { get; set; } = string.Empty;

    [HtmlAttributeName("asp-for")]
    public ModelExpression? InputExpression { get; set; }

    [HtmlAttributeName("switch-on")]
    public bool SwitchOn { get; set; } = false;

    private bool IsInputModelValid(Type type)
    {
        var validTypes = new List<Type> {
            typeof(bool)
        };

        return validTypes.Contains(type);
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        if (InputExpression is not null)
        {
            var modelType = InputExpression.Metadata?.ModelType!;

            if (!IsInputModelValid(modelType))
            {
                throw new ArgumentException(@"The model type used in ""asp-for"" is not supported by this component. Only bool is supported in PinesSwitch.");
            }
        }

        await base.ProcessAsync(context, output);
    }
}
