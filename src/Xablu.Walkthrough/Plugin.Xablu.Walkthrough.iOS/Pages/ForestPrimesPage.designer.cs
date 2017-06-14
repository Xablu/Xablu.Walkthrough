// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Plugin.Xablu.Walkthrough.Pages
{
    [Register("ForestPrimesPage")]
    partial class ForestPrimesPage
    {
        [Outlet]
        UIKit.UIImageView CenterImage { get; set; }

        [Outlet]
        UIKit.UILabel Description { get; set; }

        [Outlet]
        UIKit.UILabel Title { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (CenterImage != null)
            {
                CenterImage.Dispose();
                CenterImage = null;
            }

            if (Description != null)
            {
                Description.Dispose();
                Description = null;
            }

            if (Title != null)
            {
                Title.Dispose();
                Title = null;
            }
        }
    }
}
