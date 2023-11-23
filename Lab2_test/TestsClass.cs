using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_test
{
    [TestFixture]
    internal class TestsClass
    {
        [TestCase(-5, 5)]
        [Test, Timeout(100), MaxTime(100)]
        public void TestAbs(double x, double result)
        {
            CollectionAssert.AreEqual(result, Factorial(x));
        }

    }
}
