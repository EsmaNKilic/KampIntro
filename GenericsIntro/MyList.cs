using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items; //bunu metodun dışında yazdık çünkü direk class içinde yani her türlü erişirsin.
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) //item - eleman, T de string gibi tür
        {
            T[] tempArray = items; //geçici dizi
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
