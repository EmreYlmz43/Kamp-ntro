using System;
using System.Collections.Generic;
using System.Text;

namespace Genericsİntro
{
    class MyList<T>
    {
        T[] items;
        // constructor "class" ı newlersen aşağıdaki ctor çalışıyor.
        public MyList()
        {
            items = new T[0];
            // 0 elemanlı  bir array oluşturmuş olduk.
        }
        public void Add(T İtem) 
            // İtem yerine ne verirsen olur.
        {
            //tempArray elemanın kaybetmemek için önceki referans numarasını tutar geçicidir.
            T[] tempArray = items;
            items = new T[items.Length + 1];
            // yeni referans numarası elemanların kaybolmasına sebep olur.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = İtem;
        }
    }
}
