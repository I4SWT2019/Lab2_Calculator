﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; } = 0;

        public double Add(double a, double b)
        {
            return Accumulator = a + b;
        }

        public double Subtract(double a, double b)
        {
            return Accumulator = a - b;
        }

        public double Subtract(double a)
        {
            return Accumulator -= a;
        }

        public double Multiply(double a, double b)
        {
            return Accumulator = a * b;
        }

        public double Power(double x, double exp)
        {
            return Accumulator = Math.Pow(x, exp);
        }

        public double Divide(double divident, double divider)
        {

            if (divider != 0)
            {
                return Accumulator = divident / divider;
            }
            else
            {
                throw new InvalidOperationException("Divide by 0 error");
            }
        }

        


    }
}
