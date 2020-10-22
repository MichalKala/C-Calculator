using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathOperationsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_addition()
        {
            var tst = new MathOperations();
            double res = MathOperations.Addition(6, 6);
            Assert.AreEqual(res, 12);
        }
        [TestMethod]
        public void TestMethod_substraction()
        {
            var tst = new MathOperations();
            double res = MathOperations.Substraction(6, 6);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void TestMethod_multiplication()
        {
            var tst = new MathOperations();
            double res = MathOperations.Multiplication(6, 6);
            Assert.AreEqual(res, 36);
        }
        [TestMethod]
        public void TestMethod_division()
        {
            var tst = new MathOperations();
            double res = MathOperations.Division(6, 6);
            Assert.AreEqual(res, 1);
        }
    }
}
