using System;
using System.Collections.Generic;

namespace CodingPractice
{
    internal static class TwoSumHelper
    {
        public static Tuple<bool, int, int> IsSumPossible(int[] numbers, int target)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (var num in numbers)
            {
                set.Add(num);
            }

            foreach (var num in numbers)
            {
                set.Remove(num);
                var sub = target - num;
                if (set.Contains(target - num))
                {
                    return new Tuple<bool, int, int>(true, num, sub);
                }
                set.Add(num);
            }

            return new Tuple<bool, int, int>(false, 0, 0);
        }
    }
}
