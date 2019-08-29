using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            double result = a + b;
            return result;
        }

        public double Subtract(double a, double b)
        {
            double result = a - b;
            return result;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;
            return result;
        }

        public double Power(double x, double exp)
        {
            double result = Math.Pow(x, exp);
            return result;
        }

        public double Divide(double divident, double divider)
        {
            double result = 0;

            if (divider != 0)
            {
                result = divident / divider;
                return result;
            }
            else
            {
                throw new InvalidOperationException("Divide by 0 error");
            }
        }
    }
}
