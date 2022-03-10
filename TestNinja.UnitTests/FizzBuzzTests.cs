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
    internal class FizzBuzzTests
    {
        [Test]
        public void GetOutput_NumberDivisibleBy3And5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(30);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_NumberDisivibleBy3Only_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_NumberDisibleBy5Only_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(5);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_NumberNotDivisibleBy3Or5_ReturnNumber()
        {
            var result = FizzBuzz.GetOutput(2);

            Assert.That(result, Is.EqualTo("2"));
        }
    }
}
