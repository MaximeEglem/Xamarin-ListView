using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Xamarin_ListView.Droid
{
	[Activity (Label = "Xamarin_ListView.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

        private List<Person> mItems;
        private ListView mListView;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

            MyClass test = new MyClass();
            mItems = test.getList();

			SetContentView (Resource.Layout.Main);
            mListView = FindViewById<ListView>(Resource.Id.myListView);

            MyListViewAdapater adapter = new MyListViewAdapater(this, mItems);

            mListView.Adapter = adapter;
            
        }
	}
}


