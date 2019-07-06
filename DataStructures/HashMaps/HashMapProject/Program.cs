using System;
using HashMaps;

namespace HashMapProject
{
    class Program
    {
        static void Main(string[] args)
        {

            HashMap<char, string> map = new HashMap<char, string>();

            map.Insert('z', "Harry Potter");
            map.Insert('z', "Lord Voldemort");
            map.Insert('z', "Professor Dumbledore");
            map.Insert('b', "Harry Potter");
            map.Insert('b', "Lord Voldemort");
            map.Insert('b', "Professor Dumbledore");
            map.Insert('c', "Harry Potter");
            map.Insert('c', "Lord Voldemort");
            map.Insert('c', "Professor Dumbledore");

            map.Print();

            map.DeleteKeyValue('z', "Harry Potter");
            map.Print();

            map.DeleteKeyValue('b', "Professor Dumbledore");
            map.Print();

            map.DeleteKeyValue('c', "Lord Voldemort");
            map.Print();

        }
    }
}
