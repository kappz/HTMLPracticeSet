using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using FluentAssertions;

namespace CrackingCodeProblems
{
    class StringUniqueCharacterTests
    {

        [Test]
        public void StringUniqueCharacters_ContainsOnlyUniqueCharacters_ReturnsFalseIfStringIsNull()
        {
            // Arrange
            // Act
            StringUniqueCharacters text = new StringUniqueCharacters("");


            // Assert
            text.ContainsOnlyUniqueCharacters().Should().BeFalse();
        }
    }
}
