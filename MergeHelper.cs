using System;
using System.Collections.Generic;

namespace CodingPractice
{
    internal static class MergeHelper
    {
        public static int[] MergeSortedArrays(int[] arr1, int[] arr2)
        {
            var result = new List<int>();
            int ptr1 = 0;
            int ptr2 = 0;
            int index = 0;

            while (ptr1 < arr1.Length && ptr2 < arr2.Length)
            {
                if (arr1[ptr1] < arr2[ptr2])
                {
                    result.Add(arr1[ptr1]);
                    ptr1++;
                }
                else
                {
                    result.Add(arr2[ptr2]);
                    ptr2++;
                }
                index++;
            }

            if (ptr1 < arr1.Length)
            {
                while (ptr1 < arr1.Length)
                {
                    result.Add(arr1[ptr1]);
                    index++;
                    ptr1++;
                }
            }
            else if (ptr2 < arr2.Length)
            {
                while (ptr2 < arr2.Length)
                {
                    result.Add(arr2[ptr2]);
                    index++;
                    ptr2++;
                }
            }

            return result.ToArray();
        }

        internal static int[] MergeNSortedArrays(int[][] arrays)
        {
            int index = 0;
            var result = new List<int>();
            while (index < arrays.Length)
            {
                result = new List<int>(MergeSortedArrays(result.ToArray(), arrays[index]));
                index++;
            }

            return result.ToArray();
        }
    }
}