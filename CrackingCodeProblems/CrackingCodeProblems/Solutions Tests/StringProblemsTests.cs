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
    class StringProblemsTests
    {
        bool boolActual;
        bool boolExpected;
        string stringExpected;
        string stringActual;
        StringProblems text;

        [SetUp]
        public void TestSetup()
        {
            text = new StringProblems();
        }

        [Test]
        public void StringProblems_ContainsOnlyUniqueCharactes_ReturnsFalseIfTextIsNull()
        {
            // Arrange
            boolExpected = false;

            // Act
            boolActual = text.ContainsOnlyUniqueCharacters("");

            // Assert
            boolActual.Should().Equals(boolExpected);
        }

        [Test]
        public void StringProblems_ContainsOnlyUniqueCharactes_ReturnsTrueIfStringContainsOnlyUniqueCharacters()
        {
            // Arrange
            boolExpected = true;

            // Act
            boolActual = text.ContainsOnlyUniqueCharacters("test");

            // Assert
            boolActual.Should().Equals(boolExpected);
        }

        [Test]
        public void StringProblems_ContainsOnlyUniqueCharactes_ReturnsFalseIfStringContainsDuplicateCharacters()
        {
            // Arrange
            boolExpected = false;

            // Act
            boolActual = text.ContainsOnlyUniqueCharacters("tesst");

            // Assert
            boolActual.Should().Equals(boolExpected);
        }

        [Test]
        public void StringProblems_ReverseString_ReturnsStringIfStringLengthIsOne()
        {
            // Arrange
            stringExpected = "t";

            // Act
            stringActual = text.Reverse("t");

            // Assert
            stringActual.Should().Equals(stringExpected);
        }

        [Test]
        public void StringProblems_ReverseString_ReturnsNullIfStringLengthIsZero()
        {
            // Arrange
            stringExpected = null;

            // Act
            stringActual = text.Reverse("");

            // Assert
            stringActual.Should().BeNull();
        }

        [Test]
        public void StringProblems_ReverseString_ReturnsStringReversedForStringLengthGreaterThanOne()
        {
            // Arrange
            stringExpected = "tset";
            string oddLengthStringExpected = "ereht";
            string oddLengthStringActual;

            // Act
            stringActual = text.Reverse("test");
            oddLengthStringActual = text.Reverse("there");

            // Assert
            stringActual.Should().Equals(stringExpected);
            oddLengthStringActual.Should().Equals(oddLengthStringExpected);
        }
    }
}
