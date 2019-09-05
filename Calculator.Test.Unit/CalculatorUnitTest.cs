using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [Test]
        public void Add_TwoAndThree_Return5()
        {
            // Arrange
            double result = 0;
            // Act
            result = uut.Add(2, 3);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [TestCase(5, 8, 13)]
        [TestCase(9, 2, 11)]
        [TestCase(5, -2, 3)]
        [TestCase(-6, 3, -3)]
        [TestCase(-7, -8, -15)]
        [TestCase(19, 0, 19)]
        [TestCase(0, 812, 812)]
        [TestCase(0, 0, 0)]
        public void Add_AddNumbers_ResultIsCorrect(double a, double b, double result)
        {
            Assert.That(uut.Add(a,b),Is.EqualTo(result));
        }


        [Test]
        public void Subtract_ThreeAndTwo_Return1()
        {
            // Arrange
            double result = 0;
            // Act
            result = uut.Subtract(3, 2);
            // Assert
            Assert.That(result,Is.EqualTo(1));
        }

        [Test]
        public void Subtract_4FromAccumulator_return4()
        {
            uut.Add(4, 4);

            double result = uut.Subtract(4);

            Assert.That(result, Is.EqualTo(4));
        }

        [TestCase(2, 3, 6)]
        [TestCase(-4, 3, -12)]
        [TestCase(5, -2, -10)]
        [TestCase(-4, -4, 16)]
        [TestCase(8, 0, 0)]
        [TestCase(0, 19, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNumbers_ResultCorrect(double a, double b, double result)
        {
            Assert.That(uut.Multiply(a,b),Is.EqualTo(result));
        }


        [Test]
        public void Multiply_AccumulatorMultipliedByTwo_ResultCorrect()
        {
            double result = uut.Multiply(4, 3);
            result = uut.Multiply(2);

            Assert.That(result, Is.EqualTo(24));
        }

        [Test]
        public void Power_TwoIntThePowerOfThree_Return8()
        {
            // Arrange
            double result = 0;
            // Act
            result = uut.Power(2, 3);
            // Assert
            Assert.That(result,Is.EqualTo(8));
        }


        [Test]
        public void Power_AccumulatorToThePowerOfTwo_ResultCorrect()
        {
            double result = uut.Power(2, 2);
            result = uut.Power(2);

            Assert.That(result, Is.EqualTo(16));
        }

        [Test]
        public void Power_AccumulatorToThePowerOfZero_ResultCorrect()
        {
            double result = uut.Power(2, 2);
            result = uut.Power(0);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Power_AccumulatorToThePowerOfNegativeTwo_ResultCorrect()
        {
            double result = uut.Power(2, 2);
            result = uut.Power(-2);

            Assert.That(result, Is.EqualTo(0.0625));
        }


        [TestCase(4, 2, 2)]
        [TestCase(2, 4, 0.5)]
        [TestCase(6, -3, -2)]
        [TestCase(-8, 4, -2)]
        [TestCase(-10, -10, 1)]
        [TestCase(0, 2, 0)]
        public void Divide_DivideNumbers_ResultIsCorrect(double divident, double divider, double result)
        {
            Assert.That(uut.Divide(divident, divider), Is.EqualTo(result));
        }

        [Test]
        public void Divide_DivideByZero_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => uut.Divide(4,0));
        }

        [Test]
        public void DivideAccumulated_DivideByZero_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => uut.Divide(0));
        }

        [Test]
        public void SquareRoot_SquarerootOfNegativeNumber_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => uut.SquareRoot(-9));
        }

        [Test]
        public void SquareRoot_SquarerootOfNegativeAccumulator_ThrowsException()
        {
            uut.Subtract(7, 9);

            Assert.Throws<InvalidOperationException>(() => uut.SquareRoot());
        }

        [Test]
        public void SquareRoot_SquarerootOfNine_ResultCorrect()
        {
            double result = uut.SquareRoot(9);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void SquareRoot_SquarerootOfDecimalNumber_ResultCorrect()
        {
            double result = uut.SquareRoot(6.25);

            Assert.That(result, Is.EqualTo(2.5));
        }

        [Test]
        public void SquareRoot_SquarerootOverloadedOperator_ResultCorrect()
        {
            double result = uut.SquareRoot(81);
            result = uut.SquareRoot();

            Assert.That(result, Is.EqualTo(3));
        }

        [TestCase(1, 2, 3)]
        [TestCase(2, 2, 0)]
        [TestCase(5, 2, 10)]
        [TestCase(2, 4, 16)]
        public void TestingAccumulator_AllFourBasicOperations(double a, double b, double result)
        {
            result = uut.Add(a, b);

            Assert.That(result, Is.EqualTo(uut.Accumulator));

            result = uut.Subtract(2, 2);

            Assert.That(result, Is.EqualTo(uut.Accumulator));

            result = uut.Multiply(5, 2);

            Assert.That(result, Is.EqualTo(uut.Accumulator));

            result = uut.Power(2, 4);

            Assert.That(result, Is.EqualTo(uut.Accumulator));
        }


        [TestCase(2, 4)]
        [TestCase(2, 2)]
        [TestCase(2, 1)]
        public void AccumulatorDivide_PositiveNumbers_returnPositive(double divider, double result)
        {
            uut.Add(4, 4);

            result = uut.Divide( 2);

            Assert.That(result, Is.EqualTo(4));

            result = uut.Divide(2);

            Assert.That(result, Is.EqualTo(2));

            result = uut.Divide(2);

            Assert.That(result, Is.EqualTo(1));
        }
    }
}
