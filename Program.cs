using System;
using CodingPractice.Models;

namespace CodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // LinkedListSample();
            // FirstUniqueNumberIndex()
            ContainsDuplicate();
            // RunDialPadProblem();
            //FizzBuzz.PrintFizzBuzz(25);
            // FactorialSample();
            // Base64EncodingSample();
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

        private static void RunDialPadProblem()
        {
            DialPadProblem dp = new DialPadProblem();
            var combinations = dp.GetCombinations(2, 3);
            foreach (var comb in combinations)
            {
                Console.WriteLine(comb);
            }
        }

        private static void LinkedListSample()
        {
            System.Console.WriteLine("Linked list sample");
            var ll = new LinkedList<int>();
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
