using NUnit.Framework.Internal;
using test_lab2;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [TestCase(4, 24)]
        [TestCase(5, 120)]
        [TestCase(9, 362880)]
        [TestCase(-10, -1)]
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [Test, MaxTime(100), Timeout(100)]
        public void TestFactorial(int x, int result)
        {
            Assert.AreEqual(result, Factorial(x));
        }
    }
}