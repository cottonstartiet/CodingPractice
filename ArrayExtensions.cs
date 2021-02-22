using System;
using System.Collections.Generic;

namespace CodingPractice
{
    internal static class ArrayExtensions
    {
        internal static Tuple<int, int> GetFirstUniqueNumberIndex(this int[] numbers)
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

            foreach (var num in numbers)
            {
                if (indexes[num] != -1)
                {
                    return new Tuple<int, int>(num, indexes[num]);
                }
            }

            return new Tuple<int, int>(-1, -1);
        }

        internal static bool ContainsDuplicate(this int[] numbers)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (var num in numbers)
            {
                if (set.Contains(num))
                {
                    return true;
                }
                else
                {
                    set.Add(num);
                }
            }

            return false;
        }

        internal static void Print(this int[] numbers)
        {
            foreach (var num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}