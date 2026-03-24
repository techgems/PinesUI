using System;
using System.Collections.Generic;
using System.Text;

namespace TechGems.PinesUI.Views.Components.PinesBanner;

public class PinesBannerState
{
    public bool BannerVisible { get; set; } = false;

    public int BannerVisibleAfter { get; set; } = 1000;
}
