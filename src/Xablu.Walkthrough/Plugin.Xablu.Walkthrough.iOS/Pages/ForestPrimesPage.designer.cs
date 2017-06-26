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
    [Register ("ForestPrimesPage")]
    partial class ForestPrimesPage
    {
        [Outlet]
        UIKit.UIImageView CenterImage { get; set; }

        [Outlet]
        UIKit.UILabel Description { get; set; }

        [Outlet]
        UIKit.UILabel Title { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CenterImage != null) {
                CenterImage.Dispose ();
                CenterImage = null;
            }

            if (Description != null) {
                Description.Dispose ();
                Description = null;
            }

            if (Title != null) {
                Title.Dispose ();
                Title = null;
            }
        }
    }
}