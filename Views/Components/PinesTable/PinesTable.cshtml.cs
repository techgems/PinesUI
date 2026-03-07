using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Text;
using TechGems.StaticComponents;

namespace PinesUI.StaticComponents.Views.Components.PinesTable;

public class PinesTable : StaticComponent
{

    public PinesTable()
    {

    }

    [HtmlAttributeName("table-id")]
    public string? TableId { get; set; }

    [HtmlAttributeName("column-config")]
    public List<(string Name, string DisplayName)> ColumnList { get; set; } = new List<(string Name, string DisplayName)>();


    [HtmlAttributeName("data")]
    public List<object> Data { get; set; } = new List<object>();

    [HtmlAttributeName("display-action-col")]
    public bool RenderActionColumn { get; set; }

    public string GetDataRowHtml(int index)
    {
        var sb = new StringBuilder();
        var type = Data[index].GetType();

        var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public).ToList();

        sb.AppendLine(@"<tr class=""text-neutral-800"">");

        foreach (var item in ColumnList)
        {
            var prop = properties.FirstOrDefault(x => x.Name == item.Name);
            var propValue = prop?.GetValue(Data[index]);

            sb.AppendLine(@$"<td class=""px-5 py-4 text-sm whitespace-nowrap"">{(propValue != null ? propValue : "")}</td>");
        }

        sb.AppendLine("</tr>");

        return sb.ToString();
    }


}
