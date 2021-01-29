using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T, E>

    {
        T[] _arrValue;
        E[] _arrNumber;

        public MyDictionary()
        {
            _arrValue = new T[0];
            _arrNumber = new E[0];
        }

        public void Add(T item1, E item2)
        {
            T[] _tempValue = _arrValue;
            E[] _tempNumber = _arrNumber;

            _arrValue = new T[_arrValue.Length + 1];
            _arrNumber = new E[_arrNumber.Length + 1];

            for (int i = 0; i < _tempValue.Length; i++)
            {
                _arrValue[i] = _tempValue[i];
                _arrValue[_arrValue.Length - 1] = item1;
            }

            for (int i = 0; i < _tempNumber.Length; i++)
            {
                _arrNumber[i] = _tempNumber[i];
                _arrNumber[_arrNumber.Length - 1] = item2;
            }
            Console.WriteLine("|" + item1 + "|" + " Şehrinin Plakası" + " " + "--->" + " " + "|" + item2 + "|");
        }
    }
}