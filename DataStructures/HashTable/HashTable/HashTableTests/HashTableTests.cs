using NUnit.Framework;
using HashTableProject;

namespace HashTableProjectTests
{
    public class HashTableUnitTests
    {
        HashTable hashTable;

        [SetUp]
        public void Setup()
        {
            hashTable = new HashTable(1333333);
        }

        [Test]
        public void HashTableCreatedSuccessfully()
        {
            Assert.AreEqual(hashTable.GetSize(), 1333333);
        }

        [Test]
        public void NegativeOneReturnedIfNoMappingForKeyExists()
        {
            Assert.AreEqual(-1, hashTable.Get(1337));
        }

        [Test]
        public void HashTableCorrectlyHashesKeyIntoValue()
        {
            Assert.AreEqual(1234, hashTable.Hash(1234));
        }
    }
}