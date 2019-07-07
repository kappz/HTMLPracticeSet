using System;
using System.Collections.Generic;

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

        private T GetLeftChild(int parent)
        {
            return heap[GetLeftIndex(parent)];
        }

        private T GetRightChild(int parent)
        {
            return heap[GetRightIndex(parent)];
        }

        private T GetParent(int child)
        {
            return heap[GetParentIndex(child)];
        }

        private void Swap(int indexOne, int indexTwo)
        {
            T temp = heap[indexOne];
            heap[indexOne] = heap[indexTwo];
            heap[indexTwo] = temp;
        }

        private void ExpandCapacity()
        {
            T[] arr;

            if (size == capacity)
            {
                arr = new T[capacity * 2];
                for (int i = 0; i < size; i++)
                {
                    arr[i] = heap[i];
                }
                heap = arr;
                capacity *= 2;
            }
        }

        public T Peek()
        {
            if (size == 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return heap[0];
            }
        }

        public T Remove()
        {
            T element;

            if (size == 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                element = heap[0];
                heap[0] = heap[size - 1];
                --size;
                HeapifyDown();
                return element;
            }
        }

        public void add(T element)
        {
            ExpandCapacity();
            heap[size] = element;
            ++size;
            HeapifyUp();
        }

        public void HeapifyUp()
        {
            int index = size - 1;
            while (HasParent(index) && isGreaterThan(GetParent(index), heap[index]))
            {
                Swap(GetParentIndex(index), index);
                index = GetParentIndex(index);
            }
        }

        public void HeapifyDown()
        {
            int index = 0;
            int smallerIndex;
            while(HasLeftChild(index))
            {
                smallerIndex = GetLeftIndex(index);
                if (HasRightChild(index) && !(isGreaterThan(GetRightChild(index), GetLeftChild(index))))
                {
                    smallerIndex = GetRightIndex(index);
                }

                if (!isGreaterThan(heap[index], heap[smallerIndex]))
                {
                    break;
                }
                else
                {
                    Swap(index, smallerIndex);
                }
                index = smallerIndex;
            }
        }
        private bool isGreaterThan(T value, T other)
        {
            var valueType = value.GetType();

            if (valueType == typeof(int))
            {
                int valueChar = (int)(object)value;
                int otherChar = (int)(object)value;
                return valueChar > otherChar;
            }
            if (valueType == typeof(char))
            {
                int valueInt = (int)(object)value;
                int otherInt = (int)(object)value;
                return valueInt > otherInt;
            }
            return false;
        }
    }
}
