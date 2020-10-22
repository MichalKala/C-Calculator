using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTestMath
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Addition()
        {
            var tst = new Calculator.MathOperations();
            double res = tst.Addition(6,6);
            Assert.AreEqual(res, 12);
        }
    }
}
