using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodeProblems.Class_Solutions
{
    class UniqueCharacters
    {
        string text;

        public UniqueCharacters(string t)
        {
            text = t;
        }

        public bool ContainsOnlyUniqueCharacters()
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
    }
}
