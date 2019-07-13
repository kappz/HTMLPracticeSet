using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeProblems.DataStructures
{
    class StackNode<T>
    {
        public T data;
        public StackNode<T> next;

        public StackNode ()
        {
            next = null;
        }

        public StackNode (T d)
        {
            data = d;
            next = null;
        }
    }
    public class Stack<T>
    {
        int count;
        StackNode<T> top;

        public Stack ()
        {
            count = 0;
            top = null;
        }

        public Stack(T data)
        {
            count = 1;
            top = new StackNode<T>(data);
        }

        public void Push(T data)
        {
            StackNode<T> newTop = new StackNode<T>(data);

            newTop.next = top;
            top = newTop;
            ++count;
        }

        public T Pop()
        {
            T item;

            if (count == 0)
            {
                throw new InvalidOperationException();
            }

            item = top.data;
            top = top.next;
            --count;
            return item;
        }

        public T Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException();
            }
            return top.data;
        }

        public int Count()
        {
            return count;
        }
    }
}
