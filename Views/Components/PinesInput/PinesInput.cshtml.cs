using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesInput;

[HtmlTargetElement("pines-input")]
public class PinesInput : StaticNode
{
    [HtmlAttributeName("asp-for")]
    public ModelExpression? InputExpression { get; set; }

    [HtmlAttributeName("type")]
    public string? Type { get; set; }

    [HtmlAttributeName("show-label")]
    public bool ShowLabel { get; set; } = true;

    [HtmlAttributeName("disabled")]
    public bool Disabled { get; set; }

    [HtmlAttributeNotBound]
    public string LabelContent => InputExpression?.Metadata.DisplayName ?? string.Empty;

    public string GetHtmlInputType()
    {
        if (!string.IsNullOrEmpty(Type))
        {
            return Type;
        }

        if (InputExpression == null)
        {
            return "text";
        }

        var modelType = InputExpression.Metadata.ModelType;

        switch(modelType)
        {
            case Type t when t == typeof(string):
                return "text";
            case Type t when t == typeof(int) || t == typeof(int?) || t == typeof(long) || t == typeof(long?) || t == typeof(short) || t == typeof(short?) || t == typeof(byte) || t == typeof(byte?):
                return "number";
            case Type t when t == typeof(float) || t == typeof(float?) || t == typeof(double) || t == typeof(double?) || t == typeof(decimal) || t == typeof(decimal?):
                return "number";
            case Type t when t == typeof(DateTime) || t == typeof(DateTime?):
                return "date";
            default:
                return "text";
        }
    }

    private bool IsInputModelValid(Type type)
    {
        var validTypes = new List<Type> { 
            typeof(string),
            typeof(int),
            typeof(int?),
            typeof(long),
            typeof(long?),
            typeof(short),
            typeof(short?),
            typeof(byte),
            typeof(byte?),
            typeof(float),
            typeof(float?),
            typeof(double),
            typeof(double?),
            typeof(decimal),
            typeof(decimal?),
            typeof(DateTime),
            typeof(DateTime?)
        };


        return validTypes.Contains(type);
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        if (InputExpression is not null)
        {
            var modelType = InputExpression.Metadata?.ModelType!;

            if(!IsInputModelValid(modelType))
            {
                throw new ArgumentException(@"The model type used in ""asp-for"" is not supported by this component. The supported types are: string, int, long, short, byte, float, double, decimal and DateTime.");
            }
        }

        await base.ProcessAsync(context, output);
    }

}