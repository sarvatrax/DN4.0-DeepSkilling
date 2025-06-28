using NUnit.Framework;
using CalcLibrary;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator calc;

        [SetUp]
        public void Init()
        {
            calc = new SimpleCalculator();
        }

        [TearDown]
        public void Cleanup()
        {
            calc = null;
        }

        [Test]
        [TestCase(5, 3, 8)]
        [TestCase(0, 0, 0)]
        [TestCase(-2, -3, -5)]
        public void Addition_ValidInputs_ReturnsExpected(double a, double b, double expected)
        {
            double result = calc.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
