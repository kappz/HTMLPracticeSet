using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuffer sb = new StringBuffer();
            sb.append("hello");
            sb.append(" world.");
            sb.Print();
            Console.WriteLine(sb.length);
            sb.Replace(6, 10, "Peter");
            Console.WriteLine(sb.length);
            sb.Print();
        }
    }
}
