using System;
using Foundation;
using UIKit;
using Debug = System.Diagnostics.Debug;

namespace TrainingXamarin.iOS
{
	public partial class MyWebViewController : UIViewController
	{
		public MyWebViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			Title = "Web";
			btnGo.TouchUpInside += (sender, e) =>
			{
				
				
				WebView.LoadRequest(new NSUrlRequest(new NSUrl(@"https://www.google.com")));
			};
			UIKeyboard.Notifications.ObserveWillChangeFrame((sender, e) =>
			{

				var beginRect = e.FrameBegin;
				var endRect = e.FrameEnd;

				Debug.WriteLine($"ObserveWillChangeFrame endRect:{endRect.Height}");

				btnGoBottomConstraint.Constant = endRect.Height + 5;

			});
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


