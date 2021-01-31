using System;
using System.Collections.Generic;

namespace Genericsİntro2222
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            
            // sehirler array'inin eleman saysı demek "count"...
            sehirler.Add("Balıkesir");
            sehirler.Add("Balıkesir");
            sehirler.Add("Balıkesir");
            sehirler.Add("Balıkesir");
            sehirler.Add("Balıkesir");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            // şimdiki MyList yukarıda ki List koduna benedi...
            
            sehirler2.Add("Kütahya");
            sehirler2.Add("Kütahya");
            sehirler2.Add("Kütahya");
            sehirler2.Add("Kütahya");
            sehirler2.Add("Kütahya");
            sehirler2.Add("Kütahya");
            sehirler2.Add("Kütahya");

            Console.WriteLine(sehirler2.Count);

            // Yukarıda ki iki ""Console" u ""şehirler.Add"" eklerinin altına yazarsak ilk "şehirler" class'ına Balıkesir--
            // eklendiğinden dolayı ""count'u"" 1 olacaktır yani bir eleman eklenmiştir.

            //Ancak ""şehirler2"" class'ında  0 çıkacaktır bunun sebebi bu class'ın aşağıda ""publik void Add"" kısmındaki--
            //eleman ekleme kısmında sıkıntı var.----  O zaman ne yaparız şimdi ""Public Void Add"" kısmına giderek yeni
            // "_array" new'liyoruz...


            //Yukarıda ki iki kodda aynı ancak, biri class oluşturularak yapılıyor, biri class oluşturulmadan yapılıyor...

        }
    }
    class MyList<T>
    //  yukarıdaki T yerine ne istersen yazabilirsin ancak T harfi "Type"  dan gelir...
    // Ve bu demek oluyor ki ben bir ""GENERİC CLASS" oluşturdum...
    {
        // tempArray == Geçici demek 
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
            // Burada da "0" elemanlı herhangibir tipte olan "_array" oluşturmak...
        }

        
        public void Add(T item)
        {
            // burada T item demek  oluyor ki ;; Ben yukarıda ki ""şehirler2"" classında ne Tip bir veri tipi verirsem-- 
            //onu bana çalıştır demek oluyor yani  """MyList<string.. vb.> şehirler2 = new MyList<string.. vb.>();"""...

            _tempArray = _array; // burada array'in new lemeden önce ki datasını geçici olarak kopyalamış olduk..
            _array = new T[_array.Length + 1];

            // bu şekilde new'lemiş olduk...eleman sayısını 1 artrmış olduk ancakbu şekilde
            // tüm data gitmiş olacak yeni bir array oluşturuldugundan yeni bir referans oluşturulmuş oluyor..
            // ve şimdi ise tempArray de ki verileri yeni dataya aktarması için kopyalanan datayı dönmesi gerekecek...

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            // ve şimdi _array'ye eleman ekleyeceğiz..

            _array[_array.Length - 1] = item; // array in son elemanı sizin gönderdiğiniz item olacaktır oluyor... 





            // data nın kaybolmaması için önceki datayı geçici olarak hafızaya almak gerekiyor, bunun içinde ""tempArray' den"" 
            //yararlanıyoruz..


        }

        public int Count
        {
            get { return _array.Length; }

            // burada propfull yapmamızın sebebi get ettirip MyList'te verilen _arry'in uzunlugunu görmek maksat...
        }

    }
}
