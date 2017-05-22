using System;

namespace Plugin.Walkthrough.Abstractions
{
    /// <summary>
    /// Interface for Walkthrough
    /// </summary>
    public interface IWalkthrough
    {
		void Show();
        void Next();
        void Previous();
        void Close();
    }
}
