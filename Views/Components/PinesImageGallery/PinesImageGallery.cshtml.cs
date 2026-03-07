using System;
using System.Collections.Generic;
using System.Text;
using TechGems.StaticComponents;

namespace PinesUI.StaticComponents.Views.Components.PinesImageGallery;

public class PinesImageGallery : StaticComponent
{

    public List<GalleryItem> ImageList { get; set; } = new List<GalleryItem>();
}
