// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace WalkthroughSample.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }


        [Outlet]
        UIKit.UIButton PantheonForest { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton VestaButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Button != null) {
                Button.Dispose ();
                Button = null;
            }

            if (PantheonForest != null) {
                PantheonForest.Dispose ();
                PantheonForest = null;
            }

            if (VestaButton != null) {
                VestaButton.Dispose ();
                VestaButton = null;
            }
        }
    }
}