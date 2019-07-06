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
        public void LinkList_Insert_AddsNewElementToList()
        {
            // Arrange
            LinkList<int> list = new LinkList<int>();

            // Act
            list.Insert(5);
            list.Insert(7);

            // Assert
            list.Count().Should().Be(2);
            list.Head().Value().Should().Be(5);
            list.Tail().Value().Should().Be(7);
        }
    }
}
