using System;
using System.Collections.Generic;

namespace CodingPractice
{
    public class DialPadProblem
    {
        string[] mappings = new string[]
        {
            "0",
            "1",
            "ABC",
            "DEF",
            "GHI",
            "JKL",
            "MNO",
            "PQRS",
            "TUV",
            "WXYZ"
        };

        internal List<string> GetCombinations(string digits)
        {
            var results = new List<string>();
            if (string.IsNullOrEmpty(digits))
            {
                return results;
            }

            TraverseDepth(results, digits, "", 0);

            return results;
        }

        private void TraverseDepth(List<string> results, string digits, string combination, int index)
        {
            if (index == digits.Length)
            {
                results.Add(combination);
                return;
            }

            string letters = mappings[int.Parse(digits[index].ToString())];
            foreach (char ch in letters)
            {
                TraverseDepth(results, digits, combination + ch, index + 1);
            }
        }
    }
}