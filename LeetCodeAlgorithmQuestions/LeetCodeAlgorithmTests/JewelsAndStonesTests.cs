using LeetCodeAlgorithmQuestions;
using NUnit.Framework;

namespace LeetCodeAlgorithmUnitTests
{
    public class JewelsAndStonesTests
    {
        [Test]
        public void JewelsAndStones_ReturnsCorrectNumberOfStones() {
            int actual;
            int expected = 3;
            JewelsAndStones jewelsAndStones = new JewelsAndStones();
            actual = jewelsAndStones.NumJewelsInStones("aA", "aAAbbbb");
            Assert.AreEqual(expected, actual);
        }
    }
}