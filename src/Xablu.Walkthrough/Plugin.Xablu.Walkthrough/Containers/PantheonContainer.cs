using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public class PantheonContainer : DefaultContainer, IPantheonContainer
    {
        public virtual ButtonControl GetStartedButtonControl { get; set; }
    }
}