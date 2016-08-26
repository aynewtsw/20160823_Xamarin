using System;

using UIKit;

namespace TrainingXamarin.iOS
{
	public partial class ViewController : UIViewController
	{
		//int count = 1;

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Perform any additional setup after loading the view, typically from a nib.
			//Button.AccessibilityIdentifier = "myButton";
			//Button.TouchUpInside += delegate
			//{
			//	var title = string.Format("{0} clicks!", count++);
			//	Button.SetTitle(title, UIControlState.Normal);
			//};
			//btnConfirm.TouchUpInside += (sender, e) =>
			//{
			//	Button.SetTitle("Test", UIControlState.Normal);
			//};
			btnConfirm.TouchUpInside+= BtnConfirm_TouchUpInside;
			Button.TouchUpInside += (sender, e) =>
			 {
				 //MovetoMapSegue
				 //MovetoWebSegue
				 PerformSegue("MovetoWebSegue", this);
			 };
			btnTable.TouchUpInside += (sender, e) =>
			{
				//MovetoTableSegue
				PerformSegue("MovetoTableSegue", this);
			};
		}
		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}
		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}

		void BtnConfirm_TouchUpInside(object sender, EventArgs e)
		{
			//Button.SetTitle("Test", UIControlState.Normal);
			PerformSegue("MovetoMapSegue", this);
		}
		public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
		{
			//傳值
			base.PrepareForSegue(segue, sender);

			if (segue.Identifier == "MovetoMapSegue")
			{
				if (segue.DestinationViewController is MyMapViewController)
				{
					var dest = segue.DestinationViewController as MyMapViewController;
					dest.TitleString = "Bye! Bye!";

				}
			}
		}
	}
}
