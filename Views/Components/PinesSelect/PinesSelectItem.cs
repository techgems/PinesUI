using Newtonsoft.Json;

namespace TechGems.PinesUI.Views.Components.PinesSelect;

public class PinesSelectItem
{
    [JsonProperty("title")]
    public string Title { get; set; } = string.Empty;

    [JsonProperty("value")]
    public string Value { get; set; } = string.Empty;

    [JsonProperty("disabled")]
    public bool Disabled { get; set; } = false;
}
