using System;
using System.Collections.Generic;
using System.Text;

namespace Course03
{
    public class MyDictionary<TKey, TValue>
    {
        TKey[] _itemsKey;
        TKey[] _tempArrayKey;

        TValue[] _itemsValue;
        TValue[] _tempArrayValue;

        public int Count
        {
            get { return _itemsKey.Length + _itemsValue.Length; }
        }


        public MyDictionary()
        {
            _itemsKey = new TKey[0];
            _itemsValue = new TValue[0];
        }

        public void AddItem(TKey itemKey, TValue itemValue)
        {
            _tempArrayKey = _itemsKey;
            _tempArrayValue = _itemsValue;

            _itemsKey = new TKey[_itemsKey.Length + 1];
            _itemsValue = new TValue[_itemsValue.Length + 1];

            for (int i = 0; i < _tempArrayKey.Length; i++)
            {
                _itemsKey[i] = _tempArrayKey[i];
                for (int i2 = 0; i2 < _tempArrayValue.Length ; i2++)
                {
                    _itemsValue[i2] = _tempArrayValue[i2];
                }
            }

            _itemsKey[_itemsKey.Length - 1] = itemKey;
            _itemsValue[_itemsValue.Length - 1] = itemValue;
        }


        public void GetItems()
        {
            for (int i = 0; i < _itemsKey.Length; i++)
            {
                Console.WriteLine($"Name: {_itemsKey[i]}, Age:{_itemsValue[i]}");
            }

        }

    }
}
