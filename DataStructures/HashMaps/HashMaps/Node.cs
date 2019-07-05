using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMaps
{
    public class Node<K, V>
    {
        K key;
        V value;
        public Node<K, V> next;

        public Node()
        {
            next = null;
        }

        public Node(K k, V v)
        {
            key = k;
            value = v;
            next = null;
        }

        public K Key()
        {
            return key;
        }

        public V Value()
        {
            return value;
        }
    }
}
