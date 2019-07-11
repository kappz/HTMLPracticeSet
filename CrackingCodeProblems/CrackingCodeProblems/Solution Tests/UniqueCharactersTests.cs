using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;
using CrackingCodeProblems.Class_Solutions;

namespace CrackingCodeProblems.Solution_Tests
{
    class UniqueCharactersTests
    {

        [Test]
        public void UniqueCharacters_ContainsOnlyUniqueCharactes_ReturnsFalseIfTextIsNull()
        {
            // Arrange
            bool actual;
            bool expected = false;
            UniqueCharacters text = new UniqueCharacters("");

            // Act
            actual = text.ContainsOnlyUniqueCharacters();

            // Assert
            actual.Should().Equals(expected);
        }

        [Test]
        public void UniqueCharacters_ContainsOnlyUniqueCharactes_ReturnsTrueIfStringContainsOnlyUniqueCharacters()
        {
            // Arrange
            bool actual;
            bool expected = true;
            UniqueCharacters text = new UniqueCharacters("test");

            // Act
            actual = text.ContainsOnlyUniqueCharacters();

            // Assert
            actual.Should().Equals(expected);
        }

        [Test]
        public void UniqueCharacters_ContainsOnlyUniqueCharactes_ReturnsFalseIfStringContainsDuplicateCharacters()
        {
            // Arrange
            bool actual;
            bool expected = false;
            UniqueCharacters text = new UniqueCharacters("test");

            // Act
            actual = text.ContainsOnlyUniqueCharacters();

            // Assert
            actual.Should().Equals(expected);
        }
    }
}
