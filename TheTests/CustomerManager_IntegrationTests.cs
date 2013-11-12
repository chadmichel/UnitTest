using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheCode;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace TheTests
{
    [TestClass]
    public class CustomerManager_IntegrationTests
    {
        private CustomerManager SetupCustomerManager()
        {
            var customerManager = new CustomerManager();
            return customerManager;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CustomerManager_Integration_Upgrade_NullCustomerId()
        {
            var customerManager = SetupCustomerManager();

            var customer = new Customer()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Unit Test",
            };

            customerManager.AccessorFactory.Create<ICustomerAccessor>().Save(customer);

            Assert.IsFalse(customer.Pro);

            customerManager.Upgrade(customer.Id);

            Assert.IsTrue(customer.Pro);
        }
    }
}
