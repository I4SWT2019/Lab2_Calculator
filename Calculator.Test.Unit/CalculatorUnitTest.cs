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

        [Test]
        public void Add_ThreeAddedToAccumulator_ResultCorrect()
        {
            double result = uut.Add(6, 4);
            result = uut.Add(3);

            Assert.That(result, Is.EqualTo(13));
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
    }
}
