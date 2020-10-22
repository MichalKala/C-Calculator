using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class MathOperations
    {
        public static double Addition (double a, double b)
        {
            double res = a + b;
            return res;
        }

        public static double Substraction(double a, double b)
        {
            double res = a - b;
            return res;
        }

        public static double Multiplication(double a, double b)
        {
            double res = a * b;
            return res;
        }

        public static double Division(double a, double b)
        {
            double res = a / b;
            return res;
        }
    }
}
