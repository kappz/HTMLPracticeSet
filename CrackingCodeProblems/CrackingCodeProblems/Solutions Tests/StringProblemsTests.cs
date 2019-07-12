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

        [Test]
        public void StringProblems_Compress_ReturnsStringCompressedIfItsLengthIsSmallerThanNonCompressedString()
        {
            //Act
            string expected = "a2b1c5a3";
            stringActual = text.Compress("aabcccccaaa");

            // Assert
            stringActual.Should().Be(expected);
        }

        [Test]
        public void StringProblems_Compress_ReturnsOriginalStringIfCompressedStringLengthIsLarger()
        {
            //Act
            string expected = "abcd";
            stringActual = text.Compress("abcd");

            // Assert
            stringActual.Should().Be(expected);
        }

        [Test]
        public void StringProblems_Compress_ReturnsEmptyStringIfOriginalStringIsEmpty()
        {
            //Act
            string expected = "";
            stringActual = text.Compress("");

            // Assert
            stringActual.Should().Be(expected);
        }

        [Test]
        public void StringProblems_RotateMatrix_RotatesMatrixCorrectly()
        {
            // Arrange
            bool areEqual;
            char[] matrixOneRowOne = new char[4];
            char[] matrixOneRowTwo = new char[4];
            char[] matrixOneRowThree = new char[4];
            char[] matrixOneRowFour = new char[4];
            char[] matrixTwoRowOne = { 'm', 'i', 'e', 'a' };
            char[] matrixTwoRowTwo = { 'n', 'j', 'f', 'b' };
            char[] matrixTwoRowThree = { 'o', 'k', 'g', 'c' };
            char[] matrixTwoRowFour = { 'p', 'l', 'h', 'd' };
            char[,] preRotation =
            {
                {'a','b','c','d'}, {'e', 'f', 'g', 'h'},
                {'i', 'j', 'k', 'l'}, {'m', 'n', 'o', 'p'}
            };

            // Act
            text.RotateMatrix(ref preRotation, 4);
            for (int i = 0; i < 4; i++)
            {
                matrixOneRowOne[i] = preRotation[0, i];
                matrixOneRowTwo[i] = preRotation[1, i];
                matrixOneRowThree[i] = preRotation[2, i];
                matrixOneRowFour[i] = preRotation[3, i];
            }

            // Assert
            areEqual = matrixOneRowOne.SequenceEqual(matrixTwoRowOne);
            areEqual.Should().BeTrue();
            areEqual = matrixOneRowTwo.SequenceEqual(matrixTwoRowTwo);
            areEqual.Should().BeTrue();
            areEqual = matrixOneRowThree.SequenceEqual(matrixTwoRowThree);
            areEqual.Should().BeTrue();
            areEqual = matrixOneRowFour.SequenceEqual(matrixTwoRowFour);
            areEqual.Should().BeTrue();
        }

        [Test]
        public void StringProblems_ReplaceWithZeros_ReplacesCorrectIndicesWithZeros()
        {
            // Arrange
            bool areEqual;
            int[] matrixOneRowOne = new int[3];
            int[] matrixOneRowTwo = new int[3];
            int[] matrixOneRowThree = new int[3];
            int[] matrixOneRowFour = new int[3];
            int[] matrixTwoRowOne = {0, 0, 0};
            int[] matrixTwoRowTwo = {3, 0, 0};
            int[] matrixTwoRowThree = {0, 0, 0};
            int[] matrixTwoRowFour = {4, 0, 0};
            int[,] preReplacement =
            {
                {4, 0, 1}, {3, 5, 7},
                {9, 18, 0}, {4, 12, 14}
            };

            // Act
            text.ReplaceWithZeros(ref preReplacement, 4, 3);
            for (int i = 0; i < 3; i++)
            {
                matrixOneRowOne[i] = preReplacement[0, i];
                matrixOneRowTwo[i] = preReplacement[1, i];
                matrixOneRowThree[i] = preReplacement[2, i];
                matrixOneRowFour[i] = preReplacement[3, i];
            }

            // Assert
            areEqual = matrixOneRowOne.SequenceEqual(matrixTwoRowOne);
            areEqual.Should().BeTrue();
            areEqual = matrixOneRowTwo.SequenceEqual(matrixTwoRowTwo);
            areEqual.Should().BeTrue();
            areEqual = matrixOneRowThree.SequenceEqual(matrixTwoRowThree);
            areEqual.Should().BeTrue();
            areEqual = matrixOneRowFour.SequenceEqual(matrixTwoRowFour);
            areEqual.Should().BeTrue();

        }
    }
}
