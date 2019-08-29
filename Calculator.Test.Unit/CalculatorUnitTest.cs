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
        public void Multiply_FourAndThree_Return12()
        {
            // Arrange
            double result = 0;
            // Act
            result = uut.Multiply(4, 3);
            // Assert
            Assert.That(result,Is.EqualTo(12));
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

        [TestCase(4, 2, 2)]
        [TestCase(2, 4, 0.5)]
        [TestCase(4, 4, 0)]
        [TestCase(0, 4, 0)]
        public void Divide_TwoPositiveNumbers_ResultIsCorrect(double divident, double divider, double result)
        {
            Assert.That(uut.Divide(divident, divider),Is.EqualTo(result));
        }
    }
}
