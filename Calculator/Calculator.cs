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

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Add(double a, double b)
        {
            return Accumulator = a + b;
        }

        public double Add(double addend)
        {
            return Accumulator += addend;
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

        public double Multiply(double multiplier)
        {
            return Accumulator *= multiplier;
        }

        public double Power(double x, double exp)
        {
            return Accumulator = Math.Pow(x, exp);
        }

        public double Power(double exp)
        {
            return Accumulator = Math.Pow(Accumulator, exp);
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

        public double Divide(double divider)
        {
            if (divider != 0)
            {
                return (Accumulator /= divider);
            }
            else
            {
                throw new InvalidOperationException("Divide by 0 error");
            }
        }

        public double SquareRoot(double x)
        {
            if (x >= 0)
            {
                return Accumulator = Math.Sqrt(x);
            }
            else
            {
                throw new InvalidOperationException("Squareroot of negative number not possible");
            }
        }

        public double SquareRoot()
        {
            if (Accumulator >= 0)
            {
                return Accumulator = Math.Sqrt(Accumulator);
            }
            else
            {
                throw new InvalidOperationException("Squareroot of negative number not possible");
            }
        }




    }
}
