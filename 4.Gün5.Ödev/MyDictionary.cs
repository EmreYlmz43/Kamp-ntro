using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Gün5.Ödev
{
    class MyDictionary<K,V>
    {
        //class MyDictionary --- public MyDictionary --- public void Add (içinde) for --- public int count ---
        //public K[] Keys ---- public V[] Values

        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add (K keys, V values)
        {
            K[] _tempKeys = keys;
            V[] _tempValues = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                keys[i] = _tempKeys[i];
                values[i] = _tempValues[i];
            }

            keys[keys.Length - 1] = keys;
            values[values.Length - 1] = values;

        
        public int Count
        {
            get { return keys.Length; }
            
        }
       
        public K[] Keys
        {
            get { return keys; }
        }
              
        public V[] Value
        {
            get { return values; }            
        }





    }


    
    
}
