using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class LinkList<T>
    {
        int count;
        Node<T> head;
        Node<T> tail;

        public LinkList()
        {
            count = 0;
            head = null;
            tail = null;
        }

        public int Count()
        {
            return count;
        }

        public Node<T> Head()
        {
            return head;
        }

        public Node<T> Tail()
        {
            return tail;
        }

        public void Insert(T val)
        {
            if (count == 0)
            {
                head = new Node<T>(val);
                tail = head;
            }
            else
            {
                Node<T> walker = head;
                
                while(walker != null)
                {
                    walker = walker.Next();
                }
                walker = new Node<T>(val);
                tail = walker;
            }
            ++count;
        }
    }
}
