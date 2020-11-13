using System;
using System.Threading;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                PrintFizzBuzz(i);
                Thread.Sleep(50);
            }
        }

        public static void PrintFizzBuzz(int i)
        {
            var output = string.Empty;

            if (i % 3 == 0)
                output += "Fizz";

            if (i % 5 == 0)
                output += "Buzz";

            if (string.IsNullOrEmpty(output))
                output = i.ToString();

            Console.WriteLine(output);
        }
    }
}
