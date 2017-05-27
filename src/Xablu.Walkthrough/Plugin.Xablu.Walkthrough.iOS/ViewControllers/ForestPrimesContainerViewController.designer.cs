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
    [Register("ForestPrimesContainerViewController")]
    partial class ForestPrimesContainerViewController
    {
        [Outlet]
        UIKit.UIButton btnNext { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (btnNext != null)
            {
                btnNext.Dispose();
                btnNext = null;
            }
        }
    }
}
