using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMathAppProper;
namespace BasicMathApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_ShouldReturnCorrectSum()
        {
            Assert.AreEqual(5, BasicMath.Add(2, 3));
        }

        [TestMethod]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            Assert.AreEqual(1, BasicMath.Subtract(4, 3));
        }

        [TestMethod]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            Assert.AreEqual(12, BasicMath.Multiply(3, 4));
        }

        [TestMethod]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            Assert.AreEqual(2, BasicMath.Divide(10, 5));
        }
    }
}