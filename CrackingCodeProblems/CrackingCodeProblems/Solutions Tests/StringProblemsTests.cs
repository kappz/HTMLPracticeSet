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
        public void StringProblems_ContainsOnlyUniqueCharactes_ReturnsFalseIfTextIsEmpty()
        {
            // Arrange
            boolExpected = false;

            // Act
            boolActual = text.ContainsOnlyUniqueCharacters("");

            // Assert
            boolActual.Should().Be(boolExpected);
        }

        [Test]
        public void StringProblems_ContainsOnlyUniqueCharactes_ReturnsTrueIfStringContainsOnlyUniqueCharacters()
        {
            // Arrange
            boolExpected = true;

            // Act
            boolActual = text.ContainsOnlyUniqueCharacters("tes");

            // Assert
            boolActual.Should().Be(boolExpected);
        }


        [Test]
        public void StringProblems_ContainsOnlyUniqueCharactes_ReturnsFalseIfStringContainsDuplicateCharacters()
        {
            // Arrange
            boolExpected = false;

            // Act
            boolActual = text.ContainsOnlyUniqueCharacters("test");

            // Assert
            boolActual.Should().Be(boolExpected);
        }

        [Test]
        public void StringProblems_ReverseString_ReturnsStringIfStringLengthIsOne()
        {
            // Arrange
            stringExpected = "t";

            // Act
            stringActual = text.Reverse("t");

            // Assert
            stringActual.Should().Be(stringExpected);
        }

        [Test]
        public void StringProblems_Reverse_ReturnsNullIfStringLengthIsZero()
        {
            // Arrange
            stringExpected = "";

            // Act
            stringActual = text.Reverse("");

            // Assert
            stringActual.Should().Be(stringExpected);
        }

        [Test]
        public void StringProblems_Reverse_ReturnsStringReversedForStringLengthGreaterThanOne()
        {
            // Arrange
            stringExpected = "tset";
            string oddLengthStringExpected = "ereht";
            string oddLengthStringActual;

            // Act
            stringActual = text.Reverse("test");
            oddLengthStringActual = text.Reverse("there");

            // Assert
            stringActual.Should().Be(stringExpected);
            oddLengthStringActual.Should().Be(oddLengthStringExpected);
        }

        [Test]
        public void StringProblems_IsPermutation_ReturnsFalseIfStringIsNotPermutation()
        {
            // Act
            boolActual = text.IsPermutation("abc", "abc");

            // Assert
            boolActual.Should().BeFalse();
        }

        [Test]
        public void StringProblems_IsPermutation_ReturnsTrueIfStringIsAPermutation()
        {
            // Act
            boolActual = text.IsPermutation("abc", "acb");

            // Assert
            boolActual.Should().BeTrue();
        }

        [Test]
        public void StringProblems_ReplaceSpaces_ReturnsSameStringIfStringContainsNoSpaces()
        {
            // Act
            stringExpected = "helloworld";

            stringActual = text.ReplaceSpaces("helloworld");

            // Assert
            stringActual.Should().Be(stringExpected);
        }
        [Test]
        public void StringProblems_ReplaceSpaces_ReturnsStringWithSpacesReplaced()
        {
            // Act
            stringExpected = "%20hello%20world%20";

            stringActual = text.ReplaceSpaces(" hello world ");

            // Assert
            stringActual.Should().Be(stringExpected);
        }
    }
}
