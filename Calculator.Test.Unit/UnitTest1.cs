using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add()
        {
            // Arrange
            var uut = new Lommeregner.Calculator();

            // Act
           //  uut.Add(2, 10);
            // Assert
            Assert.That(uut.Add(2, 10), Is.EqualTo(12));

        }

        [Test]
        public void Subtract()
        {
            // Arrange
            var uut = new Lommeregner.Calculator();

            // Act
           // uut.Subtract(2, 10);
            // Assert
            Assert.That(uut.Subtract(2, 10), Is.EqualTo(-8));
        }

        [Test]
        public void Multiply()
        {
            // Arrange
            var uut = new Lommeregner.Calculator();

            // Act
           // uut.Multiply(2, 10);
            // Assert
            Assert.That(uut.Multiply(2, 10), Is.EqualTo(20));
        }

        [Test]
        public void Power()
        {
            // Arrange
            var uut = new Lommeregner.Calculator();

            // Act
           // uut.Power(2, 10);
            // Assert
            Assert.That(uut.Power(3, 3), Is.EqualTo(27));
        }
    }
}