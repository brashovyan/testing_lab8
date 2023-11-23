using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_lab2;

namespace TestProject
{
    [TestFixture]
    internal class UnitTests
    {
        // сперва идут обычные юнит тесты
        [TestCase(5, 5)]
        [TestCase(5, 5)]
        [TestCase(-12, 12)]
        [TestCase(12.5, 12.5)]
        [TestCase(-10.1234, 10.1234)]
        [Test, MaxTime(100), Timeout(100)]
        public void TestAbs(double x, double result)
        {
            Assert.AreEqual(result, MyClass.Abs(x));
        }

        [TestCase(4, 24)]
        [TestCase(5, 120)]
        [TestCase(9, 362880)]
        [TestCase(-10, -1)]
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [Test, MaxTime(100), Timeout(100)]
        public void TestFactorial(int x, int result)
        {
            Assert.AreEqual(result, MyClass.Factorial(x));
        }

        [TestCase(45, 0.7071)]
        [TestCase(30, 0.5)]
        [TestCase(50, 0.766)]
        [TestCase(79, 0.9816)]
        [TestCase(20, 0.342)]
        [TestCase(90, 1)]
        [Test, MaxTime(100), Timeout(100)]
        public void TestSin(double x, double result)
        {
            Assert.AreEqual(result, MyClass.Sin(x));
        }

        [TestCase(30, 0.866)]
        [TestCase(45, 0.7071)]
        [TestCase(-55,0.5736)]
        [TestCase(0, 1)]
        [Test, MaxTime(100), Timeout(100)]
        public void TestCos(double x, double result)
        {
            Assert.AreEqual(result, MyClass.Cos(x));
        }

        [TestCase(85, 4.441)]
        [TestCase(30, 3.4012)]
        [TestCase(0.5, -0.6931)]
        [Test, MaxTime(100), Timeout(100)]
        public void TestLn(double x, double result)
        {
            Assert.AreEqual(result, MyClass.Ln(x));
        }
    }
}
