using Plugin.Walkthrough.Abstractions;
using System;

namespace Plugin.Walkthrough
{
    /// <summary>
    /// Cross platform Walkthrough implemenations
    /// </summary>
    public class CrossWalkthrough
    {
        static Lazy<IWalkthrough> Implementation = new Lazy<IWalkthrough>(() => CreateWalkthrough(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Current settings to use
        /// </summary>
        public static IWalkthrough Current
        {
            get
            {
                var ret = Implementation.Value;
                if (ret == null)
                {
                    throw NotImplementedInReferenceAssembly();
                }
                return ret;
            }
        }

        static IWalkthrough CreateWalkthrough()
        {
#if PORTABLE
            return null;
#else
            return new WalkthroughImplementation();
#endif
        }

        internal static Exception NotImplementedInReferenceAssembly()
        {
            return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
        }
    }
}
