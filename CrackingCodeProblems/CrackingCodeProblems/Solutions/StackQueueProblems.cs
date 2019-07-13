using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingCodeProblems.DataStructures;

namespace CrackingCodeProblems.Solutions
{
    class StackQueueProblems
    {
        // Implement 3 stacks using single array
        class ThreeStacksUsingSingleArray
        {
            int stackSize;
            int[] stackPointers;
            int[] buffer;

            public ThreeStacksUsingSingleArray(int size = 100)
            {
                stackSize = size;
                stackPointers = new int[] { -1, -1, -1 };
                buffer = new int[stackSize * 3];
            }

            public void Push(int stackNum, int value)
            {
                if (TopOfStackOffset(stackNum) >= stackSize)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    stackPointers[stackNum]++;
                    buffer[TopOfStackOffset(stackNum)] = value;
                }
            }

            public int Pop(int stackNum)
            {
                int value;
                if (stackPointers[stackNum] == -1)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    value = buffer[TopOfStackOffset(stackNum)];
                    buffer[TopOfStackOffset(stackNum)] = 0;
                    stackPointers[stackNum]--;
                }
                return value;
            }

            public int Peek(int stackNum)
            {
               if (stackPointers[stackNum] == -1)
                {
                    throw new InvalidOperationException();
                }
                return buffer[TopOfStackOffset(stackNum)];
            }

            int TopOfStackOffset(int stackNum)
            {
                return stackNum * stackSize + stackPointers[stackNum];
            }
        }
    }
}
