using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionsMyDictionary
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] tempKeys = keys;
            V[] tempValues = values;
            keys = new K[tempKeys.Length+1];
            values = new V[tempValues.Length+1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
                
            }
            keys[tempKeys.Length] = key;
            values[tempValues.Length] = value;

        }

        public void PrintAll()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Key : {0}",keys[i] );
                Console.WriteLine("Value : {0}", values[i]);
                Console.WriteLine("--------------------------");
            }

        }
    }
}
