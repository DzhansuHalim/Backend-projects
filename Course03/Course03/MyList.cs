using System;
using System.Collections.Generic;
using System.Text;

namespace Course03
{
    public class MyList<T>
    {
        T[] _items;
        T[] _tempArray;

        public  int Count
        {
            get { return _items.Length; }
        }


        public MyList()
        {
            _items = new T[0];
        }

        public void AddItem(T item)
        {
            _tempArray = _items;
            _items = new T[_items.Length+1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _items[i] = _tempArray[i];
            }

            _items[_items.Length - 1] = item;

        }


    }
}
