using Plugin.Xablu.Walkthrough.Abstractions.Containers;
using Plugin.Xablu.Walkthrough.Abstractions.Controls;

namespace Plugin.Xablu.Walkthrough.Containers
{
    public class VestaContainer : PantheonContainer, IVestaContainer
    {
        public virtual ButtonControl PreviousButtonControl { get; set; }
        public virtual ButtonControl NextButtonControl { get; set; }
		public virtual ButtonControl FirstPagePreviousButtonControl { get; set; }
		public virtual ButtonControl LastPageNextButtonControl { get; set; }
	}
}