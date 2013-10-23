using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ReproduceMultiScreenBug2
{
	[Activity (Label = "ReproduceBugMultiScreen", MainLauncher = true)]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			//Use UI created in Main.axml
			SetContentView (Resource.Layout.Main);

			var showSecond = FindViewById<Button> (Resource.Id.showSecond);
			showSecond.Click += (sender, e) => {
				var second = new Intent(this, typeof(SecondActivity));
				second.PutExtra("FirstData", "Data from FirstActivity");
				StartActivity(second);
			} ;
		}
		}
	}



