using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMaps
{
    public class HashMap<K, V>
    {
        int size;
        int capacity;
        float loadFactor;
        Node<K, V>[] buckets;

        public HashMap(int s = 16, float lf = 0.75f)
        {
            size = s;
            loadFactor = lf;
            capacity = (int)(size / loadFactor);
            buckets = new Node<K, V>[size];
        }
        public void Insert(K k, V val)
        {
            int index = Hash(k);
            if (buckets[index] == null)
            {
                buckets[index] = new Node<K, V>(k, val);
            }
            else
            {
                var walker = buckets[index];
                while (walker.next != null)
                {
                    walker = walker.next;
                }
                walker = new Node<K, V>(k, val);
            }
        }

        public V GetValue(K k)
        {
            int index = Hash(k);
            return buckets[index].Value();

        }

        public int Hash(K k)
        {
            int index = -1;
            Type keyType = typeof(K);

            if (keyType == typeof(int))
            {
                var intKey = (int)(object)k;
                index = HashFunction(intKey);
            }
            else if (keyType == typeof(char))
            {
                var intKey = Convert.ToInt32(k);
                index = HashFunction(intKey);
            }
            else // Key is of type string
            {
                var intKey = 0;
                foreach (char c in (string)(object)k)
                {
                    intKey += Convert.ToInt32(c);
                }
                index = HashFunction(intKey);
            }
            return index;
        }

        private int HashFunction(int key)
        {
            return key % size;
        }
    }
}
