using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;

namespace PinesUI.LiveDemo.Pages.Components;

public class FormsModel : PageModel
{
    [DisplayName("Input Property")]
    [BindProperty]
    public int? InputPropertyBind { get; set; }

    [BindProperty]
    public string? StringPropertyBind { get; set; }

    [BindProperty]
    public List<string> ValuesMultiSelect { get; set; } = new List<string>() { "cherry" };

    public void OnGet()
    {
    }

    public void OnPost()
    {
        ValuesMultiSelect.Clear();
    }
}
