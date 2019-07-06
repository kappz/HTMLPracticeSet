using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;

namespace LinkList
{
    class LinkListTests
    {

        [Test]
        public void LinkList_AddEnd_AddsNewElementToEndOfList()
        {
            // Arrange
            LinkList<int> list = new LinkList<int>();

            // Act
            list.AddEnd(5);
            list.AddEnd(7);

            // Assert
            list.Count().Should().Be(2);
            list.Head().Value().Should().Be(5);
            list.Tail().Value().Should().Be(7);
        }

        [Test]
        public void LinkList_AddBegin_AddsNewELementToBeginningOfList()
        {
            // Arrange
            LinkList<char> list = new LinkList<char>();

            // Act
            list.AddEnd('b');
            list.AddBegin('z');

            // Assert
            list.Head().Value().Should().Be('z');
            list.Head().next.Value().Should().Be('b');
        }

        [Test]
        public void LinkList_AddBefore_AddsNewElementBeforeGivenElement()
        {
            // Arrange
            LinkList<char> list = new LinkList<char>();

            // Act
            list.AddEnd('b');
            list.AddBegin('z');
            list.AddBefore('b', 'r');
            list.AddBefore('z', 'q');

            list.Head().Value().Should().Be('q');
            list.Head().next.next.Value().Should().Be('r');

        }
    }
}
