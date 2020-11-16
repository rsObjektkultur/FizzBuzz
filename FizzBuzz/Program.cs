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
                var temp = SayFizzBuzz(i);
                Console.WriteLine(temp);
                Thread.Sleep(50);
            }
        }

        public static string SayFizzBuzz(int i)
        {
            var output = string.Empty;

            if (i % 4 == 0)
                output += "Fazz";

            if (i % 5 == 0)
                output = "Buzz";

            if (string.IsNullOrEmpty(output))
                output = i.ToString();

            return output;
        }
    }
}
