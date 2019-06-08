using System;

namespace LeetCodeAlgorithmQuestions {

    public class JewelsAndStones {

        public int NumJewelsInStones(string jewels, string stones) {
            int numJewelsInstone = 0;

            foreach (char jewel in jewels) {
                foreach(char stone in stones) {
                    if (jewel == stone) {
                        ++numJewelsInstone;
                    }
                }
            }
            return numJewelsInstone;
        }
    }
}
