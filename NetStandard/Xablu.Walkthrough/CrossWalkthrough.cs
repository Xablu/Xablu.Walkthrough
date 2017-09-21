using Plugin.Xablu.Walkthrough.Abstractions;
using System;
using System.Diagnostics;

namespace Plugin.Xablu.Walkthrough
{
    /// <summary>
    /// Cross platform Walkthrough implemenations
    /// </summary>
    public class CrossWalkthrough
    {
        static Lazy<IWalkthrough> implementation = new Lazy<IWalkthrough>(() => CreateWalkthrough(), System.Threading.LazyThreadSafetyMode.PublicationOnly);
        /// <summary>
        /// Gets if the plugin is supported on the current platform.
        /// </summary>
        public static bool IsSupported => implementation.Value == null ? false : true;

        /// <summary>
        /// Current plugin implementation to use
        /// </summary>
        public static IWalkthrough Current
        {
            get
            {
                var ret = implementation.Value;
                if (ret == null)
                {
                    throw NotImplementedInReferenceAssembly();
                }
                return ret;
            }
        }

        static IWalkthrough CreateWalkthrough()
        {
#if NETSTANDARD_20
            return null;
#else
            return new WalkthroughImplementation();
#endif
        }

        internal static Exception NotImplementedInReferenceAssembly() =>
			new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
        
    }
}
