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

namespace Xamarin_ListView.Droid
{
    class MyListViewAdapater : BaseAdapter<Person>
    {

        private List<Person> mItems;
        private Context mContext;

        public MyListViewAdapater(Context context, List<Person> items)
        {
            this.mItems = items;
            this.mContext = context;
        }

        public override Person this[int position]
        {
            get
            {return mItems[position];}
        }

        public override int Count
        {
            get
            { return mItems.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if(row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.ListView_row, null, false);
            }

            TextView txtFirstName = row.FindViewById<TextView>(Resource.Id.txtFirstName);
            txtFirstName.Text = mItems[position].firstName;
            TextView txtLastName = row.FindViewById<TextView>(Resource.Id.txtLastName);
            txtLastName.Text = mItems[position].lastName;
            TextView txtAge = row.FindViewById<TextView>(Resource.Id.txtAge);
            txtAge.Text = mItems[position].age;
            TextView txtGender = row.FindViewById<TextView>(Resource.Id.txtGender);
            txtGender.Text = mItems[position].gender;

            return row;
        }
    }
}