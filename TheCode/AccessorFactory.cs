using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCode
{
    public class AccessorFactory
    {
        public virtual T Create<T>()
            where T : class
        {
            if (typeof(T).Name == "CustomerAccessor")
                return new CustomerAccessor() as T;

            return null;
        }
    }
}
