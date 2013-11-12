using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCode
{    
    /// <summary>
    /// Private class, can only create thru AccessorFactory
    /// </summary>
    class CustomerAccessor : ICustomerAccessor
    {
        public Customer Find(string customerId)
        {
            throw new NotImplementedException();
        }

        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
