using Plugin.Xablu.Walkthrough.Abstractions.Controls;

namespace Plugin.Xablu.Walkthrough.Abstractions.Containers
{
    public interface IPantheonContainer : IDefaultContainer
    {
        ButtonControl GetStartedButtonControl { get; set; }
    }
}