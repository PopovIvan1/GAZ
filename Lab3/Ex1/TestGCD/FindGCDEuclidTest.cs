using GreatestCommonDivisor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestGCD
{
    [TestClass]
    public class FindGCDEuclidTest
    {
        [TestMethod]
        public void FindGCDTestMethod()
        {
            int a = 2806;
            int b = 345;
            int expected = 23;
            int result;
            result = GCDAlgorithms.FindGCDEuclid(a, b);
            Assert.AreEqual(expected, result);
        }
    }
}
