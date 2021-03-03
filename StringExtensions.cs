using System;
using System.Collections.Generic;

namespace CodingPractice
{
    public static class StringExtensions
    {
        public static Tuple<string, int> GetFirstUniqueLetterIndex(this string input)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            int index = 0;
            foreach (char ch in input)
            {
                if (map.ContainsKey(ch))
                {
                    map[ch] = -1;
                }
                else
                {
                    map[ch] = index;
                }

                index++;
            }

            foreach (var ch in input)
            {
                if (map[ch] != -1)
                {
                    return new Tuple<string, int>(ch.ToString(), map[ch]);
                }
            }



            return new Tuple<string, int>("", -1);
        }
    }
}