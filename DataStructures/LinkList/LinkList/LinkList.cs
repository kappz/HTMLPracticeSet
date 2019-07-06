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

        public void AddEnd(T val)
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
                    walker = walker.next;
                }
                walker = new Node<T>(val);
                tail = walker;
            }
            ++count;
        }

        public void AddBegin(T val)
        {
            var node = new Node<T>(val);
            node.next = head;
            head = node;
            ++count;
        }

        public void AddBefore(T valueToFind, T val)
        {
            Node<T> current;
            Node<T> previous;
            Node<T> node = new Node<T>(val);

            if (EqualityComparer<T>.Default.Equals(head.Value(), valueToFind))
            {
                node.next = head;
                head = node;
            }
            else
            {
                previous = head;
                current = head.next;
                while (!EqualityComparer<T>.Default.Equals(current.Value(), valueToFind))
                {
                    previous = current;
                    current = current.next;
                }
                node.next = current;
                previous.next = node;
            }
            ++count;
        }
    }
}
