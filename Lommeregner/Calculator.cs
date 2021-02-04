using System;

namespace Lommeregner
{
    public class Calculator
    {
        public Calculator()
        { }
        public double Add(double a, double b)
        {
            return (a + b);
        }
        public double Subtract(double a, double b)
        {
            return (a - b);
        }

        public double Multiply(double a, double b)
        {
            return (a * b);
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }
    }

}
