using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCode;

namespace TheCode
{
    public abstract class ManagerBase
    {
        public AccessorFactory AccessorFactory { get; set; }

        public ManagerBase()
        {
            AccessorFactory = new AccessorFactory();
        }
    }
}
