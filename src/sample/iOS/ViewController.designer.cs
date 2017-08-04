// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace WalkthroughSample.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton Button { get; set; }

		[Outlet]
		UIKit.UIButton ForestOvu { get; set; }

		[Outlet]
		UIKit.UIButton PantheonForest { get; set; }

		[Outlet]
		UIKit.UIButton VestaAltButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton VestaButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (VestaAltButton != null) {
				VestaAltButton.Dispose ();
				VestaAltButton = null;
			}

			if (Button != null) {
				Button.Dispose ();
				Button = null;
			}

			if (ForestOvu != null) {
				ForestOvu.Dispose ();
				ForestOvu = null;
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
