using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;

namespace HashMaps
{
    class HashMapTests
    {

        [Test]
        public void HashMap_HashFunction_ComputesCorrectIndexForPrimitiveTypesIntCharString()
        {

            // Arrange 
            // Act
            HashMap<int, int> integerKeyMap = new HashMap<int, int>();
            HashMap<char, int> charKeyMap = new HashMap<char, int>();
            HashMap<string, int> StringKeyMap = new HashMap<string, int>();
            int actual = 4;

            // Assert
            integerKeyMap.Hash(4).Should().Be(actual);
            charKeyMap.Hash('d').Should().Be(actual);
            StringKeyMap.Hash("ddddd").Should().Be(actual);
        }

        [Test]
        public void HashMap_Insert_SuccessfullyAddsNewKeyValuePairToHashMap()
        {
            HashMap<int, int> Map = new HashMap<int, int>();
            Map.Insert(4, 5);
            Map.Get(4).Value().Should().Be(5);
            Map.Size().Should().Be(1);

        }

        [Test]
        public void HashMap_Insert_AddsElementToEndOfListIfObjectAlreadyExistsAtComputedIndex()
        {
            // Arrange
            HashMap<int, int> Map = new HashMap<int, int>();

            // Act
            Map.Insert(4, 5);
            Map.Insert(4, 7);

            // Assert
            Map.Get(4).Value().Should().Be(5);
            Map.Get(4).next.Value().Should().Be(7);
            Map.Size().Should().Be(2);

        }

        [Test]
        public void HashMap_Get_RetrievesCorrectObjectForGivenKey()
        {
            // Arrange
            HashMap<char, string> map = new HashMap<char, string>();

            // Act
            map.Insert('z', "Harry Potter");

            // Assert
            map.Get('z').Value().Should().Be("Harry Potter");
        }

        [Test]
        public void HashMap_Get_RetrievesListOfObjectsIfMoreThanOneObjectStoredAtComputedIndex()
        {
            // Arrange
            HashMap<char, string> map = new HashMap<char, string>();

            // Act
            map.Insert('z', "Harry Potter");
            map.Insert('z', "Lord Voldemort");

            // Assert
            map.Get('z').Value().Should().Be("Harry Potter");
            map.Get('z').next.Value().Should().Be("Lord Voldemort");
        }

        [Test]
        public void HashMap_Get_ReturnsDefaultvalueFoundIfComputedHashIndexIsNull()
        {
            // Arrange
            HashMap<char, string> map = new HashMap<char, string>();

            // Assert
            map.Get('c').Should().BeNull();
        }

        [Test]
        public void HashMap_Exists_ReturnsTrueIfValueFound()
        {
            // Arrange
            HashMap<char, string> map = new HashMap<char, string>();

            // Act
            map.Insert('z', "Harry Potter");
            map.Insert('z', "Lord Voldemort");
            map.Insert('c', "Professor Dumbledore");

            // Assert
            map.Exists("Harry Potter").Should().BeTrue();
            map.Exists("Lord Voldemort").Should().BeTrue();
            map.Exists("Professor Dumbledore").Should().BeTrue();
        }

        [Test]
        public void HashMap_Exists_ReturnsFalseIfValueNotFound()
        {
            // Arrange
            HashMap<char, string> map = new HashMap<char, string>();

            // Act
            map.Insert('z', "Harry Potter");
            map.Insert('g', "Lord Voldemort");

            // Assert
            map.Exists("Professor Snape").Should().BeFalse();
        }
    }
}
