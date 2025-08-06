using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathAppProper
{
    public static class BasicMath
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b; // Should be a * b
        public static int Divide(int a, int b) => a / b; // Should be a / b, and no zero check here

    }

    public static class StringLogic
    {
        public static bool IsPalindrome(string input)
        {
            if (input == null) return false;
            var trimmed = input.Replace(" ", "").ToLowerInvariant();
            var reversed = new string(trimmed.Reverse().ToArray());
            return trimmed == reversed;
        }
    }
}

