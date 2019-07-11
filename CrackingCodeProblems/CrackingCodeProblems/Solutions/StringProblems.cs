using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeProblems.Class_Solutions
{
    class StringProblems
    {

        public bool ContainsOnlyUniqueCharacters(string text)
        {
            bool result = true;
            IDictionary<char, int> characterFrequencies = new Dictionary<char, int>();

            if (text == null)
            {
                result = false;
            }
            else
            {
                foreach(char character in text)
                {
                    if (!characterFrequencies.ContainsKey(character))
                    {
                        characterFrequencies.Add(character, 1);
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            return result;
        }

        public string Reverse(string text)
        {
            int pivot = text.Length / 2;
            int end = text.Length - 1;
            int start = 0;
            char temp;
            char[] arr = text.ToCharArray();
            if (text.Length == 0)
            {
                return null;
            }
            else if (text.Length == 1)
            {
                return text;
            }
            else
            {
                while (start < end)
                {
                    temp = arr[end];
                    arr[end] = arr[start];
                    end--;
                    start++;
                }
            }
            text = arr.ToString();
            return text;
        }
    }
}
