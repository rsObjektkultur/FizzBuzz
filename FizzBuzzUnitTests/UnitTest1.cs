
using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzUnitTests
{
    public class Tests
    {
        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        public void Test1(int i)
        {
            Program.PrintFizzBuzz(i);
        }

        [Test]
        public void Test2()
        {
            Program.Main();
        }
    }
}