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
            Map.GetValue(4).Should().Be(5);

        }
    }
}
