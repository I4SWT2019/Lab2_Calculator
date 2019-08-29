using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        private static double result;
        public double Add(double a, double b)
        {
            result = a + b;
            return result;
        }

        public double Subtract(double a, double b)
        {
            result = a - b;
            return result;
        }

        public double Multiply(double a, double b)
        {
            result = a * b;
            return result;
        }

        public double Power(double x, double exp)
        {
            result = Math.Pow(x, exp);
            return result;
        }

        public double Divide(double divident, double divider)
        {

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

        public double Accumulator
        {

            get
            {
                double resultValue = result;
                return resultValue;
            }
            //private omitted

        }


    }
}
