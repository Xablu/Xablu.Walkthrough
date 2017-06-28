// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Plugin.Xablu.Walkthrough.Pages
{
    [Register ("OvuPage")]
    partial class OvuPage
    {
        [Outlet]
        UIKit.UILabel Description { get; set; }

        [Outlet]
        UIKit.UIImageView Image { get; set; }

        [Outlet]
        UIKit.UILabel Title { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Description != null) {
                Description.Dispose ();
                Description = null;
            }

            if (Image != null) {
                Image.Dispose ();
                Image = null;
            }

            if (Title != null) {
                Title.Dispose ();
                Title = null;
            }
        }
    }
}