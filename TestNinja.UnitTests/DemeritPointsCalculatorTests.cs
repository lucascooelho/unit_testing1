using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    internal class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator demeritCalculator;

        [SetUp]
        public void SetUp()
        {
            demeritCalculator = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedOutOfRange_ThrowsArgumentOutOfRangeException(int speed)
        {
            Assert.That(() => demeritCalculator.CalculateDemeritPoints(speed),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expected)
        {
            var result = demeritCalculator.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
