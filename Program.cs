﻿using System;
using System.Collections.Generic;

namespace CodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessEevnts();
            // FindLongestPath();
            // MergeNSortedArrays();
            // MergeTwoSortedArrays();
            // TwoSum();
            // FirstUniqueLetterOfString();
            // LinkedListSample();
            // FirstUniqueNumberIndex();
            // ContainsDuplicate();
            // DialPadProblem();
            //FizzBuzz.PrintFizzBuzz(25);
            // FactorialSample();
            // Base64EncodingSample();
        }

        private static void ProcessEevnts()
        {
            var processor = new EventProcessor<string>(5, 5);
            var list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            processor.ProcessEvents(list);
            processor.Tick().Tick().Tick().Tick();
            processor.Tick();
            list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            processor.ProcessEvents(list);
            list = new List<string>();
            list.Add("4");
            list.Add("5");
            list.Add("6");
            processor.Tick();
            processor.ProcessEvents(list);
        }

        private static void FindLongestPath()
        {
            // var array = new int[][]
            // {
            //     new int[] { 0, 0, 0, 1, 0, 0 },
            //     new int[] { 1, 1, 0, 1, 0, 0 },
            //     new int[] { 0, 1, 0, 1, 1, 0 },
            //     new int[] { 0, 1, 1, 0, 1, 0 }
            // };
            var array = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 0, 1 }
            };
            var pathHelper = new PathHelper();
            var result = pathHelper.GetLongestPath(array, 0, 1);
            Console.WriteLine($"Longest path length is {result}");
        }

        private static void MergeNSortedArrays()
        {
            var result = MergeHelper.MergeNSortedArrays(new int[3][] {
                new int[] {2,4,6},
                new int[] {1,3,5},
                new int[] {7,8,9}
            });

            foreach (var num in result)
            {
                Console.Write($"{num} ");
            }
        }

        private static void MergeTwoSortedArrays()
        {
            var result = MergeHelper.MergeSortedArrays(new int[] { 2, 4, 6 }, new int[] { 3, 5 });
            Console.WriteLine("Merged Array:");
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }

        private static void TwoSum()
        {
            var target = 4;
            var (result, num1, num2) = TwoSumHelper.IsSumPossible(new int[] { 3, 5, 1, 4, 6 }, target);
            Console.WriteLine($"Target can be obtained by adding {num1} and {num2}");

            var (result2, num12, num22) = TwoSumHelper.IsSumPossible(new int[] { 3, 5, 1, 4, 6 }, target);
            Console.WriteLine($"Target can not be obtained.");
        }

        private static void FirstUniqueLetterOfString()
        {
            var (char1, index1) = "Aseem Gaurav".GetFirstUniqueLetterIndex();
            Console.WriteLine($"First unique character: {char1} at index: {index1}");

            var (char2, index2) = "aabbccdd".GetFirstUniqueLetterIndex();
            Console.WriteLine($"No unique character found: {index2}");
        }

        private static void ContainsDuplicate()
        {
            var array = new int[] { 10, 1, 1, 2, 2, 3, 4, 4, 5 };
            array.Print();
            var containsDup = array.ContainsDuplicate();
            Console.WriteLine($"Array contains duplicate? {containsDup}");

            array = new int[] { 1, 2, 3, 4, 5 };
            array.Print();
            containsDup = array.ContainsDuplicate();
            Console.WriteLine($"Array contains duplicate? {containsDup}");
        }

        private static void FirstUniqueNumberIndex()
        {
            var array = new int[] { 10, 1, 1, 2, 2, 3, 4, 4, 5 };
            array.Print();
            var (number, index) = array.GetFirstUniqueNumberIndex();
            Console.WriteLine($"First unique number {number} is present at index {index}");

            array = new int[] { 1, 1, 2, 2, 3, 4, 4, 5 };
            array.Print();
            (number, index) = array.GetFirstUniqueNumberIndex();
            Console.WriteLine($"First unique number {number} is present at index {index}");
        }

        private static void FactorialSample()
        {
            var num = 5;
            System.Console.WriteLine($"Factorial of {num}: {Factorial.GetFactorial(num)}");
        }

        private static void Base64EncodingSample()
        {
            var encoded = Base64Encoding.Encode();
            System.Console.WriteLine($"Encoded - {encoded}");
            System.Console.WriteLine($"Decoded - {Base64Encoding.Decode(encoded)}");
        }

        private static void DialPadProblem()
        {
            DialPadProblem dp = new DialPadProblem();
            var combinations = dp.GetCombinations("23");
            foreach (var comb in combinations)
            {
                Console.WriteLine(comb);
            }
        }

        private static void LinkedListSample()
        {
            System.Console.WriteLine("Linked list sample");
            var ll = new Models.LinkedList<int>();
            ll.Add(1);
            ll.Add(2);
            ll.Add(3);
            ll.Print();
            ll.Add(4);
            ll.Add(5);
            ll.Print();
        }
    }
}
