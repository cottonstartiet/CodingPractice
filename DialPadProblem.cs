using System;
using System.Collections.Generic;

namespace CodingPractice
{
    public class DialPadProblem
    {
        private string[][] dialPad = new string[4][]
        {
            new string[] {"", "", "ABC"},
            new string[] {"DEF", "GHI", "JKL"},
            new string[] {"MNO", "PQRS", "TUV"},
            new string[] {"", "WXYZ", ""}
        };

        internal List<string> GetCombinations(int startNumber, int length)
        {
            var results = new List<string>();
            for (int i = 0; i < dialPad.Length; i++)
            {
                var row = dialPad[i];
                for (int j = 0; j < row.Length; j = j + 3)
                {
                    System.Console.WriteLine($"{row[j]} {row[j + 1]} {row[j + 2]}");
                }
            }

            return results;
        }
    }
}