namespace CodingPractice
{
    class FizzBuzz
    {
        public static void PrintFizzBuzz(int count)
        {
            for (int i = 1; i < count; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.WriteLine($"FizzBuzz ({i})");
                }
                else if (i % 3 == 0)
                {
                    System.Console.WriteLine($"Fizz ({i})");
                }
                else if (i % 5 == 0)
                {
                    System.Console.WriteLine($"Buzz ({i})");
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}