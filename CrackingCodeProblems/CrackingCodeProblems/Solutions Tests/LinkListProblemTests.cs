using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;
using CrackingCodeProblems.Solutions;
using CrackingCodeProblems.DataStructures;

namespace CrackingCodeProblems.Solutions_Tests
{
    class LinkListProblemTests
    {
        LinkListProblems linkList;

        [SetUp]
        public void TestSetup()
        {
            linkList = new LinkListProblems();
        }

        [Test]
        public void LinkListProblems_RemoveDuplicates_RemovesAllDuplicates()
        {
            // Arrange
            Node head = new Node(13);
            head.next = new Node(3);
            head.next.next = new Node(13);
            head.next.next.next = new Node(7);
            head.next.next.next.next = new Node(8);
            head.next.next.next.next.next = new Node(7);

            // Act
            linkList.RemoveDuplicates(head);

            // Assert
            head.data.Should().Be(13);
            head.next.data.Should().Be(3);
            head.next.next.data.Should().Be(7);
            head.next.next.next.data.Should().Be(8);
            head.next.next.next.next.Should().BeNull();
        }

        [Test]
        public void LinkListProblems_ReturnKthNode_ReturnsCorrectNode()
        {
            // Arrange
            Node kthNode;
            Node head = new Node(13);
            head.next = new Node(3);
            head.next.next = new Node(11);
            head.next.next.next = new Node(7);
            head.next.next.next.next = new Node(8);
            head.next.next.next.next.next = new Node(7);

            // Act
            kthNode = linkList.ReturnKthNode(head, 3);

            // Assert
            kthNode.data.Should().Be(11);
        }

        [Test]
        public void LinkListProblems_RemoveMiddleNodeList_DeletesMiddleNode()
        {
            // Arrange
            Node middle;
            Node head = new Node(13);
            head.next = new Node(3);
            head.next.next = new Node(11);
            head.next.next.next = new Node(7);
            head.next.next.next.next = new Node(8);
            middle = head.next.next;

            // Act
            linkList.DeleteMiddleNode(middle);

            // Assert
            head.data.Should().Be(13);
            head.next.data.Should().Be(3);
            head.next.next.data.Should().Be(7);
            head.next.next.next.data.Should().Be(8);
        }
    }
}
