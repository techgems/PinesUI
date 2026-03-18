using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TechGems.StaticComponents;

namespace PinesUI.LiveDemo.Views.Components;

public class CodeHighlight : StaticComponent
{
    public string Code { get; set; }

    public string Lang { get; set; }
}
