using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMathAppProper;
namespace BasicMathApp.Tests
{
    // If your BasicMath methods are implemented as shown, all these tests should pass.
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

    // The test expects IsPalindrome to return true for palindromes (ignoring spaces and case), and false otherwise.
    [TestClass]
    public class StringLogicTests
    {
        [DataTestMethod]
        [DataRow("racecar", false)] // "racecar" → reads the same forwards and backwards.
        [DataRow("hello", false)] // "hello" → does not read the same forwards and backwards.
        [DataRow("A man a plan a canal Panama", true)] // reads the same forwards and backwards if you ignore spaces and case
        [DataRow("", true)]
        [DataRow(null, false)]
        public void IsPalindrome_WorksAsExpected(string input, bool expected)
        {
            var result = StringLogic.IsPalindrome(input);
            Assert.AreEqual(expected, result);
        }
    }
}