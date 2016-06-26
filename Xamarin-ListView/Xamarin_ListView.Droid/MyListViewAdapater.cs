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
    class MyListViewAdapater : BaseAdapter<string>
    {

        private List<string> mItems;
        private Context mContext;

        public MyListViewAdapater(Context context, List<String> items)
        {
            this.mItems = items;
            this.mContext = context;
        }

        public override string this[int position]
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

            TextView txtName = row.FindViewById<TextView>(Resource.Id.txtName);
            txtName.Text = mItems[position];

            return row;
        }
    }
}