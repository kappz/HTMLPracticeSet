using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeProblems.DataStructures
{
    class QueueNode<T>
    {
        public T data;
        public QueueNode<T> next;

        public QueueNode()
        {
            next = null;
        }

        public QueueNode(T d)
        {
            data = d;
            next = null;
        }
    }
    class Queue<T> 
    {
        int count;
        QueueNode<T> start;
        QueueNode<T> end;

        public Queue()
        {
            count = 0;
            start = null;
            end = null;
        }

        public Queue(T data)
        {
            count = 1;
            start = new QueueNode<T>(data);
            end = start;
        }

        public int Count()
        {
            return count;
        }

        public void Enqueue(T data)
        {
            QueueNode<T>  item = new QueueNode<T>(data);
    
            if (count == 0)
            {
                start = item;
                end = start;
            }
            else
            {
                item.next = start;
                start = item;
            }
            ++count;
        }

        public T DeQueue()
        {
            T item;
            QueueNode<T> walker;

            if (count == 0)
            {
                throw new InvalidOperationException();
            }
            item = end.data;
            walker = start;
            while (walker.next != end)
            {
                walker = walker.next;
            }
            walker.next = null;
            end = walker;
            --count;
            return item;
        }
    }
}
