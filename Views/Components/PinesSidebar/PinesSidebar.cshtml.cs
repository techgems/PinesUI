using TechGems.StaticComponents;

namespace TechGems.PinesUI.Views.Components.PinesSidebar;

public class PinesSidebar : StaticComponent
{
    public static string PrimarySectionSlot = "primary-section";

    public static string SecondarySectionSlot = "secondary-section";

    public string PrimarySectionName { get; set; }

    public string SecondarySectionName { get; set; }
}
