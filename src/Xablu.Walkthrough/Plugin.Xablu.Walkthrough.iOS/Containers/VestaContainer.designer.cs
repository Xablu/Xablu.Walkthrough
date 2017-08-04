// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Plugin.Xablu.Walkthrough.Containers
{
    [Register("VestaContainer")]
    partial class VestaContainer
    {
        [Outlet]
        UIKit.UIButton NextButton { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UIPageControl PageControl { get; set; }

        [Outlet]
        UIKit.UIButton PreviousButton { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UIButton StartButton { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (NextButton != null)
            {
                NextButton.Dispose();
                NextButton = null;
            }

            if (PreviousButton != null)
            {
                PreviousButton.Dispose();
                PreviousButton = null;
            }

            if (PageControl != null)
            {
                PageControl.Dispose();
                PageControl = null;
            }

            if (StartButton != null)
            {
                StartButton.Dispose();
                StartButton = null;
            }
        }
    }
}
