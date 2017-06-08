using System;
using System.Threading;
using Plugin.Xablu.Walkthrough.Abstractions;

namespace Plugin.Xablu.Walkthrough
{
    public class CrossWalkthoughFactory : IWalkthroughFactory
    {
        private readonly Lazy<IWalkthrough> _walkthrough;

        public CrossWalkthoughFactory()
        {
            _walkthrough = new Lazy<IWalkthrough>(() => CreateWalkthrough(), LazyThreadSafetyMode.PublicationOnly);
        }

        public IWalkthrough Create()
        {
            if (!_walkthrough.IsValueCreated)
                throw CrossWalkthrough.NotImplementedInReferenceAssembly();

            return _walkthrough.Value;
        }

        private IWalkthrough CreateWalkthrough()
        {
#if PORTABLE
            return null;
#else
            return new WalkthroughImplementation();
#endif
        }
    }
}
