using System;

namespace _4Gün5Ödev
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, string> song = new MyDictionary<string, string>();
            song.Add("Velet", "Salına salına");
            song.Add("Uzi", "Makina");
            song.Add("Ramiz", "Rest");
            song.Add("Ados", "Yıkılır");
            song.Add("Ados", "Eylül");
            song.Add("Contra", "Islak Kum");

            Console.WriteLine("Şarkıcı :" + song.Count);

            for (int i = 0; i < song.Count; i++)
            {
                Console.WriteLine(song.Keys[i] + "-" + song.Value[i]);
            }
            Console.ReadLine();
        }
    }
    class MyDictionary<K,V>
    {
        //class MyDictionary --- public MyDictionary --- public void Add (içinde) for --- public int count ---
        //public K[] Keys ---- public V[] Values

        K [] _keys;
        V [] _values;

        public MyDictionary()
        {
        _keys = new K[0];
        _values = new V[0];
        }

        public void Add(K keys, V values)
        {
            _tempArray 


            _keys = new K[_keys.Length + 1];
            _values = new V[_values.Length + 1];

            for (int i = 0; i < _keys.Length; i++)
            {
                _keys[i] = 
            }


        }
           



        public int Count
        {
        get { return _keys.Length; }

        }

         public K[] Keys
         {
         get { return _keys; }
         }

        public V[] Value
        {
        get { return _values; }
        }

        
    }   
}
