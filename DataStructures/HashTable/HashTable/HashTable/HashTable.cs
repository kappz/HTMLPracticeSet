using System;

namespace HashTableProject
{
    public class HashTable
    {
        private int size;
        private int[] table;

        public HashTable(int s = 0)
        {
            size = s;
            table = new int[size];

            for (int i = 0; i < size - 1; i++)
            {
                table[i] = -1;
            }
        }

        public int GetSize()
        {
            return size;
        }

        public int get(int key)
        {
            return table[key];
        }
    }
}
