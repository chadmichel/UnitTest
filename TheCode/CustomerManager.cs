using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCode
{
    public class CustomerManager : ManagerBase, ICustomerManager
    {
        public void Upgrade(string customerId)
        {
            var customerAccessor = AccessorFactory.Create<ICustomerAccessor>();

            // To upgrade a customer we must first find the customer.
            var customer = customerAccessor.Find(customerId);
            // Set Pro equal to true.
            customer.Pro = true;
            // Save the customer.
            customerAccessor.Save(customer);
        }
    }
}
