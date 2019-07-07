using System;

namespace Heap
{
    public class Heap<T>
    {
        int size;
        int capacity;
        T[] heap;

        public Heap()
        {
            capacity = 10;
            size = 0;
            heap = new T[capacity];
        }

        public Heap(int cap)
        {
            size = 0;
            capacity = cap;
            heap = new T[capacity];
        }

        public int GetLeftIndex(int parent)
        {
            return (parent * 2) + 1;
        }

        public int GetRightIndex(int parent)
        {
            return (parent * 2) + 2;
        }

        public int GetParentIndex(int child)
        {
            return (child - 2 / 2);
        }

        private bool HasLeftChild(int element)
        {
            if (GetLeftIndex(element) < size )
            {
                return true;
            }
            return false;
        }

        private bool HasRightChild(int element)
        {
            if (GetRightIndex(element) < size)
            {
                return true;
            }
            return false;
        }

        private bool HasParent(int element)
        {
            if (GetParentIndex(element) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T GetLeftChild(int parent)
        {
            return heap[GetLeftIndex(parent)];
        }

        public T GetRightChild(int parent)
        {
            return heap[GetRightIndex(parent)];
        }

        public T GetParent(int child)
        {
            return heap[GetParentIndex(child)];
        }
    }
}
