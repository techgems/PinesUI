using Newtonsoft.Json;

namespace TechGems.PinesUI.Views.Components.PinesImageGallery;

public class GalleryItem
{
    [JsonProperty("photo")]
    public string ImageUrl { get; set; }

    [JsonProperty("alt")]
    public string ImageAlt { get; set; }
}
