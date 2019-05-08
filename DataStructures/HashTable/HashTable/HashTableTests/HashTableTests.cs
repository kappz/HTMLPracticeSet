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

            Assert.AreEqual(-1, hashTable.get(1337));
        }
    }
}