using System;
using System.Collections.Generic;
using System.Text;

namespace PinesUI.StaticComponents.Views.Components.PinesRadioGroup;

public class PinesRadioElement<T>
{
    public string Title { get; set; }

    public string Description { get; set; }

    public T Value { get; set; }
}
