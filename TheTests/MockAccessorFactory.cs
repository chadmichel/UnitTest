using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheCode;

namespace MEF.TheTests
{
    class MockAccessorFactory : AccessorFactory
    {
        Dictionary<string, object> _overrides = new Dictionary<string, object>();

        public void AddOverride<T>(T obj)
        {
            _overrides.Add(typeof(T).Name, obj);
        }

        public override T Create<T>()
        {
            if (_overrides.ContainsKey(typeof(T).Name))
                return _overrides[typeof(T).Name] as T;

            return base.Create<T>();
        }
    }
}
