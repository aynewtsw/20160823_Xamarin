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
	[Register ("MyTableViewCell")]
	partial class MyTableViewCell
	{
		[Outlet]
		UIKit.UILabel lblDesc { get; set; }

		[Outlet]
		UIKit.UILabel lblName { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblName != null) {
				lblName.Dispose ();
				lblName = null;
			}

			if (lblDesc != null) {
				lblDesc.Dispose ();
				lblDesc = null;
			}
		}
	}
}
