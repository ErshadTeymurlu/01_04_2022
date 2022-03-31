using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_04_2022_Homework
{
    internal static class Calculator
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Divide(int a, int b)
        {
            return (double)a / (double)b;
        }
        public static int Pow(this int variable, int a)
        {
            int pow = 1;
            for (int i = 1; i <= a; i++) pow = pow * variable;
            return pow;
        }

    }
}
