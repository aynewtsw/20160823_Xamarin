
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Debug = System.Diagnostics.Debug;

namespace TrainingXamarin.Droid
{
	[Activity(Label = "MyListActivity")]
	public class MyListActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.table_mylistview);
			showTable();

			// Create your application here
		}

		private void showTable()
		{
			var list = new List<Todo>();
			list.Add(new Todo { Name = "Android", Desc = "aaa!!!" });
			list.Add(new Todo { Name = "B", Desc = "bbb" });
			list.Add(new Todo { Name = "C", Desc = "ccc" });
			list.Add(new Todo { Name = "D", Desc = "ddd" });
			list.Add(new Todo { Name = "E", Desc = "eee" });
			list.Add(new Todo { Name = "F", Desc = "fff" });

			var listview = FindViewById<ListView>(Resource.Id.table_mylistview_listview);


			listview.Adapter = new TodoAdapter(list, this);

			listview.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) =>
			{

				var selectedTodo = list[e.Position];

				Debug.WriteLine($"Name:{ selectedTodo.Name }; Description:{ selectedTodo.Desc }");

			};
		}
		class TodoAdapter : BaseAdapter<Todo>
		{
			private List<Todo> Todos { get; set; }
			private Activity Context { get; set; }

			public TodoAdapter(IEnumerable<Todo> source, Activity context)
			{
				Todos = new List<Todo>();
				Todos.AddRange(source);
				Context = context;

			}

			public override long GetItemId(int position)
			{
				return position;

			}
			public override Todo this[int position] => Todos[position];

			public override int Count => Todos.Count;
			public override View GetView(int position, View convertView, ViewGroup parent)
			{
				var view = convertView;
				if (view == null)
				{
					view = this.Context.LayoutInflater.Inflate(Resource.Layout.table_mylistview_itemview, parent, false);
				}
				var todo = Todos[position];
				view.FindViewById<TextView>(Resource.Id.table_mylistview_itemview_lblDesc).Text=todo.Name;
				view.FindViewById<TextView>(Resource.Id.table_mylistview_itemview_lblName).Text=todo.Desc;
				return view;

			}
		}
	}
}

