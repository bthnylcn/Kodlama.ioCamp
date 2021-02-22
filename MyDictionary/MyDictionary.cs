using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    
        class MyDictionary<K, V>
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
                K[] tempKey = keys;
                V[] tempValue = values;

                keys = new K[keys.Length + 1];
                values = new V[values.Length + 1];

                for (int i = 0; i < tempValue.Length; i++)
                {
                    keys[i] = tempKey[i];
                    values[i] = tempValue[i];


            }
                key = keys[keys.Length - 1];
                value = values[values.Length - 1];

                 

               


            }

        }
    
}
