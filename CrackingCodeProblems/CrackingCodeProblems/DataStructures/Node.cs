using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeProblems.DataStructures
{
    public class Node
    {
        public int data;
        public Node next;

        public Node()
        {
            next = null;
        }

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
