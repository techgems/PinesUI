using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Reflection;
using TechGems.PinesUI.Views.Components.PinesSelect;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesMultiSelect;

public class PinesMultiSelect : StaticComponent
{
    [HtmlAttributeName("items")]
    public List<PinesMultiSelectItem> Items { get; set; } = new List<PinesMultiSelectItem>();

    [HtmlAttributeName("values")]
    public List<PinesMultiSelectItem>? Values { get; set; }

    [HtmlAttributeName("placeholder")]
    public string Placeholder { get; set; } = "Select Items";

    [HtmlAttributeName("asp-for")]
    public ModelExpression? InputExpression { get; set; }

    private bool IsModelTypeValid(Type type)
    {
        var validTypes = new List<Type> { typeof(List<string>), typeof(List<int>), typeof(List<short>), typeof(List<float>), typeof(List<double>), typeof(List<decimal>), typeof(List<long>), typeof(List<byte>), typeof(List<DateTime>) };
        return validTypes.Contains(type);
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        if (InputExpression is not null) {
            var modelType = InputExpression.Metadata?.ModelType!;

            var isGenericList = IsModelTypeValid(modelType);

            if (!isGenericList) {
                throw new ArgumentException("The model type must be of type List<string>");
            }
        }

        await base.ProcessAsync(context, output);
    }
}
