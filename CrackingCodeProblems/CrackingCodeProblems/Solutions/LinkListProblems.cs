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
            }
        }

        public Node ReturnKthNode(Node head, int k)
        {
            int counter = -1;
            Node kthNode = new Node();
            ReturnKthNodeRecursion(head, ref kthNode, k, ref counter);
            return kthNode;
        }

        private void ReturnKthNodeRecursion(Node currentNode, ref Node kthNode, int k, ref int counter)
        {
            if (currentNode.next == null)
            {
                counter = 0;
                if (counter == k)
                {
                    kthNode = currentNode;
                }
                counter++;
                return;
            }
            ReturnKthNodeRecursion(currentNode.next, ref kthNode, k, ref counter);
            if (counter == k)
            {
                kthNode = currentNode;
            }
            ++counter;
            return;
        }
    }
}
