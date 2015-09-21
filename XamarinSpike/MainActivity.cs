using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace XamarinSpike
{
	[Activity (Label = "XamarinSpike", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity, GestureDetector.IOnGestureListener
	{
		private GestureDetector _gestureDetector;
		private WebView view;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			view = FindViewById<WebView> (Resource.Id.mainWebView);
			view.LoadUrl ("http://www.google.com");
			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			button.Click += delegate {


			};
		}

		public bool OnDown(MotionEvent e)
		{
			view.LoadUrl ("http://www.agilysys.com");
			return true;
		}
		public bool OnFling(MotionEvent e1, MotionEvent e2, float velocityX, float velocityY)
		{
			return false;
		}
		public void OnLongPress(MotionEvent e) {}
		public bool OnScroll(MotionEvent e1, MotionEvent e2, float distanceX, float distanceY)
		{
			return false;
		}
		public void OnShowPress(MotionEvent e) {}
		public bool OnSingleTapUp(MotionEvent e)
		{
			return false;
		}
	}
}


