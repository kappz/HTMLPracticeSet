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

            Dictionary<int, int> Links = new Dictionary<int, int>();
            Node current = head;
            Node previous = head;
            while (current != null)
            {
                if (!Links.ContainsKey(current.data))
                {
                    Links.Add(current.data, current.data);
                }
                else
                {
                    previous.next = current.next;
                }
                previous = current;
                current = current.next;
                /*previous = current;
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
                current = current.next;*/
            }
        }
    }
}
