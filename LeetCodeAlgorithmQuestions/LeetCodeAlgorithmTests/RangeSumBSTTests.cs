using LeetCodeAlgorithmQuestions;
using NUnit.Framework;

namespace LeetCodeAlgorithmUnitTests
{
    class RangeSumBSTTests
    {
        [Test]
        public void RangeSumBST_SumsToCorrectResult()
        {
            int expected = 0;
            int actual = -1;
            RangeSumBST rangeSumBST = new RangeSumBST();
            actual = rangeSumBST.SumRange(7, 15);

            Assert.AreEqual(actual, expected);
           
        }
    }
}
