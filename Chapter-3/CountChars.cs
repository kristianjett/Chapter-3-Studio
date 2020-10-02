using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_3
{
    class CountChars
    {

        public static Dictionary<char, int> countEachChar(string input)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char upperCase = char.ToUpper(c);
                    if (!dict.ContainsKey(upperCase))
                    {
                        dict[upperCase] = 0;
                    }

                    dict[upperCase]++;
                }
                

            }

            return dict;
        }
    }
}
