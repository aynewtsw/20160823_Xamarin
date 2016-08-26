// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TrainingXamarin.iOS
{
	[Register ("MyWebViewController")]
	partial class MyWebViewController
	{
		[Outlet]
		UIKit.UIButton btnGo { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint btnGoBottomConstraint { get; set; }

		[Outlet]
		UIKit.UITextField TextView { get; set; }

		[Outlet]
		UIKit.UIWebView WebView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnGoBottomConstraint != null) {
				btnGoBottomConstraint.Dispose ();
				btnGoBottomConstraint = null;
			}

			if (btnGo != null) {
				btnGo.Dispose ();
				btnGo = null;
			}

			if (TextView != null) {
				TextView.Dispose ();
				TextView = null;
			}

			if (WebView != null) {
				WebView.Dispose ();
				WebView = null;
			}
		}
	}
}
