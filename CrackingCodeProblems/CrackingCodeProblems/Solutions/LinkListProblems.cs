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

        public void DeleteMiddleNode(Node middleNode)
        {
            Node previous = middleNode;
            Node walker = middleNode;
            while (walker.next != null)
            {
                previous = walker;
                walker.data = walker.next.data;
                walker = walker.next;
            }
            previous.next = null;
        }

        public Node SumLinkLists(Node numOne, Node numTwo)
        {
            Node sumHead = new Node();
            Node walker = sumHead;
            int sum = 0;
            sum += LinkListToDigit(numOne);
            sum += LinkListToDigit(numTwo);

            while (sum > 1)
            {
                walker.data = sum % 10;
                sum /= 10;
                walker.next = new Node();
                walker = walker.next;
            }
            walker = null;
            return sumHead;
        }

        private int LinkListToDigit(Node head)
        {
            int exponent = 0;
            int result = 0;

            while (head != null)
            {
                result += head.data * (int)Math.Pow(10, exponent);
                ++exponent;
                head = head.next;
            }
            return result;
        }

        public Node ReturnBeginningNodeInCircularLinkList(Node head)
        {
            Dictionary<Node, int> nodeValues = new Dictionary<Node, int>();

            while (!nodeValues.ContainsKey(head))
            {
                nodeValues.Add(head, head.data);
                head = head.next;
            }
            return head;
        }
    }
}
