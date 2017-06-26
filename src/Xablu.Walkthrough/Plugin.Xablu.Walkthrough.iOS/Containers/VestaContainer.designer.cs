// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Plugin.Xablu.Walkthrough.Containers
{
    [Register ("VestaContainer")]
    partial class VestaContainer
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPageControl PageControl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton StartButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (PageControl != null) {
                PageControl.Dispose ();
                PageControl = null;
            }

            if (StartButton != null) {
                StartButton.Dispose ();
                StartButton = null;
            }
        }
    }
}