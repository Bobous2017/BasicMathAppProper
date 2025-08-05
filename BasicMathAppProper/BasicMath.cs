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
        public static int Multiply(int a, int b) => a * b;
        public static int Divide(int a, int b) => a / b; // Note: No zero check here
    }
}

