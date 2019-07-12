using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingCodeProblems.DataStructures;

namespace CrackingCodeProblems.Solutions
{
    class LinkListProblems
    {

        public void RemoveDuplicates(Node head)
        {
            Node current = head;
            Node previous;
            Node walker;
            while (current != null)
            {
                previous = current;
                walker = current.next;
                while (walker != null)
                {
                    if (walker.data == current.data)
                    {
                        previous.next = walker.next;
                    }
                    previous = walker;
                    walker = walker.next;
                }
                current = current.next;
            }
        }
    }
}
