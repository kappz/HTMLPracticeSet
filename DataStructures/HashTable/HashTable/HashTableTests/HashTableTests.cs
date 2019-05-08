using NUnit.Framework;
using HashTableProject;

namespace HashTableProjectTests
{
    public class HashTableUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void HashTableCreatedSuccessfully()
        {
            HashTable hashTable = new HashTable(1333333);
            Assert.AreEqual(hashTable.GetSize(), 1333333);
        }

        [Test]
        public void NegativeOneReturnedIfNoMappingForKeyExists()
        {
            HashTable hashTable = new HashTable(1333333);

            Assert.AreEqual(-1, hashTable.Get(1337));
        }

        [Test]
        public void HashTableCorrectlyHashesKeyIntoValue()
        {
            HashTable hashTable = new HashTable(1333333);

            Assert.AreEqual(1234, hashTable.Hash(1234));
        }
    }
}