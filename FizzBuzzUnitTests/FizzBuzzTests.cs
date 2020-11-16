using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzUnitTests
{
    public class FizzBussTests
    {
        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        public void PrintFizzBuzzTest(int i)
        {
            Program.PrintFizzBuzz(i);
        }

        [Test]
        public void MainMethodTest()
        {
            Program.Main();
        }
    }
}