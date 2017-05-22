using Plugin.Walkthrough.Abstractions;
using UIKit;
using BWWalkthrough;

namespace Plugin.Xablu.Walkthrough
{
    /// <summary>
    /// Implementation for Walkthrough
    /// </summary>
    public class WalkthroughImplementation : IWalkthrough
    {
        private UIStoryboard _storyBoard;
        private BWWalkthroughViewController _walkthrough;
        private string[] _idsViews;
        private UIViewController _hostViewController;

        public void Init(UIStoryboard storyBoard, string[] idsViews, UIViewController hostViewController)
        {
            _storyBoard = storyBoard;
            _idsViews = idsViews;
            _hostViewController = hostViewController;
            _walkthrough = _storyBoard.InstantiateViewController(idsViews[0]) as BWWalkthroughViewController;

            for (int i = 1; i < idsViews.Length; i++)
            {
                var vc = _storyBoard.InstantiateViewController(idsViews[i]);
                _walkthrough.AddViewController(vc);
            }
        }

        public void Show()
        {
            _hostViewController.PresentViewController(_walkthrough, true, null);
        }

        public void Next()
        {
            _walkthrough.NextPage();
        }

        public void Previous()
        {
            _walkthrough.PreviousPage();
        }

        public void Close()
        {
            _walkthrough.Close();
        }
    }
}