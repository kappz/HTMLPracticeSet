using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class Node<T>
    {
        T value;
        public Node<T> next;

        public Node()
        {
            next = null;
        }

        public Node(T val)
        {
            value = val;
            next = null;
        }

        public T Value()
        {
            return value;
        }
    }
}
