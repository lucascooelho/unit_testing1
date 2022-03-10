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
    internal class CustomerControllerTests
    {
        private CustomerController controller;

        [SetUp]
        public void SetUp()
        {
            controller = new CustomerController();
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {        
            var result = controller.GetCustomer(0);

            // NotFound
            Assert.That(result, Is.TypeOf<NotFound>());

            // NotFound or one of its derivatives
            // Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdNotZero_ReturnOk()
        {
            var result = controller.GetCustomer(1);

            // Ok
            Assert.That(result, Is.TypeOf<Ok>());

            // Ok or one of its derivatives
            //Assert.That(result, Is.InstanceOf<Ok>());
        }
    }
}
