using System;
using System.Collections.Generic;

namespace CodingPractice
{
    internal class ArrayHelper
    {
        internal static Tuple<int, int> GetFirstUniqueNumberIndex(int[] numbers)
        {
            Dictionary<int, int> indexes = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (indexes.ContainsKey(currentNumber))
                {
                    indexes[currentNumber] = -1;
                }
                else
                {
                    indexes[currentNumber] = i;
                }
            }

            foreach (var key in indexes.Keys)
            {
                if (indexes[key] != -1)
                {
                    return new Tuple<int, int>(key, indexes[key]);
                }
            }

            return new Tuple<int, int>(-1, -1);
        }
    }
}