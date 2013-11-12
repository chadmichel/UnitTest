using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheCode;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using MEF.TheTests;

namespace TheTests
{
    [TestClass]
    public class CustomerManager_UnitTests
    {
        private CustomerManager SetupCustomerManager()
        {
            var factory = new MockAccessorFactory();
            factory.AddOverride<ICustomerAccessor>(new MockCustomerAccessor());

            // Return a customer manager with the property CustomerAccessor set.
            var customerManager = new CustomerManager();
            customerManager.AccessorFactory = factory;

            return customerManager;
        }        

        [TestMethod]        
        public void CustomerManager_Unit_Upgrade()
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
