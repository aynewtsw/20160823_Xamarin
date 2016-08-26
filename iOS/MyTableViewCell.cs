using System;

using Foundation;
using UIKit;

namespace TrainingXamarin.iOS
{
	public partial class MyTableViewCell : UITableViewCell
	{

		protected MyTableViewCell(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public void UpdaeUI(Todo todo)
		{
			lblName.Text = todo.Name;
			lblDesc.Text = todo.Desc;
		}
	}
}
