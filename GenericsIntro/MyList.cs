using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempeArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempeArray.Length; i++)
            {
                items[i] = tempeArray[i];
            }


            items[items.Length - 1] = item;
        }
    }
}
