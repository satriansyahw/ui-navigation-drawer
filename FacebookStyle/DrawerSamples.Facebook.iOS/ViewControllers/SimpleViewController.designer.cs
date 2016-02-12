// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;
using UIKit;

namespace DrawerSamples.iOS
{
	[Register ("SimpleViewController")]
	partial class SimpleViewController
	{
		[Outlet]
		UIButton Button1 { get; set; }

		[Outlet]
		UITextField EditText { get; set; }

		[Outlet]
		UILabel FooterLabel { get; set; }

		[Outlet]
		UILabel GreetingLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (GreetingLabel != null) {
				GreetingLabel.Dispose ();
				GreetingLabel = null;
			}

			if (EditText != null) {
				EditText.Dispose ();
				EditText = null;
			}

			if (Button1 != null) {
				Button1.Dispose ();
				Button1 = null;
			}

			if (FooterLabel != null) {
				FooterLabel.Dispose ();
				FooterLabel = null;
			}
		}
	}
}
