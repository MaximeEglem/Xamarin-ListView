using System;
using System.Collections.Generic;

namespace Xamarin_ListView
{
    public class MyClass
    {
        public MyClass(){}

        public List<string> getList()
        {
            List<string>  mItems = new List<string>();
            mItems.Add("Maxime");
            mItems.Add("Alex");
            mItems.Add("Bob");

            return mItems;
        }
    }
}

