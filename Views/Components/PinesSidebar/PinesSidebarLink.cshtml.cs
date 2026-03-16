using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Text;
using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesSidebar;

public class PinesSidebarLink : StaticComponent
{
    [HtmlAttributeName("asp-page")]
    public string? Page { get; set; }

    [HtmlAttributeName("asp-action")]
    public string? Action { get; set; }

    [HtmlAttributeName("asp-controller")]
    public string? Controller { get; set; }

    [HtmlAttributeNotBound]
    public bool IsLinkActive { get; set; }

    private void SetLinkStatus(RouteData routeData)
    {
        var currentPage = routeData.Values["page"] as string;
        var currentAction = routeData.Values["action"] as string;
        var currentController = routeData.Values["controller"] as string;

        var acceptedActions = (Action ?? currentAction)?.Split(',');
        var acceptedControllers = (Controller ?? currentController)?.Split(',');
        var acceptedPages = (Page ?? currentPage)?.Split(',');

        var mvcMatch = acceptedActions.Contains(currentAction) && acceptedControllers.Contains(currentController);
        var pageMatch = acceptedActions.Contains(currentAction);

        IsLinkActive = mvcMatch || pageMatch;
    }

    public async override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        var routes = ViewContext!.RouteData;

        SetLinkStatus(routes);
        await base.ProcessAsync(context, output);
    }
}
