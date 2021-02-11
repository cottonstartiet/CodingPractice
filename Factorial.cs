namespace CodingPractice
{
    public class Factorial
    {
        public static int GetFactorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return num;
            }

            return num * GetFactorial(num -1);
        }
    }
}