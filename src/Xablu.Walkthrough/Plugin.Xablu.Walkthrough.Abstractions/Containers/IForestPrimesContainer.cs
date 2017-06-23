using Plugin.Xablu.Walkthrough.Abstractions.Controls;

namespace Plugin.Xablu.Walkthrough.Abstractions.Containers
{
    public interface IForestPrimesContainer : IDefaultContainer
    {
        ImageButtonControl NextButtonControl { get; set; }
        ButtonControl SkipButtonControl { get; set; }
        ButtonControl StartButtonControl { get; set; }
    }
}