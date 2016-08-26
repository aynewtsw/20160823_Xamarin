using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace TrainingXamarin.Droid
{
	[Activity(Label = "Training Xamarin", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.main_menuview);

			// Get our button from the layout resource,
			// and attach an event to it
			Button btnMap = FindViewById<Button>(Resource.Id.main_menuview_btnMap);

			btnMap.Click += (sender, e) =>
			{
				StartActivity(typeof(MyMapActivity));
			};

			Button btnWeb = FindViewById<Button>(Resource.Id.main_menuview_btnWeb);
			btnWeb.Click += (sender, e) =>
			 {
				 Intent webActivity = new Intent(this, typeof(MyWebActivity));
				 //webActivity.PutExtra("url", "https://www.google.com.tw");
				 StartActivity(webActivity);
			};
		}
	}
}


