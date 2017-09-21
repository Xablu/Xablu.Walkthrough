using System;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;

namespace Plugin.Xablu.Walkthrough.Abstractions.Containers
{
    public interface IVestaContainer : IPantheonContainer
    {
        ButtonControl PreviousButtonControl { get; set; }
        ButtonControl NextButtonControl { get; set; }
        ButtonControl FirstPagePreviousButtonControl { get; set; }
        ButtonControl LastPageNextButtonControl { get; set; }
    }
}
