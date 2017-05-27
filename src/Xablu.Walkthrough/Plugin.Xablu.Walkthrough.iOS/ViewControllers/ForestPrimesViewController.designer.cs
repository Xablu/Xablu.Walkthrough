// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Plugin.Xablu.Walkthrough.ViewControllers
{
    [Register("ForestPrimesViewController")]
    partial class ForestPrimesViewController
    {
        [Outlet]
        UIKit.UILabel lblTitle { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (lblTitle != null)
            {
                lblTitle.Dispose();
                lblTitle = null;
            }
        }
    }
}
