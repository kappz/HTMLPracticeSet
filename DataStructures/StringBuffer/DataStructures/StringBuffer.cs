using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class StringBuffer
    {
        char[] buffer;
        public int length;
        public int capacity;

        public StringBuffer()
        {
            capacity = 16;
            buffer = new char[capacity];
            length = 0;
        }

        public StringBuffer(int c)
        {
            capacity = c;
            buffer = new char[capacity];
            length = 0;
        }

        // Methods to implement

        // Append
        public void append(string s)
        {
            char[] b;
            int newCapacity;

            if (length + s.Length > capacity)
            {
                if (length + s.Length >= capacity * 2)
                {
                    newCapacity = (length + s.Length) * 2;
                }
                else
                {
                    newCapacity = capacity * 2;
                }
                b = new char[newCapacity];

                for (int i = 0; i < length; i++)
                {
                    b[i] = buffer[i];
                }
                buffer = b;
                capacity = newCapacity;
            }
            for (int i = 0; i < s.Length; i++)
            {
                buffer[length + i] = s[i];
            }

            length += s.Length;
        }

        // Replace
        public void Replace(int start, int end, string s)
        {
            int iterator = 0;
            for (int i = start; i <= end; i++)
            {
                buffer[i] = s[iterator];
                ++iterator;
            }
        }
        // Delete
        public void Delete(int start, int end)
        {
            char[] b = new char[capacity];
            int offset = (end - start) + 1;
            for (int i = 0; i < length - offset; i++)
            {
                if (i >= start)
                {
                    b[i] = buffer[i + offset];
                }
                else
                {
                    b[i] = buffer[i];
                }
            }
            length -= (end - start) + 1;
            buffer = b;
        }

        // print
        public void Print()
        {
            foreach(char character in buffer)
            {
                Console.Write(character);
            }
            Console.WriteLine();
        }


    }
}
