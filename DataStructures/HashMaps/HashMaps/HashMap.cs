using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMaps
{
    public class HashMap<K, V>
    {
        int numElements;
        int size;
        int capacity;
        float loadFactor;
        Node<K, V>[] buckets;

        public HashMap(int s = 16, float lf = 0.75f)
        {
            size = s;
            numElements = 0;
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
                walker.next = new Node<K, V>(k, val);
            }
            ++numElements;
        }

        public Node<K, V> Get(K k)
        {
            int index = Hash(k);
            return buckets[index];

        }

        public bool Exists(V val)
        {
            Node<K, V> walker;

            foreach(Node<K, V> node in buckets)
            {
                if (node != null)
                {
                    if (EqualityComparer<V>.Default.Equals(node.Value(), val))
                    {
                        return true;
                    }
                    else
                    {
                        walker = node.next;
                        while (walker != null)
                        {
                            if (EqualityComparer<V>.Default.Equals(walker.Value(), val))
                            {
                                return true;
                            }
                            walker = walker.next;
                        }
                    }
                }
            }
            return false;
        }

        public int Size()
        {
            return numElements;
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

        public bool DeleteKeyValue(K k, V v)
        {
            int index = Hash(k);
            Node<K, V> current;
            Node<K, V> previous;
            Node<K, V> next;

            current = buckets[index];

            if (current == null)
            {
                return false;
            }
            else if (EqualityComparer<V>.Default.Equals(current.Value(), v))
            {
                buckets[index] = current.next;
                return true;
            }
            else
            {
                previous = current;
                current = current.next;
                next = current.next;
                while (current != null)
                {
                    if (EqualityComparer<V>.Default.Equals(current.Value(), v))
                    {
                        current = null;
                        previous.next = next;
                        return true;
                    }
                    previous = current;
                    current = current.next;
                    next = current.next;
                }
            }
            return false;
        }

        public void Print()
        {
            Node<K, V> walker;
            
            foreach (Node<K, V> element in buckets)
            {
                if (element != null)
                {
                    walker = element;
                    while (walker != null)
                    {
                        Console.Write(walker.Value());
                        Console.Write("   ");
                        walker = walker.next;
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        private int HashFunction(int key)
        {
            return key % size;
        }
    }
}
