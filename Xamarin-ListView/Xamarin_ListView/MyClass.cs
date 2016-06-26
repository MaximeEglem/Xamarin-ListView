using System;
using System.Collections.Generic;

namespace Xamarin_ListView
{
    public class MyClass
    {

        public List<Person> getList()
        {
            List<Person>  mItems = new List<Person>();

            mItems.Add(new Person() { firstName = "Maxime", lastName = "E", age = "27", gender = "male" });
            mItems.Add(new Person() { firstName = "Alex", lastName = "B", age = "25", gender = "male" });
            mItems.Add(new Person() { firstName = "Lola", lastName = "Anderson", age = "23", gender = "female" });
            mItems.Add(new Person() { firstName = "Julie", lastName = "Judo", age = "28", gender = "female" });

            return mItems;
        }
    }
}

