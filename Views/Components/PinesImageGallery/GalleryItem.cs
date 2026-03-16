using Newtonsoft.Json;

namespace TechGems.PinesUI.Views.Components.PinesImageGallery;

public class GalleryItem
{
    [JsonProperty("photo")]
    public string ImageUrl { get; set; } = string.Empty;

    [JsonProperty("alt")]
    public string ImageAlt { get; set; } = string.Empty;
}
