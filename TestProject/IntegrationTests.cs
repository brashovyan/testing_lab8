using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_lab2;

namespace TestProject
{
    [TestFixture]
    internal class IntegrationTests
    {
        [TestCase(10, 2.26760048)]
        [TestCase(0, -6.5687)]
        [TestCase(-10, 0.35075395143220495)]
        [TestCase(-50, 0.2868078175895766)]
        [TestCase(50, 2.5146336000000002)]
        [Test, MaxTime(100), Timeout(100)]
        public void TestIntegration(double x, double result)
        {
            Assert.AreEqual(result, MyClass.MyFunction(x));
        }
    }
}
