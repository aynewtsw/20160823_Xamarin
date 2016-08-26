using System;
using System.Linq;
using UIKit;
using System.Collections.Generic;
using Debug = System.Diagnostics.Debug;

namespace TrainingXamarin.iOS
{
	public partial class MyTableViewController : UIViewController
	{
		public MyTableViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			showTable();
		}

		private void showTable()
		{
			var list = new List<Todo>();
			list.Add(new Todo { Name = "A", Desc = "aaa" });
			list.Add(new Todo { Name = "B", Desc = "bbb" });
			list.Add(new Todo { Name = "C", Desc = "ccc" });
			list.Add(new Todo { Name = "D", Desc = "ddd" });
			list.Add(new Todo { Name = "E", Desc = "eee" });
			list.Add(new Todo { Name = "F", Desc = "fff" });

			var todoSource = new TodoSource(list);
			myTablev.Source = todoSource;
			todoSource.TodoSelected += (object sender, TodoSource.TodoSelectedEventArgs e) =>
			 {
				Debug.WriteLine($"Name:{e.SelectedTodo.Name},Desc;{e.SelectedTodo.Desc}");
			 };
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		class TodoSource : UITableViewSource
		{
			private List<Todo> Todos { get; set; }

			public event EventHandler<TodoSelectedEventArgs> TodoSelected;

			const string MyTableViewCellIdentifier = "MyTableViewCell";

			public TodoSource(IEnumerable<Todo> source)
			{
				Todos = new List<Todo>();
				Todos.AddRange(source);

			}

			public override nint RowsInSection(UITableView tableview, nint section)
			{
				return Todos.Count;
			}
			public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
			{
				MyTableViewCell cell = tableView.DequeueReusableCell(MyTableViewCellIdentifier) as MyTableViewCell;

				var todo = Todos[indexPath.Row];
				cell.UpdaeUI(todo);

				return cell;
			}
			public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
			{
				
				tableView.DeselectRow(indexPath, true);

				var todo = Todos[indexPath.Row];

				EventHandler<TodoSelectedEventArgs> handle = TodoSelected;
				if (handle != null)
				{
					handle(this, new TodoSelectedEventArgs { SelectedTodo = todo });
				}
			}
			public class TodoSelectedEventArgs : EventArgs
			{
				public Todo SelectedTodo { get; set; }
			}
		}
	}
}


